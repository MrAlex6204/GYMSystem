﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;


[TypeConverter(typeof(ExpandableObjectConverter))]
public class MouseBehaviorExtension {

    #region Properties


    private string _HoverTex = string.Empty, _LeaveText = string.Empty;
    [Category("Hover")]
    public string HoverText {
        get { return _HoverTex; }
        set { _HoverTex = value; }
    }
    [Category("Leave")]
    public string LeaveText {
        get { return _LeaveText; }
        set { _LeaveText = value; }
    }

    private System.Drawing.Color _HoverBorderColor = System.Drawing.Color.Empty, _LeaveBorderColor = System.Drawing.Color.Empty;
    [Category("Hover")]
    public System.Drawing.Color HoverBorderColor {
        get {
            return _HoverBorderColor;
        }
        set {
            _HoverBorderColor = value;
        }
    }
    [Category("Leave")]
    public System.Drawing.Color LeaveBorderColor {
        get {
            return _LeaveBorderColor;
        }
        set {
            _LeaveBorderColor = value;
        }
    }

  

    private System.Drawing.Color _HoverColor = System.Drawing.Color.Empty, _LeaveColor = System.Drawing.Color.Empty;
    [Category("Hover")]
    public System.Drawing.Color HoverColor {
        get { return _HoverColor; }
        set { _HoverColor = value; }
    }
    [Category("Leave")]
    public System.Drawing.Color LeaveColor {
        get { return _LeaveColor; }
        set { _LeaveColor = value; }
    }


    private System.Drawing.Color _HoverForecolor = System.Drawing.Color.Empty, _LeaveForecolor = System.Drawing.Color.Empty;
    [Category("Hover")]
    public System.Drawing.Color HoverForecolor {
        get { return _HoverForecolor; }
        set { _HoverForecolor = value; }
    }
    [Category("Leave")]
    public System.Drawing.Color LeaveForecolor {
        get { return _LeaveForecolor; }
        set { _LeaveForecolor = value; }
    }


    private System.Drawing.Image _HoverImage = null, _LeaveImage = null;
    [Category("Hover")]
    public System.Drawing.Image HoverImage {
        get { return _HoverImage; }
        set { _HoverImage = value; }
    }
    [Category("Leave")]
    public System.Drawing.Image LeaveImage {
        get { return _LeaveImage; }
        set { _LeaveImage = value; }
    }


    #endregion

    #region Functions

    public override string ToString() {
        return "Mouse Event Adicional Behavior";
    }

    #endregion

}

