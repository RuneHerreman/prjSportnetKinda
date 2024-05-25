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

        //list nodig om te itereren en materiaal te vinden
        public Gebruiker gebruikerPar { get; set; }
        public Logboek logboekPar { get; set; }
        public Materiaal materiaalPar { get; set; }
        public List<Materiaal> geleendMatlistPar { get; set; }
        public int intGebruikerIDLogboekPar { get; set; }


        List<Logboek> logboeklist;
        List<Gebruiker> gebruikerlist;
        public LogboekItem()
        {
            InitializeComponent();
        }

        public void LogboekOpvullen(Logboek l, Gebruiker g, List<Materiaal> matlist, int intGebruikerIDLogboek)
        {
            List<Materiaal> GeleendList = new List<Materiaal>();
            //leeg de info
            this.lblAantalOfLijstMateriaal.ResetText();
            this.lblNaam.ResetText();
            btnAllesInleveren.Visible = false;
            btnKiesAantal.Visible = false;
            btnGebruikerLog.Visible = false;

            gebruikerlist = GebruikerDA.OphalenGebruikers();

            //voor gebruik bij event in form
            this.intGebruikerIDLogboekPar = intGebruikerIDLogboek;
            
            //Gebruiker zoeken
            Gebruiker GetNameByUserID(int intGerbuikerID, List<Gebruiker> gebruikers)
            {
                foreach (Gebruiker gebruiker in gebruikers)
                {
                    if (gebruiker.GebruikerID == intGebruikerIDLogboek)
                    {
                        return gebruiker;
                        //voor gebruik bij event in form
                        this.gebruikerPar = gebruiker;
                    }
                }
                return null;
            }

            //ben je beheerder of niet
            //ja --> ieder item is het materiaal van een gebuiker (item = naam van gebruiker, materiaal dat ze geleend hebben)
            if (g.Beheerder)
            {
                //alleen van de huidige opvragen
                logboeklist = LogboekDA.OphalenLogboek(intGebruikerIDLogboek);

                //er staat iets in?
                if (logboeklist.Count != 0)
                {
                    //titel = volledige naam
                    this.lblNaam.Text = GetNameByUserID(intGebruikerIDLogboek, gebruikerlist).Voornaam + GetNameByUserID(intGebruikerIDLogboek, gebruikerlist).Naam;
                    foreach (Logboek logboek in logboeklist)
                    {
                        foreach (Materiaal mat in matlist)
                        {
                            if (mat.ID.ToString() == logboek.GehuurdMateriaalID)
                            {
                                this.lblAantalOfLijstMateriaal.Text += mat.Naam + Environment.NewLine;
                                GeleendList.Add(mat);
                            }
                        }
                    }

                    //voor gebruik bij event in form
                    this.geleendMatlistPar = GeleendList;
                }
                
                //profielfoto tonen in item
                if (GetNameByUserID(intGebruikerIDLogboek, gebruikerlist).Profielfoto != null)
                {
                    this.picLogboekFoto.Image = GetNameByUserID(intGebruikerIDLogboek, gebruikerlist).Profielfoto;
                }
                //beheerder kijkt naar materiaal per gebruiker
                btnGebruikerLog.Visible = true;
            }
            else //nee --> ingelogde gebruiker ziet alleen zijn eigen materiaal (item = 1 geleen item)
            {
                if (g.GebruikerID == l.GebruikerID)
                {
                    foreach (Materiaal mat in matlist)
                    {
                        if (mat.ID.ToString() == l.GehuurdMateriaalID)
                        {
                            this.lblNaam.Text = mat.Naam;
                            this.lblAantalOfLijstMateriaal.Text = "Aantal: " + l.Aantal;
                            //als er een foto is --> materiaal
                            if (mat.Foto != null)
                            {
                                this.picLogboekFoto.Image = mat.Foto;
                            }
                            //gebruiker bekijkt materiaal per log
                            btnAllesInleveren.Visible = true;
                            btnKiesAantal.Visible = true;

                            //voor gebruik bij event in form
                            this.logboekPar = l;
                            this.materiaalPar = mat;
                        }
                    }
                }                
            }

        }

        private void LogboekItem_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (LogboekGebruikerLog != null)
            {
                LogboekGebruikerLog(this, e);
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
    }
}
