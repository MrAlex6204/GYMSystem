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
            GYMManager.Controls.MouseBehaviorExtension mouseBehaviorExtension1 = new GYMManager.Controls.MouseBehaviorExtension();
            GYMManager.Controls.MouseBehaviorExtension mouseBehaviorExtension2 = new GYMManager.Controls.MouseBehaviorExtension();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblClose = new System.Windows.Forms.Label();
            this.animatedButton1 = new GYMManager.Controls.AnimatedButton();
            this.cmdClose = new GYMManager.Controls.AnimatedButton();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(673, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(49, 23);
            this.lblClose.TabIndex = 0;
            // 
            // animatedButton1
            // 
            this.animatedButton1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.animatedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.animatedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.animatedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animatedButton1.Image = global::GYMManager.Properties.Resources.minimize_normal_pic;
            this.animatedButton1.Location = new System.Drawing.Point(676, 6);
            mouseBehaviorExtension1.HoverColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.HoverImage = global::GYMManager.Properties.Resources.minimize_hover_pic;
            mouseBehaviorExtension1.HoverText = "";
            mouseBehaviorExtension1.LeaveColor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveForecolor = System.Drawing.Color.Empty;
            mouseBehaviorExtension1.LeaveImage = global::GYMManager.Properties.Resources.minimize_normal_pic;
            mouseBehaviorExtension1.LeaveText = "";
            this.animatedButton1.MouseBehavior = mouseBehaviorExtension1;
            this.animatedButton1.Name = "animatedButton1";
            this.animatedButton1.Size = new System.Drawing.Size(23, 23);
            this.animatedButton1.TabIndex = 1;
            this.animatedButton1.UseVisualStyleBackColor = true;
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
            mouseBehaviorExtension2.HoverImage = ((System.Drawing.Image)(resources.GetObject("mouseBehaviorExtension2.HoverImage")));
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.ControlBox = false;
            this.Controls.Add(this.animatedButton1);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private Controls.AnimatedButton cmdClose;
        private Controls.AnimatedButton animatedButton1;
      

    }
}

