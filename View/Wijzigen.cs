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

namespace prjSportnetKinda.View
{
    public partial class Wijzigen : Form
    {
        Gebruiker gebruiker;

        public Wijzigen(Gebruiker wijzigen)
        {
            InitializeComponent();
            gebruiker = wijzigen;

            txtVoornaam.Text = gebruiker.Voornaam;
            txtNaam.Text = gebruiker.Naam;
            txtAdres.Text = gebruiker.Adres;
            txtGeslacht.Text = gebruiker.Geslacht;
            txtGeboortedatum.Text = gebruiker.Geboortedatum.ToString();
            txtTelefoonnr.Text = gebruiker.Telefoonnr.ToString();
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            //var decl
            string strVoornaam, strNaam, strGeslacht, strAdres;
            int intTelefoonnr;
            DateTime Geboortedatum;

            if (txtVoornaam.Text == null || txtNaam.Text == null || txtGeslacht.Text == null || txtAdres.Text == null || txtTelefoonnr.Text == null || txtGeboortedatum.Text == null)
            {
                lblFout.Text = "Alle velden moeten worden ingevuld";
            }
            else
            {
                try
                {
                    strVoornaam = txtVoornaam.Text;
                    strNaam = txtNaam.Text;
                    strGeslacht = txtGeslacht.Text;
                    strAdres = txtAdres.Text;
                    intTelefoonnr = Convert.ToInt32(txtTelefoonnr.Text);
                    Geboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);
                    MessageBox.Show(Geboortedatum.ToString());
                    Gebruiker wijzigen = GebruikerDA.Wijzigen(gebruiker.Email, strVoornaam, strNaam , Geboortedatum, strGeslacht, strAdres, intTelefoonnr);

                    
                    if (wijzigen == null)
                    {
                        lblFout.Text = "Vul alle velden correct in";
                    }
                    else
                    {
                        MessageBox.Show("Je gegevens zijn aangepast");

                        
                    }
                }
                catch
                {
                    lblFout.Text = "Vul alle velden correct in";
                }   
            }
        }

        private void lblLinkToLogin_Click(object sender, EventArgs e)
        {
            //Form sluiten
            this.Close();
        }
    }
}
