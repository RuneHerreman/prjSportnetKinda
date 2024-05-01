using prjSportnetKinda.Model;
using prjSportnetKinda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjSportnetKinda.View
{
    public partial class frmMandje : Form
    {
        //kopie maken maken
        List<int> MandjeAantallenList;
        List<String> MandjeMateriaalList;
        public frmMandje(List<String> HuurList, List<int> MandjeAantalList)
        {
            InitializeComponent();
            //omzetten naar lijst in dit formulier om leegmaken mogelijk te maken
            MandjeAantallenList = MandjeAantalList;
            MandjeMateriaalList = HuurList;

            foreach(String materiaal in MandjeMateriaalList)
            {
                //in item
                ListViewItem listViewItem = new ListViewItem(materiaal);
                //subitem aantal van dit item
                listViewItem.SubItems.Add(MandjeAantallenList[MandjeMateriaalList.IndexOf(materiaal)].ToString());
                //toevoegen aan listview
                lsvMandje.Items.Add(listViewItem);
            }
            
            
        }

        private void btnHurenLijst_Click(object sender, EventArgs e)
        {

        }


        private void btnArtikelVerwijderen_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count != 0)
            {
                //index van het geselecteerde item
                int intSelectedIndex = lsvMandje.SelectedItems[0].Index;

                //item uit de lijsten halen met een methode uit Main: Form
                Model.Gebruiker gebruiker = new Gebruiker();
                Main main = new Main(gebruiker, 1);
                
                //verwijderen uit lijst van Mandje.cs, dit zal ook de lijst in Main.cs veranderen
                MandjeAantallenList.RemoveAt(intSelectedIndex);
                MandjeMateriaalList.RemoveAt(intSelectedIndex);

                //item uit listview verwijderen
                lsvMandje.Items.RemoveAt(intSelectedIndex);

            }
            else
            {
                MessageBox.Show("Geen artikel geselecteerd");
            }
        }

        private void btnMandjeLegen_Click(object sender, EventArgs e)
        {


            //Lijsten legen, dit zal ook de lijst uit Main.cs legen
            MandjeAantallenList.Clear();
            MandjeMateriaalList.Clear();
            
            //listview legen
            lsvMandje.Items.Clear();
        }
    }
}
