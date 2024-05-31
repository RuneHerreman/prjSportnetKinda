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

namespace prjSportnetKinda
{
    public partial class LogboekItem : UserControl
    {
        //Events aanmaken voor als er op buttons geklikt wordt
        public event EventHandler LogboekGebruikerLog;
        public event EventHandler LogboekKiesAantalClick;
        public event EventHandler LogboekAllesInleverenClick;

        public List<Logboek> logListPar { get; set; }
        public Logboek logboekPar { get; set; }
        public int intGebruikerIDLogboekPar { get; set; }

        public LogboekItem()
        {
            InitializeComponent();
        }

        public void LogboekOpvullen(Gebruiker g, int intGebruikerIDLogboek, int intTeller)
        {
            //leeg de info
            this.lblAantalOfLijstMateriaal.ResetText();
            this.lblNaam.ResetText();
            btnAllesInleveren.Visible = false;
            btnKiesAantal.Visible = false;
            btnGebruikerLog.Visible = false;

            //voor gebruik bij event in form
            this.intGebruikerIDLogboekPar = intGebruikerIDLogboek;
            
            //ben je beheerder of niet
            //ja --> ieder item is het materiaal van een gebuiker (item = naam van gebruiker, materiaal dat ze geleend hebben)
            if (g.Beheerder)
            {
                List<Logboek> logList = LogboekDA.OphalenLogboek(intGebruikerIDLogboek);
                //er staat iets in?
                if (logList.Count != 0)
                {
                    //titel = volledige naam
                    this.lblNaam.Text = logList[0].Gebruiker.Voornaam + " " + logList[0].Gebruiker.Naam;

                    //maar de eerste drie logs tonen, anders te veel in één keer
                    int intTeller1 = 0;
                    foreach (Logboek logboek in logList)
                    {
                        if (intTeller1 <3)
                        {
                            this.lblAantalOfLijstMateriaal.Text += logboek.Materiaal.MateriaalNaam + Environment.NewLine;
                        }
                        else
                        {
                            this.lblAantalOfLijstMateriaal.Text += "...";
                            break;
                        }
                        intTeller1++;
                    }

                    //voor gebruik bij event in form
                    this.logListPar = logList;
                }
                
                //profielfoto tonen in item
                if (logList[0].Gebruiker.Profielfoto != null)
                {
                    this.picLogboekFoto.Image = logList[0].Gebruiker.Profielfoto;
                }
                //beheerder kijkt naar materiaal per gebruiker
                btnGebruikerLog.Visible = true;
            }
            else //nee --> ingelogde gebruiker ziet alleen zijn eigen materiaal (item = 1 geleen item)
            {
                List<Logboek> logList = LogboekDA.OphalenLogboek(g.GebruikerID);
                if (logList.Count != 0)
                {
                    //labels opvullen
                    this.lblNaam.Text = logList[intTeller].Materiaal.MateriaalNaam;
                    this.lblAantalOfLijstMateriaal.Text = "Aantal: " + logList[intTeller].Aantal;

                    //als er een foto is --> materiaal
                    if (logList[intTeller].Materiaal.Foto != null)
                    {
                        this.picLogboekFoto.Image = logList[intTeller].Materiaal.Foto;
                    }

                    //gebruiker bekijkt materiaal per log
                    btnAllesInleveren.Visible = true;
                    btnKiesAantal.Visible = true;
                    this.logboekPar = logList[intTeller];
                }
            }
        }


        private void btnAllesInleveren_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (LogboekAllesInleverenClick != null)
            {
                LogboekAllesInleverenClick(this, e);
            }
        }

        private void btnBepaaldAantal_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (LogboekKiesAantalClick != null)
            {
                LogboekKiesAantalClick(this, e);
            }
        }

        private void btnGebruikerLog_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (LogboekGebruikerLog != null)
            {
                LogboekGebruikerLog(this, e);
            }
        }
    }
}
