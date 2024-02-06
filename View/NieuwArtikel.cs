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
                MySqlCommand cmdArtikel = new MySqlCommand(query, conn);
                cmdArtikel.CommandText = query;

                cmdArtikel.Parameters.AddWithValue("@datum", dtHuidigeDatum.Date);
                cmdArtikel.Parameters.AddWithValue("@titel", txtTitelNieuw.Text);
                cmdArtikel.Parameters.AddWithValue("@artikel", txtArtikelNieuw.Text);
                cmdArtikel.Parameters.AddWithValue("@foto", arrFoto);

                cmdArtikel.ExecuteNonQuery();

                //confirmatie
                MessageBox.Show("Artikel opgeslaan in database", "Artikel opgeslaan", MessageBoxButtons.OK);

                //textboxes legen
                txtArtikelNieuw.ResetText();
                txtTitelNieuw.ResetText();
                txtFotoNieuw.ResetText();
                picNieuwArtikelPreview.Image = null;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message , "",MessageBoxButtons.OK);
            }
        }  
    }
}
