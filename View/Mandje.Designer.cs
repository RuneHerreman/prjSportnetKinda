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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Naam");
            this.lsvMandje = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lsvMandje
            // 
            this.lsvMandje.HideSelection = false;
            this.lsvMandje.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvMandje.Location = new System.Drawing.Point(12, 12);
            this.lsvMandje.Name = "lsvMandje";
            this.lsvMandje.Size = new System.Drawing.Size(111, 307);
            this.lsvMandje.TabIndex = 0;
            this.lsvMandje.UseCompatibleStateImageBehavior = false;
            this.lsvMandje.SelectedIndexChanged += new System.EventHandler(this.lsvMandje_SelectedIndexChanged);
            // 
            // Mandje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 363);
            this.Controls.Add(this.lsvMandje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Mandje";
            this.Text = "Mandje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvMandje;
    }
}