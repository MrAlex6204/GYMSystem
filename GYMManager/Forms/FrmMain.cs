using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
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
            List<SocioInfo> LstSocios = new List<SocioInfo>();

            LstSocios = SocioInfo.GetSocios();
            flwSocios.Controls.Clear();
            foreach (SocioInfo iSocio in LstSocios) {
                ItemInfo item = new ItemInfo(iSocio);
                flwSocios.Controls.Add(item);
            }


            
        }

    }

