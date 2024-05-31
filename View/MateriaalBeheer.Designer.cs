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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaalBeheer));
            this.btnNieuwMateriaal = new System.Windows.Forms.Button();
            this.btnMateriaalAanpassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNieuwMateriaal
            // 
            this.btnNieuwMateriaal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNieuwMateriaal.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuwMateriaal.Location = new System.Drawing.Point(16, 15);
            this.btnNieuwMateriaal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNieuwMateriaal.Name = "btnNieuwMateriaal";
            this.btnNieuwMateriaal.Size = new System.Drawing.Size(181, 53);
            this.btnNieuwMateriaal.TabIndex = 0;
            this.btnNieuwMateriaal.Text = "Nieuw materiaal toevoegen";
            this.btnNieuwMateriaal.UseVisualStyleBackColor = true;
            this.btnNieuwMateriaal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMateriaalAanpassen
            // 
            this.btnMateriaalAanpassen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriaalAanpassen.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriaalAanpassen.Location = new System.Drawing.Point(205, 15);
            this.btnMateriaalAanpassen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMateriaalAanpassen.Name = "btnMateriaalAanpassen";
            this.btnMateriaalAanpassen.Size = new System.Drawing.Size(181, 53);
            this.btnMateriaalAanpassen.TabIndex = 1;
            this.btnMateriaalAanpassen.Text = "Materiaal aanpassen";
            this.btnMateriaalAanpassen.UseVisualStyleBackColor = true;
            this.btnMateriaalAanpassen.Click += new System.EventHandler(this.button2_Click);
            // 
            // MateriaalBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 80);
            this.Controls.Add(this.btnMateriaalAanpassen);
            this.Controls.Add(this.btnNieuwMateriaal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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