using prjSportnetKinda.DA;
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

namespace prjSportnetKinda.View
{
    public partial class Wijzigen : Form
    {
        public Wijzigen()
        {
            InitializeComponent();

            //Gebruikers ophalen uit database
            foreach(Gebruiker g in GebruikerDA.Ophalen())
            {

            }
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {

        }
    }
}
