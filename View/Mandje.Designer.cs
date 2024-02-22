namespace prjSportnetKinda.View
{
    partial class Mandje
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Naam Artikel");
            this.lsvMandje = new System.Windows.Forms.ListView();
            this.btnHurenLijst = new System.Windows.Forms.Button();
            this.btnMandjeLegen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvMandje
            // 
            this.lsvMandje.HideSelection = false;
            this.lsvMandje.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lsvMandje.Location = new System.Drawing.Point(10, 10);
            this.lsvMandje.Name = "lsvMandje";
            this.lsvMandje.Size = new System.Drawing.Size(300, 200);
            this.lsvMandje.TabIndex = 0;
            this.lsvMandje.UseCompatibleStateImageBehavior = false;
            this.lsvMandje.View = System.Windows.Forms.View.List;
            this.lsvMandje.SelectedIndexChanged += new System.EventHandler(this.lsvMandje_SelectedIndexChanged);
            // 
            // btnHurenLijst
            // 
            this.btnHurenLijst.Location = new System.Drawing.Point(10, 272);
            this.btnHurenLijst.Name = "btnHurenLijst";
            this.btnHurenLijst.Size = new System.Drawing.Size(300, 50);
            this.btnHurenLijst.TabIndex = 1;
            this.btnHurenLijst.Text = "Huren";
            this.btnHurenLijst.UseVisualStyleBackColor = true;
            // 
            // btnMandjeLegen
            // 
            this.btnMandjeLegen.Location = new System.Drawing.Point(165, 216);
            this.btnMandjeLegen.Name = "btnMandjeLegen";
            this.btnMandjeLegen.Size = new System.Drawing.Size(145, 50);
            this.btnMandjeLegen.TabIndex = 2;
            this.btnMandjeLegen.Text = "Mandje Legen";
            this.btnMandjeLegen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Artikel Verwijderen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Mandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMandjeLegen);
            this.Controls.Add(this.btnHurenLijst);
            this.Controls.Add(this.lsvMandje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mandje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mandje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMandje;
        private System.Windows.Forms.Button btnHurenLijst;
        private System.Windows.Forms.Button btnMandjeLegen;
        private System.Windows.Forms.Button button1;
    }
}