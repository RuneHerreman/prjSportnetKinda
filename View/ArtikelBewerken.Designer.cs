namespace prjSportnetKinda.View
{
    partial class ArtikelBewerken
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
            this.btnArtikelVerwijderen = new System.Windows.Forms.Button();
            this.lblArtikelID = new System.Windows.Forms.Label();
            this.txtNieuweFotoLocatie = new System.Windows.Forms.TextBox();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.btnToepassen = new System.Windows.Forms.Button();
            this.picNieuweAfbeelding = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNieuweNaam = new System.Windows.Forms.TextBox();
            this.rtxtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.lsvArtikels = new System.Windows.Forms.ListView();
            this.cNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArtikelVerwijderen
            // 
            this.btnArtikelVerwijderen.Enabled = false;
            this.btnArtikelVerwijderen.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikelVerwijderen.Location = new System.Drawing.Point(458, 330);
            this.btnArtikelVerwijderen.Name = "btnArtikelVerwijderen";
            this.btnArtikelVerwijderen.Size = new System.Drawing.Size(82, 23);
            this.btnArtikelVerwijderen.TabIndex = 30;
            this.btnArtikelVerwijderen.Text = "Verwijderen";
            this.btnArtikelVerwijderen.UseVisualStyleBackColor = true;
            this.btnArtikelVerwijderen.Click += new System.EventHandler(this.btnArtikelVerwijderen_Click);
            // 
            // lblArtikelID
            // 
            this.lblArtikelID.AutoSize = true;
            this.lblArtikelID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblArtikelID.Location = new System.Drawing.Point(614, 337);
            this.lblArtikelID.Name = "lblArtikelID";
            this.lblArtikelID.Size = new System.Drawing.Size(0, 13);
            this.lblArtikelID.TabIndex = 29;
            // 
            // txtNieuweFotoLocatie
            // 
            this.txtNieuweFotoLocatie.Enabled = false;
            this.txtNieuweFotoLocatie.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNieuweFotoLocatie.Location = new System.Drawing.Point(458, 39);
            this.txtNieuweFotoLocatie.Name = "txtNieuweFotoLocatie";
            this.txtNieuweFotoLocatie.Size = new System.Drawing.Size(169, 20);
            this.txtNieuweFotoLocatie.TabIndex = 28;
            // 
            // btnBladeren
            // 
            this.btnBladeren.Enabled = false;
            this.btnBladeren.Location = new System.Drawing.Point(563, 13);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(64, 23);
            this.btnBladeren.TabIndex = 27;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // btnToepassen
            // 
            this.btnToepassen.Enabled = false;
            this.btnToepassen.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToepassen.Location = new System.Drawing.Point(234, 330);
            this.btnToepassen.Name = "btnToepassen";
            this.btnToepassen.Size = new System.Drawing.Size(82, 23);
            this.btnToepassen.TabIndex = 26;
            this.btnToepassen.Text = "Toepassen";
            this.btnToepassen.UseVisualStyleBackColor = true;
            this.btnToepassen.Click += new System.EventHandler(this.btnToepassen_Click);
            // 
            // picNieuweAfbeelding
            // 
            this.picNieuweAfbeelding.Location = new System.Drawing.Point(458, 66);
            this.picNieuweAfbeelding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNieuweAfbeelding.Name = "picNieuweAfbeelding";
            this.picNieuweAfbeelding.Size = new System.Drawing.Size(169, 169);
            this.picNieuweAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNieuweAfbeelding.TabIndex = 25;
            this.picNieuweAfbeelding.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Afbeelding:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Artikel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Titel:";
            // 
            // txtNieuweNaam
            // 
            this.txtNieuweNaam.Enabled = false;
            this.txtNieuweNaam.Location = new System.Drawing.Point(234, 36);
            this.txtNieuweNaam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNieuweNaam.Name = "txtNieuweNaam";
            this.txtNieuweNaam.Size = new System.Drawing.Size(218, 20);
            this.txtNieuweNaam.TabIndex = 19;
            // 
            // rtxtBeschrijving
            // 
            this.rtxtBeschrijving.Enabled = false;
            this.rtxtBeschrijving.Location = new System.Drawing.Point(234, 80);
            this.rtxtBeschrijving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtBeschrijving.Name = "rtxtBeschrijving";
            this.rtxtBeschrijving.Size = new System.Drawing.Size(218, 111);
            this.rtxtBeschrijving.TabIndex = 17;
            this.rtxtBeschrijving.Text = "";
            // 
            // lsvArtikels
            // 
            this.lsvArtikels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNaam});
            this.lsvArtikels.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvArtikels.FullRowSelect = true;
            this.lsvArtikels.HideSelection = false;
            this.lsvArtikels.Location = new System.Drawing.Point(12, 13);
            this.lsvArtikels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvArtikels.MultiSelect = false;
            this.lsvArtikels.Name = "lsvArtikels";
            this.lsvArtikels.Size = new System.Drawing.Size(213, 340);
            this.lsvArtikels.TabIndex = 16;
            this.lsvArtikels.UseCompatibleStateImageBehavior = false;
            this.lsvArtikels.View = System.Windows.Forms.View.Details;
            this.lsvArtikels.SelectedIndexChanged += new System.EventHandler(this.lsvMateriaal_SelectedIndexChanged);
            // 
            // cNaam
            // 
            this.cNaam.Text = "Naam";
            this.cNaam.Width = 208;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // ArtikelBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 370);
            this.Controls.Add(this.btnArtikelVerwijderen);
            this.Controls.Add(this.lblArtikelID);
            this.Controls.Add(this.txtNieuweFotoLocatie);
            this.Controls.Add(this.btnBladeren);
            this.Controls.Add(this.btnToepassen);
            this.Controls.Add(this.picNieuweAfbeelding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNieuweNaam);
            this.Controls.Add(this.rtxtBeschrijving);
            this.Controls.Add(this.lsvArtikels);
            this.Name = "ArtikelBewerken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArtikelBewerken";
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArtikelVerwijderen;
        private System.Windows.Forms.Label lblArtikelID;
        private System.Windows.Forms.TextBox txtNieuweFotoLocatie;
        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.Button btnToepassen;
        private System.Windows.Forms.PictureBox picNieuweAfbeelding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNieuweNaam;
        private System.Windows.Forms.RichTextBox rtxtBeschrijving;
        private System.Windows.Forms.ListView lsvArtikels;
        private System.Windows.Forms.ColumnHeader cNaam;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}