namespace prjSportnetKinda
{
    partial class LogboekItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAantalOfLijstMateriaal = new System.Windows.Forms.Label();
            this.picLogboekFoto = new System.Windows.Forms.PictureBox();
            this.btnKiesAantal = new System.Windows.Forms.Button();
            this.btnAllesInleveren = new System.Windows.Forms.Button();
            this.btnGebruikerLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogboekFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(143, 18);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(239, 22);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam (Materiaal of gebruiker)\r\n";
            // 
            // lblAantalOfLijstMateriaal
            // 
            this.lblAantalOfLijstMateriaal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalOfLijstMateriaal.Location = new System.Drawing.Point(144, 49);
            this.lblAantalOfLijstMateriaal.Name = "lblAantalOfLijstMateriaal";
            this.lblAantalOfLijstMateriaal.Size = new System.Drawing.Size(135, 77);
            this.lblAantalOfLijstMateriaal.TabIndex = 2;
            this.lblAantalOfLijstMateriaal.Text = "lblAantalOfLijstMateriaal";
            // 
            // picLogboekFoto
            // 
            this.picLogboekFoto.Image = global::prjSportnetKinda.Properties.Resources.Basic_Profile_Picture;
            this.picLogboekFoto.Location = new System.Drawing.Point(12, 12);
            this.picLogboekFoto.Name = "picLogboekFoto";
            this.picLogboekFoto.Size = new System.Drawing.Size(125, 125);
            this.picLogboekFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogboekFoto.TabIndex = 0;
            this.picLogboekFoto.TabStop = false;
            // 
            // btnKiesAantal
            // 
            this.btnKiesAantal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiesAantal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiesAantal.Location = new System.Drawing.Point(293, 76);
            this.btnKiesAantal.Name = "btnKiesAantal";
            this.btnKiesAantal.Size = new System.Drawing.Size(89, 23);
            this.btnKiesAantal.TabIndex = 3;
            this.btnKiesAantal.Text = "Kies Aantal";
            this.btnKiesAantal.UseVisualStyleBackColor = true;
            this.btnKiesAantal.Click += new System.EventHandler(this.btnBepaaldAantal_Click);
            // 
            // btnAllesInleveren
            // 
            this.btnAllesInleveren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllesInleveren.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllesInleveren.Location = new System.Drawing.Point(293, 49);
            this.btnAllesInleveren.Name = "btnAllesInleveren";
            this.btnAllesInleveren.Size = new System.Drawing.Size(89, 23);
            this.btnAllesInleveren.TabIndex = 4;
            this.btnAllesInleveren.Text = "Alles inleveren";
            this.btnAllesInleveren.UseVisualStyleBackColor = true;
            this.btnAllesInleveren.Click += new System.EventHandler(this.btnAllesInleveren_Click);
            // 
            // btnGebruikerLog
            // 
            this.btnGebruikerLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGebruikerLog.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGebruikerLog.Location = new System.Drawing.Point(293, 103);
            this.btnGebruikerLog.Name = "btnGebruikerLog";
            this.btnGebruikerLog.Size = new System.Drawing.Size(89, 23);
            this.btnGebruikerLog.TabIndex = 5;
            this.btnGebruikerLog.Text = "Gebruiker Log";
            this.btnGebruikerLog.UseVisualStyleBackColor = true;
            // 
            // LogboekItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGebruikerLog);
            this.Controls.Add(this.btnAllesInleveren);
            this.Controls.Add(this.btnKiesAantal);
            this.Controls.Add(this.lblAantalOfLijstMateriaal);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.picLogboekFoto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.Name = "LogboekItem";
            this.Size = new System.Drawing.Size(400, 150);
            this.Click += new System.EventHandler(this.LogboekItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picLogboekFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogboekFoto;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAantalOfLijstMateriaal;
        private System.Windows.Forms.Button btnKiesAantal;
        private System.Windows.Forms.Button btnAllesInleveren;
        private System.Windows.Forms.Button btnGebruikerLog;
    }
}
