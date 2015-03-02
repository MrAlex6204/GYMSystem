using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class SocioItemInfo : UserControl {

    private SocioInfo _Socio = new SocioInfo();

    [Browsable(false)]
    public SocioInfo Info {
        get {
            return _Socio;
        }
        set {
            _Socio = value;
            if (value != null) {
                lblNombres.Text = value.Nombres;
                lblApellidos.Text = value.Apellidos;
                picUser.Image = value.SocioImg.Image;
            }
        }
    }

    public SocioItemInfo() {
        InitializeComponent();
    }
        
}

