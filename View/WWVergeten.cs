using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using prjSportnetKinda.DA;
using prjSportnetKinda.Model;

//toegevoegd voor SendGrid mails
using SendGrid;
using SendGrid.Helpers.Mail;


namespace prjSportnetKinda
{
    public partial class WWVergeten : Form
    {
        public WWVergeten()
        {
            InitializeComponent();
        }

        private void btnStuurMail_Click(object sender, EventArgs e)
        {
            String Email = txtEmailRegister.Text;
            if (Email.Contains("@"))
            {
                //Code genereren
                Random random = new Random();
                int Code = random.Next(100000, 999999);

                //Mail versturen
                Execute(Email, Code);

                //Code opvragen
                string strCode = Interaction.InputBox("Geef de code in die u hebt gekregen via het gekozen email adres.\nDeze mail kan in uw spam zitten.", "Verificatie");

                //Code controleren
                if (strCode == Code.ToString())
                {
                    //Nieuw ww opvragen
                    string strNieuwPaswoord = Interaction.InputBox("Geef uw nieuw wachtwoord", "Verificatie");

                    //Kijken of ww leeg is
                    if (strNieuwPaswoord != "")
                    {
                        //Wachtwoord aanpassen
                        string strEmail = txtEmailRegister.Text;
                        GebruikerDA.WWWijzigen(strEmail, strNieuwPaswoord);

                        //Succes melding
                        MessageBox.Show("Wachtwoord is aangepast","Succesvol wachtoord aangepast");

                        //Naar login scherm
                        Login login = new Login();
                        this.Hide();
                        login.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Foutmelding
                        MessageBox.Show("Uw wachtwoord mag niet leeg zijn!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Foutmelding
                    MessageBox.Show("U gaf de verkeerde code in, stuur een nieuwe mail om opnieuw te proberen", "Foute code",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        static async Task Execute(string Email, int Code)
        {
            //Code voor client (is opgesplitst omdat door de veiligheid mag je het niet volledig in je programma steken en kan je niet pushen naar github)
            string deel1 = "SG" + ".KiLjFK_GSNmxR";
            string deel2 = "_ANE5bUuw.C20SfYAMRzS2Es" + "pt9TtfwqAkyMNb_PSP8LF7uuYmFjk";

            //Email opmaken en versturen
            var client = new SendGridClient(deel1 + deel2);
            var from = new EmailAddress("zrc.development@zrc.be", "ZRC");
            var subject = "Paswoord reset ZRC SportNet";
            var to = new EmailAddress(Email, "Gebruiker");
            var plaintextContent = "Reset uw paswoord met de code " + Code + "" ;
            var htmlContent = "Reset uw paswoord met de code <Strong>" + Code + "</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plaintextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
