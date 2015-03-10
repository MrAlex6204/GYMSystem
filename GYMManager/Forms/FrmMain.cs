using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public partial class FrmMain : FrmBase {
    public FrmMain() {
        InitializeComponent();
        lblGYMTitle.Text = Settings.GYMTitle;
        this.RegisterMouseMoveEvent(this.pnlAddPartner);
        this.RegisterMouseMoveEvent(this.pnlSocios);
        this.RegisterMouseMoveEvent(this.lblGYMTitle);
    }

    private void cmdAddPartner_Click(object sender, EventArgs e) {
        cmdSocios.DesactiveButton();
        pnlAddPartner.Show();
    }

    private void FrmMain_Load(object sender, EventArgs e) {
        this.AddKeyPressEventHandler(this);
    }

    private void cmdLstPartners_Click(object sender, EventArgs e) {
        cmdSocios.DesactiveButton();
        pnlSocios.Visible = true;
        pnlSociosCollection.LoadSocios();
    }

    private void cmdConfig_Click(object sender, EventArgs e) {
        txtTitle.Text = Settings.GYMTitle;
    }

    private void cmdSaveTitle_Click(object sender, EventArgs e) {
        Settings.GYMTitle = txtTitle.Text;
        Settings.Save();
        lblGYMTitle.Text = Settings.GYMTitle;
        MessageBox.Show("El titulo de a cambiado satisfactoriamente!", "Listo!", MessageBoxButtons.OK, MessageBoxIcon.None);
        cmdConfig.DesactiveButton();
    }
    
    private void cmdCancel_Click(object sender, EventArgs e) {
        cmdConfig.DesactiveButton();
    }


}

