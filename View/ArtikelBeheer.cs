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
    public partial class ArtikelBeheer : Form
    {
        //refresh mogelijk maken
        Main main1;
        public ArtikelBeheer(Main main)
        {
            InitializeComponent();
            //refresh mogelijk maken
            main1 = main;
        }

        private void btnArtikelToevoegen_Click(object sender, EventArgs e)
        {
            NieuwArtikel nieuwArtikel = new NieuwArtikel(main1);
            nieuwArtikel.ShowDialog();
            this.Close();
        }

        private void btnArtikelAanpassen_Click(object sender, EventArgs e)
        {
            ArtikelBewerken artikelBewerken = new ArtikelBewerken(main1);
            artikelBewerken.ShowDialog();
            this.Close();
        }
    }
}
