using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
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

        private void lblLinkToRegistreren_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            this.Hide();
            Register.ShowDialog();
            this.Close();
        }

        private void lblLinkToWWVergeten_Click(object sender, EventArgs e)
        {
            WWVergeten wWVergeten = new WWVergeten();
            this.Hide();
            wWVergeten.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //var decl
            string strEmail, strWachtwoord;

            //var opvangen
            strEmail = txtEmail.Text;
            strWachtwoord = txtPassword.Text;

            //Klasse oproepen
            Gebruiker gebruiker = GebruikerDA.Inloggen(strEmail, strWachtwoord);

            //Controle op wachtoord en email
            if (gebruiker == null)
            {
                //Foutmelding tonen
                lblFout.Text = "E-mail of Wachtwoord is fout";

                //textboxen resetten
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
            }
            else 
            {
                //Main form openen
                Main Main = new Main(gebruiker);
                this.Hide();
                Main.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
