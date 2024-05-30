namespace prjSportnetKinda.View
{
    partial class LogboekBeheer
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
            this.components = new System.ComponentModel.Container();
            this.btnAllesInleveren = new System.Windows.Forms.Button();
            this.lblLogID = new System.Windows.Forms.Label();
            this.btnKiesAantal = new System.Windows.Forms.Button();
            this.lsvLogboek = new System.Windows.Forms.ListView();
            this.cNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNiewAantal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAantalGehuurd = new System.Windows.Forms.Label();
            this.tooltipAantal = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAllesInleveren
            // 
            this.btnAllesInleveren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllesInleveren.Enabled = false;
            this.btnAllesInleveren.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllesInleveren.Location = new System.Drawing.Point(333, 238);
            this.btnAllesInleveren.Name = "btnAllesInleveren";
            this.btnAllesInleveren.Size = new System.Drawing.Size(91, 23);
            this.btnAllesInleveren.TabIndex = 3;
            this.btnAllesInleveren.Text = "Alles inleveren";
            this.btnAllesInleveren.UseVisualStyleBackColor = true;
            this.btnAllesInleveren.Click += new System.EventHandler(this.btnAllesInleveren_Click);
            // 
            // lblLogID
            // 
            this.lblLogID.AutoSize = true;
            this.lblLogID.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogID.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLogID.Location = new System.Drawing.Point(430, 242);
            this.lblLogID.Name = "lblLogID";
            this.lblLogID.Size = new System.Drawing.Size(0, 16);
            this.lblLogID.TabIndex = 41;
            // 
            // btnKiesAantal
            // 
            this.btnKiesAantal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiesAantal.Enabled = false;
            this.btnKiesAantal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiesAantal.Location = new System.Drawing.Point(236, 238);
            this.btnKiesAantal.Name = "btnKiesAantal";
            this.btnKiesAantal.Size = new System.Drawing.Size(91, 23);
            this.btnKiesAantal.TabIndex = 2;
            this.btnKiesAantal.Text = "Inleveren";
            this.btnKiesAantal.UseVisualStyleBackColor = true;
            this.btnKiesAantal.Click += new System.EventHandler(this.btnKiesAantal_Click);
            // 
            // lsvLogboek
            // 
            this.lsvLogboek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNaam,
            this.cAantal});
            this.lsvLogboek.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvLogboek.FullRowSelect = true;
            this.lsvLogboek.HideSelection = false;
            this.lsvLogboek.Location = new System.Drawing.Point(12, 13);
            this.lsvLogboek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvLogboek.MultiSelect = false;
            this.lsvLogboek.Name = "lsvLogboek";
            this.lsvLogboek.Size = new System.Drawing.Size(213, 248);
            this.lsvLogboek.TabIndex = 31;
            this.lsvLogboek.UseCompatibleStateImageBehavior = false;
            this.lsvLogboek.View = System.Windows.Forms.View.Details;
            this.lsvLogboek.SelectedIndexChanged += new System.EventHandler(this.lsvLogboek_SelectedIndexChanged);
            // 
            // cNaam
            // 
            this.cNaam.DisplayIndex = 1;
            this.cNaam.Text = "Naam";
            this.cNaam.Width = 146;
            // 
            // cAantal
            // 
            this.cAantal.DisplayIndex = 0;
            this.cAantal.Text = "Aantal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Aantal gehuurd:";
            // 
            // txtNiewAantal
            // 
            this.txtNiewAantal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNiewAantal.Location = new System.Drawing.Point(333, 54);
            this.txtNiewAantal.Name = "txtNiewAantal";
            this.txtNiewAantal.Size = new System.Drawing.Size(91, 20);
            this.txtNiewAantal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Aantal Resterend:";
            this.tooltipAantal.SetToolTip(this.label2, "Hoeveel exemplaren van het materiaal\r\nwil je overhouden?");
            // 
            // lblAantalGehuurd
            // 
            this.lblAantalGehuurd.AutoSize = true;
            this.lblAantalGehuurd.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalGehuurd.Location = new System.Drawing.Point(330, 23);
            this.lblAantalGehuurd.Name = "lblAantalGehuurd";
            this.lblAantalGehuurd.Size = new System.Drawing.Size(0, 16);
            this.lblAantalGehuurd.TabIndex = 47;
            // 
            // tooltipAantal
            // 
            this.tooltipAantal.IsBalloon = true;
            this.tooltipAantal.ShowAlways = true;
            this.tooltipAantal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LogboekBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 277);
            this.Controls.Add(this.lblAantalGehuurd);
            this.Controls.Add(this.txtNiewAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllesInleveren);
            this.Controls.Add(this.lblLogID);
            this.Controls.Add(this.btnKiesAantal);
            this.Controls.Add(this.lsvLogboek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogboekBeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogboekBeheer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllesInleveren;
        private System.Windows.Forms.Label lblLogID;
        private System.Windows.Forms.Button btnKiesAantal;
        private System.Windows.Forms.ListView lsvLogboek;
        private System.Windows.Forms.ColumnHeader cNaam;
        private System.Windows.Forms.ColumnHeader cAantal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNiewAantal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAantalGehuurd;
        private System.Windows.Forms.ToolTip tooltipAantal;
    }
}