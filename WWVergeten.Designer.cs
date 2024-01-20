namespace prjSportnetKinda
{
    partial class WWVergeten
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlEmailRegister = new System.Windows.Forms.Panel();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.btnStuurMail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEmailRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-mail";
            // 
            // pnlEmailRegister
            // 
            this.pnlEmailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
            this.pnlEmailRegister.Controls.Add(this.txtEmailRegister);
            this.pnlEmailRegister.Location = new System.Drawing.Point(32, 117);
            this.pnlEmailRegister.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmailRegister.Name = "pnlEmailRegister";
            this.pnlEmailRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pnlEmailRegister.Size = new System.Drawing.Size(381, 39);
            this.pnlEmailRegister.TabIndex = 30;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailRegister.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegister.Location = new System.Drawing.Point(0, 0);
            this.txtEmailRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailRegister.MaxLength = 100;
            this.txtEmailRegister.Multiline = true;
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(381, 35);
            this.txtEmailRegister.TabIndex = 3;
            this.txtEmailRegister.WordWrap = false;
            // 
            // btnStuurMail
            // 
            this.btnStuurMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuurMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
            this.btnStuurMail.FlatAppearance.BorderSize = 2;
            this.btnStuurMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuurMail.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuurMail.Location = new System.Drawing.Point(94, 188);
            this.btnStuurMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStuurMail.Name = "btnStuurMail";
            this.btnStuurMail.Size = new System.Drawing.Size(252, 50);
            this.btnStuurMail.TabIndex = 32;
            this.btnStuurMail.Text = "Stuur e-mail";
            this.btnStuurMail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 46);
            this.label2.TabIndex = 33;
            this.label2.Text = "Wachtwoord vergeten";
            // 
            // WWVergeten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStuurMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlEmailRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WWVergeten";
            this.Text = "ZRC - Sportnet";
            this.pnlEmailRegister.ResumeLayout(false);
            this.pnlEmailRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlEmailRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Button btnStuurMail;
        private System.Windows.Forms.Label label2;
    }
}