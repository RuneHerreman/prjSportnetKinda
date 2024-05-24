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
        public Logboek logboek { get; set; }
        public Gebruiker gebruiker { get; set; }
        public LogboekItem()
        {
            InitializeComponent();
        }

        public void LogboekOpvullen(Logboek l, Gebruiker g, List<Materiaal> matlist)
        {
            //ben je beheerder of niet
            if (g.Beheerder)
            {
                this.lblNaam.Text = g.Voornaam + g.Naam;
                this.lblAantalOfLijstMateriaal.Text += l.Aantal.ToString() + Environment.NewLine;
                this.picLogboekFoto.Image = g.Profielfoto;
            }
            else
            {

            }
            //waarden aan labels koppelen
            this.lblNaam.Text = l.GehuurdMateriaalID.ToString();

            //als er een foto is
            if (matlist[0].Foto != null)
            {
                this.picLogboekFoto.Image = matlist[0].Foto;
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
