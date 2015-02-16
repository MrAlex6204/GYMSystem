using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

     
    class BorderDrawer: IComponent
    {
        private System.Windows.Forms.Control _Owner;
        private  Pen _Pen  = new Pen(Brushes.DimGray, 1);
        public event EventHandler Disposed;
                
        public System.Drawing.Color BorderGotFocus
        {
            get;
            set;
        }

        
         public System.Drawing.Color BorderLostFocus
        {
            get;
            set;
        }

         [TypeConverter(typeof(ExpandableObjectConverter))]
        public System.Drawing.Pen Pen
        {
            get { return _Pen; }
            set { _Pen = value; }
        }
        
        public System.Windows.Forms.Control Owner
        {
            get { return _Owner; }
            set { 
                _Owner = value;
                if (_Owner != null) {
                    _Owner.LostFocus += new EventHandler(_LostFocus);
                    _Owner.GotFocus += new EventHandler(_GotFocus);
                    DrawBorder(ref _Owner, this.BorderLostFocus);                   
                }
            }
        }

        public void DrawBorder(ref System.Windows.Forms.Control OwnerControl,System.Drawing.Color Color)
        {
            System.Drawing.Graphics Graphic = OwnerControl.CreateGraphics();
            System.Drawing.Point Location = OwnerControl.Location;
            System.Drawing.Size Size = new System.Drawing.Size(OwnerControl.Width - (int)this.Pen.Width, OwnerControl.Height - (int)this.Pen.Width);

            this.Pen.Color = Color;

            System.Drawing.Rectangle Rectangle = new Rectangle(OwnerControl.Location, Size);                        
            Graphic.DrawRectangle(this.Pen, Rectangle);
        }
                
        private void _GotFocus(object sender, EventArgs e) {

            DrawBorder(ref _Owner, BorderGotFocus);
        }
        private void _LostFocus(object sender,  EventArgs e)
        {
            DrawBorder(ref _Owner, BorderLostFocus);
        }
        



        public ISite Site
        {
            get;            
            set;            
        }

        public void Dispose()
        {
            
        }
    }

