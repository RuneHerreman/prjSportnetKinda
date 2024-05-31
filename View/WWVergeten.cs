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
            var subject = "Wachtwoord herstellen ZRC SportNet";
            var to = new EmailAddress(Email, "Gebruiker");
            var plaintextContent = $"Reset uw paswoord met de code " + Code + "" ;
            var htmlContent = "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\">\r\n<html data-editor-version=\"2\" class=\"sg-campaigns\" xmlns=\"http://www.w3.org/1999/xhtml\">\r\n    <head>\r\n      <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\r\n      <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, minimum-scale=1, maximum-scale=1\">\r\n      <!--[if !mso]><!-->\r\n      <meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\">\r\n      <!--<![endif]-->\r\n      <!--[if (gte mso 9)|(IE)]>\r\n      <xml>\r\n        <o:OfficeDocumentSettings>\r\n          <o:AllowPNG/>\r\n          <o:PixelsPerInch>96</o:PixelsPerInch>\r\n        </o:OfficeDocumentSettings>\r\n      </xml>\r\n      <![endif]-->\r\n      <!--[if (gte mso 9)|(IE)]>\r\n  <style type=\"text/css\">\r\n    body {width: 600px;margin: 0 auto;}\r\n    table {border-collapse: collapse;}\r\n    table, td {mso-table-lspace: 0pt;mso-table-rspace: 0pt;}\r\n    img {-ms-interpolation-mode: bicubic;}\r\n  </style>\r\n<![endif]-->\r\n      <style type=\"text/css\">\r\n    body, p, div {\r\n      font-family: trebuchet ms,helvetica,sans-serif;\r\n      font-size: 14px;\r\n    }\r\n    body {\r\n      color: #000000;\r\n    }\r\n    body a {\r\n      color: #1188E6;\r\n      text-decoration: none;\r\n    }\r\n    p { margin: 0; padding: 0; }\r\n    table.wrapper {\r\n      width:100% !important;\r\n      table-layout: fixed;\r\n      -webkit-font-smoothing: antialiased;\r\n      -webkit-text-size-adjust: 100%;\r\n      -moz-text-size-adjust: 100%;\r\n      -ms-text-size-adjust: 100%;\r\n    }\r\n    img.max-width {\r\n      max-width: 100% !important;\r\n    }\r\n    .column.of-2 {\r\n      width: 50%;\r\n    }\r\n    .column.of-3 {\r\n      width: 33.333%;\r\n    }\r\n    .column.of-4 {\r\n      width: 25%;\r\n    }\r\n    ul ul ul ul  {\r\n      list-style-type: disc !important;\r\n    }\r\n    ol ol {\r\n      list-style-type: lower-roman !important;\r\n    }\r\n    ol ol ol {\r\n      list-style-type: lower-latin !important;\r\n    }\r\n    ol ol ol ol {\r\n      list-style-type: decimal !important;\r\n    }\r\n    @media screen and (max-width:480px) {\r\n      .preheader .rightColumnContent,\r\n      .footer .rightColumnContent {\r\n        text-align: left !important;\r\n      }\r\n      .preheader .rightColumnContent div,\r\n      .preheader .rightColumnContent span,\r\n      .footer .rightColumnContent div,\r\n      .footer .rightColumnContent span {\r\n        text-align: left !important;\r\n      }\r\n      .preheader .rightColumnContent,\r\n      .preheader .leftColumnContent {\r\n        font-size: 80% !important;\r\n        padding: 5px 0;\r\n      }\r\n      table.wrapper-mobile {\r\n        width: 100% !important;\r\n        table-layout: fixed;\r\n      }\r\n      img.max-width {\r\n        height: auto !important;\r\n        max-width: 100% !important;\r\n      }\r\n      a.bulletproof-button {\r\n        display: block !important;\r\n        width: auto !important;\r\n        font-size: 80%;\r\n        padding-left: 0 !important;\r\n        padding-right: 0 !important;\r\n      }\r\n      .columns {\r\n        width: 100% !important;\r\n      }\r\n      .column {\r\n        display: block !important;\r\n        width: 100% !important;\r\n        padding-left: 0 !important;\r\n        padding-right: 0 !important;\r\n        margin-left: 0 !important;\r\n        margin-right: 0 !important;\r\n      }\r\n      .social-icon-column {\r\n        display: inline-block !important;\r\n      }\r\n    }\r\n  </style>\r\n      <!--user entered Head Start--><!--End Head user entered-->\r\n    </head>\r\n    <body>\r\n      <center class=\"wrapper\" data-link-color=\"#1188E6\" data-body-style=\"font-size:14px; font-family:trebuchet ms,helvetica,sans-serif; color:#000000; background-color:#ececec;\">\r\n        <div class=\"webkit\">\r\n          <table cellpadding=\"0\" cellspacing=\"0\" border=\"0\" width=\"100%\" class=\"wrapper\" bgcolor=\"#ececec\">\r\n            <tr>\r\n              <td valign=\"top\" bgcolor=\"#ececec\" width=\"100%\">\r\n                <table width=\"100%\" role=\"content-container\" class=\"outer\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">\r\n                  <tr>\r\n                    <td width=\"100%\">\r\n                      <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">\r\n                        <tr>\r\n                          <td>\r\n                            <!--[if mso]>\r\n    <center>\r\n    <table><tr><td width=\"600\">\r\n  <![endif]-->\r\n                                    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" style=\"width:100%; max-width:600px;\" align=\"center\">\r\n                                      <tr>\r\n                                        <td role=\"modules-container\" style=\"padding:7px 20px 20px 20px; color:#000000; text-align:left;\" bgcolor=\"#FFFFFF\" width=\"100%\" align=\"left\"><table class=\"module preheader preheader-hide\" role=\"module\" data-type=\"preheader\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"display: none !important; mso-hide: all; visibility: hidden; opacity: 0; color: transparent; height: 0; width: 0;\">\r\n    <tr>\r\n      <td role=\"module-content\">\r\n        <p></p>\r\n      </td>\r\n    </tr>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"a20c84af-6e6d-4e44-b3e0-29f47bd88ec0\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:2px 0px 18px 12px; line-height:22px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><div style=\"font-family: inherit; text-align: inherit\"><span style=\"font-family: trebuchet ms, helvetica, sans-serif; color: #a5a5a5\">Hallo, "+Email+"</span></div><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"wrapper\" role=\"module\" data-type=\"image\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"3633310c-f5fe-4374-9819-a7864f8b673d\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"font-size:6px; line-height:10px; padding:0px 0px 8px 0px;\" valign=\"top\" align=\"left\">\r\n          <img class=\"max-width\" border=\"0\" style=\"display:block; color:#000000; text-decoration:none; font-family:Helvetica, arial, sans-serif; font-size:16px; max-width:20% !important; width:20%; height:auto !important;\" width=\"112\" alt=\"\" data-proportionally-constrained=\"true\" data-responsive=\"true\" src=\"http://cdn.mcauto-images-production.sendgrid.net/9a12740c30c17b0d/9114fad1-1466-43a7-9892-575849db19e9/2251x2251.png\">\r\n        </td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"divider\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"f9668752-4a55-4459-ac65-6242847b67f9\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:5px 0px 1px 0px;\" role=\"module-content\" height=\"100%\" valign=\"top\" bgcolor=\"\">\r\n          <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" width=\"100%\" height=\"1px\" style=\"line-height:1px; font-size:1px;\">\r\n            <tbody>\r\n              <tr>\r\n                <td style=\"padding:0px 0px 1px 0px;\" bgcolor=\"#d7d7d7\"></td>\r\n              </tr>\r\n            </tbody>\r\n          </table>\r\n        </td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"254f32d9-d909-42fd-a397-045316655b39\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:7px 0px 9px 0px; line-height:26px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><h1 style=\"text-align: left\"><span style=\"font-family: trebuchet ms, helvetica, sans-serif; color: #0f3051; font-size: 26px\"><strong>Verifieer dat jij het bent</strong></span></h1><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"e1bda6bd-b0ea-4d2c-99a1-6cb046d0579e\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:7px 0px 3px 0px; line-height:17px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><div style=\"font-family: inherit; text-align: left\"><span style=\"font-family: trebuchet ms, helvetica, sans-serif\">Iemand probeert het wachtwoord van je account te wijzigen.</span></div>\r\n<div style=\"font-family: inherit; text-align: left\"><br></div>\r\n<div style=\"font-family: inherit; text-align: left\"><span style=\"font-family: trebuchet ms, helvetica, sans-serif\">Vul deze code in om te bevestigen dat je je wachtwoord wil aanpassen:</span></div><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"2ab657bb-d42c-4126-a202-d62ed312fc24\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:7px 0px 18px 0px; line-height:-14px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><h1 style=\"text-align: inherit\">"+Code+"</h1><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"c2f1f58e-550c-4ac9-93a4-9a6b6387e466\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:7px 0px 18px 0px; line-height:20px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><div style=\"font-family: inherit; text-align: inherit\"><span style=\"color: #717171; font-size: 12px\">In het geval dat je niet hebt geprobeerd om je wachtwoord te wijzigen bij ons kan je deze e-mail negeren.</span></div><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table><table class=\"module\" role=\"module\" data-type=\"text\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"table-layout: fixed;\" data-muid=\"00ecb05c-4967-44c5-9d15-b8314b8c453d\" data-mc-module-version=\"2019-10-22\">\r\n    <tbody>\r\n      <tr>\r\n        <td style=\"padding:3px 0px 8px 0px; line-height:22px; text-align:inherit;\" height=\"100%\" valign=\"top\" bgcolor=\"\" role=\"module-content\"><div><div style=\"font-family: inherit; text-align: center\"><span style=\"color: #717171; font-size: 12px\">Egellaan, 8400 Oostende, België</span></div><div></div></div></td>\r\n      </tr>\r\n    </tbody>\r\n  </table></td>\r\n                                      </tr>\r\n                                    </table>\r\n                                    <!--[if mso]>\r\n                                  </td>\r\n                                </tr>\r\n                              </table>\r\n                            </center>\r\n                            <![endif]-->\r\n                          </td>\r\n                        </tr>\r\n                      </table>\r\n                    </td>\r\n                  </tr>\r\n                </table>\r\n              </td>\r\n            </tr>\r\n          </table>\r\n        </div>\r\n      </center>\r\n    </body>\r\n  </html>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plaintextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
