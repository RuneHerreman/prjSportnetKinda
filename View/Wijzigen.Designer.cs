﻿namespace prjSportnetKinda.View
{
    partial class Wijzigen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wijzigen));
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.chkBeheerder = new System.Windows.Forms.CheckBox();
            this.chkTrainer = new System.Windows.Forms.CheckBox();
            this.chkRenner = new System.Windows.Forms.CheckBox();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(15, 219);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(161, 33);
            this.btnOpslaan.TabIndex = 15;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Visible = false;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(345, 219);
            this.btnVerwijderen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(253, 33);
            this.btnVerwijderen.TabIndex = 14;
            this.btnVerwijderen.Text = "Gebruiker Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Visible = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // chkBeheerder
            // 
            this.chkBeheerder.AutoSize = true;
            this.chkBeheerder.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBeheerder.Location = new System.Drawing.Point(15, 174);
            this.chkBeheerder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBeheerder.Name = "chkBeheerder";
            this.chkBeheerder.Size = new System.Drawing.Size(86, 22);
            this.chkBeheerder.TabIndex = 13;
            this.chkBeheerder.Text = "Beheerder";
            this.chkBeheerder.UseVisualStyleBackColor = true;
            this.chkBeheerder.Visible = false;
            // 
            // chkTrainer
            // 
            this.chkTrainer.AutoSize = true;
            this.chkTrainer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrainer.Location = new System.Drawing.Point(15, 144);
            this.chkTrainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrainer.Name = "chkTrainer";
            this.chkTrainer.Size = new System.Drawing.Size(69, 22);
            this.chkTrainer.TabIndex = 12;
            this.chkTrainer.Text = "Trainer";
            this.chkTrainer.UseVisualStyleBackColor = true;
            this.chkTrainer.Visible = false;
            // 
            // chkRenner
            // 
            this.chkRenner.AutoSize = true;
            this.chkRenner.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRenner.Location = new System.Drawing.Point(15, 113);
            this.chkRenner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRenner.Name = "chkRenner";
            this.chkRenner.Size = new System.Drawing.Size(67, 22);
            this.chkRenner.TabIndex = 11;
            this.chkRenner.Text = "Renner";
            this.chkRenner.UseVisualStyleBackColor = true;
            this.chkRenner.Visible = false;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoeken.Location = new System.Drawing.Point(460, 46);
            this.btnZoeken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(143, 34);
            this.btnZoeken.TabIndex = 10;
            this.btnZoeken.Text = "Zoeken";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGebruiker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGebruiker.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruiker.Location = new System.Drawing.Point(17, 46);
            this.txtGebruiker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(436, 25);
            this.txtGebruiker.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kies de gebruiker die u wilt wijzigen";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 18);
            this.lblEmail.TabIndex = 16;
            // 
            // Wijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 266);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.chkBeheerder);
            this.Controls.Add(this.chkTrainer);
            this.Controls.Add(this.chkRenner);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.txtGebruiker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Wijzigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wijzigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.CheckBox chkBeheerder;
        private System.Windows.Forms.CheckBox chkTrainer;
        private System.Windows.Forms.CheckBox chkRenner;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
    }
}