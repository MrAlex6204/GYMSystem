using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Design;

class PanelWindow : System.Windows.Forms.Panel {

    #region Declarations
    private bool _bFlagShowCloseButton = true;
    private AnimatedButton _ButtonOwner;
    private AnimatedButton _cmdClosePanel;

    MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
    #endregion

    #region Constructor and Initilizing

    public PanelWindow() {
        this.InitializeComponent();
        if (this.DesignMode) {
            this.Visible = false;
        }
    }

    public void InitializeComponent() {
            MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
            this._cmdClosePanel = new AnimatedButton();
            this.SuspendLayout();
            // 
            // _cmdClosePanel
            // 
            this._cmdClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cmdClosePanel.BackColor = System.Drawing.Color.Transparent;
            this._cmdClosePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this._cmdClosePanel.FlatAppearance.BorderSize = 0;
            this._cmdClosePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._cmdClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._cmdClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cmdClosePanel.Image = global::GYMManager.Properties.Resources.close_normal_pic;
            this._cmdClosePanel.Location = new System.Drawing.Point(124, 3);
            mouseBehaviorExtension1.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverImage = global::GYMManager.Properties.Resources.close_hover_pic1;
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveImage = global::GYMManager.Properties.Resources.close_normal_pic;
            mouseBehaviorExtension1.LeaveText = "";
            this._cmdClosePanel.MouseBehavior = mouseBehaviorExtension1;
            this._cmdClosePanel.Name = "_cmdClosePanel";
            this._cmdClosePanel.SetAsToggleButton = false;
            this._cmdClosePanel.Size = new System.Drawing.Size(23, 23);
            this._cmdClosePanel.TabIndex = 1;
            this._cmdClosePanel.UseVisualStyleBackColor = false;
            this._cmdClosePanel.Click += new System.EventHandler(this._PanelClose);
            // 
            // PanelWindow
            // 
            this.Controls.Add(this._cmdClosePanel);
            this.Name = "PanelWindow";
            this.ResumeLayout(false);

    }

    #endregion

    #region Properties

    public bool ShowCloseButton {
        get {
            return _bFlagShowCloseButton;
        }
        set {
            _cmdClosePanel.Visible = _bFlagShowCloseButton = value;
        }
    }

    public AnimatedButton MenuButton {
        get {
            return _ButtonOwner;
        }
        set {
            _ButtonOwner = value;            
            this.Visible = this.DesignMode;            
            if (value != null) {                
                _ButtonOwner.Click += new EventHandler(_OwnerClick);
                //_ButtonOwner.LostFocus += new EventHandler(_OwnerLost);
            }
        }

    }

    #endregion

    #region Private Function

    private void _OwnerClick(object sender, object e) {

        if (!this.DesignMode) {
            this.Visible = !this.Visible;
        }

    }

    private void _OwnerLost(object sender, object e) {
        ((AnimatedButton)sender).DesactiveButton();
        this.Visible = false;
    }

    private void _PanelClose(object sender, EventArgs e) {
        this.Visible = false;
    }

    #endregion

   

}