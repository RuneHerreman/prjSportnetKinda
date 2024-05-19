namespace prjSportnetKinda.View
{
    partial class MateriaalBeheer
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
            this.btnNieuwMateriaal = new System.Windows.Forms.Button();
            this.btnMateriaalAanpassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNieuwMateriaal
            // 
            this.btnNieuwMateriaal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNieuwMateriaal.Location = new System.Drawing.Point(12, 12);
            this.btnNieuwMateriaal.Name = "btnNieuwMateriaal";
            this.btnNieuwMateriaal.Size = new System.Drawing.Size(136, 43);
            this.btnNieuwMateriaal.TabIndex = 0;
            this.btnNieuwMateriaal.Text = "Nieuw materiaal toevoegen";
            this.btnNieuwMateriaal.UseVisualStyleBackColor = true;
            this.btnNieuwMateriaal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMateriaalAanpassen
            // 
            this.btnMateriaalAanpassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriaalAanpassen.Location = new System.Drawing.Point(154, 12);
            this.btnMateriaalAanpassen.Name = "btnMateriaalAanpassen";
            this.btnMateriaalAanpassen.Size = new System.Drawing.Size(136, 43);
            this.btnMateriaalAanpassen.TabIndex = 1;
            this.btnMateriaalAanpassen.Text = "Materiaal aanpassen";
            this.btnMateriaalAanpassen.UseVisualStyleBackColor = true;
            this.btnMateriaalAanpassen.Click += new System.EventHandler(this.button2_Click);
            // 
            // MateriaalBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 65);
            this.Controls.Add(this.btnMateriaalAanpassen);
            this.Controls.Add(this.btnNieuwMateriaal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MateriaalBeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MateriaalBeheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNieuwMateriaal;
        private System.Windows.Forms.Button btnMateriaalAanpassen;
    }
}