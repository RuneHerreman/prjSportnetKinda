namespace prjSportnetKinda
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.Start = new System.Windows.Forms.TabPage();
            this.Kalender = new System.Windows.Forms.TabPage();
            this.Materiaal = new System.Windows.Forms.TabPage();
            this.Profiel = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 708);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::prjSportnetKinda.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.Start);
            this.tcMain.Controls.Add(this.Kalender);
            this.tcMain.Controls.Add(this.Materiaal);
            this.tcMain.Controls.Add(this.Profiel);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(75, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1110, 708);
            this.tcMain.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(4, 22);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(3);
            this.Start.Size = new System.Drawing.Size(1102, 682);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            // 
            // Kalender
            // 
            this.Kalender.BackColor = System.Drawing.Color.White;
            this.Kalender.Location = new System.Drawing.Point(4, 22);
            this.Kalender.Name = "Kalender";
            this.Kalender.Padding = new System.Windows.Forms.Padding(3);
            this.Kalender.Size = new System.Drawing.Size(971, 682);
            this.Kalender.TabIndex = 1;
            this.Kalender.Text = "Kalender";
            // 
            // Materiaal
            // 
            this.Materiaal.BackColor = System.Drawing.Color.White;
            this.Materiaal.Location = new System.Drawing.Point(4, 22);
            this.Materiaal.Name = "Materiaal";
            this.Materiaal.Padding = new System.Windows.Forms.Padding(3);
            this.Materiaal.Size = new System.Drawing.Size(971, 682);
            this.Materiaal.TabIndex = 2;
            this.Materiaal.Text = "Materiaal";
            // 
            // Profiel
            // 
            this.Profiel.BackColor = System.Drawing.Color.White;
            this.Profiel.Location = new System.Drawing.Point(4, 22);
            this.Profiel.Name = "Profiel";
            this.Profiel.Padding = new System.Windows.Forms.Padding(3);
            this.Profiel.Size = new System.Drawing.Size(971, 682);
            this.Profiel.TabIndex = 3;
            this.Profiel.Text = "Profiel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 61);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 708);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZRC - Sportnet";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage Start;
        private System.Windows.Forms.TabPage Kalender;
        private System.Windows.Forms.TabPage Materiaal;
        private System.Windows.Forms.TabPage Profiel;
        private System.Windows.Forms.Button button1;
    }
}

