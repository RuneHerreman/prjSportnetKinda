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
        //Event aanmaken voor als er op button huren geklikt wordt
        public event EventHandler ButtonClick;

        //Public object om data van event te kunnen uitlezen
        bool blEmpty;
        public Logboek logboek { get; set; }
        public Gebruiker gebruiker { get; set; }
        List<Logboek> logboeklist;
        List<Gebruiker> gebruikerlist;
        public LogboekItem()
        {
            InitializeComponent();
        }

        public void LogboekOpvullen(Logboek l, Gebruiker g, List<Materiaal> matlist, int intGebruikerIDLogboek)
        {
            //leeg de info
            this.lblAantalOfLijstMateriaal.ResetText();
            this.lblNaam.ResetText();
 
            gebruikerlist = GebruikerDA.OphalenGebruikers();

            //ben je beheerder of niet
            //ja --> ieder item is het materiaal van een gebuiker (item = naam van gebruiker, materiaal dat ze geleend hebben)
            if (g.Beheerder)
            {
                //alleen van de huidige opvragen
                logboeklist = LogboekDA.OphalenLogboek(intGebruikerIDLogboek);

                if (logboeklist.Count != 0)
                {
                    //titel = volledige naam
                    this.lblNaam.Text = gebruikerlist[intGebruikerIDLogboek].Voornaam + " " + gebruikerlist[intGebruikerIDLogboek].Naam;
                    foreach (Logboek logboek in logboeklist)
                    {
                        foreach (Materiaal mat in matlist)
                        {
                            if (mat.ID.ToString() == logboek.GehuurdMateriaalID)
                            {
                                this.lblAantalOfLijstMateriaal.Text += mat.Naam + Environment.NewLine;
                                    
                            }
                        }
                    }
                }
                
                if (g.Profielfoto != null)
                {
                    this.picLogboekFoto.Image = g.Profielfoto;
                }
            }
            //nee --> ingelogde gebruiker ziet alleen zijn eigen materiaal (item = 1 geleen item)
            else
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
                        }
                    }
                }                
            }
        }

        private void LogboekItem_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (ButtonClick != null)
            {
                ButtonClick(this, e);
            }
        }
    }
}
