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
            Execute();
            String strCode = Interaction.InputBox("Code e-mail", "Verificatie");
        }


        static async Task Execute()
        {

         /*   var client = new SendGridClient("");
            var from = new EmailAddress("zrc.development@zrc.be", "ZRC");
            var subject = "Sending with Sendgrid is Fun";
            var to = new EmailAddress("lars.patrouille@gmail.com", "lars");
            var plaintextContent = "and easy to do anywhere, even with c#";
            var htmlContent = "<Strong>and easy to do anywhere, even with c#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plaintextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
         */

        }
    }
}
