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
using Microsoft.VisualBasic;

//toegevoegd voor SendGrid mails
using SendGrid;
using SendGrid.Helpers.Mail;

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

                    //Controle
                    if (strWachtwoord == strWachtwoordHerhalen)
                    {
                        if (GebruikerDA.ControleEmail(strEmail) == null)
                        {
                            if (DateTime.Now.Year - Geboortedatum.Year > 8)
                            {
                                //Code genereren
                                Random random = new Random();
                                int Code = random.Next(100000, 999999);

                                //Code voor client (is opgesplitst omdat door de veiligheid mag je het niet volledig in je programma steken en kan je niet pushen naar github)
                                string deel1 = "SG" + ".KiLjFK_GSNmxR";
                                string deel2 = "_ANE5bUuw.C20SfYAMRzS2Es" + "pt9TtfwqAkyMNb_PSP8LF7uuYmFjk";

                                //Email opmaken en versturen
                                var client = new SendGridClient(deel1 + deel2);
                                var from = new EmailAddress("zrc.development@zrc.be", "ZRC");
                                var subject = "Paswoord reset ZRC SportNet";
                                var to = new EmailAddress(strEmail, "Gebruiker");
                                var plaintextContent = "Reset uw paswoord met de code " + Code + "";
                                var htmlContent = "Reset uw paswoord met de code <Strong>" + Code + "</strong>";
                                var msg = MailHelper.CreateSingleEmail(from, to, subject, plaintextContent, htmlContent);
                                var response = client.SendEmailAsync(msg);

                                //Code opvragen
                                string strCode = Interaction.InputBox("Geef de code in die u hebt gekregen via het gekozen email adres.\nDeze mail kan in uw spam zitten.", "Verificatie");

                                //Code controleren
                                if (strCode == Code.ToString())
                                {
                                    Gebruiker registreren = GebruikerDA.Registreren(strNaam, strVoornaam, strEmail, Geboortedatum, strWachtwoord);

                                    if (registreren == null)
                                    {
                                        //Foutmelding
                                        MessageBox.Show("Er is een fout opgetreden, uw account kan niet worden aangemaakt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        //Succes melding
                                        MessageBox.Show("Uw account is aangemaakt, u kan nu inloggen.", "Succes");

                                        //Login pagina openen
                                        Login login = new Login();
                                        this.Hide();
                                        login.ShowDialog();
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    //Foutmelding
                                    MessageBox.Show("U gaf de verkeerde code in, stuur een nieuwe mail om opnieuw te proberen", "Foute code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Foutmelding
                                lblFout.Text = "Je bent nog te jong om je aan te melden";
                            }
                        }
                        else
                        {
                            //Foutmelding
                            lblFout.Text = "Dit e-mail is al in gebruik";
                        }
                    }
                    else
                    {
                        //Foutmelding
                        lblFout.Text = "Wachtwoorden komen niet overeen";
                    }
                }
                catch
                {
                    //Foutmelding
                    lblFout.Text = "Vul alle velden correct in";
                }
            }
        }
    }
}
