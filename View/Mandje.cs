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
    public partial class frmMandje : Form
    {
        public frmMandje(List<String> HuurList)
        {
            InitializeComponent();

            foreach(String materiaal in HuurList)
            {
                lsvMandje.Items.Add(materiaal);
            }
            
        }

        private void btnHurenLijst_Click(object sender, EventArgs e)
        {

        }

        private void lsvMandje_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
