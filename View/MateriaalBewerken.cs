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
    public partial class MateriaalBewerken : Form
    {
        public MateriaalBewerken()
        {
            InitializeComponent();
            foreach (Materiaal materiaal in MateriaalDA.OphalenMateriaal())
            {
                lsvMateriaal.Items.Add(materiaal.Naam);
            }
        }
    }
}
