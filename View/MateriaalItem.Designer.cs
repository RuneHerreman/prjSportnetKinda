namespace prjSportnetKinda
{
    partial class MateriaalItem
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
            this.picMateriaal = new System.Windows.Forms.PictureBox();
            this.lblMateriaalBeschrijving = new System.Windows.Forms.Label();
            this.btnHuren = new System.Windows.Forms.Button();
            this.lblMateriaalTitel = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMateriaal)).BeginInit();
            this.SuspendLayout();
            // 
            // picMateriaal
            // 
            this.picMateriaal.Image = global::prjSportnetKinda.Properties.Resources._1_DDsOx6D3oe8ZxcA_OTfIDA;
            this.picMateriaal.Location = new System.Drawing.Point(3, 3);
            this.picMateriaal.Name = "picMateriaal";
            this.picMateriaal.Size = new System.Drawing.Size(169, 168);
            this.picMateriaal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMateriaal.TabIndex = 1;
            this.picMateriaal.TabStop = false;
            // 
            // lblMateriaalBeschrijving
            // 
            this.lblMateriaalBeschrijving.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaalBeschrijving.Location = new System.Drawing.Point(3, 198);
            this.lblMateriaalBeschrijving.Name = "lblMateriaalBeschrijving";
            this.lblMateriaalBeschrijving.Size = new System.Drawing.Size(169, 83);
            this.lblMateriaalBeschrijving.TabIndex = 2;
            this.lblMateriaalBeschrijving.Text = "Naam: Skeeler\r\nEigenschappen:\r\nWiel: 100mm\r\nxµx\r\nx\r\nx";
            // 
            // btnHuren
            // 
            this.btnHuren.BackColor = System.Drawing.Color.Green;
            this.btnHuren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuren.FlatAppearance.BorderSize = 0;
            this.btnHuren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuren.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuren.ForeColor = System.Drawing.Color.White;
            this.btnHuren.Location = new System.Drawing.Point(3, 284);
            this.btnHuren.Name = "btnHuren";
            this.btnHuren.Size = new System.Drawing.Size(169, 40);
            this.btnHuren.TabIndex = 3;
            this.btnHuren.Text = "Huren";
            this.btnHuren.UseVisualStyleBackColor = false;
            this.btnHuren.Click += new System.EventHandler(this.btnHuren_Click);
            // 
            // lblMateriaalTitel
            // 
            this.lblMateriaalTitel.AutoSize = true;
            this.lblMateriaalTitel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriaalTitel.Location = new System.Drawing.Point(-1, 174);
            this.lblMateriaalTitel.Name = "lblMateriaalTitel";
            this.lblMateriaalTitel.Size = new System.Drawing.Size(110, 22);
            this.lblMateriaalTitel.TabIndex = 4;
            this.lblMateriaalTitel.Text = "Materiaaltitel";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Visible = false;
            // 
            // MateriaalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblMateriaalTitel);
            this.Controls.Add(this.btnHuren);
            this.Controls.Add(this.lblMateriaalBeschrijving);
            this.Controls.Add(this.picMateriaal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(35, 0, 0, 40);
            this.Name = "MateriaalItem";
            this.Size = new System.Drawing.Size(175, 327);
            ((System.ComponentModel.ISupportInitialize)(this.picMateriaal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMateriaal;
        private System.Windows.Forms.Label lblMateriaalBeschrijving;
        private System.Windows.Forms.Button btnHuren;
        private System.Windows.Forms.Label lblMateriaalTitel;
        private System.Windows.Forms.Label lblID;
    }
}
