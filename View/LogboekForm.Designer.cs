namespace prjSportnetKinda.View
{
    partial class LogboekForm
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
            this.fpnlLogboek = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtZoeken = new System.Windows.Forms.TextBox();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.btnFiltersWissen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlLogboek
            // 
            this.fpnlLogboek.AutoScroll = true;
            this.fpnlLogboek.Location = new System.Drawing.Point(0, 41);
            this.fpnlLogboek.Name = "fpnlLogboek";
            this.fpnlLogboek.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.fpnlLogboek.Size = new System.Drawing.Size(420, 570);
            this.fpnlLogboek.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFiltersWissen);
            this.panel1.Controls.Add(this.btnZoeken);
            this.panel1.Controls.Add(this.txtZoeken);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 35);
            this.panel1.TabIndex = 0;
            // 
            // txtZoeken
            // 
            this.txtZoeken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtZoeken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtZoeken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZoeken.Location = new System.Drawing.Point(12, 8);
            this.txtZoeken.Name = "txtZoeken";
            this.txtZoeken.Size = new System.Drawing.Size(213, 20);
            this.txtZoeken.TabIndex = 0;
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(231, 5);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(75, 23);
            this.btnZoeken.TabIndex = 1;
            this.btnZoeken.Text = "Zoek";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // btnFiltersWissen
            // 
            this.btnFiltersWissen.Location = new System.Drawing.Point(312, 5);
            this.btnFiltersWissen.Name = "btnFiltersWissen";
            this.btnFiltersWissen.Size = new System.Drawing.Size(96, 23);
            this.btnFiltersWissen.TabIndex = 2;
            this.btnFiltersWissen.Text = "Filters Wissen";
            this.btnFiltersWissen.UseVisualStyleBackColor = true;
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpnlLogboek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogboekForm";
            this.Text = "Logboek";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlLogboek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txtZoeken;
        private System.Windows.Forms.Button btnFiltersWissen;
    }
}