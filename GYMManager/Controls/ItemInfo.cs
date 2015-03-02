using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class ItemInfo : UserControl {

    private SocioInfo _Socio = new SocioInfo();

    [Browsable(false)]
    public SocioInfo Info {
        get {
            return _Socio;
        }
        set {
            _Socio = value;
            if (value != null) {
                if (value.Nombres != "" && value.Nombres != null) {
                    lblNombres.Text = value.Nombres.ToUpper();
                } else {
                    lblNombres.Text = "S/N NOMBRES!";
                }
                if (value.Apellidos != "" && value.Apellidos != null) {
                    lblApellidos.Text = value.Apellidos.ToUpper();
                } else {
                    lblApellidos.Text = "S/N APELLIDOS!";
                }
                if (value.Domicilio != "" && value.Domicilio != null) {
                    lblDomicilio.Text = value.Domicilio;
                } else {
                    lblDomicilio.Text = "S/N DOMICILIO!".ToUpper();
                }

                if(value.SocioImg.Image!=null){
                    picUser.SizeMode = PictureBoxSizeMode.StretchImage;
                    picUser.Image = value.SocioImg.Image;
                }

                lblEdad.Text = value.Edad;                
            }
        }
    }

    public ItemInfo() {
        InitializeComponent();
    }
    public ItemInfo(SocioInfo Info) {
        InitializeComponent();
        this.Info = Info;
    }

    private void cmdMenu_Click(object sender, EventArgs e) {
        mnuOptions.Show((Control)sender,cmdMenu.PointToClient(Cursor.Position) ,ToolStripDropDownDirection.BelowLeft);
    }
    //protected override void OnResize(EventArgs e) {        
    //    base.OnResize(e);
    //    cmdMenu.Location = new Point(this.Width - 23, cmdMenu.Location.Y);
    //}
        
}

