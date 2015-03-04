
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
            MouseBehaviorExtension mouseBehaviorExtension3 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension7 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension8 = new MouseBehaviorExtension();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.mnuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSubMenu = new System.Windows.Forms.Panel();
            this.cmdDelete = new AnimatedButton();
            this.cmdEdit = new AnimatedButton();
            this.cmdMenu = new AnimatedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.mnuOptions.SuspendLayout();
            this.pnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(91, 5);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(592, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "[NOMBRES]";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(91, 23);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(616, 14);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "[APELLIDOS]";
            this.lblApellidos.Click += new System.EventHandler(this.lblApellidos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edad: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(126, 39);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 15);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "[EDAD]";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Domicilio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(91, 70);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(650, 30);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "[DOMICILIO]";
            this.lblDomicilio.Click += new System.EventHandler(this.lblDomicilio_Click);
            // 
            // picUser
            // 
            this.picUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picUser.Image = global::GYMManager.Properties.Resources.ic_account_box_grey600_24dp;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(86, 106);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // mnuOptions
            // 
            this.mnuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuBorrar});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuOptions.Size = new System.Drawing.Size(105, 48);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(104, 22);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuBorrar
            // 
            this.mnuBorrar.Name = "mnuBorrar";
            this.mnuBorrar.Size = new System.Drawing.Size(104, 22);
            this.mnuBorrar.Text = "Borrar";
            this.mnuBorrar.Click += new System.EventHandler(this.mnuBorrar_Click);
            // 
            // pnlSubMenu
            // 
            this.pnlSubMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSubMenu.Controls.Add(this.cmdDelete);
            this.pnlSubMenu.Controls.Add(this.cmdEdit);
            this.pnlSubMenu.Location = new System.Drawing.Point(662, 4);
            this.pnlSubMenu.Name = "pnlSubMenu";
            this.pnlSubMenu.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSubMenu.Size = new System.Drawing.Size(82, 52);
            this.pnlSubMenu.TabIndex = 8;
            this.pnlSubMenu.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdDelete.FlatAppearance.BorderSize = 0;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.Color.Silver;
            this.cmdDelete.Location = new System.Drawing.Point(3, 26);
            mouseBehaviorExtension3.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.HoverForecolor = System.Drawing.Color.Goldenrod;
            mouseBehaviorExtension3.HoverImage = null;
            mouseBehaviorExtension3.HoverText = "";
            mouseBehaviorExtension3.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension3.LeaveForecolor = System.Drawing.Color.Silver;
            mouseBehaviorExtension3.LeaveImage = null;
            mouseBehaviorExtension3.LeaveText = "";
            this.cmdDelete.MouseBehavior = mouseBehaviorExtension3;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.SetAsToggleButton = false;
            this.cmdDelete.Size = new System.Drawing.Size(76, 23);
            this.cmdDelete.TabIndex = 1;
            this.cmdDelete.Text = "Eliminar";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdEdit.FlatAppearance.BorderSize = 0;
            this.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.ForeColor = System.Drawing.Color.Silver;
            this.cmdEdit.Location = new System.Drawing.Point(3, 3);
            mouseBehaviorExtension7.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.HoverForecolor = System.Drawing.Color.Goldenrod;
            mouseBehaviorExtension7.HoverImage = null;
            mouseBehaviorExtension7.HoverText = "";
            mouseBehaviorExtension7.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension7.LeaveForecolor = System.Drawing.Color.Silver;
            mouseBehaviorExtension7.LeaveImage = null;
            mouseBehaviorExtension7.LeaveText = "";
            this.cmdEdit.MouseBehavior = mouseBehaviorExtension7;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.SetAsToggleButton = false;
            this.cmdEdit.Size = new System.Drawing.Size(76, 23);
            this.cmdEdit.TabIndex = 0;
            this.cmdEdit.Text = "Editar";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdMenu
            // 
            this.cmdMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMenu.BackColor = System.Drawing.Color.Transparent;
            this.cmdMenu.ContextMenuStrip = this.mnuOptions;
            this.cmdMenu.FlatAppearance.BorderSize = 0;
            this.cmdMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMenu.Image = global::GYMManager.Properties.Resources.vertical_menu_icon_normal;
            this.cmdMenu.Location = new System.Drawing.Point(737, 0);
            mouseBehaviorExtension8.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.HoverColor = System.Drawing.Color.Transparent;
            mouseBehaviorExtension8.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.HoverImage = global::GYMManager.Properties.Resources.vertical_menu_icon_hover;
            mouseBehaviorExtension8.HoverText = "";
            mouseBehaviorExtension8.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.LeaveColor = System.Drawing.Color.Transparent;
            mouseBehaviorExtension8.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension8.LeaveImage = global::GYMManager.Properties.Resources.vertical_menu_icon_normal;
            mouseBehaviorExtension8.LeaveText = "";
            this.cmdMenu.MouseBehavior = mouseBehaviorExtension8;
            this.cmdMenu.Name = "cmdMenu";
            this.cmdMenu.SetAsToggleButton = false;
            this.cmdMenu.Size = new System.Drawing.Size(8, 23);
            this.cmdMenu.TabIndex = 7;
            this.cmdMenu.UseVisualStyleBackColor = false;
            this.cmdMenu.Click += new System.EventHandler(this.cmdMenu_Click);
            // 
            // ItemInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlSubMenu);
            this.Controls.Add(this.cmdMenu);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.picUser);
            this.Name = "ItemInfo";
            this.Size = new System.Drawing.Size(748, 105);
            this.MouseLeave += new System.EventHandler(this.ItemInfo_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemInfo_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.mnuOptions.ResumeLayout(false);
            this.pnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picUser;
    private System.Windows.Forms.Label lblNombres;
    private System.Windows.Forms.Label lblApellidos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblEdad;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblDomicilio;
    private AnimatedButton cmdMenu;
    private System.Windows.Forms.ContextMenuStrip mnuOptions;
    private System.Windows.Forms.ToolStripMenuItem mnuEditar;
    private System.Windows.Forms.ToolStripMenuItem mnuBorrar;
    private System.Windows.Forms.Panel pnlSubMenu;
    private AnimatedButton cmdDelete;
    private AnimatedButton cmdEdit;
}

