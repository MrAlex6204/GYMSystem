using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;


class FocusBehaviorExtension : IComponent
{
    private System.Windows.Forms.Control _Owner;

    public event EventHandler Disposed;

    public int BorderWidth
    {
        get;
        set;
    }
    public System.Drawing.Color FocusBorderColor
    {
        get;
        set;
    }
    public System.Drawing.Color LostFocusBorderColor
    {
        get;
        set;
    }
    public System.Drawing.Drawing2D.DashStyle BorderStyle
    {
        get;
        set;
    }

    public System.Drawing.Color FocusBgColor
    {
        get;
        set;
    }

    public System.Drawing.Color LostFocusBgColor
    {
        get;
        set;    
    }
    public System.Windows.Forms.Control ControlOwner
    {
        get { return _Owner; }
        set
        {
            _Owner = value;
            if (_Owner != null)
            {
                Debug.Print("Value assigned\n");
                _Owner.GotFocus += new EventHandler(_GotFocus);
                _Owner.LostFocus += new EventHandler(_LostFocus);
                _Owner.Paint += new System.Windows.Forms.PaintEventHandler(_OnPaint);
                DrawBorder();
            }
        }
    }

    public void DrawBorder()
    {
        System.Drawing.Graphics Graphic = _Owner.CreateGraphics();
        System.Drawing.Point Location = _Owner.Location;
        System.Drawing.Size Size = _Owner.Size;

        System.Drawing.Rectangle Rectangle = new Rectangle(Location, Size);
        System.Drawing.Pen Pen = new Pen(Brushes.Red, 1);
        Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        _Owner.CreateGraphics().DrawRectangle(Pen, Rectangle);        
    }

    private void _OnPaint(object sender,System.Windows.Forms.PaintEventArgs e)
    {
      
    }
    private void _GotFocus(object sender, EventArgs e)
    {
              
        DrawBorder();
        if (this.FocusBgColor != null) {
            _Owner.BackColor = this.FocusBgColor;
        }

    }
    private void _LostFocus(object sender, EventArgs e)
    {      
        DrawBorder();
        if (this.LostFocusBorderColor != null) {
            _Owner.BackColor = this.LostFocusBgColor;
        }
    }



    [Browsable(false)]
    public ISite Site
    {
        get;
        set;
    }

    public void Dispose()
    {

    }
}

