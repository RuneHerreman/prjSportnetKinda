namespace prjSportnetKinda.View
{
    partial class ArtikelBeheer
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
            this.btnArtikelAanpassen = new System.Windows.Forms.Button();
            this.btnArtikelToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtikelAanpassen
            // 
            this.btnArtikelAanpassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtikelAanpassen.Location = new System.Drawing.Point(154, 11);
            this.btnArtikelAanpassen.Name = "btnArtikelAanpassen";
            this.btnArtikelAanpassen.Size = new System.Drawing.Size(136, 43);
            this.btnArtikelAanpassen.TabIndex = 3;
            this.btnArtikelAanpassen.Text = "Artikel aanpassen";
            this.btnArtikelAanpassen.UseVisualStyleBackColor = true;
            this.btnArtikelAanpassen.Click += new System.EventHandler(this.btnArtikelAanpassen_Click);
            // 
            // btnArtikelToevoegen
            // 
            this.btnArtikelToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtikelToevoegen.Location = new System.Drawing.Point(12, 11);
            this.btnArtikelToevoegen.Name = "btnArtikelToevoegen";
            this.btnArtikelToevoegen.Size = new System.Drawing.Size(136, 43);
            this.btnArtikelToevoegen.TabIndex = 2;
            this.btnArtikelToevoegen.Text = "Nieuw artikel toevoegen";
            this.btnArtikelToevoegen.UseVisualStyleBackColor = true;
            this.btnArtikelToevoegen.Click += new System.EventHandler(this.btnArtikelToevoegen_Click);
            // 
            // ArtikelBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 65);
            this.Controls.Add(this.btnArtikelAanpassen);
            this.Controls.Add(this.btnArtikelToevoegen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ArtikelBeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArtikelBeheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArtikelAanpassen;
        private System.Windows.Forms.Button btnArtikelToevoegen;
    }
}