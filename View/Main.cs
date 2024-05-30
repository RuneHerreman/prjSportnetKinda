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
using System.Windows.Documents;

namespace prjSportnetKinda
{
    public partial class Main : Form
    {
        Gebruiker gebruiker;
        Activiteit activiteit;

        //lijst om gehuurd materiaal in te plaatsen
        List<Materiaal> HuurList = new List<Materiaal>();
        List<int> MandjeAantalList = new List<int>();

        //Lijst voor activiteiten in op te slaan
        List<Activiteit> ActiviteitList = new List<Activiteit>();

        public Main(Gebruiker login)
        {
            InitializeComponent();

            //Gegevens in het programma oplsaan
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

            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_select;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_select;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            //Welkom text invullen
            this.lblNaamVoornaam.Text = "Welkom " + gebruiker.Voornaam + " " + gebruiker.Naam;

            //Activiteiten voor de komende 30 dagen tonen
            KomendeDagen();

            //Profiel invullen
            lblVoornaam.Text = gebruiker.Voornaam;
            lblNaam.Text = gebruiker.Naam;
            lblGeslacht.Text = gebruiker.Geslacht;
            lblAdres.Text = gebruiker.Adres;
            lblTelefoon.Text = gebruiker.Telefoonnummer.ToString();
            lblEmail.Text = gebruiker.Email;
            lblGeboortedatum.Text = gebruiker.Geboortedatum.ToString("d");
            lblLidSinds.Text = gebruiker.Lidsinds.ToString("d");
            if(gebruiker.Profielfoto != null)
            {
                picProfielFoto.Image = gebruiker.Profielfoto;
            }
            if(gebruiker.Bannerfoto != null)
            {
                picBannerFoto.Image = gebruiker.Bannerfoto;
            }

            //Ben je renner?
            if (gebruiker.Renner)
            {
                lblCategorieKop.Text = "Categorie:";

                CategorieBerekenen(gebruiker);

                btnDeelnemen.Visible = true;
            }

            //Ben je trainer?
            if (gebruiker.Trainer)
            {
                btnActiviteitToevoegen.Visible = true;
                btnWijzigenActiviteit.Visible = true;

                //Button opschuiven in geval van ook renner
                if (gebruiker.Renner)
                {
                    btnWijzigenActiviteit.Location = new Point(240, 300);
                }
            }

            //Ben je beheerder?
            if (gebruiker.Beheerder)
            {
                btnBeheerdersinstellingen.Visible = true;
                btnArtiekelToevoegen.Visible = true;
                btnActiviteitToevoegen.Visible = true;
                btnWijzigenActiviteit.Visible = true;
                btnBeheer.Visible = true;
                btnBeheer.Visible = true;

                //Button opschuiven in geval van ook renner
                if (gebruiker.Renner)
                {
                    btnWijzigenActiviteit.Location = new Point(240, 300);
                }
            }
        }

        public void KomendeDagen()
        {
            lsvTraining.Items.Clear();
            ActiviteitList.Clear();

            DateTime dtSelectedDateStart = DateTime.Now;
            DateTime dtSelectedDateEnd = DateTime.Now.AddDays(30);

            //Activiteiten tonen in listview
            foreach (Activiteit a in ActiviteitDA.OphalenActiviteiten(dtSelectedDateStart, dtSelectedDateEnd))
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new String[] {a.Datum.ToString("d"), a.Type, a.Datum.ToString("HH:mm:ss") });
                item.Tag = a;
                lsvTraining.Items.Add(item);

