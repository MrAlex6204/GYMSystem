using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

class PanelPartner : System.Windows.Forms.UserControl {

    private SocioInfo _SocioInfo = new SocioInfo();
    private RecordModeAction _ActionType = new RecordModeAction();
    #region Initilize & Constructor

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cmbGenero;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private AnimatedButton cmdCancel;
    private AnimatedButton cmdOk;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox picPartnerPhoto;
    private System.Windows.Forms.LinkLabel lnkBrow;
    private TextBoxAnimate txtNombre;
    private TextBoxAnimate txtApellidos;
    private TextBoxAnimate txtEdad;
    private TextBoxAnimate txtDir;
    private TextBoxAnimate txtEmail;
    private TextBoxAnimate txtTel;
    private TextBoxAnimate txtMovil;
    private TextBoxAnimate txtNotas;
    private Label lblTitle;
    private System.Windows.Forms.Label label1;

    private void InitializeComponent() {
            MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension2 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension3 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension4 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension5 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension6 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension7 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension8 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension9 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension10 = new MouseBehaviorExtension();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPartnerPhoto = new System.Windows.Forms.PictureBox();
            this.lnkBrow = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNotas = new TextBoxAnimate();
            this.txtMovil = new TextBoxAnimate();
            this.txtTel = new TextBoxAnimate();
            this.txtEmail = new TextBoxAnimate();
            this.txtDir = new TextBoxAnimate();
            this.txtEdad = new TextBoxAnimate();
            this.txtApellidos = new TextBoxAnimate();
            this.txtNombre = new TextBoxAnimate();
            this.cmdOk = new AnimatedButton();
            this.cmdCancel = new AnimatedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPartnerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(326, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Notas :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(328, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(300, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Direccion :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(328, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Edad :";
            // 
            // cmbGenero
            // 
            this.cmbGenero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbGenero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbGenero.ForeColor = System.Drawing.Color.Navy;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbGenero.Location = new System.Drawing.Point(474, 121);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(51, 25);
            this.cmbGenero.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(411, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(457, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Movil :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(340, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tel :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(300, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apellidos :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(291, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre(s) :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.picPartnerPhoto);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(273, 360);
            this.panel1.TabIndex = 44;
            // 
            // picPartnerPhoto
            // 
            this.picPartnerPhoto.BackColor = System.Drawing.Color.Silver;
            this.picPartnerPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPartnerPhoto.Location = new System.Drawing.Point(3, 3);
            this.picPartnerPhoto.Name = "picPartnerPhoto";
            this.picPartnerPhoto.Size = new System.Drawing.Size(267, 354);
            this.picPartnerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPartnerPhoto.TabIndex = 0;
            this.picPartnerPhoto.TabStop = false;
            // 
            // lnkBrow
            // 
            this.lnkBrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkBrow.AutoSize = true;
            this.lnkBrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lnkBrow.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBrow.LinkColor = System.Drawing.Color.Navy;
            this.lnkBrow.Location = new System.Drawing.Point(12, 412);
            this.lnkBrow.Name = "lnkBrow";
            this.lnkBrow.Size = new System.Drawing.Size(73, 16);
            this.lnkBrow.TabIndex = 11;
            this.lnkBrow.TabStop = true;
            this.lnkBrow.Text = "Examinar...";
            this.lnkBrow.VisitedLinkColor = System.Drawing.Color.Navy;
            this.lnkBrow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrow_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Image = global::GYMManager.Properties.Resources.ic_account_box_black_24dp;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(14, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 35);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Nuevo socio";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotas
            // 
            this.txtNotas.AcceptsReturn = true;
            this.txtNotas.AcceptsTab = true;
            this.txtNotas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNotas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension1.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension1.HoverImage = null;
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension1.LeaveImage = null;
            mouseBehaviorExtension1.LeaveText = "";
            this.txtNotas.FocusBehavior = mouseBehaviorExtension1;
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNotas.ForeColor = System.Drawing.Color.DimGray;
            this.txtNotas.Location = new System.Drawing.Point(380, 268);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(429, 131);
            this.txtNotas.TabIndex = 10;
            // 
            // txtMovil
            // 
            this.txtMovil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMovil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMovil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension2.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension2.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension2.HoverImage = null;
            mouseBehaviorExtension2.HoverText = "";
            mouseBehaviorExtension2.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension2.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension2.LeaveImage = null;
            mouseBehaviorExtension2.LeaveText = "";
            this.txtMovil.FocusBehavior = mouseBehaviorExtension2;
            this.txtMovil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMovil.ForeColor = System.Drawing.Color.DimGray;
            this.txtMovil.Location = new System.Drawing.Point(511, 237);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(100, 25);
            this.txtMovil.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension3.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension3.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension3.HoverImage = null;
            mouseBehaviorExtension3.HoverText = "";
            mouseBehaviorExtension3.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension3.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension3.LeaveImage = null;
            mouseBehaviorExtension3.LeaveText = "";
            this.txtTel.FocusBehavior = mouseBehaviorExtension3;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTel.ForeColor = System.Drawing.Color.DimGray;
            this.txtTel.Location = new System.Drawing.Point(380, 237);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(68, 25);
            this.txtTel.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension4.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension4.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension4.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension4.HoverImage = null;
            mouseBehaviorExtension4.HoverText = "";
            mouseBehaviorExtension4.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension4.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension4.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension4.LeaveImage = null;
            mouseBehaviorExtension4.LeaveText = "";
            this.txtEmail.FocusBehavior = mouseBehaviorExtension4;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(380, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // txtDir
            // 
            this.txtDir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension5.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension5.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension5.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension5.HoverImage = null;
            mouseBehaviorExtension5.HoverText = "";
            mouseBehaviorExtension5.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension5.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension5.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension5.LeaveImage = null;
            mouseBehaviorExtension5.LeaveText = "";
            this.txtDir.FocusBehavior = mouseBehaviorExtension5;
            this.txtDir.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtDir.ForeColor = System.Drawing.Color.DimGray;
            this.txtDir.Location = new System.Drawing.Point(380, 181);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(427, 25);
            this.txtDir.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtEdad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension6.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension6.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension6.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension6.HoverImage = null;
            mouseBehaviorExtension6.HoverText = "";
            mouseBehaviorExtension6.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension6.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension6.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension6.LeaveImage = null;
            mouseBehaviorExtension6.LeaveText = "";
            this.txtEdad.FocusBehavior = mouseBehaviorExtension6;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEdad.ForeColor = System.Drawing.Color.DimGray;
            this.txtEdad.Location = new System.Drawing.Point(380, 121);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(29, 25);
            this.txtEdad.TabIndex = 2;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtApellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension7.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension7.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension7.HoverImage = null;
            mouseBehaviorExtension7.HoverText = "";
            mouseBehaviorExtension7.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension7.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension7.LeaveImage = null;
            mouseBehaviorExtension7.LeaveText = "";
            this.txtApellidos.FocusBehavior = mouseBehaviorExtension7;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtApellidos.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellidos.Location = new System.Drawing.Point(380, 90);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(429, 25);
            this.txtApellidos.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            mouseBehaviorExtension8.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.HoverColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension8.HoverForecolor = System.Drawing.Color.Navy;
            mouseBehaviorExtension8.HoverImage = null;
            mouseBehaviorExtension8.HoverText = "";
            mouseBehaviorExtension8.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.LeaveColor = System.Drawing.Color.WhiteSmoke;
            mouseBehaviorExtension8.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension8.LeaveImage = null;
            mouseBehaviorExtension8.LeaveText = "";
            this.txtNombre.FocusBehavior = mouseBehaviorExtension8;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(380, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(429, 25);
            this.txtNombre.TabIndex = 0;
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.BackColor = System.Drawing.Color.Silver;
            this.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOk.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.ForeColor = System.Drawing.Color.DimGray;
            this.cmdOk.Location = new System.Drawing.Point(651, 405);
            mouseBehaviorExtension9.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension9.HoverColor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension9.HoverForecolor = System.Drawing.Color.Silver;
            mouseBehaviorExtension9.HoverImage = null;
            mouseBehaviorExtension9.HoverText = null;
            mouseBehaviorExtension9.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension9.LeaveColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension9.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension9.LeaveImage = null;
            mouseBehaviorExtension9.LeaveText = null;
            this.cmdOk.MouseBehavior = mouseBehaviorExtension9;
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.SetAsToggleButton = false;
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 12;
            this.cmdOk.Text = "Guardar";
            this.cmdOk.UseVisualStyleBackColor = false;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.Silver;
            this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.ForeColor = System.Drawing.Color.DimGray;
            this.cmdCancel.Location = new System.Drawing.Point(732, 405);
            mouseBehaviorExtension10.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension10.HoverColor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension10.HoverForecolor = System.Drawing.Color.Silver;
            mouseBehaviorExtension10.HoverImage = null;
            mouseBehaviorExtension10.HoverText = null;
            mouseBehaviorExtension10.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension10.LeaveColor = System.Drawing.Color.Silver;
            mouseBehaviorExtension10.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension10.LeaveImage = null;
            mouseBehaviorExtension10.LeaveText = null;
            this.cmdCancel.MouseBehavior = mouseBehaviorExtension10;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.SetAsToggleButton = false;
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 13;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // PanelPartner
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lnkBrow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelPartner";
            this.Size = new System.Drawing.Size(836, 443);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPartnerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public PanelPartner() {
        InitializeComponent();
    }

    #endregion

    #region Public properties

    [Browsable(false)]
    public SocioInfo SocioInfo {
        get {
            return _SocioInfo;
        }
        set {
            _SocioInfo = value;

            if (value != null) {
                this.txtNombre.Text = value.Nombres;
                this.txtApellidos.Text = value.Apellidos;
                this.txtEdad.Text = value.Edad;
                this.cmbGenero.Text = value.Sexo;
                this.txtDir.Text = value.Domicilio;
                this.txtEmail.Text = value.Email;
                this.txtTel.Text = value.Tel;
                this.txtMovil.Text = value.Movil;
                this.txtNotas.Text = value.Notas;
                this.picPartnerPhoto.Image = value.SocioImg.Image;
            }

        }
    }

    public enum RecordModeAction {
        NewRecord, UpdateRecord
    }
    public RecordModeAction ActionType {
        get {
            return _ActionType;
        }
        set {
            switch (value) { 
                case RecordModeAction.NewRecord:
                    lblTitle.Text = "Nuevo Socio";
                    break;
                case RecordModeAction.UpdateRecord:
                    lblTitle.Text = "Edicion";
                    break;
            }
            _ActionType = value;
        }
    }

    #endregion

    #region Functions

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
        _SocioInfo.SocioImg.FSImage = null;
        _SocioInfo.SocioImg.FileName = null;       
    }

    private void cmdOk_Click(object sender, EventArgs e) {
        int Edad = 0;

        if (!int.TryParse(txtEdad.Text,out Edad)) {
            MessageBox.Show("Favor de verificar la edad!", "Formato invalido!");
            txtEdad.Focus();
            return;
        }

        _SocioInfo.Nombres = this.txtNombre.Text;
        _SocioInfo.Apellidos = this.txtApellidos.Text;
        _SocioInfo.Edad = this.txtEdad.Text;
        _SocioInfo.Sexo = cmbGenero.Text;
        _SocioInfo.Domicilio = this.txtDir.Text;
        _SocioInfo.Email = this.txtEmail.Text;
        _SocioInfo.Tel = this.txtTel.Text;
        _SocioInfo.Movil = this.txtMovil.Text;
        _SocioInfo.Notas = this.txtNotas.Text;

        switch (this.ActionType) {
            case RecordModeAction.NewRecord:
                if (_SocioInfo.Save()) {
                    MessageBox.Show("Socio regitrado con el numero " + _SocioInfo.Id, "Socio Registrado");
                    this.Clear();
                } else {
                    MessageBox.Show("No se puedo registrar!", "Error al registrar");
                }
                break;
            case RecordModeAction.UpdateRecord:

                break;
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
            _SocioInfo.SocioImg.FileName = (new System.IO.FileInfo(dlgOpenFile.FileName)).Name;
            _SocioInfo.SocioImg.FSImage = Utility.GetPictureStream(dlgOpenFile.FileName);            
        }

    }

    private void cmdCancel_Click(object sender, EventArgs e) {
        this.Visible = false;
        this.Clear();
    }

    #endregion





}

