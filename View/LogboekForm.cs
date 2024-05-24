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
                item.LogboekOpvullen(logboek, g1, matlist1);

                //huidig artikel toevoegen aan fpnl
                fpnlLogboek.Controls.Add(item);
            }
        }

        private void LogboekItem_Click(object sender, EventArgs e)
        {

        }
    }
}
