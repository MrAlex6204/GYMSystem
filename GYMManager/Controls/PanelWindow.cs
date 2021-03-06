﻿#region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Design;
using System.Diagnostics;
using System.Drawing;
#endregion

class PanelWindow : System.Windows.Forms.Panel {

    #region Private Declarations

    private bool _bFlagShowCloseButton = true;
    private AnimatedButton _ButtonOwner;
    private AnimatedButton _cmdClosePanel;
    private static List<AnimatedButton> _RegisteredButtons = new List<AnimatedButton>();
    private Point _InitialLocation = Point.Empty;
    #endregion

    #region Enums

    public enum SlideType {
        None, Left, Rigth, Top, Bottom
    }

    #endregion

    #region Constructor and Initilizing

    public PanelWindow() {
        this.InitializeComponent();
        _InitialLocation = this.Location;
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
        // 200, 100
        this.Size = new System.Drawing.Size(200, 100);
        this._cmdClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this._cmdClosePanel.BackColor = System.Drawing.Color.Transparent;
        this._cmdClosePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
        this._cmdClosePanel.FlatAppearance.BorderSize = 0;
        this._cmdClosePanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        this._cmdClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
        this._cmdClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this._cmdClosePanel.Image = global::GYMManager.Properties.Resources.close_normal_pic;
        this._cmdClosePanel.Location = new System.Drawing.Point(175, 3);
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
        this.ResumeLayout(false);

    }

    #endregion

    #region Properties

    public SlideType SlideIn {
        get;
        set;
    }
    public SlideType SlideOut {
        get;
        set;
    }

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
            this.Visible = this.DesignMode; //===>Set visible the panel when is in a design mode
            if (value != null) {
                _ButtonOwner.StateChange += new AnimatedButton.StateChangeHandler(_OwnerStateChangeEvent);
                _RegisteredButtons.Add(_ButtonOwner);
            }
        }
    }

    #endregion

    #region Public Function

    public void SlideTo(SlideType Slide, bool Visible) {
        int OrientationLenght = 0;
        Point TargetLocation = Point.Empty;

        if (this.DesignMode) {
            return;//===>Do not nothing in design mode.
        }

        if (this.Location != Point.Empty && _InitialLocation == Point.Empty) {
            _InitialLocation = this.Location; //===>Save the original location.
        }

        TargetLocation = _InitialLocation;

        switch (Slide) {//===>Set the panel start position
            case SlideType.Left:
                if (Visible) {
                    //===>SlideIn
                    base.Visible = true;//===>Set visible!
                    OrientationLenght = 1;
                    this.Location = new Point(this.Location.X - this.Width, this.Location.Y);//===>Move offset
                    Debug.Print("Slide In");
                } else {
                    //===>SlideOut
                    OrientationLenght = -1;
                    TargetLocation.X -= this.Width;
                    Debug.Print("Slide Out");
                }

                do {
                    this.Location = new Point(this.Location.X + (OrientationLenght), TargetLocation.Y);
                    System.Diagnostics.Debug.Print(Location.X.ToString());                    
                } while (this.Location.X != TargetLocation.X);

                this.Location = TargetLocation;

                if (!Visible) {
                    base.Visible = false;//===>Hide control after the slide efect.
                }

                break;
            case SlideType.Rigth:
                if (Visible) {
                    //===>SlideIn

                } else {
                    //===>SlideOut

                }

                break;
            case SlideType.Top:
                if (Visible) {
                    //===>SlideIn

                } else {
                    //===>SlideOut

                }

                break;
            case SlideType.Bottom:
                if (Visible) {
                    //===>SlideIn

                } else {
                    //===>SlideOut

                }
                break;
            case SlideType.None:
                base.Visible = Visible;
                break;
        }



    }

    #endregion

    #region Private Functions

    protected override void OnResize(EventArgs eventargs) {
        base.OnResize(eventargs);
        _cmdClosePanel.Location = new System.Drawing.Point(this.Width - 25, 3);
    }

    public bool Visible {//===>We overrides this property to handle the SlideIn and SlideOut
        get {
            return base.Visible;
        }
        set {
            if (value) {
                SlideTo(this.SlideIn, true);//Visible
            } else {
                SlideTo(this.SlideOut, false);//Invisible!
            }
        }
    }

    private void _OwnerStateChangeEvent(object sender, object e) {
        //===>Owner button has change state
        if (!this.DesignMode) {
            if ((bool)e) {
                foreach (AnimatedButton iButton in _RegisteredButtons) {
                    iButton.DesactiveButton();//===>Hide all opened
                }
                ((AnimatedButton)sender).ActiveButton(false);
                this.Visible = true;
            } else {
                this.Visible = false;
            }
        } else {
            this.Visible = false;
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