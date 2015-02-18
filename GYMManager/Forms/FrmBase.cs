using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.SQLTransac;
namespace GYMManager
{
    public partial class FrmMain : Form
    {
        private bool _bFlagMouseDown = false;
        private int offSetX = 0, OffSetY = 0;



        public FrmMain()
        {
            InitializeComponent();
        }


        private void _DrawBorders()
        {
            System.Drawing.Graphics Graphic = this.CreateGraphics();
            System.Drawing.Point Location = new System.Drawing.Point(0, 0);
            System.Drawing.Size Size = new System.Drawing.Size(this.Width - 1, this.Height - 1);

            System.Drawing.Rectangle Rectangle = new Rectangle(Location, Size);
            System.Drawing.Pen Pen = new Pen(Brushes.Black, 1);
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Graphic.DrawRectangle(Pen, Rectangle);
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
           _DrawBorders();
        }

        private void animatedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            _bFlagMouseDown = true;
            offSetX = Cursor.Position.X - this.Left;
            OffSetY = Cursor.Position.Y - this.Top;
            this.Cursor = Cursors.SizeAll;
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            _bFlagMouseDown = false;
            this.Cursor = Cursors.Default;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_bFlagMouseDown)
            {
                this.Top = Cursor.Position.Y - OffSetY;
                this.Left = Cursor.Position.X - offSetX;
            }

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void animatedButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void cmdHome_Click(object sender, EventArgs e)
        {


        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            focusBehaviorExtension1.DrawBorder(Color.Red);
        }

    }
}