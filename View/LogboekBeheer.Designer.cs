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
            this.btnAllesInleveren = new System.Windows.Forms.Button();
            this.btnKiesHoeveelheid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAllesInleveren
            // 
            this.btnAllesInleveren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllesInleveren.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllesInleveren.Location = new System.Drawing.Point(154, 10);
            this.btnAllesInleveren.Name = "btnAllesInleveren";
            this.btnAllesInleveren.Size = new System.Drawing.Size(136, 43);
            this.btnAllesInleveren.TabIndex = 5;
            this.btnAllesInleveren.Text = "Alles inleveren";
            this.btnAllesInleveren.UseVisualStyleBackColor = true;
            // 
            // btnKiesHoeveelheid
            // 
            this.btnKiesHoeveelheid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiesHoeveelheid.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiesHoeveelheid.Location = new System.Drawing.Point(12, 10);
            this.btnKiesHoeveelheid.Name = "btnKiesHoeveelheid";
            this.btnKiesHoeveelheid.Size = new System.Drawing.Size(136, 43);
            this.btnKiesHoeveelheid.TabIndex = 4;
            this.btnKiesHoeveelheid.Text = "Bepaalde hoeveelheid inleveren";
            this.btnKiesHoeveelheid.UseVisualStyleBackColor = true;
            // 
            // LogboekBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 65);
            this.Controls.Add(this.btnAllesInleveren);
            this.Controls.Add(this.btnKiesHoeveelheid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogboekBeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogboekBeheer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllesInleveren;
        private System.Windows.Forms.Button btnKiesHoeveelheid;
    }
}