namespace prjSportnetKinda.View
{
    partial class NieuwMateriaal
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
            this.lblLengteArtikel = new System.Windows.Forms.Label();
            this.lblLengte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBeschrijvingNieuw = new System.Windows.Forms.RichTextBox();
            this.txtNaamNieuw = new System.Windows.Forms.TextBox();
            this.btnMateriaalOpslaan = new System.Windows.Forms.Button();
            this.txtFotoNieuw = new System.Windows.Forms.TextBox();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.picNieuwMateriaalPreview = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVoorraad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNieuwMateriaalPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLengteArtikel
            // 
            this.lblLengteArtikel.AutoSize = true;
            this.lblLengteArtikel.BackColor = System.Drawing.Color.Transparent;
            this.lblLengteArtikel.Location = new System.Drawing.Point(377, 92);
            this.lblLengteArtikel.Name = "lblLengteArtikel";
            this.lblLengteArtikel.Size = new System.Drawing.Size(0, 13);
            this.lblLengteArtikel.TabIndex = 20;
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.BackColor = System.Drawing.Color.Transparent;
            this.lblLengte.Location = new System.Drawing.Point(377, 69);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(0, 13);
            this.lblLengte.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Afbeelding (1:1 of 170x170 aanbevolen)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Beschrijving";
            // 
            // txtBeschrijvingNieuw
            // 
            this.txtBeschrijvingNieuw.Location = new System.Drawing.Point(12, 108);
            this.txtBeschrijvingNieuw.MaxLength = 1000;
            this.txtBeschrijvingNieuw.Name = "txtBeschrijvingNieuw";
            this.txtBeschrijvingNieuw.Size = new System.Drawing.Size(400, 208);
            this.txtBeschrijvingNieuw.TabIndex = 15;
            this.txtBeschrijvingNieuw.Text = "";
            this.txtBeschrijvingNieuw.TextChanged += new System.EventHandler(this.txtBeschrijvingNieuw_TextChanged);
            // 
            // txtNaamNieuw
            // 
            this.txtNaamNieuw.Location = new System.Drawing.Point(12, 66);
            this.txtNaamNieuw.MaxLength = 15;
            this.txtNaamNieuw.Name = "txtNaamNieuw";
            this.txtNaamNieuw.Size = new System.Drawing.Size(400, 20);
            this.txtNaamNieuw.TabIndex = 14;
            this.txtNaamNieuw.TextChanged += new System.EventHandler(this.txtTitelNieuw_TextChanged);
            // 
            // btnMateriaalOpslaan
            // 
            this.btnMateriaalOpslaan.Location = new System.Drawing.Point(16, 364);
            this.btnMateriaalOpslaan.Name = "btnMateriaalOpslaan";
            this.btnMateriaalOpslaan.Size = new System.Drawing.Size(396, 23);
            this.btnMateriaalOpslaan.TabIndex = 13;
            this.btnMateriaalOpslaan.Text = "Opslaan";
            this.btnMateriaalOpslaan.UseVisualStyleBackColor = true;
            this.btnMateriaalOpslaan.Click += new System.EventHandler(this.btnMateriaalOpslaan_Click);
            // 
            // txtFotoNieuw
            // 
            this.txtFotoNieuw.Enabled = false;
            this.txtFotoNieuw.Location = new System.Drawing.Point(12, 24);
            this.txtFotoNieuw.Name = "txtFotoNieuw";
            this.txtFotoNieuw.Size = new System.Drawing.Size(400, 20);
            this.txtFotoNieuw.TabIndex = 12;
            // 
            // btnBladeren
            // 
            this.btnBladeren.Location = new System.Drawing.Point(418, 22);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(75, 23);
            this.btnBladeren.TabIndex = 11;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // picNieuwMateriaalPreview
            // 
            this.picNieuwMateriaalPreview.Location = new System.Drawing.Point(418, 108);
            this.picNieuwMateriaalPreview.Name = "picNieuwMateriaalPreview";
            this.picNieuwMateriaalPreview.Size = new System.Drawing.Size(200, 250);
            this.picNieuwMateriaalPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNieuwMateriaalPreview.TabIndex = 21;
            this.picNieuwMateriaalPreview.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Voorraad:";
            // 
            // txtVoorraad
            // 
            this.txtVoorraad.Location = new System.Drawing.Point(12, 338);
            this.txtVoorraad.MaxLength = 15;
            this.txtVoorraad.Name = "txtVoorraad";
            this.txtVoorraad.Size = new System.Drawing.Size(400, 20);
            this.txtVoorraad.TabIndex = 22;
            // 
            // NieuwMateriaal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVoorraad);
            this.Controls.Add(this.picNieuwMateriaalPreview);
            this.Controls.Add(this.lblLengteArtikel);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeschrijvingNieuw);
            this.Controls.Add(this.txtNaamNieuw);
            this.Controls.Add(this.btnMateriaalOpslaan);
            this.Controls.Add(this.txtFotoNieuw);
            this.Controls.Add(this.btnBladeren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NieuwMateriaal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nieuw materiaal";
            ((System.ComponentModel.ISupportInitialize)(this.picNieuwMateriaalPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNieuwMateriaalPreview;
        private System.Windows.Forms.Label lblLengteArtikel;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtBeschrijvingNieuw;
        private System.Windows.Forms.TextBox txtNaamNieuw;
        private System.Windows.Forms.Button btnMateriaalOpslaan;
        private System.Windows.Forms.TextBox txtFotoNieuw;
        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVoorraad;
    }
}