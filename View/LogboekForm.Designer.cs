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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogboekForm));
            this.fpnlLogboek = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExporteren = new System.Windows.Forms.Button();
            this.btnFiltersWissen = new System.Windows.Forms.Button();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txtZoeken = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fpnlLogboek
            // 
            this.fpnlLogboek.AutoScroll = true;
            this.fpnlLogboek.Location = new System.Drawing.Point(0, 50);
            this.fpnlLogboek.Margin = new System.Windows.Forms.Padding(4);
            this.fpnlLogboek.Name = "fpnlLogboek";
            this.fpnlLogboek.Padding = new System.Windows.Forms.Padding(16, 15, 0, 0);
            this.fpnlLogboek.Size = new System.Drawing.Size(560, 702);
            this.fpnlLogboek.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExporteren);
            this.panel1.Controls.Add(this.btnFiltersWissen);
            this.panel1.Controls.Add(this.btnZoeken);
            this.panel1.Controls.Add(this.txtZoeken);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnExporteren
            // 
            this.btnExporteren.Location = new System.Drawing.Point(437, 6);
            this.btnExporteren.Margin = new System.Windows.Forms.Padding(4);
            this.btnExporteren.Name = "btnExporteren";
            this.btnExporteren.Size = new System.Drawing.Size(105, 28);
            this.btnExporteren.TabIndex = 3;
            this.btnExporteren.Text = "&Exporteren";
            this.btnExporteren.UseVisualStyleBackColor = true;
            this.btnExporteren.Click += new System.EventHandler(this.btnExporteren_Click);
            // 
            // btnFiltersWissen
            // 
            this.btnFiltersWissen.Location = new System.Drawing.Point(308, 6);
            this.btnFiltersWissen.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltersWissen.Name = "btnFiltersWissen";
            this.btnFiltersWissen.Size = new System.Drawing.Size(128, 28);
            this.btnFiltersWissen.TabIndex = 2;
            this.btnFiltersWissen.Text = "Filters Wissen";
            this.btnFiltersWissen.UseVisualStyleBackColor = true;
            this.btnFiltersWissen.Click += new System.EventHandler(this.btnFiltersWissen_Click);
            // 
            // btnZoeken
            // 
            this.btnZoeken.Location = new System.Drawing.Point(207, 6);
            this.btnZoeken.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(100, 28);
            this.btnZoeken.TabIndex = 1;
            this.btnZoeken.Text = "Zoek";
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txtZoeken
            // 
            this.txtZoeken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtZoeken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtZoeken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZoeken.Location = new System.Drawing.Point(16, 10);
            this.txtZoeken.Margin = new System.Windows.Forms.Padding(4);
            this.txtZoeken.Name = "txtZoeken";
            this.txtZoeken.Size = new System.Drawing.Size(182, 22);
            this.txtZoeken.TabIndex = 0;
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 752);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fpnlLogboek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LogboekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnExporteren;
    }
}