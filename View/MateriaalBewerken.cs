using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace prjSportnetKinda.View
{
    public partial class MateriaalBewerken : Form
    {
        List<Materiaal> matList = new List<Materiaal>();
        
        public MateriaalBewerken()
        {
            InitializeComponent();

            matList = MateriaalDA.OphalenMateriaal();

            foreach (Materiaal materiaal in matList)
            {
                lsvMateriaal.Items.Add(materiaal.Naam);
            }
        }

        private void lsvMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //leeg alles
            txtNieuweNaam.Text = "";
            rtxtBeschrijving.Text = "";
            txtNieuweVoorraad.Text = "";
            picNieuweAfbeelding.Image = null;

            if (lsvMateriaal.SelectedItems.Count != 0)
            {
                //welk materiaal is geselecteerd?
                Materiaal materiaal = matList[lsvMateriaal.SelectedIndices[0]];
                //vul alles
                txtNieuweNaam.Text = materiaal.Naam;
                rtxtBeschrijving.Text = materiaal.Beschrijving;
                txtNieuweVoorraad.Text = materiaal.Voorraad.ToString();
                picNieuweAfbeelding.Image = materiaal.Foto;
            }
        }

        private void btnToepassen_Click(object sender, EventArgs e)
        {

        }
    }
}
