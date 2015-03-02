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
        }

        private void cmdAddPartner_Click(object sender, EventArgs e) {
            cmdSocios.DesactiveButton();
            pnlAddPartner.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            this.AddKeyPressEventHandler(this);
        }

    }

