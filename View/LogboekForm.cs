using Microsoft.VisualBasic;
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
using System.Windows.Input;

namespace prjSportnetKinda.View
{
    public partial class LogboekForm : Form
    {
        //gebruiker meenemen
        Main main1;
        Gebruiker g1;
        List<Materiaal> matlist1;
        int intFoundUserID;

        public LogboekForm(Main main, Gebruiker g, List<Materiaal> matlist)
        {
            InitializeComponent();
            //gegevens koppelen
            main1 = main;
            g1 = g;
            matlist1 = matlist;
            LogboekRefresh();

            if (g.Beheerder)
            {
                //Gebruikers ophalen uit database
                foreach (Logboek log in LogboekDA.AantalUniekeGebruikersEnHunIDs())
                {
                    if (log != null)
                    {
                        foreach (Logboek logboek in LogboekDA.OphalenLogboek(log.GebruikerID))
                        {
                            txtZoeken.AutoCompleteCustomSource.Add(logboek.Gebruiker.Voornaam + " " + logboek.Gebruiker.Naam);
                        }
                    }
                }
            }
            else
            {
                foreach (Logboek logboek in LogboekDA.OphalenLogboek(g1.GebruikerID))
                {
                    txtZoeken.AutoCompleteCustomSource.Add(logboek.Materiaal.MateriaalNaam);
                }
            }
        }

