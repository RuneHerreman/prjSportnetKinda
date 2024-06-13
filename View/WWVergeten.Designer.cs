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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WWVergeten));
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
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-mail";
            // 
            // pnlEmailRegister
            // 
            this.pnlEmailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
            this.pnlEmailRegister.Controls.Add(this.txtEmailRegister);
            this.pnlEmailRegister.Location = new System.Drawing.Point(16, 59);
            this.pnlEmailRegister.Name = "pnlEmailRegister";
            this.pnlEmailRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlEmailRegister.Size = new System.Drawing.Size(286, 32);
            this.pnlEmailRegister.TabIndex = 30;
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailRegister.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegister.Location = new System.Drawing.Point(0, 0);
            this.txtEmailRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailRegister.MaxLength = 100;
            this.txtEmailRegister.Multiline = true;
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(286, 30);
            this.txtEmailRegister.TabIndex = 3;
            this.txtEmailRegister.WordWrap = false;
            // 
            // btnStuurMail
            // 
            this.btnStuurMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStuurMail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(48)))), ((int)(((byte)(81)))));
            this.btnStuurMail.FlatAppearance.BorderSize = 2;
            this.btnStuurMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStuurMail.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuurMail.Location = new System.Drawing.Point(79, 104);
            this.btnStuurMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStuurMail.Name = "btnStuurMail";
            this.btnStuurMail.Size = new System.Drawing.Size(157, 40);
            this.btnStuurMail.TabIndex = 32;
            this.btnStuurMail.Text = "Stuur e-mail";
            this.btnStuurMail.UseVisualStyleBackColor = true;
            this.btnStuurMail.Click += new System.EventHandler(this.btnStuurMail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Wachtwoord vergeten";
            // 
            // WWVergeten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStuurMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlEmailRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WWVergeten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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