                ActiviteitList.Add(a);
            }
        }

        public void CategorieBerekenen(Gebruiker g)
        {
            int intJaar = DateTime.Now.Year;

            //Categorie berekenen
            int intLeeftijd = intJaar - g.Geboortedatum.Year;

            if (intLeeftijd <= 8)
            {
                g.Categorie = "Miniem";
            }
            else if (intLeeftijd == 9 || intLeeftijd == 10)
            {
                g.Categorie = "Pupil";
            }
            else if (intLeeftijd == 11 || intLeeftijd == 12)
            {
                g.Categorie = "Scholier";
            }
            else if (intLeeftijd == 13 || intLeeftijd == 14)
            {
                g.Categorie = "Cadet";
            }
            else if (intLeeftijd == 15 || intLeeftijd == 16)
            {
                g.Categorie = "Jeugd";
            }
            else if (intLeeftijd == 17 || intLeeftijd == 18)
            {
                g.Categorie = "Junior";
            }
            else
            {
                g.Categorie = "Senior";
            }

            lblCategorie.Text = g.Categorie;

            gebruiker.Categorie = g.Categorie;
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
        public void TelAanpassen()
        {
            int intMandjeTel = 0;
            foreach (int aantal in MandjeAantalList)
            {
                intMandjeTel = intMandjeTel + aantal;
            }
            lblMandjeTel.Text = intMandjeTel.ToString();
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

            //label bij mandje aanpassen
            TelAanpassen();
        }

        private void KalenderRefresh()
        {
            //Listview updaten
            if (lblActiviteiten.Text == "Activiteiten komende 30 dagen:")
            {
                KomendeDagen();
            }
            else
            {
                //legen
                lsvTraining.Items.Clear();
                ActiviteitList.Clear();

                //Activiteiten invullen
                DateTime dtSelectedDateStart = mcalKalender.SelectionStart;
                DateTime dtSelectedDateEnd = mcalKalender.SelectionEnd;
                foreach (Activiteit a in ActiviteitDA.OphalenActiviteiten(dtSelectedDateStart, dtSelectedDateEnd))
                {
                    System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new String[] { a.Datum.ToString("d"), a.Type, a.Locatie });
                    item.Tag = a;
                    lsvTraining.Items.Add(item);

                    ActiviteitList.Add(a);
                }

                //Label aanpassen en button tonen
                lblActiviteiten.Text = $"Activiteiten op {dtSelectedDateStart.ToString("d")}";
                btnKomendeDagen.Visible = true;
            }
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
            ArtikelBeheer artikelBeheer = new ArtikelBeheer(this);
            artikelBeheer.Show();
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
            //Controleren of het admin account is
            if(gebruiker.GebruikerID != 1)
            {
                //navragen op keuze met Dialogresult
                DialogResult dialogresult = MessageBox.Show("Weet je zeker dat je je account wilt verwijderen?", "Account verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                //Als DialogResult ja is: wachtwoord vragen
                if (dialogresult == DialogResult.Yes)
                {
                    strWachtwoord = Interaction.InputBox("Geef je wachtoord in om je account te verwijderen.", "Wachtwoord ingeven");

                    if (strWachtwoord == gebruiker.Wachtwoord)
                    {
                        if (GebruikerDA.Verwijderen(gebruiker.Email) != null)
                        {
                            Login login = new Login();
                            this.Hide();
                            login.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Er is een fout opgetreden.\nAccount kan niet verwijderd worden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Je mag dit account niet verwijderen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmbGeslacht.Visible = true;
                    cmbGeslacht.Text = lblGeslacht.Text;
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
                    if (txtVoornaam.Text == "" || txtNaam.Text == "" || cmbGeslacht.Text == "" || txtAdres.Text == "" || txtTelefoonnr.Text == "" || txtGeboortedatum.Text == "")
                    {
                        //Foutmelding
                        MessageBox.Show("Je moet alle velden invullen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            //Nieuwe gegevens opslaan
                            Gebruiker Aanpassingen = new Gebruiker();

                            Aanpassingen.Voornaam = txtVoornaam.Text;
                            Aanpassingen.Naam = txtNaam.Text;
                            Aanpassingen.Geslacht = cmbGeslacht.Text;
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

                                //Categorie aanpassen
                                if (gebruiker.Renner)
                                {
                                    CategorieBerekenen(gebruiker);
                                }
                                
                                //Textboxes legen en hidden
                                txtVoornaam.Visible = false;
                                txtVoornaam.Clear();
                                txtNaam.Visible = false;
                                txtNaam.Clear();
                                txtAdres.Visible = false;
                                txtAdres.Clear();
                                txtGeboortedatum.Visible = false;
                                txtGeboortedatum.Clear();
                                cmbGeslacht.Visible = false;
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
            ActiviteitList.Clear();

            //Activiteiten invullen
            DateTime dtSelectedDateStart = mcalKalender.SelectionStart;
            DateTime dtSelectedDateEnd = mcalKalender.SelectionEnd;
            foreach (Activiteit a in ActiviteitDA.OphalenActiviteiten(dtSelectedDateStart, dtSelectedDateEnd))
            {
                System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(new String[] { a.Datum.ToString("d"), a.Type, a.Locatie });
                item.Tag = a;
                lsvTraining.Items.Add(item);

                ActiviteitList.Add(a);
            }

            //Label aanpassen en button tonen
            lblActiviteiten.Text = $"Activiteiten op {dtSelectedDateStart.ToString("d")}";
            btnKomendeDagen.Visible = true;
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

        private void lsvTraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Var decl
            int intTellerMAX;
            bool MeerDeelnemers = false;
            string strDeelnemers = ""; //om label in te vullen later

            //is er een index, Error voorkomen
            if (lsvTraining.SelectedIndices.Count == 0)
            {
                return;
            }
            
            //Alle gegevens ophalen aan de hand van Type activiteit
            Activiteit a = ActiviteitDA.AllesOphalen(ActiviteitList[lsvTraining.SelectedIndices[0]]);

            //Gegevens invullen
            if(a != null)
            {
                lblType.Text = a.Type;
                lblDatum.Text = a.Datum.ToString("d");
                lblStart.Text = a.Datum.ToString("HH:mm:ss");
                lblLocatie.Text = a.Locatie;
                lblDuur.Text = a.Duur.ToString() + " min";

                if (a.Training != null)
                {
                    lblInfo1Kop.Text = "Categoieën:";
                    lblInfo2Kop.Text = "Trainer:";
                    lblInfo3Kop.Text = "Beschrijving:";

                    lblInfo1.Text = a.Training.Categorieën;
                    lblInfo2.Text = a.Training.Trainer;
                    lblInfo3.Text = a.Training.Beschrijving;
                }
                else if (a.Wedstrijd != null)
                {
                    lblInfo1Kop.Text = "Naam wedstrijd:";
                    lblInfo2Kop.Text = "Type:";
                    lblInfo3Kop.Text = "Organisator:";

                    lblInfo1.Text = a.Wedstrijd.Naam;
                    lblInfo2.Text = a.Wedstrijd.Type;
                    lblInfo3.Text = a.Wedstrijd.Organisator;
                }
                else if (a.Feest != null)
                {
                    lblInfo1Kop.Text = "Organisator:";
                    lblInfo2Kop.Text = "Eten:";
                    lblInfo3Kop.Text = "Beschrijving:";

                    lblInfo1.Text = a.Feest.Organisator;
                    if (a.Feest.Eten)
                    {
                        lblInfo2.Text = "Eten voorzien";
                    }
                    else
                    {
                        lblInfo2.Text = "Geen eten voorzien";
                    }
                    lblInfo3.Text = a.Feest.Beschrijving;
                }

                //de eerste 3 nemen uit de lijst
                if (a.Deelnemers.Count <= 3) //zijn er niet 3 of meer deelnemers?
                {
                    intTellerMAX = a.Deelnemers.Count;
                }
                else //meer dan 3 deelnemers?
                {
                    intTellerMAX = 3;
                    MeerDeelnemers = true;
                }

                //zet de variabele gelijk aan de eerste drie deelnemers
                for (int intTeller = 0; intTeller < intTellerMAX; intTeller++)
                {
                    if (strDeelnemers != "")
                    {
                        strDeelnemers = strDeelnemers + ", " + a.Deelnemers[intTeller].Voornaam + " " + a.Deelnemers[intTeller].Naam;
                    }
                    else
                    {
                        strDeelnemers = a.Deelnemers[intTeller].Voornaam + " " + a.Deelnemers[intTeller].Naam;
                    }
                }

                //aantonen dat er meer te zien is
                if(MeerDeelnemers)
                {
                    strDeelnemers = strDeelnemers + ", ...";
                }

                lblDeelnemers.Text = strDeelnemers;

                //Button aanpassen voor mocht je al ingeschreven zijn
                if(a.Deelnemers.Any(x => x.GebruikerID == gebruiker.GebruikerID))
                {
                    btnDeelnemen.Text = "Niet meer deelnemen";
                }
                else
                {
                    btnDeelnemen.Text = "Deelnemen";
                }

                //Panel tonen
                pnlActiviteitInfo.Visible = true;

                //Activiteit opslaan in variable
                activiteit = a;
            }
        }

        private void btnDeelnemen_Click(object sender, EventArgs e)
        {
            if(btnDeelnemen.Text == "Deelnemen")
            {
                //add userID to the 'Deelnemers' Column
                ActiviteitDA.DeelnemerToevoegen(activiteit.ActiviteitID, gebruiker.GebruikerID);

                //Messagebox
                MessageBox.Show("Je neemt nu deel aan deze activiteit");

                //Naam button veranderen
                btnDeelnemen.Text = "Niet meer deelnemen";

                //Lijst updaten voor Deelnemers knop
                activiteit = ActiviteitDA.AllesOphalen(activiteit);
            }
            else
            {
                //add userID to the 'Deelnemers' Column
                ActiviteitDA.DeelnemerVerwijderen(activiteit.ActiviteitID, gebruiker.GebruikerID);

                //Messagebox
                MessageBox.Show("je neemt niet meer deel aan deze activiteit.");

                //Naam button veranderen
                btnDeelnemen.Text = "Deelnemen";

                //Lijst updaten voor Deelnemers knop
                activiteit = ActiviteitDA.AllesOphalen(activiteit);
            }

            //Deelnemers label updaten
            //Var decl
            string strDeelnemers = "";
            int intTellerMAX;
            bool MeerDeelnemers = false;

            //Alle gegevens ophalen aan de hand van Type activiteit
            Activiteit a = ActiviteitDA.AllesOphalen(activiteit);

            //de eerste 3 nemen uit de lijst
            if (a.Deelnemers.Count <= 3) //zijn er niet 3 of meer deelnemers?
            {
                intTellerMAX = a.Deelnemers.Count;
            }
            else //meer dan 3 deelnemers?
            {
                intTellerMAX = 3;
                MeerDeelnemers = true;
            }

            //zet de variabele gelijk aan de eerste drie deelnemers
            for (int intTeller = 0; intTeller < intTellerMAX; intTeller++)
            {
                if (strDeelnemers != "")
                {
                    strDeelnemers = strDeelnemers + ", " + a.Deelnemers[intTeller].Voornaam + " " + a.Deelnemers[intTeller].Naam;
                }
                else
                {
                    strDeelnemers = a.Deelnemers[intTeller].Voornaam + " " + a.Deelnemers[intTeller].Naam;
                }
            }

            //aantonen dat er meer te zien is
            if (MeerDeelnemers)
            {
                strDeelnemers = strDeelnemers + ", ...";
            }

            lblDeelnemers.Text = strDeelnemers;
        }

        private void lblTrainingDeelnemers_Click(object sender, EventArgs e)
        {
            //Om de deelnemers in te plaatsen
            string strDeelnemers = "";

            //lijst van deelnemers toevoegen aan messagebox
            foreach (Gebruiker Deelnemer in activiteit.Deelnemers)
            {
                strDeelnemers = strDeelnemers + Deelnemer.Voornaam + " " + Deelnemer.Naam + Environment.NewLine;
            }
            //alle deelnemers weergeven
            MessageBox.Show(strDeelnemers, "Deelnemers");
        }

        //onderlijn de label
        private void lblTrainingDeelnemers_MouseEnter(object sender, EventArgs e)
        {
            lblDeelnemers.Font = new Font(lblDeelnemers.Font, FontStyle.Underline);
        }

        //stop onderlijn de label
        private void lblTrainingDeelnemers_MouseLeave(object sender, EventArgs e)
        {
            lblDeelnemers.Font = new Font(lblDeelnemers.Font, FontStyle.Regular);
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

        private void btnKomendeDagen_Click(object sender, EventArgs e)
        {
            //Komende 30 dagen tonen
            KomendeDagen();

            //Text aanpassen en button hidden
            lblActiviteiten.Text = "Activiteiten komende 30 dagen:";
            btnKomendeDagen.Visible = false;
        }

        private void btnWijzigenActiviteit_Click(object sender, EventArgs e)
        {
            if (btnWijzigenActiviteit.Text != "Opslaan")
            {
                //Tekstboxes tonen
                txtDatum.Visible = true;
                txtStart.Visible = true;
                txtLocatie.Visible = true;
                txtDuur.Visible = true;
                txtInfo1.Visible = true;
                if (activiteit.Type == "Feest")
                {
                    chkEten.Visible = true;
                    lblInfo2.Visible = false;
                }
                else
                {
                    txtInfo2.Visible = true;
                }
                txtInfo3.Visible = true;
                lblDeelnemers.Enabled = false;
                mcalKalender.Enabled = false;
                lsvTraining.Enabled = false;
                btnDeelnemen.Enabled = false;
                btnDeelnemen.BackColor = Color.Gray;
                btnActiviteitToevoegen.Enabled = false;
                btnKomendeDagen.Enabled = false;
                btnActiviteitVerwijderen.Visible = true;

                //Textboxes invullen
                txtDatum.Text = lblDatum.Text;
                txtStart.Text = lblStart.Text;
                txtLocatie.Text = lblLocatie.Text;
                txtDuur.Text = lblDuur.Text.Replace(" min", "");
                txtInfo1.Text = lblInfo1.Text;
                if (activiteit.Type == "Feest")
                {
                    if (lblInfo2.Text == "Eten voorzien")
                    {
                        chkEten.Checked = true;
                    }
                    else
                    {
                        chkEten.Checked = false;
                    }
                }
                txtInfo2.Text = lblInfo2.Text;
                txtInfo3.Text = lblInfo3.Text;

                //Button veranderen naar opslaan button
                btnWijzigenActiviteit.Text = "Opslaan";
            }
            else
            {
                //Vragen of ze zeker willen aanpassen
                DialogResult result = MessageBox.Show("Wilt u deze gegevens opslaan?", "Gegevens aanpassen", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Controle op lege velden
                    if(txtDatum.Text == "" || txtStart.Text == "" || txtLocatie.Text == "" || txtDuur.Text == "" || txtInfo1.Text == "" || txtInfo2.Text == "" || txtInfo3.Text == "")
                    {
                        //Foutmelding
                        MessageBox.Show("Je moet alle velden invullen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            //Nieuwe gegevens oplslaan
                            Activiteit Activiteit = new Activiteit();

                            Activiteit.ActiviteitID = activiteit.ActiviteitID;
                            Activiteit.Datum = Convert.ToDateTime(txtDatum.Text).Date.Add(Convert.ToDateTime(txtStart.Text).TimeOfDay);
                            Activiteit.Locatie = txtLocatie.Text;
                            Activiteit.Duur = Convert.ToInt32(txtDuur.Text);

                            //gegevens afhankelijk van type
                            if(lblType.Text == "Training")
                            {
                                Activiteit.Training = new Training();

                                Activiteit.Training.Categorieën = txtInfo1.Text;
                                Activiteit.Training.Trainer = txtInfo2.Text;
                                Activiteit.Training.Beschrijving = txtInfo3.Text;
                            }
                            else if (lblType.Text == "Wedstrijd")
                            {
                                Activiteit.Wedstrijd = new Wedstrijd();

                                Activiteit.Wedstrijd.Naam = txtInfo1.Text;
                                Activiteit.Wedstrijd.Type = txtInfo2.Text;
                                Activiteit.Wedstrijd.Organisator = txtInfo3.Text;
                            }
                            else if (lblType.Text == "Feest")
                            {
                                Activiteit.Feest = new Feest();

                                Activiteit.Feest.Organisator = txtInfo1.Text;
                                Activiteit.Feest.Eten = Convert.ToBoolean(chkEten.Checked);
                                Activiteit.Feest.Beschrijving = txtInfo3.Text;
                            }

                            if (ActiviteitDA.ActiviteitWijzigen(Activiteit) != null)
                            {
                                //Succes melding
                                MessageBox.Show("De activiteit is aangepast");

                                //Labels uptdaten
                                lblDatum.Text = Activiteit.Datum.ToString("d");
                                lblStart.Text = Activiteit.Datum.ToString("HH:mm:ss");
                                lblLocatie.Text = Activiteit.Locatie;
                                lblDuur.Text = Activiteit.Duur.ToString() + " min";

                                if (Activiteit.Training != null)
                                {
                                    lblInfo1.Text = Activiteit.Training.Categorieën;
                                    lblInfo2.Text = Activiteit.Training.Trainer;
                                    lblInfo3.Text = Activiteit.Training.Beschrijving;
                                }
                                else if (Activiteit.Wedstrijd != null)
                                {
                                    lblInfo1.Text = Activiteit.Wedstrijd.Naam;
                                    lblInfo2.Text = Activiteit.Wedstrijd.Type;
                                    lblInfo3.Text = Activiteit.Wedstrijd.Organisator;
                                }
                                else if (Activiteit.Feest != null)
                                {
                                    lblInfo1.Text = Activiteit.Feest.Organisator;
                                    if (Activiteit.Feest.Eten)
                                    {
                                        lblInfo2.Text = "Eten voorzien";
                                    }
                                    else
                                    {
                                        lblInfo2.Text = "Geen eten voorzien";
                                    }
                                    lblInfo3.Text = Activiteit.Feest.Beschrijving;
                                }

                                //Textboxes retten
                                txtDatum.Visible = false;
                                txtStart.Visible = false;
                                txtLocatie.Visible = false;
                                txtDuur.Visible = false;
                                txtInfo1.Visible = false;
                                txtInfo2.Visible = false;
                                txtInfo3.Visible = false;
                                chkEten.Visible = false;
                                lblInfo2.Visible = true;

                                txtDatum.Clear();
                                txtStart.Clear();
                                txtLocatie.Clear();
                                txtDuur.Clear();
                                txtInfo1.Clear();
                                txtInfo2.Clear();
                                txtInfo3.Clear();

                                //Buttons en labels enabellen
                                lblDeelnemers.Enabled = true;
                                mcalKalender.Enabled = true;
                                lsvTraining.Enabled = true;
                                btnDeelnemen.Enabled = true;
                                btnDeelnemen.BackColor = Color.Green;
                                btnActiviteitToevoegen.Enabled = true;
                                btnKomendeDagen.Enabled = true;
                                btnActiviteitVerwijderen.Visible = false;
                                btnWijzigenActiviteit.Text = "Wijzigen";

                                //Form updaten
                                KalenderRefresh();
                            }
                            else
                            {
                                //Foutmelding
                                MessageBox.Show("Er is een fout opgetreden, kan acticiteit niet aanpassen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnActiviteitVerwijderen_Click(object sender, EventArgs e)
        {
            //var decl
            string strWachtwoord;

            //navragen op keuze met Dialogresult
            DialogResult dialogresult = MessageBox.Show("Weet je zeker dat je deze activiteit wilt verwijderen?", "Activiteit verwijderen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Als DialogResult ja is: wachtwoord vragen
            if (dialogresult == DialogResult.Yes)
            {
                //Wachtwoord opvragen
                strWachtwoord = Interaction.InputBox("Geef je wachtoord in om deze activiteit te verwijderen.", "Wachtwoord ingeven");

                if (strWachtwoord == gebruiker.Wachtwoord)
                {
                    if (ActiviteitDA.ActiviteitVerwijderen(activiteit) != null)
                    {
                        MessageBox.Show("Activiteit is verwijderd");

                        //Form resetten
                        //Textboxes retten
                        txtDatum.Visible = false;
                        txtStart.Visible = false;
                        txtLocatie.Visible = false;
                        txtDuur.Visible = false;
                        txtInfo1.Visible = false;
                        txtInfo2.Visible = false;
                        txtInfo3.Visible = false;

                        txtDatum.Clear();
                        txtStart.Clear();
                        txtLocatie.Clear();
                        txtDuur.Clear();
                        txtInfo1.Clear();
                        txtInfo2.Clear();
                        txtInfo3.Clear();

                        //Buttons en labels enabellen
                        lblDeelnemers.Enabled = true;
                        mcalKalender.Enabled = true;
                        lsvTraining.Enabled = true;
                        btnDeelnemen.Enabled = true;
                        btnDeelnemen.BackColor = Color.Green;
                        btnActiviteitToevoegen.Enabled = true;
                        btnKomendeDagen.Enabled = true;
                        btnActiviteitVerwijderen.Visible = false;
                        btnWijzigenActiviteit.Text = "Wijzigen";

                        //Form updaten
                        KalenderRefresh();

                        //Panel hidden
                        pnlActiviteitInfo.Visible = false;
                    }
                    else
                    {
                        //Foutmelding
                        MessageBox.Show("Er is een fout opgetreden.\nActiviteit kan niet verwijderd worden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Foutmelding
                    MessageBox.Show("Wachtwoord is fout", "Fout wachtwoord", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActiviteitToevoegen_Click(object sender, EventArgs e)
        {
            ActiviteitToevoegen activiteitToevoegen = new ActiviteitToevoegen();
            activiteitToevoegen.ShowDialog();

            //form updaten
            KalenderRefresh();
        }

        private void btnLogboek_Click(object sender, EventArgs e)
        {
            LogboekForm logboek = new LogboekForm(this, gebruiker, MateriaalDA.OphalenMateriaal());
            logboek.ShowDialog();
        }

        private void btnBeheer_Click(object sender, EventArgs e)
        {
            MateriaalBeheer beheer = new MateriaalBeheer(this);
            beheer.ShowDialog();
        }
    }
}
