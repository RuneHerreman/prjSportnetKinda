namespace prjSportnetKinda.View
{
    partial class NieuwArtikel
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
            this.btnBladeren = new System.Windows.Forms.Button();
            this.txtFotoNieuw = new System.Windows.Forms.TextBox();
            this.btnArtikelOpslaan = new System.Windows.Forms.Button();
            this.txtTitelNieuw = new System.Windows.Forms.TextBox();
            this.txtArtikelNieuw = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.lblLengte = new System.Windows.Forms.Label();
            this.lblLengteArtikel = new System.Windows.Forms.Label();
            this.picNieuwArtikelPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNieuwArtikelPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBladeren
            // 
            this.btnBladeren.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBladeren.Location = new System.Drawing.Point(418, 24);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(75, 23);
            this.btnBladeren.TabIndex = 0;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            this.btnBladeren.Click += new System.EventHandler(this.btnBladeren_Click);
            // 
            // txtFotoNieuw
            // 
            this.txtFotoNieuw.Enabled = false;
            this.txtFotoNieuw.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFotoNieuw.Location = new System.Drawing.Point(12, 26);
            this.txtFotoNieuw.Name = "txtFotoNieuw";
            this.txtFotoNieuw.Size = new System.Drawing.Size(400, 20);
            this.txtFotoNieuw.TabIndex = 1;
            // 
            // btnArtikelOpslaan
            // 
            this.btnArtikelOpslaan.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikelOpslaan.Location = new System.Drawing.Point(16, 366);
            this.btnArtikelOpslaan.Name = "btnArtikelOpslaan";
            this.btnArtikelOpslaan.Size = new System.Drawing.Size(396, 23);
            this.btnArtikelOpslaan.TabIndex = 2;
            this.btnArtikelOpslaan.Text = "Opslaan";
            this.btnArtikelOpslaan.UseVisualStyleBackColor = true;
            this.btnArtikelOpslaan.Click += new System.EventHandler(this.btnArtikelOpslaan_Click);
            // 
            // txtTitelNieuw
            // 
            this.txtTitelNieuw.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitelNieuw.Location = new System.Drawing.Point(12, 68);
            this.txtTitelNieuw.MaxLength = 44;
            this.txtTitelNieuw.Name = "txtTitelNieuw";
            this.txtTitelNieuw.Size = new System.Drawing.Size(400, 20);
            this.txtTitelNieuw.TabIndex = 3;
            this.txtTitelNieuw.TextChanged += new System.EventHandler(this.txtTitelNieuw_TextChanged);
            // 
            // txtArtikelNieuw
            // 
            this.txtArtikelNieuw.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtikelNieuw.Location = new System.Drawing.Point(12, 110);
            this.txtArtikelNieuw.MaxLength = 50000;
            this.txtArtikelNieuw.Name = "txtArtikelNieuw";
            this.txtArtikelNieuw.Size = new System.Drawing.Size(400, 250);
            this.txtArtikelNieuw.TabIndex = 4;
            this.txtArtikelNieuw.Text = "";
            this.txtArtikelNieuw.TextChanged += new System.EventHandler(this.txtArtikelNieuw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artikel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Afbeelding (4:5 of 200x250 aanbevolen)";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // lblLengte
            // 
            this.lblLengte.AutoSize = true;
            this.lblLengte.BackColor = System.Drawing.Color.Transparent;
            this.lblLengte.Location = new System.Drawing.Point(377, 71);
            this.lblLengte.Name = "lblLengte";
            this.lblLengte.Size = new System.Drawing.Size(0, 13);
            this.lblLengte.TabIndex = 8;
            // 
            // lblLengteArtikel
            // 
            this.lblLengteArtikel.AutoSize = true;
            this.lblLengteArtikel.BackColor = System.Drawing.Color.Transparent;
            this.lblLengteArtikel.Location = new System.Drawing.Point(377, 94);
            this.lblLengteArtikel.Name = "lblLengteArtikel";
            this.lblLengteArtikel.Size = new System.Drawing.Size(0, 13);
            this.lblLengteArtikel.TabIndex = 9;
            // 
            // picNieuwArtikelPreview
            // 
            this.picNieuwArtikelPreview.Location = new System.Drawing.Point(418, 110);
            this.picNieuwArtikelPreview.Name = "picNieuwArtikelPreview";
            this.picNieuwArtikelPreview.Size = new System.Drawing.Size(200, 250);
            this.picNieuwArtikelPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNieuwArtikelPreview.TabIndex = 10;
            this.picNieuwArtikelPreview.TabStop = false;
            // 
            // NieuwArtikel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 395);
            this.Controls.Add(this.picNieuwArtikelPreview);
            this.Controls.Add(this.lblLengteArtikel);
            this.Controls.Add(this.lblLengte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtikelNieuw);
            this.Controls.Add(this.txtTitelNieuw);
            this.Controls.Add(this.btnArtikelOpslaan);
            this.Controls.Add(this.txtFotoNieuw);
            this.Controls.Add(this.btnBladeren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NieuwArtikel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NieuwArtikel";
            ((System.ComponentModel.ISupportInitialize)(this.picNieuwArtikelPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.TextBox txtFotoNieuw;
        private System.Windows.Forms.Button btnArtikelOpslaan;
        private System.Windows.Forms.TextBox txtTitelNieuw;
        private System.Windows.Forms.RichTextBox txtArtikelNieuw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lblLengte;
        private System.Windows.Forms.Label lblLengteArtikel;
        private System.Windows.Forms.PictureBox picNieuwArtikelPreview;
    }
}