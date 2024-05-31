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

        Main main1;

        public MateriaalBewerken(Main main)
        {
            InitializeComponent();

            //lijst maken laden
            matList = MateriaalDA.OphalenMateriaal();
            //listview opvullen
            foreach (Materiaal materiaal in matList)
            {
                lsvMateriaal.Items.Add(materiaal.MateriaalNaam);
            }

            //herladen van materiaal
            main1 = main;
        }

        public void ClearInputs()
        {
            //leeg alle inputs
            txtNieuweNaam.ResetText();
            rtxtBeschrijving.ResetText();
            txtNieuweVoorraad.ResetText();
            picNieuweAfbeelding.Image = null;
            lblMateriaalID.ResetText();
        }

        private void lsvMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMateriaal.SelectedIndices.Count == 0)
            {
                return;
            }
            //welk materiaal is geselecteerd?
            Materiaal materiaal = matList[lsvMateriaal.SelectedIndices[0]];
            txtNieuweNaam.Enabled = true;
            rtxtBeschrijving.Enabled = true;
            txtNieuweVoorraad.Enabled = true;
            btnBladeren.Enabled = true;
            btnToepassen.Enabled = true;
            btnMateriaalVerwijderen.Enabled = true;
            
            ClearInputs();

            //vul alles
            txtNieuweNaam.Text = materiaal.MateriaalNaam;
            rtxtBeschrijving.Text = materiaal.Beschrijving;
            txtNieuweVoorraad.Text = materiaal.Voorraad.ToString();
            picNieuweAfbeelding.Image = materiaal.Foto;
            lblMateriaalID.Text = materiaal.ID.ToString();
        }

        private void btnToepassen_Click(object sender, EventArgs e)
        {
            try
            {
                if (picNieuweAfbeelding.Image != null)
                {
                    //foto's omzetten naar byte array
                    MemoryStream msProfiel = new MemoryStream();
                    picNieuweAfbeelding.Image.Save(msProfiel, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrFoto = msProfiel.GetBuffer();

                    if (arrFoto.Length < 2000000)
                    {
                        //aanpassen in datatbase
                        MateriaalDA.MateriaalUpdate(txtNieuweNaam.Text, rtxtBeschrijving.Text, Convert.ToInt16(txtNieuweVoorraad.Text), arrFoto, Convert.ToInt32(lblMateriaalID.Text));

                        //niets geselecteerd --> ZONDER DIT CRASHT HET PROGRAMMA NA EEN VERANDERING
                        lsvMateriaal.SelectedItems.Clear();
                        //leeg listview
                        lsvMateriaal.Items.Clear();
                        //opnieuw opvullen met geüpdatete item
                        foreach (Materiaal materiaal in MateriaalDA.OphalenMateriaal())
                        {
                            //listview opvullen
                            lsvMateriaal.Items.Add(materiaal.MateriaalNaam);
                        }

                        //ook de lijst waar de info uit komt updaten
                        matList = MateriaalDA.OphalenMateriaal();

                        ClearInputs();

                        //materiaal verversen
                        main1.MateriaalRefresh();
                    }
                    else
                    {
                        //Foutmelding
                        MessageBox.Show("De foto is te groot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Foutmelding
                    MessageBox.Show("Voeg eerst een foto toe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                //Foutmelding
                MessageBox.Show("Er is heeft zich een fout opgetreden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btnMateriaalVerwijderen_Click(object sender, EventArgs e)
        {
            //verwijderen uit database
            MateriaalDA.MateriaalVerwijderen(Convert.ToInt32(lblMateriaalID.Text));

            //refresh list
            matList = MateriaalDA.OphalenMateriaal();
            
            //niets geselecteerd --> ZONDER DIT CRASHT HET PROGRAMMA NA EEN VERANDERING
            lsvMateriaal.SelectedItems.Clear();
            //leeg listview
            lsvMateriaal.Items.Clear();
            //opnieuw opvullen met geüpdatete item
            foreach (Materiaal materiaal in matList)
            {
                //listview opvullen
                lsvMateriaal.Items.Add(materiaal.MateriaalNaam);
            }

            ClearInputs();

            main1.MateriaalRefresh();
        }

        private void rtxtBeschrijving_TextChanged(object sender, EventArgs e)
        {
            lblLengteBeschrijving.BackColor = Color.Transparent;
            lblLengteBeschrijving.Text = rtxtBeschrijving.TextLength + "/1000";
            if (rtxtBeschrijving.TextLength > 1000)
            {
                lblLengteBeschrijving.ForeColor = Color.Red;
            }
        }

        private void txtNieuweNaam_TextChanged(object sender, EventArgs e)
        {
            lblLengte.BackColor = Color.Transparent;
            lblLengte.Text = txtNieuweNaam.TextLength + "/20";
            if (txtNieuweNaam.TextLength > 20)
            {
                lblLengte.ForeColor = Color.Red;
            }
        }
    }
}
