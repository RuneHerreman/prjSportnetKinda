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
            this.SuspendLayout();
            // 
            // fpnlLogboek
            // 
            this.fpnlLogboek.AutoScroll = true;
            this.fpnlLogboek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlLogboek.Location = new System.Drawing.Point(0, 0);
            this.fpnlLogboek.Name = "fpnlLogboek";
            this.fpnlLogboek.Padding = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.fpnlLogboek.Size = new System.Drawing.Size(420, 611);
            this.fpnlLogboek.TabIndex = 0;
            // 
            // LogboekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 611);
            this.Controls.Add(this.fpnlLogboek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogboekForm";
            this.Text = "Logboek";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlLogboek;
    }
}