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
        List<Gebruiker> gebruikers = new List<Gebruiker>();

        public Wijzigen()
        {
            InitializeComponent();

            //Gebruikers ophalen uit database
            foreach(Gebruiker g in GebruikerDA.Ophalen())
            {
                txtGebruiker.AutoCompleteCustomSource.Add(g.Voornaam + " " + g.Naam);
                gebruikers.Add(g);
            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            int intFound = 0;

            try
            {
                foreach (Gebruiker g in gebruikers)
                {
                    //Naam controleren
                    if (g.Voornaam.ToLower() + " " + g.Naam.ToLower() == txtGebruiker.Text.ToLower())
                    {
                        //Email tonen
                        lblEmail.Text = $"E-mailadres gebruiker:\n{g.Email}";

                        //Checkboxes tonen
                        chkRenner.Visible = true;
                        if (g.Renner)
                        {
                            chkRenner.Checked = true;
                        }
                        else
                        {
                            chkRenner.Checked = false;
                        }

                        chkTrainer.Visible = true;
                        if (g.Trainer)
                        {
                            chkTrainer.Checked = true;
                        }
                        else
                        {
                            chkTrainer.Checked = false;
                        }

                        chkBeheerder.Visible = true;
                        if (g.Beheerder)
                        {
                            chkBeheerder.Checked = true;
                        }
                        else
                        {
                            chkBeheerder.Checked = false;
                        }

                        btnOpslaan.Visible = true;
                        btnVerwijderen.Visible = true;

                        intFound = 1;
                    }
                }

                //Controle of gebruiker gevonden is of niet
                if(intFound == 0)
                {
                    //Checkboxes hidden
                    chkRenner.Visible = false;
                    chkTrainer.Visible = false;
                    chkBeheerder.Visible = false;

                    btnOpslaan.Visible = false;
                    btnVerwijderen.Visible = false;

                    lblEmail.Text = "";

                    //Messagebox
                    MessageBox.Show($"{txtGebruiker.Text} bestaat niet in het programma");
                }

                intFound = 0;
            }
            catch
            {
                //foutmelding
                MessageBox.Show("Vul het veld correct in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            Gebruiker g = new Gebruiker();

            //Email uitlezen
            g.Email = lblEmail.Text.Substring(23,lblEmail.Text.Length - 23);

            //Checkboxes uitlzen
            if (chkRenner.Checked)
            {
                g.Renner = true;
            }
            else
            {
                g.Renner = false;
            }

            if (chkTrainer.Checked)
            {
                g.Trainer = true;
            }
            else
            {
                g.Trainer = false;
            }

            if (chkBeheerder.Checked)
            {
                g.Beheerder = true;
            }
            else
            {
                g.Beheerder = false;
            }

            if (GebruikerDA.WijzigenRollen(g) != null)
            {
                //Resetten form
                txtGebruiker.Clear();
                lblEmail.Text = "";
                chkRenner.Visible = false;
                chkTrainer.Visible = false;
                chkBeheerder.Visible = false;
                btnVerwijderen.Visible = false;
                btnOpslaan.Visible = false;

                //Succes Message
                MessageBox.Show("De rollen zijn geüpdate");
            }
            else
            {
                //Error
                MessageBox.Show("Kan gegevens niet aanpassen wegens fout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            //Waarschuwing
            DialogResult result = MessageBox.Show("Weet u zeker dat u deze gebruiker wilt verwijderen?", "Waarschuwing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //Gebruiker verwijderen
                if (GebruikerDA.Verwijderen(lblEmail.Text.Substring(23, lblEmail.Text.Length - 23)) != null)
                {
                    //Resetten form
                    txtGebruiker.Clear();
                    lblEmail.Text = "";
                    chkRenner.Visible = false;
                    chkTrainer.Visible = false;
                    chkBeheerder.Visible = false;
                    btnVerwijderen.Visible = false;
                    btnOpslaan.Visible = false;
                    txtGebruiker.AutoCompleteCustomSource.Remove(txtGebruiker.Text);

                    //Succes melding
                    MessageBox.Show("De gebruiker is verwijderd", "Verwijderd");
                }
                else
                {
                    //Error
                    MessageBox.Show("Gebruiker kon niet verwijderd worden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
