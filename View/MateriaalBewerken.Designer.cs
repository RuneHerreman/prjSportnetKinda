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
            this.lsvMateriaal = new System.Windows.Forms.ListView();
            this.rtxtBeschrijving = new System.Windows.Forms.RichTextBox();
            this.txtNieuweVoorraad = new System.Windows.Forms.TextBox();
            this.txtNieuweNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picNieuweAfbeelding = new System.Windows.Forms.PictureBox();
            this.btnToepassen = new System.Windows.Forms.Button();
            this.btnBladeren = new System.Windows.Forms.Button();
            this.txtNieuweFotoLocatie = new System.Windows.Forms.TextBox();
            this.cNaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMateriaal
            // 
            this.lsvMateriaal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNaam});
            this.lsvMateriaal.HideSelection = false;
            this.lsvMateriaal.Location = new System.Drawing.Point(12, 15);
            this.lsvMateriaal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvMateriaal.Name = "lsvMateriaal";
            this.lsvMateriaal.Size = new System.Drawing.Size(149, 340);
            this.lsvMateriaal.TabIndex = 0;
            this.lsvMateriaal.UseCompatibleStateImageBehavior = false;
            this.lsvMateriaal.View = System.Windows.Forms.View.Details;
            // 
            // rtxtBeschrijving
            // 
            this.rtxtBeschrijving.Location = new System.Drawing.Point(179, 82);
            this.rtxtBeschrijving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtBeschrijving.Name = "rtxtBeschrijving";
            this.rtxtBeschrijving.Size = new System.Drawing.Size(218, 111);
            this.rtxtBeschrijving.TabIndex = 1;
            this.rtxtBeschrijving.Text = "";
            // 
            // txtNieuweVoorraad
            // 
            this.txtNieuweVoorraad.Location = new System.Drawing.Point(179, 217);
            this.txtNieuweVoorraad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNieuweVoorraad.Name = "txtNieuweVoorraad";
            this.txtNieuweVoorraad.Size = new System.Drawing.Size(59, 20);
            this.txtNieuweVoorraad.TabIndex = 3;
            // 
            // txtNieuweNaam
            // 
            this.txtNieuweNaam.Location = new System.Drawing.Point(179, 38);
            this.txtNieuweNaam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNieuweNaam.Name = "txtNieuweNaam";
            this.txtNieuweNaam.Size = new System.Drawing.Size(218, 20);
            this.txtNieuweNaam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Beschrijving:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Voorraad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Afbeelding:";
            // 
            // picNieuweAfbeelding
            // 
            this.picNieuweAfbeelding.Location = new System.Drawing.Point(403, 38);
            this.picNieuweAfbeelding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNieuweAfbeelding.Name = "picNieuweAfbeelding";
            this.picNieuweAfbeelding.Size = new System.Drawing.Size(200, 200);
            this.picNieuweAfbeelding.TabIndex = 10;
            this.picNieuweAfbeelding.TabStop = false;
            // 
            // btnToepassen
            // 
            this.btnToepassen.Location = new System.Drawing.Point(179, 332);
            this.btnToepassen.Name = "btnToepassen";
            this.btnToepassen.Size = new System.Drawing.Size(82, 23);
            this.btnToepassen.TabIndex = 11;
            this.btnToepassen.Text = "Toepassen";
            this.btnToepassen.UseVisualStyleBackColor = true;
            // 
            // btnBladeren
            // 
            this.btnBladeren.Location = new System.Drawing.Point(403, 245);
            this.btnBladeren.Name = "btnBladeren";
            this.btnBladeren.Size = new System.Drawing.Size(59, 23);
            this.btnBladeren.TabIndex = 12;
            this.btnBladeren.Text = "Bladeren";
            this.btnBladeren.UseVisualStyleBackColor = true;
            // 
            // txtNieuweFotoLocatie
            // 
            this.txtNieuweFotoLocatie.Location = new System.Drawing.Point(468, 248);
            this.txtNieuweFotoLocatie.Name = "txtNieuweFotoLocatie";
            this.txtNieuweFotoLocatie.Size = new System.Drawing.Size(135, 20);
            this.txtNieuweFotoLocatie.TabIndex = 13;
            // 
            // cNaam
            // 
            this.cNaam.Text = "Naam";
            // 
            // MateriaalBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 370);
            this.Controls.Add(this.txtNieuweFotoLocatie);
            this.Controls.Add(this.btnBladeren);
            this.Controls.Add(this.btnToepassen);
            this.Controls.Add(this.picNieuweAfbeelding);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNieuweNaam);
            this.Controls.Add(this.txtNieuweVoorraad);
            this.Controls.Add(this.rtxtBeschrijving);
            this.Controls.Add(this.lsvMateriaal);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MateriaalBewerken";
            this.Text = "MateriaalBewerken";
            ((System.ComponentModel.ISupportInitialize)(this.picNieuweAfbeelding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMateriaal;
        private System.Windows.Forms.RichTextBox rtxtBeschrijving;
        private System.Windows.Forms.TextBox txtNieuweVoorraad;
        private System.Windows.Forms.TextBox txtNieuweNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picNieuweAfbeelding;
        private System.Windows.Forms.Button btnToepassen;
        private System.Windows.Forms.Button btnBladeren;
        private System.Windows.Forms.TextBox txtNieuweFotoLocatie;
        private System.Windows.Forms.ColumnHeader cNaam;
    }
}