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

namespace prjSportnetKinda
{
    public partial class MateriaalItem : UserControl
    {
        public MateriaalItem()
        {
            InitializeComponent();
        }
        static MateriaalItem ucMateriaalItem = Application.OpenForms.OfType<MateriaalItem>().FirstOrDefault();
        public static void MateriaalOpvullen(string matNaam, string matBeschrijving, MateriaalItem ucMateriaalItem, Image matImage)
        {
            ucMateriaalItem.lblMateriaalBeschrijving.Text = matBeschrijving;
            ucMateriaalItem.lblMateriaalTitel.Text = matNaam;
            if (matImage != null)
            {
                ucMateriaalItem.picMateriaal.Image = matImage;
            }
        }

        private void btnHuren_Click(object sender, EventArgs e)
        {
            
        }

        private static string InMandje()
        {
            string matNaamLijst = ucMateriaalItem.lblMateriaalTitel.Text;
            return matNaamLijst;
        }
    }
}
