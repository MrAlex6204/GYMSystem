namespace GYMManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            GYMManager.Controls.MouseBehaviorExtension mouseBehaviorExtension1 = new GYMManager.Controls.MouseBehaviorExtension();
            GYMManager.Controls.MouseBehaviorExtension mouseBehaviorExtension2 = new GYMManager.Controls.MouseBehaviorExtension();
            GYMManager.Controls.MouseBehaviorExtension mouseBehaviorExtension3 = new GYMManager.Controls.MouseBehaviorExtension();
            this.lblClose = new System.Windows.Forms.Label();
            this.cmdMinimize = new GYMManager.Controls.AnimatedButton();
            this.cmdClose = new GYMManager.Controls.AnimatedButton();
            this.animatedButton1 = new GYMManager.Controls.AnimatedButton();
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
            this.cmdMinimize.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMinimize.Image = ((System.Drawing.Image)(resources.GetObject("cmdMinimize.Image")));
            this.cmdMinimize.Location = new System.Drawing.Point(676, 6);
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverImage = ((System.Drawing.Image)(resources.GetObject("mouseBehaviorExtension1.HoverImage")));
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveImage = ((System.Drawing.Image)(resources.GetObject("mouseBehaviorExtension1.LeaveImage")));
            mouseBehaviorExtension1.LeaveText = "";
            this.cmdMinimize.MouseBehavior = mouseBehaviorExtension1;
            this.cmdMinimize.Name = "cmdMinimize";
            this.cmdMinimize.Size = new System.Drawing.Size(23, 23);
            this.cmdMinimize.TabIndex = 1;
            this.cmdMinimize.UseVisualStyleBackColor = true;
            this.cmdMinimize.Click += new System.EventHandler(this.cmdMinimize_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Image = global::GYMManager.Properties.Resources.close_normal_pic;
            this.cmdClose.Location = new System.Drawing.Point(705, 6);
            mouseBehaviorExtension2.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.HoverImage = global::GYMManager.Properties.Resources.close_hover_pic1;
            mouseBehaviorExtension2.HoverText = "";
            mouseBehaviorExtension2.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension2.LeaveImage = global::GYMManager.Properties.Resources.close_normal_pic;
            mouseBehaviorExtension2.LeaveText = "";
            this.cmdClose.MouseBehavior = mouseBehaviorExtension2;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(23, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.animatedButton1_Click_1);
            // 
            // animatedButton1
            // 
            this.animatedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.animatedButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.animatedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animatedButton1.ForeColor = System.Drawing.Color.DimGray;
            this.animatedButton1.Location = new System.Drawing.Point(3, 6);
            mouseBehaviorExtension3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            mouseBehaviorExtension3.HoverForecolor = System.Drawing.Color.Goldenrod;
            mouseBehaviorExtension3.HoverImage = null;
            mouseBehaviorExtension3.HoverText = null;
            mouseBehaviorExtension3.LeaveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            mouseBehaviorExtension3.LeaveForecolor = System.Drawing.Color.DimGray;
            mouseBehaviorExtension3.LeaveImage = null;
            mouseBehaviorExtension3.LeaveText = null;
            this.animatedButton1.MouseBehavior = mouseBehaviorExtension3;
            this.animatedButton1.Name = "animatedButton1";
            this.animatedButton1.Size = new System.Drawing.Size(131, 78);
            this.animatedButton1.TabIndex = 2;
            this.animatedButton1.Text = "Agregar Contacto";
            this.animatedButton1.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.ControlBox = false;
            this.Controls.Add(this.animatedButton1);
            this.Controls.Add(this.cmdMinimize);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private Controls.AnimatedButton cmdClose;
        private Controls.AnimatedButton cmdMinimize;
        private Controls.AnimatedButton animatedButton1;
      

    }
}

