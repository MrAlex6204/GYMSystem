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

    public delegate void EditEventHandler(object sender, SocioInfo e);
    public delegate void DeleteEventHandler(object sender, SocioInfo e);

    public EditEventHandler Edit;
    public DeleteEventHandler Delete;

    [Browsable(false)]
    public SocioInfo Info {
        get {
            return _Socio;
        }
        set {
            _Socio = value;
            if (value != null) {
                if (value.Nombres != "" && value.Nombres != null) {
                    lblNombres.Text = "#" + value.Id + " " + value.Nombres.ToUpper();
                } else {
                    lblNombres.Text = "#" + value.Id + " S/N NOMBRES!";
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

                if (value.SocioImg.Image != null) {
                    picUser.SizeMode = PictureBoxSizeMode.StretchImage;
                    picUser.Image = value.SocioImg.Image;
                }

                lblEdad.Text = value.Edad;
            }
        }
    }

    public ItemInfo() {
        InitializeComponent();
        this.pnlSubMenu.LostFocus += delegate(object sender, EventArgs e) {
            pnlSubMenu.Visible = false;
        };
    }
    public ItemInfo(SocioInfo Info) {
        InitializeComponent();
        this.Info = Info;
    }

    private void cmdMenu_Click(object sender, EventArgs e) {
        pnlSubMenu.Visible = true;
        // mnuOptions.Show((Control)sender,cmdMenu.PointToClient(Cursor.Position) ,ToolStripDropDownDirection.BelowLeft);
    }

    private void mnuEditar_Click(object sender, EventArgs e) {
        if (Edit != null) {
            Edit(this, _Socio);
        }
    }

    private void mnuBorrar_Click(object sender, EventArgs e) {
        if (Delete != null) {
            Delete(this, _Socio);
        }
    }


    private void cmdEdit_Click(object sender, EventArgs e) {
        if (Edit != null) {
            Edit(this, _Socio);
        }
    }

    private void cmdDelete_Click(object sender, EventArgs e) {
        if (Delete != null) {
            Delete(this, _Socio);
        }
    }

    private void lblDomicilio_Click(object sender, EventArgs e) {

    }

    private void label2_Click(object sender, EventArgs e) {

    }

    private void lblEdad_Click(object sender, EventArgs e) {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void lblApellidos_Click(object sender, EventArgs e) {

    }

    private void lblNombres_Click(object sender, EventArgs e) {

    }

    private void ItemInfo_MouseMove(object sender, MouseEventArgs e) {
        if (this.BackColor != Color.DarkCyan) {
            this.BackColor = Color.DarkCyan;
        }
    }

    private void ItemInfo_MouseLeave(object sender, EventArgs e) {
        if (this.BackColor != Color.WhiteSmoke) {
            this.BackColor = Color.WhiteSmoke;
        }
    }
    //protected override void OnResize(EventArgs e) {        
    //    base.OnResize(e);
    //    cmdMenu.Location = new Point(this.Width - 23, cmdMenu.Location.Y);
    //}

}

