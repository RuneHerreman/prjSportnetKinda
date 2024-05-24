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
                int intGebruikersIDLogboek;
                List<Logboek> logList = new List<Logboek>();
                logList = LogboekDA.AantalUniekeGebruikersEnHunIDs();
                //leegmaken
                fpnlLogboek.Controls.Clear();

                //een userControl maken voor iedere rij in de lijst van logboek
                for (int i = 0; i < LogboekDA.AantalUniekeGebruikersEnHunIDs().Count; i++)
                {
                    intGebruikersIDLogboek = Convert.ToInt16(logList[i].GebruikerID);
                    //object maken van de userControl
                    LogboekItem item = new LogboekItem();

                    //Event toevoegen
                    item.ButtonClick += LogboekItem_Click;

                    //artikel opvullen
                    item.LogboekOpvullen(l, g1, matlist1, intGebruikersIDLogboek);

                    //huidig artikel toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            else
            {
                int intGebruikerIDLogboek = 0;
                //leegmaken
                fpnlLogboek.Controls.Clear();

                //een userControl maken voor iedere rij in de lijst van logboek
                foreach (Logboek logboek in LogboekDA.OphalenLogboek(g1.GebruikerID))
                {
                    //object maken van de userControl
                    LogboekItem item = new LogboekItem();

                    //Event toevoegen
                    item.ButtonClick += LogboekItem_Click;

                    //artikel opvullen
                    item.LogboekOpvullen(logboek, g1, matlist1, intGebruikerIDLogboek);

                    //huidig artikel toevoegen aan fpnl
                    fpnlLogboek.Controls.Add(item);
                }
            }
            
        }

        private void LogboekItem_Click(object sender, EventArgs e)
        {

        }
    }
}
