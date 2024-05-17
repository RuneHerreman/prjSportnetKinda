﻿using prjSportnetKinda.DA;
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
using System.Windows.Documents;

namespace prjSportnetKinda
{
    public partial class Main : Form
    {
        Model.Gebruiker gebruiker;

        //lijst om gehuurd materiaal in te plaatsen
        List<Materiaal> HuurList = new List<Materiaal>();
        List<int> MandjeAantalList = new List<int>();
        List<Training> TrainingList = new List<Training>();
        List<Gebruiker> GebruikerList = new List<Gebruiker>();

        public Main(Gebruiker login)
        {
            InitializeComponent();
            GebruikerList = GebruikerDA.OphalenGebruikers();
            int intJaar = DateTime.Now.Year;

            //het uiterlijk van de tabcontrol aanpassen
            //stijl van knoppen aanpassen
            tcMain.Appearance = TabAppearance.FlatButtons;
            //grootte van de knoppen aanpassen
            tcMain.ItemSize = new Size(0, 1);
            //manier waarop grootte bepaald wordt aanpassen
            tcMain.SizeMode = TabSizeMode.Fixed;

            //Refresh alle tabladen
            ArtikelRefresh();

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
            if(login.Profielfoto != null)
            {
                picProfielFoto.Image = login.Profielfoto;
            }
            if(login.Bannerfoto != null)
            {
                picBannerFoto.Image = login.Bannerfoto;
            }

            //Ben je renner?
            if (login.Renner)
            {
                lblCategorieKop.Text = "Categorie:";

                //Categorie berekenen
                int intLeeftijd = intJaar - login.Geboortedatum.Year;

                if (intLeeftijd <= 8)
                {
                    login.Categorie = "Miniem";
                }
                else if (intLeeftijd == 9 || intLeeftijd == 10)
                {
                    login.Categorie = "Pupil";
                }
                else if (intLeeftijd == 11 || intLeeftijd == 12)
                {
                    login.Categorie = "Scholier";
                }
                else if (intLeeftijd == 13 || intLeeftijd == 14)
                {
                    login.Categorie = "Cadet";
                }
                else if (intLeeftijd == 15 || intLeeftijd == 16)
                {
                    login.Categorie = "Jeugd";
                }
                else if (intLeeftijd == 17 || intLeeftijd == 18)
                {
                    login.Categorie = "Junior";
                }
                else
                {
                    login.Categorie = "Senior";
                }

                lblCategorie.Text = login.Categorie;
            }

            //Ben je beheerder?
            if (login.Beheerder)
            {
                btnBeheerdersinstellingen.Visible = true;
            }

            //Gegevens in het programma oplsaan
            gebruiker = login;
        }

        public void ArtikelRefresh()
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

        public void MateriaalRefresh() 
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

                    //Event toevoegen
                    item.ButtonClick += MateriaalItem_ButtonClick;

                    //artikel opvullen
                    item.MateriaalOpvullen(materiaal);

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

