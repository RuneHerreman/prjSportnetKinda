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
            /*  Mail met code wordt verstuurt naar opgegeven Emailadres
                --> geef code in 
                correct?:   Verander wachtwoord mogelijk
                incorrect?:  Error
            */
            String Email = txtEmailRegister.Text;
            if (Email.Contains("@"))
            {
                Random random = new Random();
                int Code = random.Next(100000, 999999);

                Execute(Email, Code);

                String strCode = Interaction.InputBox("Code e-mail", "Verificatie");
                if (strCode == Code.ToString())
                {
                    String strNieuwPaswoord = Interaction.InputBox("Geef uw nieuw paswoord", "Verificatie");
                }
                else
                {
                    MessageBox.Show("U gaf de verkeerde code in. Probeer opnieuw.");
                }
            }
        }


        static async Task Execute(String Email, int Code)
        {
            String deel1 = "SG" + ".KiLjFK_GSNmxR";
            String deel2 = "_ANE5bUuw.C20SfYAMRzS2Es" + "pt9TtfwqAkyMNb_PSP8LF7uuYmFjk";
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
