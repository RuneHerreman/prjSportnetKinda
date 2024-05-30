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
    public partial class ArtikelBewerken : Form
    {
        List<Artikel> artikelList;
        //refresh mogelijk maken
        Main main1;
        public ArtikelBewerken(Main main)
        {
            InitializeComponent();
            //lijst maken laden
            artikelList = ArtikelDA.OphalenArtikel();
            //listview opvullen
            foreach (Artikel artikel in artikelList)
            {
                lsvArtikels.Items.Add(artikel.titel);
            }
            //refresh mogelijk maken
            main1 = main;
        }


        private void btnToepassen_Click(object sender, EventArgs e)
        {
            //aanpassen in datatbase
            ArtikelDA.ArtikelUpdate(txtNieuweNaam.Text, rtxtBeschrijving.Text, picNieuweAfbeelding, Convert.ToInt32(lblArtikelID.Text));

            //niets geselecteerd --> ZONDER DIT CRASHT HET PROGRAMMA NA EEN VERANDERING
            lsvArtikels.SelectedItems.Clear();
            //leeg listview
            lsvArtikels.Items.Clear();
            //opnieuw opvullen met geüpdatete item
            foreach (Artikel artikel in ArtikelDA.OphalenArtikel())
            {
                //listview opvullen
                lsvArtikels.Items.Add(artikel.titel);
            }

            //ook de lijst waar de info uit komt updaten
            artikelList = ArtikelDA.OphalenArtikel();

            //materiaal verversen
            main1.ArtikelRefresh();
        }
        private void lsvMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvArtikels.SelectedIndices.Count == 0)
            {
                return;
            }
            //welk materiaal is geselecteerd?
            Artikel artikel = artikelList[lsvArtikels.SelectedIndices[0]];
            txtNieuweNaam.Enabled = true;
            rtxtBeschrijving.Enabled = true;
            btnBladeren.Enabled = true;
            btnToepassen.Enabled = true;
            btnArtikelVerwijderen.Enabled = true;

            //leeg alles
            txtNieuweNaam.Clear();
            rtxtBeschrijving.Clear();
            picNieuweAfbeelding.Image = null;
            lblArtikelID.ResetText();

            //vul alles
            txtNieuweNaam.Text = artikel.titel;
            rtxtBeschrijving.Text = artikel.artikel;
            picNieuweAfbeelding.Image = artikel.foto;
            lblArtikelID.Text = artikel.ID.ToString();
        }


        private void btnBladeren_Click(object sender, EventArgs e)
        {
            try
            {
                //openfiledialog = ofdFoto
                ofdFoto.Title = "Selecteer een bestand";
                ofdFoto.FileName = string.Empty;
                ofdFoto.ShowHelp = false;
                ofdFoto.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.JPG;*.PNG;*JPEG";
                //open de verkenner
                DialogResult result = ofdFoto.ShowDialog();
                //als je niet op cancel klikt:
                if (result != DialogResult.Cancel)
                {
                    //textbox opvullen met bestandspad
                    txtNieuweFotoLocatie.Text = ofdFoto.FileName;
                    //preview weergeven
                    picNieuweAfbeelding.ImageLocation = ofdFoto.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnArtikelVerwijderen_Click(object sender, EventArgs e)
        {
            //verwijderen uit database
            ArtikelDA.ArtikelVerwijderen(Convert.ToInt32(lblArtikelID.Text));

            //refreshlist
            artikelList = ArtikelDA.OphalenArtikel();
            //niets geselecteerd --> ZONDER DIT CRASHT HET PROGRAMMA NA EEN VERANDERING
            lsvArtikels.SelectedItems.Clear();
            //leeg listview
            lsvArtikels.Items.Clear();
            //opnieuw opvullen met geüpdatete item
            foreach (Artikel artikel in artikelList)
            {
                //listview opvullen
                lsvArtikels.Items.Add(artikel.titel);
            }

            //leeg alles
            txtNieuweNaam.Clear();
            rtxtBeschrijving.Clear();
            picNieuweAfbeelding.Image = null;
            txtNieuweFotoLocatie.ResetText();
            lblArtikelID.ResetText();

            main1.ArtikelRefresh();
        }

        private void txtNieuweNaam_TextChanged(object sender, EventArgs e)
        {
            //hoeveel karakters mag ik hebben
            lblLengte.BackColor = Color.Transparent;
            lblLengte.Text = txtNieuweNaam.TextLength + "/44";
            if (txtNieuweNaam.TextLength > 44)
            {
                lblLengte.ForeColor = Color.Red;
            }
        }

        private void rtxtBeschrijving_TextChanged(object sender, EventArgs e)
        {
            //hoeveel karakters mag ik hebben
            lblLengteArtikel.BackColor = Color.Transparent;
            lblLengteArtikel.Text = rtxtBeschrijving.TextLength + "/50000";
            if (rtxtBeschrijving.TextLength > 50000)
            {
                lblLengteArtikel.ForeColor = Color.Red;
            }
        }
    }
}
