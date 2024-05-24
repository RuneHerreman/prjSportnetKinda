namespace prjSportnetKinda.View
{
    partial class ActiviteitToevoegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTraining = new System.Windows.Forms.RadioButton();
            this.rdbWedstrijd = new System.Windows.Forms.RadioButton();
            this.rdbFeest = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblDuur = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.btnDeelnemen = new System.Windows.Forms.Button();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activiteit toevoegen:";
            // 
            // rdbTraining
            // 
            this.rdbTraining.AutoSize = true;
            this.rdbTraining.Checked = true;
            this.rdbTraining.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraining.Location = new System.Drawing.Point(24, 23);
            this.rdbTraining.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTraining.Name = "rdbTraining";
            this.rdbTraining.Size = new System.Drawing.Size(94, 28);
            this.rdbTraining.TabIndex = 1;
            this.rdbTraining.TabStop = true;
            this.rdbTraining.Text = "Training";
            this.rdbTraining.UseVisualStyleBackColor = true;
            this.rdbTraining.CheckedChanged += new System.EventHandler(this.rdbTraining_CheckedChanged);
            // 
            // rdbWedstrijd
            // 
            this.rdbWedstrijd.AutoSize = true;
            this.rdbWedstrijd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWedstrijd.Location = new System.Drawing.Point(24, 64);
            this.rdbWedstrijd.Margin = new System.Windows.Forms.Padding(4);
            this.rdbWedstrijd.Name = "rdbWedstrijd";
            this.rdbWedstrijd.Size = new System.Drawing.Size(110, 28);
            this.rdbWedstrijd.TabIndex = 2;
            this.rdbWedstrijd.TabStop = true;
            this.rdbWedstrijd.Text = "Wedstrijd";
            this.rdbWedstrijd.UseVisualStyleBackColor = true;
            this.rdbWedstrijd.CheckedChanged += new System.EventHandler(this.rdbWedstrijd_CheckedChanged);
            // 
            // rdbFeest
            // 
            this.rdbFeest.AutoSize = true;
            this.rdbFeest.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeest.Location = new System.Drawing.Point(24, 105);
            this.rdbFeest.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFeest.Name = "rdbFeest";
            this.rdbFeest.Size = new System.Drawing.Size(74, 28);
            this.rdbFeest.TabIndex = 3;
            this.rdbFeest.TabStop = true;
            this.rdbFeest.Text = "Feest";
            this.rdbFeest.UseVisualStyleBackColor = true;
            this.rdbFeest.CheckedChanged += new System.EventHandler(this.rdbFeest_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTraining);
            this.groupBox1.Controls.Add(this.rdbWedstrijd);
            this.groupBox1.Controls.Add(this.rdbFeest);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(29, 223);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(134, 16);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum: (dd/mm/yyyy)";
            this.lblDatum.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(29, 254);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(104, 16);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start: (hh:mm:ss)";
            this.lblStart.Visible = false;
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(29, 285);
            this.lblLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(54, 16);
            this.lblLocatie.TabIndex = 7;
            this.lblLocatie.Text = "Locatie:";
            this.lblLocatie.Visible = false;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Location = new System.Drawing.Point(29, 313);
            this.lblDuur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(70, 16);
            this.lblDuur.TabIndex = 8;
            this.lblDuur.Text = "Duur: (min)";
            this.lblDuur.Visible = false;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(29, 342);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(38, 16);
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "Info1:";
            this.lblInfo1.Visible = false;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(29, 370);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(38, 16);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "Info2:";
            this.lblInfo2.Visible = false;
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(29, 401);
            this.lblInfo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(38, 16);
            this.lblInfo3.TabIndex = 11;
            this.lblInfo3.Text = "Info3:";
            this.lblInfo3.Visible = false;
            // 
            // btnDeelnemen
            // 
            this.btnDeelnemen.BackColor = System.Drawing.Color.Green;
            this.btnDeelnemen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeelnemen.FlatAppearance.BorderSize = 0;
            this.btnDeelnemen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnDeelnemen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDeelnemen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeelnemen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeelnemen.ForeColor = System.Drawing.Color.White;
            this.btnDeelnemen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeelnemen.Location = new System.Drawing.Point(32, 443);
            this.btnDeelnemen.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeelnemen.Name = "btnDeelnemen";
            this.btnDeelnemen.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDeelnemen.Size = new System.Drawing.Size(254, 47);
            this.btnDeelnemen.TabIndex = 12;
            this.btnDeelnemen.Text = "Activiteit Toevoegen";
            this.btnDeelnemen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeelnemen.UseVisualStyleBackColor = false;
            this.btnDeelnemen.Click += new System.EventHandler(this.btnDeelnemen_Click);
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(169, 339);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(265, 22);
            this.txtInfo1.TabIndex = 13;
            this.txtInfo1.Visible = false;
            // 
            // txtDuur
            // 
            this.txtDuur.Location = new System.Drawing.Point(169, 310);
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(265, 22);
            this.txtDuur.TabIndex = 14;
            this.txtDuur.Visible = false;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(169, 220);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 22);
            this.txtDatum.TabIndex = 15;
            this.txtDatum.Visible = false;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(169, 251);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(265, 22);
            this.txtStart.TabIndex = 16;
            this.txtStart.Visible = false;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(169, 282);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(265, 22);
            this.txtLocatie.TabIndex = 17;
            this.txtLocatie.Visible = false;
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(169, 367);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(265, 22);
            this.txtInfo2.TabIndex = 18;
            this.txtInfo2.Visible = false;
            // 
            // txtInfo3
            // 
            this.txtInfo3.Location = new System.Drawing.Point(169, 398);
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(265, 22);
            this.txtInfo3.TabIndex = 19;
            this.txtInfo3.Visible = false;
            // 
            // ActiviteitToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 503);
            this.Controls.Add(this.txtInfo3);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.btnDeelnemen);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActiviteitToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ActiviteitToevoegen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTraining;
        private System.Windows.Forms.RadioButton rdbWedstrijd;
        private System.Windows.Forms.RadioButton rdbFeest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblDuur;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Button btnDeelnemen;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.TextBox txtInfo3;
    }
}