        //methodes
        public void LogboekRefresh()
        {
            //clear inputs
            txtZoeken.ResetText();

            //if statement bepaald hoeveel keer de loop zal lopen
            //vb:   beheerder=true  --> unieke gebruikers nodig uit logboek --> 2 of 8 of 13 users
            //      beheerder=false --> alle items die een specifieke gebruiker gehuurd heeft
            int intTeller = 0;
            if (g1.Beheerder)
            {
                //init var
                int intGebruikersIDLogboek;

                //lijst vullen met de gebruikers uit het logboek
                List<Logboek> logList = new List<Logboek>();
                logList = LogboekDA.AantalUniekeGebruikersEnHunIDs();
                //leegmaken
                fpnlLogboek.Controls.Clear();

                //een userControl maken voor iedere rij in de lijst van logboek
                for (int i = 0; i < LogboekDA.AantalUniekeGebruikersEnHunIDs().Count; i++)
                {
                    //over welke gebruiker gaat het?
                    intGebruikersIDLogboek = Convert.ToInt16(logList[i].GebruikerID);

                    //object maken van de userControl
                    LogboekItem item = new LogboekItem();

                    //Event toevoegen
                    item.LogboekGebruikerLog += LogboekGebruikerLog_Click;

                    //item opvullen
                    item.LogboekOpvullen(g1, intGebruikersIDLogboek, intTeller);

                    //huidig item toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            else
            {
                //leegmaken
                fpnlLogboek.Controls.Clear();

                //een userControl maken voor iedere rij in de lijst van logboek
                foreach (Logboek logboek in LogboekDA.OphalenLogboek(g1.GebruikerID))
                {
                    //object maken van de userControl
                    LogboekItem item = new LogboekItem();

                    //Event toevoegen
                    item.LogboekAllesInleverenClick += LogboekAllesInlveren_Click;
                    item.LogboekKiesAantalClick += LogboekKiesAantal_Click;

                    //item opvullen
                    item.LogboekOpvullen(g1, g1.GebruikerID, intTeller);
                    intTeller++;

                    //huidig item toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            
        }        
        private void DeleteLog(LogboekItem item)
        {
            //vragen voor bevestigen van verwijderen
            DialogResult result = MessageBox.Show($"Wil je alle {item.logboekPar.Materiaal.MateriaalNaam} inleveren?", "Alles inleveren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //als je het wel wil doen
            if (result == DialogResult.Yes)
            {
                //log verwijderen
                LogboekDA.LogDelete(item.logboekPar.LogID);

                //pas het materiaal aan
                MateriaalAanpassen(0, item);

                //vernieuw de pagina
                LogboekRefresh();
            }
        }
        private void MateriaalAanpassen(int intNumber, LogboekItem item)
        {
            //foto van materiaal in picturebox nodig voor het uitvoeren van de methode
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = item.logboekPar.Materiaal.Foto;

            //aantal terug toevoegen aan materiaal (huidige voorraad + hoeveel je wil indienen)
            int intNieuweVoorraad = item.logboekPar.Materiaal.Voorraad + intNumber;

            MateriaalDA.MateriaalUpdate(item.logboekPar.Materiaal.MateriaalNaam, item.logboekPar.Materiaal.Beschrijving, intNieuweVoorraad, pictureBox, item.logboekPar.Materiaal.ID);

            LogboekRefresh();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        private void LogboekGebruikerLog_Click(object sender, EventArgs e)
        {
            //Omzetten van object naar MateriaalItem
            LogboekItem item = (LogboekItem)sender;

            //open het beheer formulier
            LogboekBeheer logboekBeheer = new LogboekBeheer(item, this);
            logboekBeheer.ShowDialog();
        }
        private void LogboekKiesAantal_Click(object sender, EventArgs e)
        {
            //Omzetten van object naar MateriaalItem
            LogboekItem item = (LogboekItem)sender;

            //Hoeveel wil je teruggeven
            string strAantalInleveren = Interaction.InputBox("Hoeveel exemplaren wil je inleveren?", "Aantal inleveren?");
            
            //is er een invoer?, positief?, groter dan 0?
            if (strAantalInleveren != "" && int.TryParse(strAantalInleveren, out int number) && number > 0)
            {
                if (number < Convert.ToInt16(item.logboekPar.Aantal))
                {
                    int intNieuwAantal = Convert.ToInt16(item.logboekPar.Aantal) - number;
                    //aantal verminderen uit logboek
                    LogboekDA.LogUpdate(item.logboekPar.LogID, intNieuwAantal);
                    MateriaalAanpassen(number, item);
                }
                else if (number == Convert.ToInt32(item.logboekPar.Aantal))
                {
                    //verwijder
                    DeleteLog(item);
                }
            }
            else
            {
                MessageBox.Show("Je mag alleen positieve getallen ingeven!", "Alleen getallen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogboekAllesInlveren_Click(object sender, EventArgs e)
        {
            //Omzetten van object naar MateriaalItem
            LogboekItem item = (LogboekItem)sender;

            DeleteLog(item);
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtZoeken.Text != "")
                {
                    fpnlLogboek.Controls.Clear();

                    //beheerder --> zoeken op persoon
                    //gebruiker --> zoeken op gehuurd materiaal
                    if (g1.Beheerder)
                    {
                        foreach (Gebruiker gebruiker in GebruikerDA.OphalenGebruikers())
                        {
                            //Naam controleren
                            if (gebruiker.Voornaam.ToLower() + " " + gebruiker.Naam.ToLower() == txtZoeken.Text.ToLower())
                            {
                                //wie is de gevonden gebruiker?
                                intFoundUserID = gebruiker.GebruikerID;

                                //om de methode aan te vullen
                                int intTeller = 0;

                                //object maken van de userControl
                                LogboekItem item = new LogboekItem();

                                //Event toevoegen
                                item.LogboekGebruikerLog += LogboekGebruikerLog_Click;

                                //item opvullen
                                item.LogboekOpvullen(g1, intFoundUserID, intTeller);

                                //huidig item toevoegen aan fpnl
                                fpnlLogboek.Controls.Add(item);
                            }
                        }
                        if (fpnlLogboek.Controls.Count < 1)
                        {
                            //Messagebox
                            MessageBox.Show($"{txtZoeken.Text} bestaat niet in het programma");
                        }
                    }
                    else if (g1.Beheerder == false)
                    {
                        //tellen hoeveel er al gepasseerd zijn
                        int intTeller = 0;

                        foreach (Logboek logboek in LogboekDA.OphalenLogboek(g1.GebruikerID))
                        {
                            if (logboek.Materiaal.MateriaalNaam.ToLower() == txtZoeken.Text.ToLower())
                            {
                                //object maken van de userControl
                                LogboekItem item = new LogboekItem();

                                //Event toevoegen
                                item.LogboekGebruikerLog += LogboekGebruikerLog_Click;

                                //item opvullen
                                item.LogboekOpvullen(g1, intFoundUserID, intTeller);

                                //huidig item toevoegen aan fpnl
                                fpnlLogboek.Controls.Add(item);
                            }
                            intTeller++;
                        }
                        if (fpnlLogboek.Controls.Count < 1)
                        {
                            //Messagebox
                            MessageBox.Show($"Je hebt {txtZoeken.Text} niet gehuurd");
                        }
                    }
                    txtZoeken.ResetText();
                }
                else
                {
                    MessageBox.Show("Je hebt niets ingevuld!", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnFiltersWissen_Click(object sender, EventArgs e)
        {
            //terug normaal overzicht tonen
            LogboekRefresh();
        }
    }
}
