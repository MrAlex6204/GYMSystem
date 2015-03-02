using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextBoxAnimate : System.Windows.Forms.TextBox {

    private MouseBehaviorExtension _FocusBehavior = new MouseBehaviorExtension();

    public MouseBehaviorExtension FocusBehavior {
        get {
            return _FocusBehavior;
        }
        set {
            _FocusBehavior = value;
        }
    }

    protected override void OnGotFocus(EventArgs e) {
        if (this.FocusBehavior.HoverColor != System.Drawing.Color.Empty) {
            this.BackColor = this.FocusBehavior.HoverColor;
        }
        if (this.FocusBehavior.HoverForecolor != System.Drawing.Color.Empty) {
            this.ForeColor = this.FocusBehavior.HoverForecolor;
        }
    }

    protected override void OnLostFocus(EventArgs e) {
        if (this.FocusBehavior.LeaveColor != System.Drawing.Color.Empty) {
            this.BackColor = this.FocusBehavior.LeaveColor;
        }
        if (this.FocusBehavior.LeaveForecolor != System.Drawing.Color.Empty) {
            this.ForeColor = this.FocusBehavior.LeaveForecolor;
        }
    }


}

