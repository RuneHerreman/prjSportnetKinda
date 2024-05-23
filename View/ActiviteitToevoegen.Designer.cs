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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activiteit toevoegen:";
            // 
            // rdbTraining
            // 
            this.rdbTraining.AutoSize = true;
            this.rdbTraining.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTraining.Location = new System.Drawing.Point(14, 12);
            this.rdbTraining.Name = "rdbTraining";
            this.rdbTraining.Size = new System.Drawing.Size(94, 28);
            this.rdbTraining.TabIndex = 1;
            this.rdbTraining.TabStop = true;
            this.rdbTraining.Text = "Training";
            this.rdbTraining.UseVisualStyleBackColor = true;
            // 
            // rdbWedstrijd
            // 
            this.rdbWedstrijd.AutoSize = true;
            this.rdbWedstrijd.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWedstrijd.Location = new System.Drawing.Point(14, 45);
            this.rdbWedstrijd.Name = "rdbWedstrijd";
            this.rdbWedstrijd.Size = new System.Drawing.Size(110, 28);
            this.rdbWedstrijd.TabIndex = 2;
            this.rdbWedstrijd.TabStop = true;
            this.rdbWedstrijd.Text = "Wedstrijd";
            this.rdbWedstrijd.UseVisualStyleBackColor = true;
            // 
            // rdbFeest
            // 
            this.rdbFeest.AutoSize = true;
            this.rdbFeest.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFeest.Location = new System.Drawing.Point(14, 78);
            this.rdbFeest.Name = "rdbFeest";
            this.rdbFeest.Size = new System.Drawing.Size(74, 28);
            this.rdbFeest.TabIndex = 3;
            this.rdbFeest.TabStop = true;
            this.rdbFeest.Text = "Feest";
            this.rdbFeest.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbTraining);
            this.panel1.Controls.Add(this.rdbFeest);
            this.panel1.Controls.Add(this.rdbWedstrijd);
            this.panel1.Location = new System.Drawing.Point(16, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 119);
            this.panel1.TabIndex = 4;
            // 
            // ActiviteitToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ActiviteitToevoegen";
            this.Text = "ActiviteitToevoegen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTraining;
        private System.Windows.Forms.RadioButton rdbWedstrijd;
        private System.Windows.Forms.RadioButton rdbFeest;
        private System.Windows.Forms.Panel panel1;
    }
}