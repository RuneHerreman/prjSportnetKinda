using prjSportnetKinda.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace prjSportnetKinda.View
{
    public partial class NieuwMateriaal : Form
    {
        Main main1;
        public NieuwMateriaal(Main main)
        {
            InitializeComponent();

            //refresh van materiaal
            main1 = main;
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
                    txtFotoNieuw.Text = ofdFoto.FileName;
                    //preview weergeven
                    picNieuwMateriaalPreview.ImageLocation = ofdFoto.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtTitelNieuw_TextChanged(object sender, EventArgs e)
        {
            lblLengte.BackColor = Color.Transparent;
            lblLengte.Text = txtNaamNieuw.TextLength + "/20";
            if (txtNaamNieuw.TextLength > 20)
            {
                lblLengte.ForeColor = Color.Red;
            }
        }

        private void txtBeschrijvingNieuw_TextChanged(object sender, EventArgs e)
        {
            lblLengteArtikel.BackColor = Color.Transparent;
            lblLengteArtikel.Text = txtBeschrijvingNieuw.TextLength + "/1000";
            if (txtBeschrijvingNieuw.TextLength > 1000)
            {
                lblLengteArtikel.ForeColor = Color.Red;
            }
        }

        private void btnMateriaalOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (picNieuwMateriaalPreview.Image != null)
                {
                    //foto's omzetten naar byte array
                    MemoryStream msProfiel = new MemoryStream();
                    picNieuwMateriaalPreview.Image.Save(msProfiel, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrFoto = msProfiel.GetBuffer();

                    if (arrFoto.Length < 2000000)
                    {
                        MateriaalDA.MateriaalMaken(txtNaamNieuw.Text, txtBeschrijvingNieuw.Text, Convert.ToInt16(txtVoorraad.Text), arrFoto);

                        //textboxes legen
                        txtBeschrijvingNieuw.ResetText();
                        txtNaamNieuw.ResetText();
                        txtFotoNieuw.ResetText();
                        txtVoorraad.ResetText();
                        picNieuwMateriaalPreview.Image = null;
                        txtVoorraad.ResetText();
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
    }
}
