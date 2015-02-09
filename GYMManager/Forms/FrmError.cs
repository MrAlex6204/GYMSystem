using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowError(Exception ex) {
            FrmError wndError = new FrmError();
            wndError.txtError.AppendText("Error Message:\n");
            wndError.txtError.AppendText(ex.Message+"\n");
            wndError.txtError.AppendText("Stack Trace:\n");
            wndError.txtError.AppendText(ex.StackTrace + "\n");
            wndError.ShowDialog(); 
       }
    }

