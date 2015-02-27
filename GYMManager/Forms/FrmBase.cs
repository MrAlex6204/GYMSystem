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
    private bool _bFlagMouseDown = false;
    private int offSetX = 0, OffSetY = 0;



    public FrmBase() {
        InitializeComponent();
        cmdMinimize.Visible = this.MinimizeBox;
    }

    private void _DrawBorders() {
        System.Drawing.Graphics Graphic = this.CreateGraphics();
        System.Drawing.Point Location = new System.Drawing.Point(0, 0);
        System.Drawing.Size Size = new System.Drawing.Size(this.Width - 1, this.Height - 1);

        System.Drawing.Rectangle Rectangle = new Rectangle(Location, Size);
        System.Drawing.Pen Pen = new Pen(Brushes.Black, 1);
        Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        Graphic.DrawRectangle(Pen, Rectangle);
    }

    protected override void OnPaint(PaintEventArgs e) {
        using (Pen brder = new Pen(Color.Blue)) {
            using (System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Color.FromArgb(128, System.Drawing.Color.Black))) {
                e.Graphics.FillRectangle(myBrush, new Rectangle(200, 0, 200, 300));
                e.Graphics.DrawLine(brder, 150, 50, 200, 50);
                myBrush.Color = Color.BlueViolet;//' change brush color
                e.Graphics.FillEllipse(myBrush, 40, 90, 86, 30);
            }
        }
        _DrawBorders();
    }

    private void animatedButton1_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void cmdMinimize_Click(object sender, EventArgs e) {
        this.WindowState = FormWindowState.Minimized;
    }

    private void FrmMain_MouseDown(object sender, MouseEventArgs e) {
        _bFlagMouseDown = true;
        offSetX = Cursor.Position.X - this.Left;
        OffSetY = Cursor.Position.Y - this.Top;
        this.Cursor = Cursors.SizeAll;
    }

    private void FrmMain_MouseUp(object sender, MouseEventArgs e) {
        _bFlagMouseDown = false;
        this.Cursor = Cursors.Default;
    }

    private void FrmMain_MouseMove(object sender, MouseEventArgs e) {
        if (_bFlagMouseDown) {
            this.Top = Cursor.Position.Y - OffSetY;
            this.Left = Cursor.Position.X - offSetX;
        }

    }

    private void cmdClose_Click(object sender, EventArgs e) {
        this.Close();
    }

    private void animatedButton2_Click(object sender, EventArgs e) {

    }

    private void cmdHome_Click(object sender, EventArgs e) {

    }

}
