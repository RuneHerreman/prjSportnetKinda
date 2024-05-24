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
            ((System.ComponentModel.ISupportInitialize)(this.picLogboekFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(143, 12);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(193, 18);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam (Materiaal of gebruiker)\r\n";
            // 
            // lblAantalOfLijstMateriaal
            // 
            this.lblAantalOfLijstMateriaal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalOfLijstMateriaal.Location = new System.Drawing.Point(146, 40);
            this.lblAantalOfLijstMateriaal.Name = "lblAantalOfLijstMateriaal";
            this.lblAantalOfLijstMateriaal.Size = new System.Drawing.Size(240, 97);
            this.lblAantalOfLijstMateriaal.TabIndex = 2;
            this.lblAantalOfLijstMateriaal.Text = "lblAantalOfLijstMateriaal";
            // 
            // picLogboekFoto
            // 
            this.picLogboekFoto.Location = new System.Drawing.Point(12, 12);
            this.picLogboekFoto.Name = "picLogboekFoto";
            this.picLogboekFoto.Size = new System.Drawing.Size(125, 125);
            this.picLogboekFoto.TabIndex = 0;
            this.picLogboekFoto.TabStop = false;
            // 
            // LogboekItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAantalOfLijstMateriaal);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.picLogboekFoto);
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
    }
}
