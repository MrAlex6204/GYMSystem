using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.SQLTransac;

public partial class FrmBase : Form {

    #region Declarations

    private bool _bFlagMouseDown = false;
    private int offSetX = 0, OffSetY = 0;

    #endregion

    #region Constructor Class

    public FrmBase() {
        InitializeComponent();
        cmdMinimize.Visible = this.MinimizeBox;
        AddKeyPressEventHandler(this);
    }

    #endregion




    private void _DrawBorders() {
        System.Drawing.Graphics Graphic = this.CreateGraphics();
        System.Drawing.Point Location = new System.Drawing.Point(0, 0);
        System.Drawing.Size Size = new System.Drawing.Size(this.Width - 1, this.Height - 1);

        System.Drawing.Rectangle Rectangle = new Rectangle(Location, Size);
        System.Drawing.Pen Pen = new Pen(Brushes.Black, 1);
        Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        Graphic.DrawRectangle(Pen, Rectangle);
    }

    #region Functions

    public void AddKeyPressEventHandler(System.Windows.Forms.Control OwnerControl) {
        if (OwnerControl.Controls.Count > 0) {
            foreach (Control iControl in OwnerControl.Controls) {
                AddKeyPressEventHandler(iControl);
            }
        } else {
            if (((OwnerControl is TextBox || OwnerControl is TextBoxAnimate) && !((TextBox)OwnerControl).Multiline) || OwnerControl is ComboBox) {
                OwnerControl.KeyPress += new KeyPressEventHandler(_KeyPress);
            }
            System.Diagnostics.Debug.Print(OwnerControl.Name);
        }
    }

    public void RegisterMouseMoveEvent(Control OwnerControl) {
        OwnerControl.MouseMove += new MouseEventHandler(this.BaseForm_MouseMove);
        OwnerControl.MouseDown += new MouseEventHandler(this.BaseForm_MouseDown);
        OwnerControl.MouseUp += new MouseEventHandler(this.BaseForm_MouseUp);
    }

    #endregion


    #region Functions Events

    protected override void OnLoad(EventArgs e) {
        AddKeyPressEventHandler(this);
    }

    private void _KeyPress(object sender, KeyPressEventArgs e) {
        if (e.KeyChar == (char)13) {
            System.Windows.Forms.SendKeys.Send("{TAB}");
        }
    }

    protected override void OnPaint(PaintEventArgs e) {
        //using (Pen brder = new Pen(Color.Blue)) {
        //    using (System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Color.FromArgb(128, System.Drawing.Color.Black))) {
        //        e.Graphics.FillRectangle(myBrush, new Rectangle(200, 0, 200, 300));
        //        e.Graphics.DrawLine(brder, 150, 50, 200, 50);
        //        myBrush.Color = Color.BlueViolet;//' change brush color
        //        e.Graphics.FillEllipse(myBrush, 40, 90, 86, 30);
        //    }
        //}
        _DrawBorders();
    }

    private void animatedButton1_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void cmdMinimize_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Minimized;
    }

    public void BaseForm_MouseDown(object sender, MouseEventArgs e) {
        _bFlagMouseDown = true;
        offSetX = Cursor.Position.X - this.Left;
        OffSetY = Cursor.Position.Y - this.Top;
        this.Cursor = Cursors.SizeAll;
    }

    public void BaseForm_MouseUp(object sender, MouseEventArgs e) {
        _bFlagMouseDown = false;
        this.Cursor = Cursors.Default;
    }

    public void BaseForm_MouseMove(object sender, MouseEventArgs e) {
        if (_bFlagMouseDown) {
            this.Top = Cursor.Position.Y - OffSetY;
            this.Left = Cursor.Position.X - offSetX;
        }

    }

    private void cmdClose_Click(object sender, EventArgs e) {
        this.Close();
    }
    #endregion
}
