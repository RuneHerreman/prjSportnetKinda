namespace prjSportnetKinda.View
{
    partial class MateriaalBewerken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaalBewerken));
            this.lsvMateriaal = new System.Windows.Forms.ListView();
            this.cNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtxtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.txtNieuweNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToepassen = new System.Windows.Forms.Button();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.txtNieuweFotoLocatie = new System.Windows.Forms.TextBox();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblMateriaalID = new System.Windows.Forms.Label();
            this.picNieuweAfbeelding = new System.Windows.Forms.PictureBox();
            this.btnMateriaalVerwijderen = new System.Windows.Forms.Button();
            this.txtNieuweVoorraad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.Label();
            this.lblLengteBeschrijving = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMateriaal
            // 
            this.lsvMateriaal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNaam});
            this.lsvMateriaal.FullRowSelect = true;
            this.lsvMateriaal.HideSelection = false;
            this.lsvMateriaal.Location = new System.Drawing.Point(12, 15);
            this.lsvMateriaal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvMateriaal.MultiSelect = false;
            this.lsvMateriaal.Name = "lsvMateriaal";
            this.lsvMateriaal.Size = new System.Drawing.Size(213, 340);
            this.lsvMateriaal.TabIndex = 0;
            this.lsvMateriaal.UseCompatibleStateImageBehavior = false;
            this.lsvMateriaal.View = System.Windows.Forms.View.Details;
            this.lsvMateriaal.SelectedIndexChanged += new System.EventHandler(this.lsvMateriaal_SelectedIndexChanged);
            // 
            // cNaam
            // 
            this.cNaam.Text = "Naam";
            this.cNaam.Width = 208;
            // 
            // rtxtBeschrijving
            // 
            this.rtxtBeschrijving.Enabled = false;
            this.rtxtBeschrijving.Location = new System.Drawing.Point(234, 82);
            this.rtxtBeschrijving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtBeschrijving.MaxLength = 1000;
            this.rtxtBeschrijving.Name = "rtxtBeschrijving";
            this.rtxtBeschrijving.Size = new System.Drawing.Size(218, 111);
            this.rtxtBeschrijving.TabIndex = 1;
            this.rtxtBeschrijving.Text = "";
            this.rtxtBeschrijving.TextChanged += new System.EventHandler(this.rtxtBeschrijving_TextChanged);
            // 
            // txtNieuweNaam
            // 
            this.txtNieuweNaam.Enabled = false;
            this.txtNieuweNaam.Location = new System.Drawing.Point(234, 38);
            this.txtNieuweNaam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNieuweNaam.MaxLength = 20;
            this.txtNieuweNaam.Name = "txtNieuweNaam";
            this.txtNieuweNaam.Size = new System.Drawing.Size(218, 20);
            this.txtNieuweNaam.TabIndex = 4;
            this.txtNieuweNaam.TextChanged += new System.EventHandler(this.txtNieuweNaam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Beschrijving:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Afbeelding:";
            // 
            // btnToepassen
            // 
            this.btnToepassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToepassen.Enabled = false;
            this.btnToepassen.Location = new System.Drawing.Point(234, 332);
            this.btnToepassen.Name = "btnToepassen";
            this.btnToepassen.Size = new System.Drawing.Size(82, 23);
            this.btnToepassen.TabIndex = 11;
            this.btnToepassen.Text = "Toepassen";
            this.btnToepassen.UseVisualStyleBackColor = true;
            this.btnToepassen.Click += new System.EventHandler(this.btnToepassen_Click);
            // 
            // btnBladeren
            // 
            this.btnBladeren.Enabled = false;
            this.btnBladeren.Location = new System.Drawing.Point(563, 15);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(64, 23);
            this.btnBladeren.TabIndex = 12;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // txtNieuweFotoLocatie
            // 
            this.txtNieuweFotoLocatie.Enabled = false;
            this.txtNieuweFotoLocatie.Location = new System.Drawing.Point(458, 41);
            this.txtNieuweFotoLocatie.Name = "txtNieuweFotoLocatie";
            this.txtNieuweFotoLocatie.Size = new System.Drawing.Size(169, 20);
            this.txtNieuweFotoLocatie.TabIndex = 13;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // lblMateriaalID
            // 
            this.lblMateriaalID.AutoSize = true;
            this.lblMateriaalID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMateriaalID.Location = new System.Drawing.Point(614, 339);
            this.lblMateriaalID.Name = "lblMateriaalID";
            this.lblMateriaalID.Size = new System.Drawing.Size(13, 16);
            this.lblMateriaalID.TabIndex = 14;
            this.lblMateriaalID.Text = "8";
            // 
            // picNieuweAfbeelding
            // 
            this.picNieuweAfbeelding.Location = new System.Drawing.Point(458, 68);
            this.picNieuweAfbeelding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNieuweAfbeelding.Name = "picNieuweAfbeelding";
            this.picNieuweAfbeelding.Size = new System.Drawing.Size(169, 169);
            this.picNieuweAfbeelding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNieuweAfbeelding.TabIndex = 10;
            this.picNieuweAfbeelding.TabStop = false;
            // 
            // btnMateriaalVerwijderen
            // 
            this.btnMateriaalVerwijderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriaalVerwijderen.Enabled = false;
            this.btnMateriaalVerwijderen.Location = new System.Drawing.Point(458, 332);
            this.btnMateriaalVerwijderen.Name = "btnMateriaalVerwijderen";
            this.btnMateriaalVerwijderen.Size = new System.Drawing.Size(82, 23);
            this.btnMateriaalVerwijderen.TabIndex = 15;
            this.btnMateriaalVerwijderen.Text = "Verwijderen";
            this.btnMateriaalVerwijderen.UseVisualStyleBackColor = true;
            this.btnMateriaalVerwijderen.Click += new System.EventHandler(this.btnMateriaalVerwijderen_Click);
            // 
            // txtNieuweVoorraad
            // 
            this.txtNieuweVoorraad.Enabled = false;
            this.txtNieuweVoorraad.Location = new System.Drawing.Point(234, 217);
            this.txtNieuweVoorraad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNieuweVoorraad.Name = "txtNieuweVoorraad";
            this.txtNieuweVoorraad.Size = new System.Drawing.Size(82, 20);
            this.txtNieuweVoorraad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Voorraad:";
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.BackColor = System.Drawing.Color.Transparent;
            this.lblLengte.Location = new System.Drawing.Point(421, 40);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(0, 16);
            this.lblLengte.TabIndex = 20;
            // 
            // lblLengteBeschrijving
            // 
            this.lblLengteBeschrijving.AutoSize = true;
            this.lblLengteBeschrijving.BackColor = System.Drawing.Color.Transparent;
            this.lblLengteBeschrijving.Location = new System.Drawing.Point(395, 63);
            this.lblLengteBeschrijving.Name = "lblLengteBeschrijving";
            this.lblLengteBeschrijving.Size = new System.Drawing.Size(0, 16);
            this.lblLengteBeschrijving.TabIndex = 21;
            // 
            // MateriaalBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 370);
            this.Controls.Add(this.lblLengteBeschrijving);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.btnMateriaalVerwijderen);
            this.Controls.Add(this.lblMateriaalID);
            this.Controls.Add(this.txtNieuweFotoLocatie);
            this.Controls.Add(this.btnBladeren);
            this.Controls.Add(this.btnToepassen);
            this.Controls.Add(this.picNieuweAfbeelding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNieuweNaam);
            this.Controls.Add(this.txtNieuweVoorraad);
            this.Controls.Add(this.rtxtBeschrijving);
            this.Controls.Add(this.lsvMateriaal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MateriaalBewerken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MateriaalBewerken";
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMateriaal;
        private System.Windows.Forms.RichTextBox rtxtBeschrijving;
        private System.Windows.Forms.TextBox txtNieuweNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picNieuweAfbeelding;
        private System.Windows.Forms.Button btnToepassen;
        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.TextBox txtNieuweFotoLocatie;
        private System.Windows.Forms.ColumnHeader cNaam;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lblMateriaalID;
        private System.Windows.Forms.Button btnMateriaalVerwijderen;
        private System.Windows.Forms.TextBox txtNieuweVoorraad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label lblLengteBeschrijving;
    }
}