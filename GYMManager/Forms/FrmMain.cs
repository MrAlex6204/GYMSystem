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
    }

