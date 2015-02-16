using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
namespace GYMManager.Controls
{
   
    class AnimatedButton : System.Windows.Forms.Button
    {

        private MouseBehaviorExtension _MouseEventBehavior = new MouseBehaviorExtension();

      
        public MouseBehaviorExtension MouseBehavior
        {
            get { return _MouseEventBehavior; }
            set { _MouseEventBehavior = value;  }
        }

        public override string ToString()
        {

            return "Button";
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            //===>Set values when the mouse leave

            if (this.MouseBehavior.LeaveImage != null)
            {
                this.Image = this.MouseBehavior.LeaveImage;
            }
            if (this.MouseBehavior.LeaveText != null & this.MouseBehavior.LeaveText != "")
            {
                this.Text = this.MouseBehavior.LeaveText;
            }
            if (this.MouseBehavior.LeaveForecolor != null)
            {
                this.ForeColor = this.MouseBehavior.LeaveForecolor;
            }
            if (this.MouseBehavior.LeaveColor != null)
            {
                this.BackColor = this.MouseBehavior.LeaveColor;
            }
            this.Refresh();

            base.OnMouseLeave(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            //===>Set values when the mouse hover

            if (this.MouseBehavior.HoverImage != null)
            {
                this.Image = this.MouseBehavior.HoverImage;
            }
            if (this.MouseBehavior.HoverText != null & this.MouseBehavior.HoverText != "")
            {
                this.Text = this.MouseBehavior.HoverText;
            }
            if (this.MouseBehavior.HoverForecolor != null)
            {
                this.ForeColor = this.MouseBehavior.HoverForecolor;
            }
            if (this.MouseBehavior.HoverColor != null)
            {
                this.BackColor = this.MouseBehavior.HoverColor;
            }
            base.OnMouseHover(e);
        }

    }
}
