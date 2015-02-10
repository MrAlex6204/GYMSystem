﻿namespace GYMManager
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
            this.lblClose = new System.Windows.Forms.Label();
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
            // animatedButton1
            // 
            this.animatedButton1.BackColor = System.Drawing.SystemColors.Control;
            this.animatedButton1.Image = global::GYMManager.Properties.Resources.close_normal_pic;
            this.animatedButton1.Location = new System.Drawing.Point(698, 8);
            this.animatedButton1.MouseOverImage = global::GYMManager.Properties.Resources.close_hover_pic;
            this.animatedButton1.Name = "animatedButton1";
            this.animatedButton1.Size = new System.Drawing.Size(24, 23);
            this.animatedButton1.TabIndex = 1;
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
            this.Controls.Add(this.lblClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private Controls.AnimatedButton animatedButton1;


    }
}

