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
            pnlWndSocios.Desactive();
            pnlAddPartner.Show();
        }

        private void animatedButton1_Click(object sender, EventArgs e) {
            MessageBox.Show("Ok");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e) {

        }

        private void pnlWndAddPartner_Paint(object sender, PaintEventArgs e) {

        }

        private void pnlWndAddPartner_Load(object sender, EventArgs e) {

        }

        private void FrmMain_Load(object sender, EventArgs e) {

        }
    }

