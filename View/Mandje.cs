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
    public partial class Mandje : Form
    {
        public Mandje()
        {
            InitializeComponent();

        }

        private void lsvMandje_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvMandje.Items.Clear();
            
        }
    }
}
