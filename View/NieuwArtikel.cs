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
using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using prjSportnetKinda.DA;

namespace prjSportnetKinda.View
{
    public partial class NieuwArtikel : Form
    {

        public NieuwArtikel()
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
                    picNieuwArtikelPreview.ImageLocation = ofdFoto.FileName.ToString();
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
            lblLengte.Text = txtTitelNieuw.TextLength + "/44";
            if (txtTitelNieuw.TextLength >44)
            {
                lblLengte.ForeColor = Color.Red;
            }
        }

        private void txtArtikelNieuw_TextChanged(object sender, EventArgs e)
        {
            lblLengteArtikel.BackColor = Color.Transparent;
            lblLengteArtikel.Text = txtArtikelNieuw.TextLength + "/50000";
            if (txtArtikelNieuw.TextLength > 50000)
            {
                lblLengteArtikel.ForeColor = Color.Red;
            }
        }

        private void btnArtikelOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                ArtikelDA.ArtikelMaken(txtTitelNieuw.Text, txtArtikelNieuw.Text, picNieuwArtikelPreview);
                //textboxes legen
                txtArtikelNieuw.ResetText();
                txtTitelNieuw.ResetText();
                txtFotoNieuw.ResetText();
                picNieuwArtikelPreview.Image = null;
            }
            catch
            {

            }
        }  
    }
}
