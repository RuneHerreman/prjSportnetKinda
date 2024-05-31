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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiviteitToevoegen));
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtDuur = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.txtInfo3 = new System.Windows.Forms.TextBox();
            this.chkEten = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activiteit toevoegen:";
            // 
            // rdbTraining
            // 
            this.rdbTraining.AutoSize = true;
            this.rdbTraining.Checked = true;
            this.rdbTraining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTraining.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraining.Location = new System.Drawing.Point(12, 23);
            this.rdbTraining.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTraining.Name = "rdbTraining";
            this.rdbTraining.Size = new System.Drawing.Size(74, 22);
            this.rdbTraining.TabIndex = 1;
            this.rdbTraining.TabStop = true;
            this.rdbTraining.Text = "Training";
            this.rdbTraining.UseVisualStyleBackColor = true;
            this.rdbTraining.CheckedChanged += new System.EventHandler(this.rdbTraining_CheckedChanged);
            // 
            // rdbWedstrijd
            // 
            this.rdbWedstrijd.AutoSize = true;
            this.rdbWedstrijd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbWedstrijd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWedstrijd.Location = new System.Drawing.Point(12, 58);
            this.rdbWedstrijd.Margin = new System.Windows.Forms.Padding(4);
            this.rdbWedstrijd.Name = "rdbWedstrijd";
            this.rdbWedstrijd.Size = new System.Drawing.Size(83, 22);
            this.rdbWedstrijd.TabIndex = 2;
            this.rdbWedstrijd.TabStop = true;
            this.rdbWedstrijd.Text = "Wedstrijd";
            this.rdbWedstrijd.UseVisualStyleBackColor = true;
            this.rdbWedstrijd.CheckedChanged += new System.EventHandler(this.rdbWedstrijd_CheckedChanged);
            // 
            // rdbFeest
            // 
            this.rdbFeest.AutoSize = true;
            this.rdbFeest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFeest.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeest.Location = new System.Drawing.Point(12, 92);
            this.rdbFeest.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFeest.Name = "rdbFeest";
            this.rdbFeest.Size = new System.Drawing.Size(58, 22);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(147, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(20, 188);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(118, 16);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum: (dd/mm/yyyy)";
            this.lblDatum.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(20, 219);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(94, 16);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start: (hh:mm:ss)";
            this.lblStart.Visible = false;
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocatie.Location = new System.Drawing.Point(20, 251);
            this.lblLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(49, 16);
            this.lblLocatie.TabIndex = 7;
            this.lblLocatie.Text = "Locatie:";
            this.lblLocatie.Visible = false;
            // 
            // lblDuur
            // 
            this.lblDuur.AutoSize = true;
            this.lblDuur.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuur.Location = new System.Drawing.Point(20, 278);
            this.lblDuur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuur.Name = "lblDuur";
            this.lblDuur.Size = new System.Drawing.Size(63, 16);
            this.lblDuur.TabIndex = 8;
            this.lblDuur.Text = "Duur: (min)";
            this.lblDuur.Visible = false;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(20, 308);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(37, 16);
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "Info1:";
            this.lblInfo1.Visible = false;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(20, 336);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(37, 16);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "Info2:";
            this.lblInfo2.Visible = false;
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.Location = new System.Drawing.Point(20, 367);
            this.lblInfo3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(37, 16);
            this.lblInfo3.TabIndex = 11;
            this.lblInfo3.Text = "Info3:";
            this.lblInfo3.Visible = false;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.Green;
            this.btnToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToevoegen.FlatAppearance.BorderSize = 0;
            this.btnToevoegen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnToevoegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToevoegen.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.ForeColor = System.Drawing.Color.White;
            this.btnToevoegen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnToevoegen.Location = new System.Drawing.Point(21, 412);
            this.btnToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnToevoegen.Size = new System.Drawing.Size(253, 47);
            this.btnToevoegen.TabIndex = 11;
            this.btnToevoegen.Text = "Activiteit toevoegen";
            this.btnToevoegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnDeelnemen_Click);
            // 
            // txtInfo1
            // 
            this.txtInfo1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo1.Location = new System.Drawing.Point(184, 306);
            this.txtInfo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(265, 20);
            this.txtInfo1.TabIndex = 8;
            this.txtInfo1.Visible = false;
            // 
            // txtDuur
            // 
            this.txtDuur.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuur.Location = new System.Drawing.Point(184, 278);
            this.txtDuur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuur.Name = "txtDuur";
            this.txtDuur.Size = new System.Drawing.Size(265, 20);
            this.txtDuur.TabIndex = 7;
            this.txtDuur.Visible = false;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(184, 186);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 20);
            this.txtDatum.TabIndex = 4;
            this.txtDatum.Visible = false;
            // 
            // txtStart
            // 
            this.txtStart.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStart.Location = new System.Drawing.Point(184, 217);
            this.txtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(265, 20);
            this.txtStart.TabIndex = 5;
            this.txtStart.Visible = false;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocatie.Location = new System.Drawing.Point(184, 249);
            this.txtLocatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(265, 20);
            this.txtLocatie.TabIndex = 6;
            this.txtLocatie.Visible = false;
            // 
            // txtInfo2
            // 
            this.txtInfo2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo2.Location = new System.Drawing.Point(184, 335);
            this.txtInfo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(265, 20);
            this.txtInfo2.TabIndex = 9;
            this.txtInfo2.Visible = false;
            // 
            // txtInfo3
            // 
            this.txtInfo3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo3.Location = new System.Drawing.Point(184, 366);
            this.txtInfo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo3.Name = "txtInfo3";
            this.txtInfo3.Size = new System.Drawing.Size(265, 20);
            this.txtInfo3.TabIndex = 10;
            this.txtInfo3.Visible = false;
            // 
            // chkEten
            // 
            this.chkEten.AutoSize = true;
            this.chkEten.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEten.Location = new System.Drawing.Point(184, 335);
            this.chkEten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEten.Name = "chkEten";
            this.chkEten.Size = new System.Drawing.Size(102, 20);
            this.chkEten.TabIndex = 9;
            this.chkEten.Text = "Eten Aanwezig?";
            this.chkEten.UseVisualStyleBackColor = true;
            this.chkEten.Visible = false;
            // 
            // ActiviteitToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 470);
            this.Controls.Add(this.chkEten);
            this.Controls.Add(this.txtInfo3);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.txtLocatie);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtDuur);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblDuur);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtDuur;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.TextBox txtInfo3;
        private System.Windows.Forms.CheckBox chkEten;
    }
}