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
        //object van de usercontrol om deze te kunnen aanspreken
        static MateriaalItem ucMateriaalItem = Application.OpenForms.OfType<MateriaalItem>().FirstOrDefault();

        //opvullen van de usercontrol met de gegevens uit de lijst
        public static void MateriaalOpvullen(string matNaam, string matBeschrijving, MateriaalItem ucMateriaalItem, Image matImage, int intID)
        {
            //waarden aan labels koppelen
            ucMateriaalItem.lblMateriaalBeschrijving.Text = matBeschrijving;
            ucMateriaalItem.lblMateriaalTitel.Text = matNaam;
            if (matImage != null)
            {
                ucMateriaalItem.picMateriaal.Image = matImage;
            }
            int ID = intID;
        }
    }
}
