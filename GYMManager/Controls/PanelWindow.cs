﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PanelWindow : System.Windows.Forms.Panel {

    private bool _bFlagShowCloseButton = true;
    private System.Windows.Forms.Button _ButtonOwner;
    private AnimatedButton cmdClosePanel;
    MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();

    public PanelWindow() {
        this.InitilizeComponents();
    }

    public void InitilizeComponents() {
        MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
        this.cmdClosePanel = new AnimatedButton();
        this.cmdClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.cmdClosePanel.BackColor = System.Drawing.Color.Transparent;
        this.cmdClosePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
        this.cmdClosePanel.FlatAppearance.BorderSize = 0;
        this.cmdClosePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this.cmdClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this.cmdClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdClosePanel.Image = global::GYMManager.Properties.Resources.close_normal_pic;
        this.cmdClosePanel.Location = new System.Drawing.Point(175, 2);
        mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.HoverImage = global::GYMManager.Properties.Resources.close_hover_pic1;
        mouseBehaviorExtension1.HoverText = "";
        mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.LeaveImage = global::GYMManager.Properties.Resources.close_normal_pic;
        mouseBehaviorExtension1.LeaveText = "";
        this.cmdClosePanel.MouseBehavior = mouseBehaviorExtension1;
        this.cmdClosePanel.Name = "cmdClosePanel";
        this.cmdClosePanel.Size = new System.Drawing.Size(23, 23);
        this.cmdClosePanel.TabIndex = 1;
        this.cmdClosePanel.UseVisualStyleBackColor = false;
        this.cmdClosePanel.Click += new System.EventHandler(this._PanelClose);
        this.Controls.Add(this.cmdClosePanel);
    }

    public bool ShowCloseButton {
        get {
            return _bFlagShowCloseButton;
        }
        set {
            cmdClosePanel.Visible = _bFlagShowCloseButton = value;
        }
    }

    public System.Windows.Forms.Button OwnerButton {
        get {
            return _ButtonOwner;
        }
        set {
            _ButtonOwner = value;
            if (value != null) {
                if (!this.DesignMode) {
                    this.Visible = false;
                }
                _ButtonOwner.Click += new EventHandler(_OwnerClick);
            }
        }

    }

    private void _OwnerClick(object sender, object e) {

        if (!this.DesignMode) {

            this.Visible = !this.Visible;
        }

    }

    private void _PanelClose(object sender, EventArgs e) {
        this.Visible = false;
    }

}

