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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


        private void lblLinkToLogin_Click(object sender, EventArgs e)
        {
            //ga naar login als je al een account hebt
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            //ga naar login nadat de registratie is uitgevoerd
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
