using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjSportnetKinda
{
    public partial class WWVergeten : Form
    {
        public WWVergeten()
        {
            InitializeComponent();
        }

        private void btnStuurMail_Click(object sender, EventArgs e)
        {
            /*  Mail met code wordt verstuurt naar opgegeven Emailadres
                --> geef code in 
                correct?:    Verander wachtwoord mogelijk
                incorrect?:  Error
            */
            String strCode = Interaction.InputBox("Code e-mail", "Verificatie");
        }
    }
}
