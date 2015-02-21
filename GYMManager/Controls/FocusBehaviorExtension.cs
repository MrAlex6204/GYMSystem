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

    #region Properties

    public float BorderWidth
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
                
                _Owner.Paint += new System.Windows.Forms.PaintEventHandler(_OnPaint);
                _Owner.GotFocus += new EventHandler(_GotFocus);
                _Owner.LostFocus += new EventHandler(_LostFocus);                
                DrawBorder(this.LostFocusBorderColor);
                SetBgColor(this.LostFocusBgColor);
            }
        }
    }

    public void DrawBorder(System.Drawing.Color BorderColor)
    {
        using (Graphics g = _Owner.CreateGraphics())
        {
            System.Drawing.Rectangle Rectangle = new Rectangle(10,10, 50,50);
            System.Drawing.Pen Pen = new Pen(Brushes.Red, this.BorderWidth);

            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.DrawRectangle(Pen, Rectangle);
            Debug.Print("Border drawed!");
        }
        
    }

    #endregion

    #region Functions

    private void SetBgColor(System.Drawing.Color BgColor) {
        _Owner.BackColor = BgColor;
    }

    private void _OnPaint(object sender, System.Windows.Forms.PaintEventArgs e) {
        
            System.Drawing.Rectangle Rectangle = new Rectangle(_Owner.Location, _Owner.Size);
            System.Drawing.Pen Pen = new Pen(Brushes.Red, this.BorderWidth);

            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawRectangle(Pen, Rectangle);
            Debug.Print("On Paint!");
        
    
    }

    private void _GotFocus(object sender, EventArgs e)
    {
       
        if (this.FocusBgColor != null) {
            SetBgColor(this.FocusBgColor);
            
        }
        if (this.FocusBorderColor != null) {
            DrawBorder(this.FocusBorderColor);
        }
        
    }

    private void _LostFocus(object sender, EventArgs e)
    {     
        
        if (this.LostFocusBorderColor != null) {
            SetBgColor(this.LostFocusBgColor);
           
        }
        if (this.LostFocusBorderColor != null) {
            DrawBorder(this.LostFocusBorderColor);
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

    #endregion
}


