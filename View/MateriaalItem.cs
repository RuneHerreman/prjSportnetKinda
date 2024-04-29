using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSportnetKinda
{
    public partial class MateriaalItem : UserControl
    {
        //Event aanmaken voor als er op button huren geklikt wordt
        public event EventHandler ButtonClick;

        //Public object om data van event te kunnen uitlezen
        public Materiaal materiaal { get; set; }

        public MateriaalItem()
        {
            InitializeComponent();
        }

        //opvullen van de usercontrol met de gegevens uit de lijst
        public  void MateriaalOpvullen(Materiaal m)
        {
            //waarden aan labels koppelen
            this.lblMateriaalBeschrijving.Text = m.Beschrijving;
            this.lblMateriaalTitel.Text = m.Naam;

            //als er een foto is
            if (m.Foto != null)
            {
                this.picMateriaal.Image = m.Foto ;
            }

            this.lblID.Text = m.ID.ToString();
            this.materiaal = m;

        }

        private void btnHuren_Click(object sender, EventArgs e)
        {
            //Event oproepen als op button huren wordt geklikt
            if (ButtonClick != null)
            {
                ButtonClick(this, e);
            }
        }
    }


}
