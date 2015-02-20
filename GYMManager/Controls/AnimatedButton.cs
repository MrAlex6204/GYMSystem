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

    private void _ActiveButton() {//Set button active button design
        if (this.MouseBehavior.HoverImage != null) {
            this.Image = this.MouseBehavior.HoverImage;
        }
        if (this.MouseBehavior.HoverText != null & this.MouseBehavior.HoverText != "") {
            this.Text = this.MouseBehavior.HoverText;
        }
        if (this.MouseBehavior.HoverForecolor != null) {
            this.ForeColor = this.MouseBehavior.HoverForecolor;
        }
        if (this.MouseBehavior.HoverColor != null) {
            this.BackColor = this.MouseBehavior.HoverColor;
        }
        this.Refresh();
    }

    private void _DesactiveButton() {//Set button desactive design
        if (this.MouseBehavior.LeaveImage != null) {
            this.Image = this.MouseBehavior.LeaveImage;
        }
        if (this.MouseBehavior.LeaveText != null & this.MouseBehavior.LeaveText != "") {
            this.Text = this.MouseBehavior.LeaveText;
        }
        if (this.MouseBehavior.LeaveForecolor != null) {
            this.ForeColor = this.MouseBehavior.LeaveForecolor;
        }
        if (this.MouseBehavior.LeaveColor != null) {
            this.BackColor = this.MouseBehavior.LeaveColor;
        }
        this.Refresh();
    }
    #region Events

    protected override void OnClick(EventArgs e) {

        if (this.SetAsToggleButton) {
            _bFlagIsActive = !_bFlagIsActive;

            if (_bFlagIsActive) {
                _ActiveButton();
            } else {
                _DesactiveButton();
            }
        }

        base.OnClick(e);
    }

    protected override void OnMouseLeave(EventArgs e) {
        //===>Set values when the mouse leave
        if (!this.SetAsToggleButton) {
            _DesactiveButton();
        }
        base.OnMouseLeave(e);
    }

    protected override void OnMouseHover(EventArgs e) {
        //===>Set values when the mouse hover

        if (!this.SetAsToggleButton) {
            _ActiveButton();
        }
        base.OnMouseHover(e);
    }

    #endregion



}

