
    partial class FrmError
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtError = new System.Windows.Forms.RichTextBox();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ups! Error Inesperado";
            // 
            // txtError
            // 
            this.txtError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtError.BackColor = System.Drawing.Color.DarkRed;
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtError.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtError.Location = new System.Drawing.Point(12, 60);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(655, 219);
            this.txtError.TabIndex = 1;
            this.txtError.Text = "";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.BackColor = System.Drawing.Color.Red;
            this.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.cmdCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCerrar.Location = new System.Drawing.Point(578, 285);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(89, 29);
            this.cmdCerrar.TabIndex = 2;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(679, 324);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtError;
        private System.Windows.Forms.Button cmdCerrar;
    }
