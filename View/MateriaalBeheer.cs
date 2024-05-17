using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace prjSportnetKinda.View
{
    public partial class MateriaalBeheer : Form
    {
        Main main1;
        public MateriaalBeheer(Main main)
        {
            InitializeComponent();
            main1 = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open form
            NieuwMateriaal nieuwMateriaal = new NieuwMateriaal(main1);
            nieuwMateriaal.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open form
            MateriaalBewerken materiaalBewerken = new MateriaalBewerken(main1);
            materiaalBewerken.ShowDialog();
            this.Close();
        }
    }
}
