using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;


class AnimatedButton : System.Windows.Forms.Button {

    private bool _bFlagIsActive = false;
    private MouseBehaviorExtension _MouseEventBehavior = new MouseBehaviorExtension();

    public MouseBehaviorExtension MouseBehavior {
        get { return _MouseEventBehavior; }
        set { _MouseEventBehavior = value; }
    }

    /// <summary>
    /// Set true if you wants to set this button as toggle button
    /// </summary>
    public bool SetAsToggleButton {
        get;
        set;
    }

    public override string ToString() {

        return "Button";
    }

    public bool IsActive {
        get { return _bFlagIsActive; }
    }


    public void ActiveButton() {//Set button active button design
        if (this.MouseBehavior.HoverImage != null) {
            this.Image = this.MouseBehavior.HoverImage;
        }
        if (this.MouseBehavior.HoverText != string.Empty && this.MouseBehavior.HoverText != null) {
            this.Text = this.MouseBehavior.HoverText;
        }
        if (this.MouseBehavior.HoverForecolor != System.Drawing.Color.Empty) {
            this.ForeColor = this.MouseBehavior.HoverForecolor;
        }
        if (this.MouseBehavior.HoverColor != System.Drawing.Color.Empty) {
            this.BackColor = this.MouseBehavior.HoverColor;
        }
        if (this.MouseBehavior.HoverBorderColor != System.Drawing.Color.Empty) {
            this.FlatAppearance.BorderColor = this.MouseBehavior.HoverBorderColor;
        }
        _bFlagIsActive = true;
        this.Refresh();
    }

    public void DesactiveButton() {//Set button desactive design
        if (this.MouseBehavior.LeaveImage != null) {
            this.Image = this.MouseBehavior.LeaveImage;
        }
        if (this.MouseBehavior.LeaveText != string.Empty && this.MouseBehavior.LeaveText != null) {
            this.Text = this.MouseBehavior.LeaveText;
        }
        if (this.MouseBehavior.LeaveForecolor != System.Drawing.Color.Empty) {
            this.ForeColor = this.MouseBehavior.LeaveForecolor;
        }
        if (this.MouseBehavior.LeaveColor != System.Drawing.Color.Empty) {
            this.BackColor = this.MouseBehavior.LeaveColor;
        }
        if (this.MouseBehavior.LeaveBorderColor != System.Drawing.Color.Empty) {
            this.FlatAppearance.BorderColor = this.MouseBehavior.LeaveBorderColor;
        }
        _bFlagIsActive = false;
        this.Refresh();
    }

    #region Events

    protected override void OnClick(EventArgs e) {
        base.OnClick(e);
        if (this.SetAsToggleButton) {//===>Check if is as Toogle mode
            if (_bFlagIsActive) {
                DesactiveButton();//===>Set Desaactive color
            } else {
                ActiveButton();//===>Set Active color
            }
        }


    }

    protected override void OnMouseLeave(EventArgs e) {
        //===>Set values when the mouse leave
        if (!this.SetAsToggleButton) {
            DesactiveButton();
        }
        base.OnMouseLeave(e);
    }

    protected override void OnMouseHover(EventArgs e) {
        //===>Set values when the mouse hover

        if (!this.SetAsToggleButton) {
            ActiveButton();
        }
        base.OnMouseHover(e);
    }

    #endregion



}

