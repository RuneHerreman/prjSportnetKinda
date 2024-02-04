namespace prjSportnetKinda
{
    partial class WelkomItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelkomItem));
            this.lblArtiekelTitel = new System.Windows.Forms.Label();
            this.picArtiekelFoto = new System.Windows.Forms.PictureBox();
            this.lblArtiekelDatum = new System.Windows.Forms.Label();
            this.pnlItemFoto = new System.Windows.Forms.Panel();
            this.txtArtiekel = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiekelFoto)).BeginInit();
            this.pnlItemFoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArtiekelTitel
            // 
            this.lblArtiekelTitel.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiekelTitel.Location = new System.Drawing.Point(245, 9);
            this.lblArtiekelTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtiekelTitel.Name = "lblArtiekelTitel";
            this.lblArtiekelTitel.Size = new System.Drawing.Size(508, 86);
            this.lblArtiekelTitel.TabIndex = 0;
            this.lblArtiekelTitel.Text = "ArtiekelTitel\r\nArtiekelTitel";
            this.lblArtiekelTitel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // picArtiekelFoto
            // 
            this.picArtiekelFoto.Image = global::prjSportnetKinda.Properties.Resources.IMG_Login1;
            this.picArtiekelFoto.Location = new System.Drawing.Point(25, 50);
            this.picArtiekelFoto.Margin = new System.Windows.Forms.Padding(4);
            this.picArtiekelFoto.Name = "picArtiekelFoto";
            this.picArtiekelFoto.Size = new System.Drawing.Size(200, 250);
            this.picArtiekelFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiekelFoto.TabIndex = 3;
            this.picArtiekelFoto.TabStop = false;
            // 
            // lblArtiekelDatum
            // 
            this.lblArtiekelDatum.AutoSize = true;
            this.lblArtiekelDatum.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiekelDatum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArtiekelDatum.Location = new System.Drawing.Point(22, 304);
            this.lblArtiekelDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtiekelDatum.Name = "lblArtiekelDatum";
            this.lblArtiekelDatum.Size = new System.Drawing.Size(82, 18);
            this.lblArtiekelDatum.TabIndex = 4;
            this.lblArtiekelDatum.Text = "dd/mm/yyyy";
            // 
            // pnlItemFoto
            // 
            this.pnlItemFoto.Controls.Add(this.lblArtiekelDatum);
            this.pnlItemFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlItemFoto.Location = new System.Drawing.Point(0, 0);
            this.pnlItemFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItemFoto.Name = "pnlItemFoto";
            this.pnlItemFoto.Size = new System.Drawing.Size(250, 350);
            this.pnlItemFoto.TabIndex = 5;
            // 
            // txtArtiekel
            // 
            this.txtArtiekel.BackColor = System.Drawing.SystemColors.Control;
            this.txtArtiekel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArtiekel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtArtiekel.Location = new System.Drawing.Point(253, 97);
            this.txtArtiekel.Name = "txtArtiekel";
            this.txtArtiekel.ReadOnly = true;
            this.txtArtiekel.Size = new System.Drawing.Size(500, 225);
            this.txtArtiekel.TabIndex = 6;
            this.txtArtiekel.Text = resources.GetString("txtArtiekel.Text");
            // 
            // WelkomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtArtiekel);
            this.Controls.Add(this.picArtiekelFoto);
            this.Controls.Add(this.pnlItemFoto);
            this.Controls.Add(this.lblArtiekelTitel);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(775, 350);
            this.MinimumSize = new System.Drawing.Size(775, 350);
            this.Name = "WelkomItem";
            this.Size = new System.Drawing.Size(775, 350);
            ((System.ComponentModel.ISupportInitialize)(this.picArtiekelFoto)).EndInit();
            this.pnlItemFoto.ResumeLayout(false);
            this.pnlItemFoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlItemFoto;
        public System.Windows.Forms.Label lblArtiekelTitel;
        public System.Windows.Forms.PictureBox picArtiekelFoto;
        public System.Windows.Forms.Label lblArtiekelDatum;
        public System.Windows.Forms.RichTextBox txtArtiekel;
    }
}
