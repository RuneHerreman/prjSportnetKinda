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
    public partial class NieuwArtiekel : Form
    {
        int intFotoTeller = 0;
        string strFotoFolder = "ArtikelFotos";
        public NieuwArtiekel()
        {
            InitializeComponent();
        }

        private void btnBladeren_Click(object sender, EventArgs e)
        {
            try
            {
                ofdFoto.Title = "Selecteer een bestand";
                ofdFoto.FileName = string.Empty;
                ofdFoto.ShowHelp = false;
                ofdFoto.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.PNG;";
                DialogResult _result = ofdFoto.ShowDialog();
                if (_result == DialogResult.Cancel) 
                {

                }
                else
                {
                    txtFotoNieuw.Text = ofdFoto.FileName;
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
            string strFotoBestandPad = ofdFoto.FileName;
            Image foto = Image.FromFile(strFotoBestandPad);
            SaveToFolder(foto);
        }


        //methode om foto op te slaan
        private void SaveToFolder(Image foto)
        {
            try
            {
                //wat
                string strFotoNaam = $"artikel_foto_{intFotoTeller++}";

                //opslaan in folder
                string strFotoPad = Path.Combine(strFotoFolder, strFotoNaam);

                using (FileStream fs = new FileStream(strFotoPad,FileMode.Create))
                {
                    foto.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
