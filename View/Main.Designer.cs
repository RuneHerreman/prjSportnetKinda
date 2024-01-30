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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblNaamVoornaam = new System.Windows.Forms.Label();
            this.tabKalender = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMateriaal = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabProfiel = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnArtiekelToevoegen = new prjSportnetKinda.View.ButtonControls();
            this.welkomItem1 = new prjSportnetKinda.WelkomItem();
            this.welkomItem2 = new prjSportnetKinda.WelkomItem();
            this.btnProfiel = new prjSportnetKinda.View.ButtonControls();
            this.btnMateriaal = new prjSportnetKinda.View.ButtonControls();
            this.btnKalender = new prjSportnetKinda.View.ButtonControls();
            this.btnStart = new prjSportnetKinda.View.ButtonControls();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tabStart.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabKalender.SuspendLayout();
            this.tabMateriaal.SuspendLayout();
            this.tabProfiel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnProfiel);
            this.panel1.Controls.Add(this.btnMateriaal);
            this.panel1.Controls.Add(this.btnKalender);
            this.panel1.Controls.Add(this.btnStart);
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
            this.pictureBox1.Image = global::prjSportnetKinda.Properties.Resources.Logo_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabStart);
            this.tcMain.Controls.Add(this.tabKalender);
            this.tcMain.Controls.Add(this.tabMateriaal);
            this.tcMain.Controls.Add(this.tabProfiel);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(75, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(908, 708);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcMain.TabIndex = 1;
            // 
            // tabStart
            // 
            this.tabStart.BackColor = System.Drawing.SystemColors.Control;
            this.tabStart.Controls.Add(this.btnArtiekelToevoegen);
            this.tabStart.Controls.Add(this.panel2);
            this.tabStart.Controls.Add(this.lblNaamVoornaam);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(900, 682);
            this.tabStart.TabIndex = 0;
            this.tabStart.Text = "Start";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.welkomItem1);
            this.panel2.Controls.Add(this.welkomItem2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 579);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::prjSportnetKinda.Properties.Resources.IMG_Login2;
            this.pictureBox5.Location = new System.Drawing.Point(50, 1178);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(800, 283);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::prjSportnetKinda.Properties.Resources.IMG_Login2;
            this.pictureBox4.Location = new System.Drawing.Point(50, 822);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(800, 283);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // lblNaamVoornaam
            // 
            this.lblNaamVoornaam.AutoSize = true;
            this.lblNaamVoornaam.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamVoornaam.Location = new System.Drawing.Point(50, 17);
            this.lblNaamVoornaam.Name = "lblNaamVoornaam";
            this.lblNaamVoornaam.Size = new System.Drawing.Size(623, 61);
            this.lblNaamVoornaam.TabIndex = 1;
            this.lblNaamVoornaam.Text = "Welkom [voornaam] [naam]";
            // 
            // tabKalender
            // 
            this.tabKalender.BackColor = System.Drawing.Color.White;
            this.tabKalender.Controls.Add(this.label1);
            this.tabKalender.Location = new System.Drawing.Point(4, 22);
            this.tabKalender.Name = "tabKalender";
            this.tabKalender.Padding = new System.Windows.Forms.Padding(3);
            this.tabKalender.Size = new System.Drawing.Size(900, 682);
            this.tabKalender.TabIndex = 1;
            this.tabKalender.Text = "Kalender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalender";
            // 
            // tabMateriaal
            // 
            this.tabMateriaal.BackColor = System.Drawing.Color.White;
            this.tabMateriaal.Controls.Add(this.label3);
            this.tabMateriaal.Location = new System.Drawing.Point(4, 22);
            this.tabMateriaal.Name = "tabMateriaal";
            this.tabMateriaal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateriaal.Size = new System.Drawing.Size(900, 682);
            this.tabMateriaal.TabIndex = 2;
            this.tabMateriaal.Text = "Materiaal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(438, 108);
            this.label3.TabIndex = 1;
            this.label3.Text = "Materiaal";
            // 
            // tabProfiel
            // 
            this.tabProfiel.BackColor = System.Drawing.Color.White;
            this.tabProfiel.Controls.Add(this.label4);
            this.tabProfiel.Location = new System.Drawing.Point(4, 22);
            this.tabProfiel.Name = "tabProfiel";
            this.tabProfiel.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiel.Size = new System.Drawing.Size(900, 682);
            this.tabProfiel.TabIndex = 3;
            this.tabProfiel.Text = "Profiel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 108);
            this.label4.TabIndex = 1;
            this.label4.Text = "Profiel";
            // 
            // btnArtiekelToevoegen
            // 
            this.btnArtiekelToevoegen.BackColor = System.Drawing.Color.Transparent;
            this.btnArtiekelToevoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArtiekelToevoegen.FlatAppearance.BorderSize = 0;
            this.btnArtiekelToevoegen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnArtiekelToevoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtiekelToevoegen.HoverFoto1 = global::prjSportnetKinda.Properties.Resources.ItemAdd;
            this.btnArtiekelToevoegen.Image = global::prjSportnetKinda.Properties.Resources.ItemAdd;
            this.btnArtiekelToevoegen.Location = new System.Drawing.Point(776, 18);
            this.btnArtiekelToevoegen.Name = "btnArtiekelToevoegen";
            this.btnArtiekelToevoegen.NormaalFoto1 = global::prjSportnetKinda.Properties.Resources.ItemAdd;
            this.btnArtiekelToevoegen.Size = new System.Drawing.Size(60, 60);
            this.btnArtiekelToevoegen.TabIndex = 5;
            this.btnArtiekelToevoegen.Tooltip1 = "ArtiekelToevoegen";
            this.btnArtiekelToevoegen.UseVisualStyleBackColor = false;
            // 
            // welkomItem1
            // 
            this.welkomItem1.BackColor = System.Drawing.SystemColors.Control;
            this.welkomItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welkomItem1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welkomItem1.Location = new System.Drawing.Point(58, 0);
            this.welkomItem1.Margin = new System.Windows.Forms.Padding(4);
            this.welkomItem1.MaximumSize = new System.Drawing.Size(775, 350);
            this.welkomItem1.MinimumSize = new System.Drawing.Size(775, 350);
            this.welkomItem1.Name = "welkomItem1";
            this.welkomItem1.Size = new System.Drawing.Size(775, 350);
            this.welkomItem1.TabIndex = 10;
            // 
            // welkomItem2
            // 
            this.welkomItem2.BackColor = System.Drawing.SystemColors.Control;
            this.welkomItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.welkomItem2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welkomItem2.Location = new System.Drawing.Point(58, 445);
            this.welkomItem2.Margin = new System.Windows.Forms.Padding(4);
            this.welkomItem2.MaximumSize = new System.Drawing.Size(775, 350);
            this.welkomItem2.MinimumSize = new System.Drawing.Size(775, 350);
            this.welkomItem2.Name = "welkomItem2";
            this.welkomItem2.Size = new System.Drawing.Size(775, 350);
            this.welkomItem2.TabIndex = 9;
            // 
            // btnProfiel
            // 
            this.btnProfiel.BackColor = System.Drawing.Color.Transparent;
            this.btnProfiel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiel.FlatAppearance.BorderSize = 0;
            this.btnProfiel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProfiel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfiel.HoverFoto1 = global::prjSportnetKinda.Properties.Resources.user_select;
            this.btnProfiel.Image = global::prjSportnetKinda.Properties.Resources.user_standard;
            this.btnProfiel.Location = new System.Drawing.Point(5, 638);
            this.btnProfiel.Name = "btnProfiel";
            this.btnProfiel.NormaalFoto1 = global::prjSportnetKinda.Properties.Resources.user_standard;
            this.btnProfiel.Size = new System.Drawing.Size(65, 65);
            this.btnProfiel.TabIndex = 7;
            this.btnProfiel.Tooltip1 = "Profiel";
            this.btnProfiel.UseVisualStyleBackColor = false;
            this.btnProfiel.Click += new System.EventHandler(this.btnProfiel_Click);
            // 
            // btnMateriaal
            // 
            this.btnMateriaal.BackColor = System.Drawing.Color.Transparent;
            this.btnMateriaal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriaal.FlatAppearance.BorderSize = 0;
            this.btnMateriaal.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMateriaal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMateriaal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMateriaal.HoverFoto1 = global::prjSportnetKinda.Properties.Resources.cart_select;
            this.btnMateriaal.Image = global::prjSportnetKinda.Properties.Resources.cart_standard;
            this.btnMateriaal.Location = new System.Drawing.Point(5, 220);
            this.btnMateriaal.Name = "btnMateriaal";
            this.btnMateriaal.NormaalFoto1 = global::prjSportnetKinda.Properties.Resources.cart_standard;
            this.btnMateriaal.Size = new System.Drawing.Size(65, 65);
            this.btnMateriaal.TabIndex = 6;
            this.btnMateriaal.Tooltip1 = "Materiaal";
            this.btnMateriaal.UseVisualStyleBackColor = false;
            this.btnMateriaal.Click += new System.EventHandler(this.btnMateriaal_Click);
            // 
            // btnKalender
            // 
            this.btnKalender.BackColor = System.Drawing.Color.Transparent;
            this.btnKalender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKalender.FlatAppearance.BorderSize = 0;
            this.btnKalender.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKalender.HoverFoto1 = global::prjSportnetKinda.Properties.Resources.calendar_select;
            this.btnKalender.Image = global::prjSportnetKinda.Properties.Resources.calendar_standard;
            this.btnKalender.Location = new System.Drawing.Point(5, 150);
            this.btnKalender.Name = "btnKalender";
            this.btnKalender.NormaalFoto1 = global::prjSportnetKinda.Properties.Resources.calendar_standard;
            this.btnKalender.Size = new System.Drawing.Size(65, 65);
            this.btnKalender.TabIndex = 5;
            this.btnKalender.Tooltip1 = "Planning";
            this.btnKalender.UseVisualStyleBackColor = false;
            this.btnKalender.Click += new System.EventHandler(this.btnKalender_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.HoverFoto1 = global::prjSportnetKinda.Properties.Resources.home_select;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(5, 80);
            this.btnStart.Name = "btnStart";
            this.btnStart.NormaalFoto1 = ((System.Drawing.Image)(resources.GetObject("btnStart.NormaalFoto1")));
            this.btnStart.Size = new System.Drawing.Size(65, 65);
            this.btnStart.TabIndex = 4;
            this.btnStart.Tooltip1 = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 708);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZRC - Sportnet";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabKalender.ResumeLayout(false);
            this.tabKalender.PerformLayout();
            this.tabMateriaal.ResumeLayout(false);
            this.tabMateriaal.PerformLayout();
            this.tabProfiel.ResumeLayout(false);
            this.tabProfiel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TabPage tabKalender;
        private System.Windows.Forms.TabPage tabMateriaal;
        private System.Windows.Forms.TabPage tabProfiel;
        private View.ButtonControls btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNaamVoornaam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private View.ButtonControls btnKalender;
        private View.ButtonControls btnProfiel;
        private View.ButtonControls btnMateriaal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private WelkomItem welkomItem2;
        private View.ButtonControls btnArtiekelToevoegen;
        private WelkomItem welkomItem1;
    }
}

