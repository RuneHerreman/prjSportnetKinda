using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjSportnetKinda.DA;
using prjSportnetKinda.Model;

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
            //var decl
            string strNaam, strVoornaam, strEmail, strWachtwoord, strWachtwoordHerhalen;
            DateTime Geboortedatum;

            //Contole op ivullen
            if (txtNaam.Text == "" || txtVoornaam.Text == "" || txtEmail.Text == "" || txtGeboortedatum.Text == "" || txtWachtwoord.Text == "")
            {
                //Foutmelding
                lblFout.Text = "Alle velden moeten worden ingevuld";
            }
            else
            {
                try
                {
                    strNaam = txtNaam.Text;
                    strVoornaam = txtVoornaam.Text;
                    strEmail = txtEmail.Text;
                    Geboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);
                    strWachtwoord = txtWachtwoord.Text;
                    strWachtwoordHerhalen = txtWachtwoordHerhalen.Text;

                    if (strWachtwoord == strWachtwoordHerhalen)
                    {
                        Gebruiker registreren = GebruikerDA.Registreren(strNaam, strVoornaam, strEmail, Geboortedatum, strWachtwoord);

                        if (registreren == null)
                        {
                            lblFout.Text = "Vul alle velden correct in";
                        }
                        else if (registreren.email == "Bezet")
                        {
                            lblFout.Text = "E-mail is al in gebruik";
                        }
                        else
                        {
                            Login login = new Login();
                            this.Hide();
                            login.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        lblFout.Text = "Wachtwoorden komen niet overeen";
                    }
                }
                catch
                {
                    lblFout.Text = "Vul alle velden correct in";
                }
            }
        }
    }
}
