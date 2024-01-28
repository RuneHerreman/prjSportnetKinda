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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            tcMain.SizeMode = TabSizeMode.Fixed;
        }

        private void buttonControls1_Click(object sender, EventArgs e)
        {

        }
    }
}
