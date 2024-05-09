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

namespace prjSportnetKinda.View
{
    public partial class NieuwMateriaal : Form
    {
        public NieuwMateriaal()
        {
            InitializeComponent();
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
            lblLengte.Text = txtNaamNieuw.TextLength + "/15";
            if (txtNaamNieuw.TextLength > 15)
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
                MateriaalDA.MateriaalMaken(txtNaamNieuw.Text, txtBeschrijvingNieuw.Text, Convert.ToInt16(txtVoorraad.Text), picNieuwMateriaalPreview);
                //textboxes legen
                txtBeschrijvingNieuw.ResetText();
                txtNaamNieuw.ResetText();
                txtFotoNieuw.ResetText();
                picNieuwMateriaalPreview.Image = null;
            }
            catch
            {

            }
        }
    }
}