        //btnHuren on click:
        private void MateriaalItem_ButtonClick(object sender, EventArgs e)
        {
            //Omzetten van object naar MateriaalItem
            MateriaalItem item = (MateriaalItem)sender;
            //hoeveel keer is het artikel toegevoegd
            //voorraad en naam van gekozen artikel
            int intAantal = 1;
            int intVoorraad = item.materiaal.Voorraad;
            //index van naam materiaal
            int intMateriaalIndex = HuurList.IndexOf(item.materiaal);

            if (HuurList.IndexOf(item.materiaal) == -1)
            {
                //voeg toe aan lijst
                HuurList.Add(item.materiaal);

                //item komt 1 keer voor
                MandjeAantalList.Add(intAantal);
            }
            //je mag niet meer huren dan dat er voorraad is
            else if (MandjeAantalList[intMateriaalIndex] < intVoorraad)
            {
                //nieuwe hoeveelheid vinden
                int intNieuwAantal = (MandjeAantalList[intMateriaalIndex] + 1);
                //verwijder het vorige aantal
                MandjeAantalList.RemoveAt(intMateriaalIndex);
                //voeg het nieuwe aantal toe
                MandjeAantalList.Insert(intMateriaalIndex, intNieuwAantal);
            }
            else
            {
                MessageBox.Show("Niet genoeg voorraad", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Main meegeven bij het openen van NieuwArtikel
            NieuwArtikel nieuwartikel = new NieuwArtikel(this);
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

            if(btnWijzigenProfiel.Text != "Opslaan")
            {
                //Wachtwoord opvragen
                strWachtwoord = Interaction.InputBox("Geef je wachtoord in om je gegevens te wijzigen.", "Wachtwoord ingeven");

                if (strWachtwoord == gebruiker.Wachtwoord)
                {
                    //Textboxes tonen en opvullen om gegevens te wijzigen
                    txtVoornaam.Visible = true;
                    txtVoornaam.Text = lblVoornaam.Text;
                    txtNaam.Visible = true;
                    txtNaam.Text = lblNaam.Text;
                    txtAdres.Visible = true;
                    txtAdres.Text = lblAdres.Text;
                    txtGeboortedatum.Visible = true;
                    txtGeboortedatum.Text = lblGeboortedatum.Text;
                    txtGeslacht.Visible = true;
                    txtGeslacht.Text = lblGeslacht.Text;
                    txtTelefoonnr.Visible = true;
                    txtTelefoonnr.Text = lblTelefoon.Text;

                    //Opties voor foto's tonen
                    lblProfielFoto.Visible = true;
                    lblBannerFoto.Visible = true;
                    txtProfielFoto.Visible = true;
                    txtBannerFoto.Visible = true;
                    btnProfielFoto.Visible = true;
                    btnBannerFoto.Visible = true;

                    //Button veranderen naar opslaan button
                    btnWijzigenProfiel.Text = "Opslaan";
                }
                else
                {
                    //Messagebox
                    MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Wilt u deze gegevens opslaan?", "Gegevens aanpassen", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    //Controle op Lege velden
                    if (txtVoornaam.Text == null || txtNaam.Text == null || txtGeslacht.Text == null || txtAdres.Text == null || txtTelefoonnr.Text == null || txtGeboortedatum.Text == null)
                    {
                        //Foutmelding
                        MessageBox.Show("Vul alle velden correct in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            //Nieuwe gegevens opslaan
                            Gebruiker Aanpassingen = new Gebruiker();

                            Aanpassingen.Voornaam = txtVoornaam.Text;
                            Aanpassingen.Naam = txtNaam.Text;
                            Aanpassingen.Geslacht = txtGeslacht.Text;
                            Aanpassingen.Adres = txtAdres.Text;
                            Aanpassingen.Telefoonnummer = Convert.ToInt32(txtTelefoonnr.Text);
                            Aanpassingen.Geboortedatum = Convert.ToDateTime(txtGeboortedatum.Text);
                            Aanpassingen.Email = gebruiker.Email;
                            Aanpassingen.Profielfoto = picProfielFoto.Image;
                            Aanpassingen.Bannerfoto = picBannerFoto.Image;

                            //Gegevens aanpassen
                            Gebruiker wijzigen = GebruikerDA.Wijzigen(Aanpassingen);

                            if (wijzigen == null)
                            {
                                //Foutmelding
                                MessageBox.Show("Vul alle velden correct in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //Succes melding
                                MessageBox.Show("Je gegevens zijn aangepast");

                                //Variable aanpassen
                                gebruiker.Voornaam = Aanpassingen.Voornaam;
                                gebruiker.Naam = Aanpassingen.Naam;
                                gebruiker.Geslacht = Aanpassingen.Geslacht;
                                gebruiker.Adres = Aanpassingen.Adres;
                                gebruiker.Telefoonnummer = Aanpassingen.Telefoonnummer;
                                gebruiker.Geboortedatum = Aanpassingen.Geboortedatum;

                                //Labels updaten
                                lblNaamVoornaam.Text = "Welkom " + gebruiker.Voornaam + " " + gebruiker.Naam;
                                lblVoornaam.Text = gebruiker.Voornaam;
                                lblNaam.Text = gebruiker.Naam;
                                lblGeslacht.Text = gebruiker.Geslacht;
                                lblAdres.Text = gebruiker.Adres;
                                lblTelefoon.Text = gebruiker.Telefoonnummer.ToString();
                                lblEmail.Text = gebruiker.Email;
                                lblGeboortedatum.Text = gebruiker.Geboortedatum.ToString("d");
                                lblLidSinds.Text = gebruiker.Lidsinds.ToString("d");

                                //Textboxes legen en hidden
                                txtVoornaam.Visible = false;
                                txtVoornaam.Clear();
                                txtNaam.Visible = false;
                                txtNaam.Clear();
                                txtAdres.Visible = false;
                                txtAdres.Clear();
                                txtGeboortedatum.Visible = false;
                                txtGeboortedatum.Clear();
                                txtGeslacht.Visible = false;
                                txtGeslacht.Clear();
                                txtTelefoonnr.Visible = false;
                                txtTelefoonnr.Clear();

                                //Foto opties hiden
                                lblProfielFoto.Visible = false;
                                lblBannerFoto.Visible = false;
                                txtProfielFoto.Visible = false;
                                txtProfielFoto.Clear();
                                txtBannerFoto.Visible = false;
                                txtBannerFoto.Clear();
                                btnProfielFoto.Visible = false;
                                btnBannerFoto.Visible = false;

                                //Button veranderen naar opslaan button
                                btnWijzigenProfiel.Text = "Gegevens Wijzigen";
                            }
                        }
                        catch
                        {
                            //Foutmelding
                            MessageBox.Show("Vul alle velden correct in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnWinkelwagentje_Click(object sender, EventArgs e)
        {
            //open form van het mandje
            //geef HuurList en AantalLijst mee om de listview te kunnen opvullen, Main voor de refresh van het materiaal
            frmMandje mandje = new frmMandje(HuurList, MandjeAantalList, gebruiker, this);
            mandje.ShowDialog();
        }

        private void mcalKalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            //legen
            lsvTraining.Items.Clear();

            DateTime dtSelectedDateStart = mcalKalender.SelectionStart;
            DateTime dtSelectedDateEnd = mcalKalender.SelectionEnd;
            TrainingList = TrainingDA.OphalenTraining(dtSelectedDateStart, dtSelectedDateEnd);
            foreach (Training t in TrainingList)
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new String[] { t.Datum.ToString("g"), t.Locatie, t.Categorie });
                item.Tag = t;
                lsvTraining.Items.Add(item);
            }
        }

        private void lblBeheer_Click(object sender, EventArgs e)
        {
            MateriaalBeheer beheer = new MateriaalBeheer(this);
            beheer.ShowDialog();
        }

        private void btnBeheerdersinstellingen_Click(object sender, EventArgs e)
        {
            string strWachtwoord;

            //Wachtwoord opvragen
            strWachtwoord = Interaction.InputBox("Geef je wachtoord in om je gegevens te wijzigen.", "Wachtwoord ingeven");

            if(strWachtwoord == gebruiker.Wachtwoord)
            {
                //Nieuw form openen
                Wijzigen Wijzigen = new Wijzigen();
                Wijzigen.ShowDialog();
            }
            else
            {
                //Fout wachtwoord
                MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<String> DeelnemersBenoemen(Training training)
        {
            //om deelnemers in te plaatsen
            List<string> DeelnemersList = new List<string>();

            //is er een index, Error voorkomen
            if (lsvTraining.SelectedIndices.Count == 0)
            {
                return DeelnemersList;
            }
            
            //IDs uit de string halen, ze worden opgesplits door een streepje, die halen we hier weg
            String[] arrStringDeelnemers = training.Deelnemers.Split('-');

            //voor ieder ID van de deelnemers, loop door de gebruikers om te zien of er een match is
            foreach (string deelnemerID in arrStringDeelnemers)
            {
                foreach (Gebruiker gebruiker in GebruikerList)
                {
                    //voor- en achternaam toevoegen aan de lijst
                    if (deelnemerID == gebruiker.GebruikerID.ToString())
                    {
                        DeelnemersList.Add(gebruiker.Voornaam.ToString() + " " + gebruiker.Naam.ToString());
                    }
                }
            }

            return DeelnemersList;
        }
        private void lsvTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            //om label in te vullen later
            string strDeelnemers = "";

            //is er een index, Error voorkomen
            if (lsvTraining.SelectedIndices.Count == 0)
            {
                return;
            }

            //geselecteerde training terugvinden en opslaan
            Training training = TrainingList[lsvTraining.SelectedIndices[0]];

            //deelnemers benoemen
            List<string> DeelnemersList = DeelnemersBenoemen(training);

            //de eerste 3 nemen uit de lijst
            int intTellerMAX;
            if (DeelnemersList.Count < 3) //zijn er niet 3 of meer deelnemers?
            {
                intTellerMAX = DeelnemersList.Count;
            }
            else //meer of gelijk aan 3 deelnemers?
            {
                intTellerMAX = 3;
            }
            //zet de variabele gelijk aan de eerste drie deelnemers
            for (int intTeller = 0; intTeller < intTellerMAX; intTeller++)
            {
                if (strDeelnemers != "")
                {
                    strDeelnemers = strDeelnemers + ", " + DeelnemersList[intTeller];
                }
                else
                {
                    strDeelnemers = DeelnemersList[intTeller];
                }
            }
            //aantonen dat er meer te zien is
            strDeelnemers = strDeelnemers + ", ...";

            lblTrainingCategorie.ResetText();
            lblTrainingDeelnemers.ResetText();
            lblTrainingDuur.ResetText();
            lblTrainingLocatie.ResetText();
            lblTrainingStart.ResetText();
            lblTrainingTrainer.ResetText();

            //labels opvullen
            lblTrainingCategorie.Text = training.Categorie;
            lblTrainingStart.Text = training.Datum.ToString("HH:mm:ss");
            lblTrainingLocatie.Text = training.Locatie;
            lblTrainingTrainer.Text = training.Trainer;
            lblTrainingDeelnemers.Text = strDeelnemers;
        }

        private void btnDeelnemen_Click(object sender, EventArgs e)
        {
            if (lsvTraining.SelectedItems.Count != 0)
            {
                //geselecteerde training terugvinden en opslaan
                Training training = TrainingList[lsvTraining.SelectedIndices[0]];
                //add userID to the 'Deelnemers' Column
                TrainingDA.DeelnemerToevoegen(training.TrainingID, gebruiker.GebruikerID);
            }
            else
            {
                MessageBox.Show("Je hebt niets geselecteerd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblTrainingDeelnemers_Click(object sender, EventArgs e)
        {
            //om de deelnemers in te plaatsen
            string strDeelnemers = "";

            //is er een index, Error voorkomen
            if (lsvTraining.SelectedIndices.Count == 0)
            {
                return;
            }

            //lijst van deelnemers toevoegen aan messagebox
            foreach (string Deelnemer in DeelnemersBenoemen(TrainingList[lsvTraining.SelectedIndices[0]]))
            {
                strDeelnemers = strDeelnemers + Deelnemer + Environment.NewLine;
            }
            //alle deelnemers weergeven
            MessageBox.Show(strDeelnemers, "Deelnemers");
        }

        //onderlijn de label
        private void lblTrainingDeelnemers_MouseEnter(object sender, EventArgs e)
        {
            lblTrainingDeelnemers.Font = new Font(lblTrainingDeelnemers.Font, FontStyle.Underline);
        }

        //stop onderlijn de label
        private void lblTrainingDeelnemers_MouseLeave(object sender, EventArgs e)
        {
            lblTrainingDeelnemers.Font = new Font(lblTrainingDeelnemers.Font, FontStyle.Regular);
        }

        private void btnProfielFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //openfiledialog = ofdFoto
                ofdFotos.Title = "Selecteer een bestand";
                ofdFotos.FileName = string.Empty;
                ofdFotos.ShowHelp = false;
                ofdFotos.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.JPG;*.PNG;*JPEG";
                //open de verkenner
                DialogResult result = ofdFotos.ShowDialog();
                //als je niet op cancel klikt:
                if (result != DialogResult.Cancel)
                {
                    //textbox opvullen met bestandspad
                    txtProfielFoto.Text = ofdFotos.FileName;
                    //preview weergeven
                    picProfielFoto.ImageLocation = ofdFotos.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnBannerFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //openfiledialog = ofdFoto
                ofdFotos.Title = "Selecteer een bestand";
                ofdFotos.FileName = string.Empty;
                ofdFotos.ShowHelp = false;
                ofdFotos.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.JPG;*.PNG;*JPEG";
                //open de verkenner
                DialogResult result = ofdFotos.ShowDialog();
                //als je niet op cancel klikt:
                if (result != DialogResult.Cancel)
                {
                    //textbox opvullen met bestandspad
                    txtBannerFoto.Text = ofdFotos.FileName;
                    //preview weergeven
                    picBannerFoto.ImageLocation = ofdFotos.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
