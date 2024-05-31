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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtikelBeheer));
            this.btnArtikelAanpassen = new System.Windows.Forms.Button();
            this.btnArtikelToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArtikelAanpassen
            // 
            this.btnArtikelAanpassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtikelAanpassen.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikelAanpassen.Location = new System.Drawing.Point(205, 14);
            this.btnArtikelAanpassen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArtikelAanpassen.Name = "btnArtikelAanpassen";
            this.btnArtikelAanpassen.Size = new System.Drawing.Size(181, 53);
            this.btnArtikelAanpassen.TabIndex = 2;
            this.btnArtikelAanpassen.Text = "Artikel aanpassen";
            this.btnArtikelAanpassen.UseVisualStyleBackColor = true;
            this.btnArtikelAanpassen.Click += new System.EventHandler(this.btnArtikelAanpassen_Click);
            // 
            // btnArtikelToevoegen
            // 
            this.btnArtikelToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtikelToevoegen.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikelToevoegen.Location = new System.Drawing.Point(16, 14);
            this.btnArtikelToevoegen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArtikelToevoegen.Name = "btnArtikelToevoegen";
            this.btnArtikelToevoegen.Size = new System.Drawing.Size(181, 53);
            this.btnArtikelToevoegen.TabIndex = 1;
            this.btnArtikelToevoegen.Text = "Nieuw artikel toevoegen";
            this.btnArtikelToevoegen.UseVisualStyleBackColor = true;
            this.btnArtikelToevoegen.Click += new System.EventHandler(this.btnArtikelToevoegen_Click);
            // 
            // ArtikelBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 80);
            this.Controls.Add(this.btnArtikelAanpassen);
            this.Controls.Add(this.btnArtikelToevoegen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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