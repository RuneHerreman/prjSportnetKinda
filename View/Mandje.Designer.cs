namespace prjSportnetKinda.View
{
    partial class frmMandje
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
            this.lsvMandje = new System.Windows.Forms.ListView();
            this.cNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHurenLijst = new System.Windows.Forms.Button();
            this.btnMandjeLegen = new System.Windows.Forms.Button();
            this.btnArtikelVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMandje
            // 
            this.lsvMandje.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNaam,
            this.cAantal});
            this.lsvMandje.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMandje.FullRowSelect = true;
            this.lsvMandje.HideSelection = false;
            this.lsvMandje.Location = new System.Drawing.Point(10, 10);
            this.lsvMandje.MultiSelect = false;
            this.lsvMandje.Name = "lsvMandje";
            this.lsvMandje.Size = new System.Drawing.Size(300, 200);
            this.lsvMandje.TabIndex = 0;
            this.lsvMandje.UseCompatibleStateImageBehavior = false;
            this.lsvMandje.View = System.Windows.Forms.View.Details;
            // 
            // cNaam
            // 
            this.cNaam.Text = "Naam";
            this.cNaam.Width = 220;
            // 
            // cAantal
            // 
            this.cAantal.Text = "Aantal";
            this.cAantal.Width = 50;
            // 
            // btnHurenLijst
            // 
            this.btnHurenLijst.BackColor = System.Drawing.Color.Green;
            this.btnHurenLijst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHurenLijst.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHurenLijst.ForeColor = System.Drawing.Color.White;
            this.btnHurenLijst.Location = new System.Drawing.Point(10, 272);
            this.btnHurenLijst.Name = "btnHurenLijst";
            this.btnHurenLijst.Size = new System.Drawing.Size(300, 50);
            this.btnHurenLijst.TabIndex = 1;
            this.btnHurenLijst.Text = "Huren";
            this.btnHurenLijst.UseVisualStyleBackColor = false;
            this.btnHurenLijst.Click += new System.EventHandler(this.btnHurenLijst_Click_1);
            // 
            // btnMandjeLegen
            // 
            this.btnMandjeLegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMandjeLegen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMandjeLegen.Location = new System.Drawing.Point(165, 216);
            this.btnMandjeLegen.Name = "btnMandjeLegen";
            this.btnMandjeLegen.Size = new System.Drawing.Size(145, 50);
            this.btnMandjeLegen.TabIndex = 2;
            this.btnMandjeLegen.Text = "Mandje Legen";
            this.btnMandjeLegen.UseVisualStyleBackColor = true;
            this.btnMandjeLegen.Click += new System.EventHandler(this.btnMandjeLegen_Click);
            // 
            // btnArtikelVerwijderen
            // 
            this.btnArtikelVerwijderen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtikelVerwijderen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtikelVerwijderen.Location = new System.Drawing.Point(12, 216);
            this.btnArtikelVerwijderen.Name = "btnArtikelVerwijderen";
            this.btnArtikelVerwijderen.Size = new System.Drawing.Size(145, 50);
            this.btnArtikelVerwijderen.TabIndex = 3;
            this.btnArtikelVerwijderen.Text = "Artikel Verwijderen";
            this.btnArtikelVerwijderen.UseVisualStyleBackColor = true;
            this.btnArtikelVerwijderen.Click += new System.EventHandler(this.btnArtikelVerwijderen_Click);
            // 
            // frmMandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 331);
            this.Controls.Add(this.btnArtikelVerwijderen);
            this.Controls.Add(this.btnMandjeLegen);
            this.Controls.Add(this.btnHurenLijst);
            this.Controls.Add(this.lsvMandje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMandje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mandje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMandje;
        private System.Windows.Forms.Button btnHurenLijst;
        private System.Windows.Forms.Button btnMandjeLegen;
        private System.Windows.Forms.Button btnArtikelVerwijderen;
        private System.Windows.Forms.ColumnHeader cNaam;
        private System.Windows.Forms.ColumnHeader cAantal;
    }
}