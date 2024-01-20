using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSportnetKinda
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLinkToRegistreren_Click(object sender, EventArgs e)
        {
            Register accountAanmaken = new Register();
            this.Hide();
            accountAanmaken.ShowDialog();
            this.Close();
        }
    }
}
