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
            txtTelefoonnr.Text = gebruiker.Telefoonnummer.ToString();
        }

        private void btnWijzigen_Click(object sender, EventArgs e)
        {
            if (txtVoornaam.Text == null || txtNaam.Text == null || txtGeslacht.Text == null || txtAdres.Text == null || txtTelefoonnr.Text == null || txtGeboortedatum.Text == null)
            {
                lblFout.Text = "Alle velden moeten worden ingevuld";
            }
            else
            {
                try
                {
                    gebruiker.Voornaam = txtVoornaam.Text;
                    gebruiker.Naam = txtNaam.Text;
                    gebruiker.Geslacht = txtGeslacht.Text;
                    gebruiker.Adres = txtAdres.Text;
                    gebruiker.Telefoonnummer = Convert.ToInt32(txtTelefoonnr.Text);
                    gebruiker.Geboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);

                    Gebruiker wijzigen = GebruikerDA.Wijzigen(gebruiker);
                    
                    if (wijzigen == null)
                    {
                        lblFout.Text = "Vul alle velden correct in";
                    }
                    else
                    {
                        MessageBox.Show("Je gegevens zijn aangepast");

                        Main main = new Main(gebruiker, 4);
                        this.Hide();
                        main.ShowDialog();
                        this.Close();

                        
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
