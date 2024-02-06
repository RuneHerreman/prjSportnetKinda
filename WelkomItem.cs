using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSportnetKinda
{
    public partial class WelkomItem : UserControl
    {
        
        public WelkomItem()
        {
            InitializeComponent();
            
        }
        static WelkomItem usercontrol = Application.OpenForms.OfType<WelkomItem>().FirstOrDefault();
        public static void ArtikelOpvullen(string artTitel, string artArtikel, DateTime artDatum, WelkomItem usercontrol, Image image)
        {
            usercontrol.lblArtiekelTitel.Text = artTitel;
            usercontrol.txtArtiekel.Text = artArtikel;
            usercontrol.lblArtiekelDatum.Text = artDatum.ToString("dd/MM/yyyy");
            if (image != null)
            {
                usercontrol.picArtiekelFoto.Image = image;
            }
        }
    }
}
