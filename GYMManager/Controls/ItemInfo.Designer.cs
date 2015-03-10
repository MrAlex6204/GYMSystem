
partial class ItemInfo {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.cmConfigAccount = new AnimatedButton();
            this.mnuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(91, 5);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(598, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "[NOMBRES]";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.DimGray;
            this.lblApellidos.Location = new System.Drawing.Point(91, 27);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(639, 14);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "[APELLIDOS]";
            // 
            // lblEdad
            // 
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.DimGray;
            this.lblEdad.Location = new System.Drawing.Point(123, 71);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(31, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "[EDAD]";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ForeColor = System.Drawing.Color.DimGray;
            this.lblDomicilio.Location = new System.Drawing.Point(110, 53);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(627, 15);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "[DOMICILIO]";
            // 
            // mnuOptions
            // 
            this.mnuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuBorrar});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuOptions.Size = new System.Drawing.Size(107, 48);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(106, 22);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuBorrar
            // 
            this.mnuBorrar.Name = "mnuBorrar";
            this.mnuBorrar.Size = new System.Drawing.Size(106, 22);
            this.mnuBorrar.Text = "Borrar";
            this.mnuBorrar.Click += new System.EventHandler(this.mnuBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(89, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(147, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "socio # :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.ForeColor = System.Drawing.Color.DimGray;
            this.lblClienteId.Location = new System.Drawing.Point(198, 71);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(26, 15);
            this.lblClienteId.TabIndex = 11;
            this.lblClienteId.Text = "[ID]";
            this.lblClienteId.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Image = global::GYMManager.Properties.Resources.ic_place_grey600_18dp;
            this.label2.Location = new System.Drawing.Point(91, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 22);
            this.label2.TabIndex = 9;
            // 
            // picUser
            // 
            this.picUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picUser.Image = global::GYMManager.Properties.Resources.ic_mood_grey600_48dp;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(86, 102);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // cmConfigAccount
            // 
            this.cmConfigAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmConfigAccount.BackColor = System.Drawing.Color.Transparent;
            this.cmConfigAccount.ContextMenuStrip = this.mnuOptions;
            this.cmConfigAccount.FlatAppearance.BorderSize = 0;
            this.cmConfigAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmConfigAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmConfigAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmConfigAccount.ForeColor = System.Drawing.Color.DimGray;
            this.cmConfigAccount.Image = global::GYMManager.Properties.Resources.ic_settings_grey600_18dp;
            this.cmConfigAccount.Location = new System.Drawing.Point(732, -1);
            mouseBehaviorExtension1.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Transparent;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Black;
            mouseBehaviorExtension1.HoverImage = global::GYMManager.Properties.Resources.ic_settings_black_18dp;
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Transparent;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Silver;
            mouseBehaviorExtension1.LeaveImage = global::GYMManager.Properties.Resources.ic_settings_grey600_18dp;
            mouseBehaviorExtension1.LeaveText = "";
            this.cmConfigAccount.MouseBehavior = mouseBehaviorExtension1;
            this.cmConfigAccount.Name = "cmConfigAccount";
            this.cmConfigAccount.SetAsToggleButton = false;
            this.cmConfigAccount.Size = new System.Drawing.Size(20, 22);
            this.cmConfigAccount.TabIndex = 7;
            this.cmConfigAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmConfigAccount.UseVisualStyleBackColor = false;
            this.cmConfigAccount.Click += new System.EventHandler(this.cmConfigAccount_Click);
            // 
            // ItemInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmConfigAccount);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.picUser);
            this.Name = "ItemInfo";
            this.Size = new System.Drawing.Size(754, 101);
            this.mnuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picUser;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.Label lblApellidos;
    private System.Windows.Forms.Label lblEdad;
    private System.Windows.Forms.Label lblDomicilio;
    private AnimatedButton cmConfigAccount;
    private System.Windows.Forms.ContextMenuStrip mnuOptions;
    private System.Windows.Forms.ToolStripMenuItem mnuEditar;
    private System.Windows.Forms.ToolStripMenuItem mnuBorrar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblClienteId;
}

