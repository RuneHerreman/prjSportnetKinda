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

namespace prjSportnetKinda.View
{
    public partial class NieuwArtiekel : Form
    {

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
                ofdFoto.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.JPG;*.PNG;*JPEG";
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
            

            try
            {
                //foto omzetten naar byte array
                MemoryStream ms = new MemoryStream();
                picNieuwArtikelPreview.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrFoto = ms.GetBuffer();

                //huidige datum
                DateTime dtHuidigeDatum = DateTime.Now;


                
                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //query maken
                string query = "INSERT INTO `tblartikels`(`datum`, `titel`, `artikel`, `foto`) VALUES (@datum,@titel,@artikel,@foto)";
                //commando maken
                MySqlCommand cmdArtiekel = new MySqlCommand(query, conn);
                cmdArtiekel.CommandText = query;

                cmdArtiekel.Parameters.AddWithValue("@datum", dtHuidigeDatum.ToString("yyyy-MM-dd"));
                cmdArtiekel.Parameters.AddWithValue("@titel", txtTitelNieuw.Text);
                cmdArtiekel.Parameters.AddWithValue("@artikel", txtArtikelNieuw.Text);
                cmdArtiekel.Parameters.AddWithValue("@foto", arrFoto);

                cmdArtiekel.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message , "",MessageBoxButtons.OK);
            }
        }  
    }
}
