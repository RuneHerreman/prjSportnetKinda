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
    }
}
