using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
using prjSportnetKinda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjSportnetKinda
{
    public partial class Main : Form
    {
        Model.Gebruiker gebruiker;
        public Main(Gebruiker login, int tab)
        {
            InitializeComponent();

            gebruiker = login;

            //het uiterlijk van de tabcontrol aanpassen
            //stijl van knoppen aanpassen
            tcMain.Appearance = TabAppearance.FlatButtons;
            //grootte van de knoppen aanpassen
            tcMain.ItemSize = new Size(0, 1);
            //manier waarop grootte bepaald wordt aanpassen
            tcMain.SizeMode = TabSizeMode.Fixed;

            //Refresh alle tabladen
            ArtikelRefresh();
            MateriaalRefresh();
            

            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_select;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_select;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            //Welkom text invullen
            this.lblNaamVoornaam.Text = "Welkom " + login.Voornaam + " " + login.Naam;

            //Profiel invullen
            lblVoornaam.Text = login.Voornaam;
            lblNaam.Text = login.Naam;
            lblGeslacht.Text = login.Geslacht;
            lblAdres.Text = login.Adres;
            lblTelefoon.Text = login.Telefoonnummer.ToString();
            lblEmail.Text = login.Email;
            lblGeboortedatum.Text = login.Geboortedatum.ToString("d");
            lblLidSinds.Text = login.Lidsinds.ToString("d");

            //Ben je renner?
            if (login.Renner == 1)
            {
                lblCategorieKop.Text = "Categorie:";
                //lblCategorie.Text = login.Categorie;
            }
            //Ben je beheerder?
            if (login.Beheerder == 1)
            {
                btnBeheerdersinstellingen.Visible = true;
            }
            /////////////////////////////////////////////////////////////Vragen aan Lars wat deze doet. Werkelijk geen flauw idee (Rune)
            if (tab == 4)
            {
                tcMain.SelectTab(tabProfiel);
            }
        }

        private void ArtikelRefresh()
        {
            try
            {
                //leeg flowlayoutpanel
                fpnlArtiekelContainer.Controls.Clear();
                //een userControl maken voor iedere rij in de lijst van artikelen
                foreach (Artikel artikel in ArtikelDA.OphalenArtikel())
                {
                    //object maken van de userControl
                    WelkomItem item = new WelkomItem();

                    //artikel opvullen
                    WelkomItem.ArtikelOpvullen(artikel.titel, artikel.artikel, artikel.datum, item, artikel.foto);

                    //huidig artikel toevoegen aan fpnl
                    fpnlArtiekelContainer.Controls.Add(item);
                }
            }
            catch (Exception exc)
            {
                //bij error toon de foutmelding
                MessageBox.Show(exc.Message);
            }
        }

        private void MateriaalRefresh() 
        {
            try
            {
                //leeg fpnl
                fpnlMateriaalContainer.Controls.Clear();
                //een userControl maken voor iedere rij in de lijst van materiaal
                foreach (Materiaal materiaal in MateriaalDA.OphalenMateriaal())
                {
                    //object maken van de userControl
                    MateriaalItem item = new MateriaalItem();

                    //artikel opvullen
                    MateriaalItem.MateriaalOpvullen(materiaal.Naam, materiaal.Beschrijving, item, materiaal.Foto, materiaal.ID);

                    //huidig artikel toevoegen aan fpnl
                    fpnlMateriaalContainer.Controls.Add(item);
                }
            }
            catch (Exception exc)
            {
                //bij error toon de foutmelding
                MessageBox.Show(exc.Message);
            }
        }

        private void KalenderRefresh()
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //verander tab
            tcMain.SelectTab(tabStart);

            //toon alleen geselecteerde tab
            //foto veranderen van kleur en de achtergrond donkerder maken om aan te tonen welke geselecteerd is
            this.btnStart.NormaalFoto1 = Properties.Resources.home_select;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;

            //refresh
            ArtikelRefresh();
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            //verander tab
            tcMain.SelectTab(tabKalender);

            //toon alleen geselecteerde tab
            //foto veranderen van kleur en de achtergrond donkerder maken om aan te tonen welke geselecteerd is
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_select;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            //Refresh
            MateriaalRefresh();

            //verander tab
            tcMain.SelectTab(tabMateriaal);

            //toon alleen geselecteerde tab
            //foto veranderen van kleur en de achtergrond donkerder maken om aan te tonen welke geselecteerd is
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_select;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            //toon alleen geselecteerde tab
            //foto veranderen van kleur en de achtergrond donkerder maken om aan te tonen welke geselecteerd is
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_select;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
            //verander tab
            tcMain.SelectTab(tabProfiel);
        }

        private void btnArtiekelToevoegen_Click(object sender, EventArgs e)
        {
            NieuwArtikel nieuwartikel = new NieuwArtikel();
            nieuwartikel.ShowDialog();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            //ga naar Login
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnAccountVerwijderen_Click(object sender, EventArgs e)
        {
            //var decl
            string strWachtwoord;

            //navragen op keuze met Dialogresult
            DialogResult dialogresult = new DialogResult();
            dialogresult = MessageBox.Show("Weet je zeker dat je je account wilt verwijderen?", "Account verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Als DialogResult ja is: wachtwoord vragen
            if (dialogresult == DialogResult.Yes)
            {
                strWachtwoord = Interaction.InputBox("Geef je wachtoord in om je account te verwijderen.", "Wachtwoord ingeven");

                if(strWachtwoord == gebruiker.Wachtwoord)
                {
                    Gebruiker verwijderen = GebruikerDA.Verwijderen(gebruiker.Email);

                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnWijzigenProfiel_Click(object sender, EventArgs e)
        {
            //var decl
            string strWachtwoord;

            strWachtwoord = Interaction.InputBox("Geef je wachtoord in om je gegevens te wijzigen.", "Wachtwoord ingeven");

            if (strWachtwoord == gebruiker.Wachtwoord)
            {
                Wijzigen wijzigen = new Wijzigen(gebruiker);
                wijzigen.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWinkelwagentje_Click(object sender, EventArgs e)
        {
            //open form van het mandje
            Mandje mandje = new Mandje();
            mandje.ShowDialog();
        }

        private void mcalKalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            //legen
            lsvTraining.Items.Clear();

            DateTime dtSelectedDateStart = mcalKalender.SelectionStart;
            DateTime dtSelectedDateEnd = mcalKalender.SelectionEnd;

            foreach (Training t in TrainingDA.OphalenTraining(dtSelectedDateStart, dtSelectedDateEnd))
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new String[] { t.Datum.ToString("g"), t.Locatie, t.Categorie });
                item.Tag = t;
                lsvTraining.Items.Add(item);
            }
        }
    }
}
