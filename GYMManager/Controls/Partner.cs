using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

class PanelPartner : System.Windows.Forms.UserControl {

    private System.IO.FileInfo _PictureFile = null;
    
    #region Initilize & Constructor

    private System.Windows.Forms.TextBox txtNotas;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtDir;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtEdad;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbGenero;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtMovil;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNombre;
    private AnimatedButton cmdCancel;
    private AnimatedButton cmdOk;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox picPartnerPhoto;
    private System.Windows.Forms.LinkLabel lnkBrow;
    private System.Windows.Forms.Label label1;

    private void InitializeComponent() {
        MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
        MouseBehaviorExtension mouseBehaviorExtension2 = new MouseBehaviorExtension();
        this.txtNotas = new System.Windows.Forms.TextBox();
        this.label9 = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.label8 = new System.Windows.Forms.Label();
        this.txtDir = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.txtEdad = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.cmbGenero = new System.Windows.Forms.ComboBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtMovil = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.txtTel = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.txtApellidos = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.picPartnerPhoto = new System.Windows.Forms.PictureBox();
        this.lnkBrow = new System.Windows.Forms.LinkLabel();
        this.cmdOk = new AnimatedButton();
        this.cmdCancel = new AnimatedButton();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.picPartnerPhoto)).BeginInit();
        this.SuspendLayout();
        // 
        // txtNotas
        // 
        this.txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNotas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtNotas.Location = new System.Drawing.Point(347, 226);
        this.txtNotas.Multiline = true;
        this.txtNotas.Name = "txtNotas";
        this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtNotas.Size = new System.Drawing.Size(396, 89);
        this.txtNotas.TabIndex = 38;
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label9.ForeColor = System.Drawing.Color.DimGray;
        this.label9.Location = new System.Drawing.Point(293, 226);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(53, 17);
        this.label9.TabIndex = 37;
        this.label9.Text = "Notas :";
        // 
        // txtEmail
        // 
        this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtEmail.Location = new System.Drawing.Point(347, 170);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(228, 24);
        this.txtEmail.TabIndex = 36;
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label8.ForeColor = System.Drawing.Color.DimGray;
        this.label8.Location = new System.Drawing.Point(295, 172);
        this.label8.Name = "label8";
        this.label8.Size = new System.Drawing.Size(54, 17);
        this.label8.TabIndex = 35;
        this.label8.Text = "Email : ";
        // 
        // txtDir
        // 
        this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtDir.Location = new System.Drawing.Point(347, 142);
        this.txtDir.Name = "txtDir";
        this.txtDir.Size = new System.Drawing.Size(396, 24);
        this.txtDir.TabIndex = 34;
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label7.ForeColor = System.Drawing.Color.DimGray;
        this.label7.Location = new System.Drawing.Point(267, 144);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(75, 17);
        this.label7.TabIndex = 33;
        this.label7.Text = "Direccion :";
        // 
        // txtEdad
        // 
        this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtEdad.Location = new System.Drawing.Point(347, 81);
        this.txtEdad.MaxLength = 2;
        this.txtEdad.Name = "txtEdad";
        this.txtEdad.Size = new System.Drawing.Size(25, 24);
        this.txtEdad.TabIndex = 32;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label6.ForeColor = System.Drawing.Color.DimGray;
        this.label6.Location = new System.Drawing.Point(295, 83);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(49, 17);
        this.label6.TabIndex = 31;
        this.label6.Text = "Edad :";
        // 
        // cmbGenero
        // 
        this.cmbGenero.BackColor = System.Drawing.Color.Silver;
        this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbGenero.ForeColor = System.Drawing.Color.Navy;
        this.cmbGenero.FormattingEnabled = true;
        this.cmbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
        this.cmbGenero.Location = new System.Drawing.Point(441, 81);
        this.cmbGenero.Name = "cmbGenero";
        this.cmbGenero.Size = new System.Drawing.Size(51, 21);
        this.cmbGenero.TabIndex = 30;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label5.ForeColor = System.Drawing.Color.DimGray;
        this.label5.Location = new System.Drawing.Point(378, 83);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(60, 17);
        this.label5.TabIndex = 29;
        this.label5.Text = "Genero:";
        // 
        // txtMovil
        // 
        this.txtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtMovil.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtMovil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtMovil.Location = new System.Drawing.Point(482, 198);
        this.txtMovil.Name = "txtMovil";
        this.txtMovil.Size = new System.Drawing.Size(93, 24);
        this.txtMovil.TabIndex = 28;
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label4.ForeColor = System.Drawing.Color.DimGray;
        this.label4.Location = new System.Drawing.Point(424, 200);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(48, 17);
        this.label4.TabIndex = 27;
        this.label4.Text = "Movil :";
        // 
        // txtTel
        // 
        this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtTel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtTel.Location = new System.Drawing.Point(347, 198);
        this.txtTel.Name = "txtTel";
        this.txtTel.Size = new System.Drawing.Size(67, 24);
        this.txtTel.TabIndex = 26;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label3.ForeColor = System.Drawing.Color.DimGray;
        this.label3.Location = new System.Drawing.Point(307, 200);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(36, 17);
        this.label3.TabIndex = 25;
        this.label3.Text = "Tel :";
        // 
        // txtApellidos
        // 
        this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtApellidos.Location = new System.Drawing.Point(347, 52);
        this.txtApellidos.Name = "txtApellidos";
        this.txtApellidos.Size = new System.Drawing.Size(396, 24);
        this.txtApellidos.TabIndex = 24;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label2.ForeColor = System.Drawing.Color.DimGray;
        this.label2.Location = new System.Drawing.Point(267, 54);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(73, 17);
        this.label2.TabIndex = 23;
        this.label2.Text = "Apellidos :";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
        this.label1.ForeColor = System.Drawing.Color.DimGray;
        this.label1.Location = new System.Drawing.Point(258, 28);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(83, 17);
        this.label1.TabIndex = 22;
        this.label1.Text = "Nombre(s) :";
        // 
        // txtNombre
        // 
        this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
        this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.txtNombre.Location = new System.Drawing.Point(347, 26);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(396, 24);
        this.txtNombre.TabIndex = 41;
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.Silver;
        this.panel1.Controls.Add(this.picPartnerPhoto);
        this.panel1.Location = new System.Drawing.Point(12, 13);
        this.panel1.Name = "panel1";
        this.panel1.Padding = new System.Windows.Forms.Padding(3);
        this.panel1.Size = new System.Drawing.Size(240, 320);
        this.panel1.TabIndex = 44;
        // 
        // picPartnerPhoto
        // 
        this.picPartnerPhoto.BackColor = System.Drawing.Color.WhiteSmoke;
        this.picPartnerPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
        this.picPartnerPhoto.Location = new System.Drawing.Point(3, 3);
        this.picPartnerPhoto.Name = "picPartnerPhoto";
        this.picPartnerPhoto.Size = new System.Drawing.Size(234, 314);
        this.picPartnerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picPartnerPhoto.TabIndex = 0;
        this.picPartnerPhoto.TabStop = false;
        // 
        // lnkBrow
        // 
        this.lnkBrow.AutoSize = true;
        this.lnkBrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
        this.lnkBrow.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
        this.lnkBrow.LinkColor = System.Drawing.Color.Navy;
        this.lnkBrow.Location = new System.Drawing.Point(12, 339);
        this.lnkBrow.Name = "lnkBrow";
        this.lnkBrow.Size = new System.Drawing.Size(73, 16);
        this.lnkBrow.TabIndex = 47;
        this.lnkBrow.TabStop = true;
        this.lnkBrow.Text = "Examinar...";
        this.lnkBrow.VisitedLinkColor = System.Drawing.Color.Navy;
        this.lnkBrow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrow_LinkClicked);
        // 
        // cmdOk
        // 
        this.cmdOk.BackColor = System.Drawing.Color.Silver;
        this.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
        this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdOk.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdOk.ForeColor = System.Drawing.Color.DimGray;
        this.cmdOk.Location = new System.Drawing.Point(587, 336);
        mouseBehaviorExtension1.HoverBorderColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.HoverColor = System.Drawing.Color.DimGray;
        mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Silver;
        mouseBehaviorExtension1.HoverImage = null;
        mouseBehaviorExtension1.HoverText = null;
        mouseBehaviorExtension1.LeaveBorderColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Silver;
        mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.DimGray;
        mouseBehaviorExtension1.LeaveImage = null;
        mouseBehaviorExtension1.LeaveText = null;
        this.cmdOk.MouseBehavior = mouseBehaviorExtension1;
        this.cmdOk.Name = "cmdOk";
        this.cmdOk.SetAsToggleButton = false;
        this.cmdOk.Size = new System.Drawing.Size(75, 23);
        this.cmdOk.TabIndex = 43;
        this.cmdOk.Text = "Guardar";
        this.cmdOk.UseVisualStyleBackColor = false;
        this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
        // 
        // cmdCancel
        // 
        this.cmdCancel.BackColor = System.Drawing.Color.Silver;
        this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
        this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmdCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.cmdCancel.ForeColor = System.Drawing.Color.DimGray;
        this.cmdCancel.Location = new System.Drawing.Point(668, 336);
        mouseBehaviorExtension2.HoverBorderColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension2.HoverColor = System.Drawing.Color.DimGray;
        mouseBehaviorExtension2.HoverForecolor = System.Drawing.Color.Silver;
        mouseBehaviorExtension2.HoverImage = null;
        mouseBehaviorExtension2.HoverText = null;
        mouseBehaviorExtension2.LeaveBorderColor = System.Drawing.Color.Empty;
        mouseBehaviorExtension2.LeaveColor = System.Drawing.Color.Silver;
        mouseBehaviorExtension2.LeaveForecolor = System.Drawing.Color.DimGray;
        mouseBehaviorExtension2.LeaveImage = null;
        mouseBehaviorExtension2.LeaveText = null;
        this.cmdCancel.MouseBehavior = mouseBehaviorExtension2;
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.SetAsToggleButton = false;
        this.cmdCancel.Size = new System.Drawing.Size(75, 23);
        this.cmdCancel.TabIndex = 42;
        this.cmdCancel.Text = "Cancelar";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
        // 
        // PanelPartner
        // 
        this.BackColor = System.Drawing.Color.White;
        this.Controls.Add(this.lnkBrow);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.cmdOk);
        this.Controls.Add(this.cmdCancel);
        this.Controls.Add(this.txtNombre);
        this.Controls.Add(this.txtNotas);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.txtDir);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.txtEdad);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.cmbGenero);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.txtMovil);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtTel);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.txtApellidos);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Name = "PanelPartner";
        this.Size = new System.Drawing.Size(770, 375);
        this.panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.picPartnerPhoto)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    public PanelPartner() {
        InitializeComponent();
    }

    #endregion

    #region Private Function
    public void Clear() {
        lnkBrow.Enabled = true;
        txtNombre.Text = "";
        txtApellidos.Text = "";
        txtEdad.Text = "";
        cmbGenero.SelectedIndex = -1;
        txtDir.Text = "";
        txtEmail.Text = "";
        txtTel.Text = "";
        txtMovil.Text = "";
        txtNotas.Text = "";
        picPartnerPhoto.Image = null;
        _PictureFile = null;
    }
    private void cmdOk_Click(object sender, EventArgs e) {
        
        int Id = 0;
        string GetIdQry = "Select @@Identity";
        string SavePictureQry =
        "INSERT INTO TBL_FOTOS (CLIENTE_ID,FOTO,FILE_NAME) VALUES(@ID,@FOTO,@FILE_NAME)";
        string InsertQry =
        " INSERT INTO TBL_SOCIOS " +
        " (NOMBRES,APELLIDOS,TEL,MOVIL,SEXO,DOMICILIO,EMAIL,EDAD,NOTAS)" +
        " VALUES (@NOMBRES,@APELLIDOS,@TEL,@MOVIL,@SEXO,@DOMICILIO,@EMAIL,@EDAD,@NOTAS)";

        Utility.Db.ClearSqlVars();
        Utility.Db.AddSqlVar("@NOMBRES", txtNombre.Text);
        Utility.Db.AddSqlVar("@APELLIDOS", txtApellidos.Text);
        Utility.Db.AddSqlVar("@TEL", txtTel.Text);
        Utility.Db.AddSqlVar("@MOVIL", txtMovil.Text);
        Utility.Db.AddSqlVar("@SEXO", cmbGenero.Text);
        Utility.Db.AddSqlVar("@DOMICILIO", txtDir.Text);
        Utility.Db.AddSqlVar("@EMAIL", txtEmail.Text);
        Utility.Db.AddSqlVar("@EDAD", txtEdad.Text);
        Utility.Db.AddSqlVar("@NOTAS", txtNotas.Text);

        if (Utility.Db.SqlExec(InsertQry) > 0) {
            Id = (int)Utility.Db.SqlExecScalar(GetIdQry);

            if (_PictureFile != null) {
                Utility.Db.ClearSqlVars();
                Utility.Db.AddSqlVar("@ID", Id);
                Utility.Db.AddSqlVar("@FILE_NAME", _PictureFile.Name);
                Utility.Db.AddSqlVar("@FOTO", Utility.GetPictureStream(_PictureFile.FullName));

                if (Utility.Db.SqlExec(SavePictureQry) > 0) {
                    MessageBox.Show("El socio a sido regitrado satisfactoriamente\nCon el numero "+Id.ToString(),"Listo!");
                }

            } else {
                MessageBox.Show("El socio a sido regitrado satisfactoriamente\nCon el numero " + Id.ToString(), "Listo!");
            }
            lnkBrow.Enabled =  false;
        }


    }
    private void lnkBrow_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
        System.Windows.Forms.OpenFileDialog dlgOpenFile = new System.Windows.Forms.OpenFileDialog();

        dlgOpenFile.Title = "Selecccione una fotografia para el socio.";
        dlgOpenFile.Filter = "Imagen|*.png;*.bmp;*.jpg)";
        dlgOpenFile.Multiselect = false;
        dlgOpenFile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        if (dlgOpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
            picPartnerPhoto.Image = System.Drawing.Image.FromFile(dlgOpenFile.FileName);
            _PictureFile = new System.IO.FileInfo( dlgOpenFile.FileName);
        }

    }
    private void cmdCancel_Click(object sender, EventArgs e) {
        this.Visible = false;
    }

    #endregion




}

