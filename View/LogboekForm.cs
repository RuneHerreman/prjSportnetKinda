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
        Logboek l;
        public LogboekForm(Main main, Gebruiker g, List<Materiaal> matlist)
        {
            InitializeComponent();
            //gegevens koppelen
            main1 = main;
            g1 = g;
            matlist1 = matlist;
            LogboekRefresh();
        }

        public void LogboekRefresh()
        {
            //if statement bepaald hoeveel keer de loop zal lopen
            //vb:   beheerder=true  --> unieke gebruikers nodig uit logboek --> 2 of 8 of 13 users
            //      beheerder=false --> alle items die een specifieke gebruiker gehuurd heeft
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
                    item.LogboekOpvullen(l, g1, matlist1, intGebruikersIDLogboek);

                    //huidig item toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            else
            {
                //moet in de methode worden ingevuld en moest het een waarde geven
                int intGebruikerIDLogboek = 0;

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
                    item.LogboekOpvullen(logboek, g1, matlist1, intGebruikerIDLogboek);

                    //huidig item toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            
        }

        private void LogboekGebruikerLog_Click(object sender, EventArgs e)
        {

        }
        private void LogboekAllesInlveren_Click(object sender, EventArgs e)
        {
            //Omzetten van object naar MateriaalItem
            LogboekItem item = (LogboekItem)sender;
            //hoeveel keer is het artikel toegevoegd
            //voorraad en naam van gekozen artikel
            MessageBox.Show(item.materiaalPar.Naam);

        }
        private void LogboekKiesAantal_Click(object sender, EventArgs e)
        {

        }
    }
}
