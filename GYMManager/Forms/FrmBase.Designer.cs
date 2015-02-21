
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            MouseBehaviorExtension mouseBehaviorExtension1 = new MouseBehaviorExtension();
            MouseBehaviorExtension mouseBehaviorExtension2 = new MouseBehaviorExtension();
            this.lblClose = new System.Windows.Forms.Label();
            this.cmdMinimize = new AnimatedButton();
            this.cmdClose = new AnimatedButton();
            this.focusBehaviorExtension1 = new FocusBehaviorExtension();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(673, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(49, 23);
            this.lblClose.TabIndex = 0;
            // 
            // cmdMinimize
            // 
            this.cmdMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdMinimize.BackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.cmdMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimize.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimize.Image")));
            this.cmdMinimize.Location = new System.Drawing.Point(923, 15);
            mouseBehaviorExtension1.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverImage = ((System.Drawing.Image)(resources.GetObject("mouseBehaviorExtension1.HoverImage")));
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveImage = ((System.Drawing.Image)(resources.GetObject("mouseBehaviorExtension1.LeaveImage")));
            mouseBehaviorExtension1.LeaveText = "";
            this.cmdMinimize.MouseBehavior = mouseBehaviorExtension1;
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.SetAsToggleButton = false;
            this.cmdMinimize.Size = new System.Drawing.Size(23, 19);
            this.cmdMinimize.TabIndex = 1;
            this.cmdMinimize.UseVisualStyleBackColor = false;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.BackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Image = global::GYMManager.Properties.Resources.close_normal_pic;
            this.cmdClose.Location = new System.Drawing.Point(946, 8);
            mouseBehaviorExtension2.HoverBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverImage = global::GYMManager.Properties.Resources.close_hover_pic1;
            mouseBehaviorExtension2.HoverText = "";
            mouseBehaviorExtension2.LeaveBorderColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveImage = global::GYMManager.Properties.Resources.close_normal_pic;
            mouseBehaviorExtension2.LeaveText = "";
            this.cmdClose.MouseBehavior = mouseBehaviorExtension2;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.SetAsToggleButton = false;
            this.cmdClose.Size = new System.Drawing.Size(23, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.UseVisualStyleBackColor = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // focusBehaviorExtension1
            // 
            this.focusBehaviorExtension1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.focusBehaviorExtension1.BorderWidth = 10F;
            this.focusBehaviorExtension1.ControlOwner = null;
            this.focusBehaviorExtension1.FocusBgColor = System.Drawing.Color.DimGray;
            this.focusBehaviorExtension1.FocusBorderColor = System.Drawing.Color.Goldenrod;
            this.focusBehaviorExtension1.LostFocusBgColor = System.Drawing.Color.White;
            this.focusBehaviorExtension1.LostFocusBorderColor = System.Drawing.Color.Silver;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(980, 443);
            this.Controls.Add(this.cmdMinimize);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBase";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private AnimatedButton cmdClose;
        private AnimatedButton cmdMinimize;
        private FocusBehaviorExtension focusBehaviorExtension1;
      
    }


