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
using System.Windows.Controls;
using System.Windows.Forms;

namespace prjSportnetKinda.View
{
    public partial class LogboekBeheer : Form
    {
        LogboekItem item1;
        LogboekForm logboekform1;
        List<Logboek> logList;
        public LogboekBeheer(LogboekItem item, LogboekForm logboekform)
        {
            InitializeComponent();

            this.logboekform1 = logboekform;
            item1 = item;
            logList = LogboekDA.OphalenLogboek(item1.logListPar[0].Gebruiker.GebruikerID);

            LogboekListRefresh();
        }

        public void LeegAlles()
        {
            //leeg en deselecteer listview
            txtNiewAantal.ResetText();
            lblAantalGehuurd.ResetText();
            lblLogID.ResetText();

            lsvLogboek.SelectedItems.Clear();
            lsvLogboek.Items.Clear();
        }

        public void LogboekListRefresh()
        {
            LeegAlles();
            //refresh list
            if (item1.logListPar[0].GebruikerID != null)
            {
                logList = LogboekDA.OphalenLogboek(item1.logListPar[0].Gebruiker.GebruikerID);
                foreach (Logboek logboek in logList)
                {
                    System.Windows.Forms.ListViewItem lsvItem = new System.Windows.Forms.ListViewItem(logboek.Materiaal.MateriaalNaam);
                    lsvItem.SubItems.Add(logboek.Aantal);
                    lsvLogboek.Items.Add(lsvItem);
                }
                btnAllesInleveren.Enabled = false;
                btnKiesAantal.Enabled = false;
            }

        }

        private void MateriaalAanpassen(int intNumber)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Foto;
            int intNieuweVoorraad = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Voorraad + (Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal) - intNumber);

            MateriaalDA.MateriaalUpdate(logList[lsvLogboek.SelectedIndices[0]].Materiaal.MateriaalNaam, logList[lsvLogboek.SelectedIndices[0]].Materiaal.Beschrijving, intNieuweVoorraad, pictureBox, logList[lsvLogboek.SelectedIndices[0]].Materiaal.ID);
            //listview verversen
            LogboekListRefresh();
            logboekform1.LogboekRefresh();
        }

        private void btnKiesAantal_Click(object sender, EventArgs e)
        {
            
            if (txtNiewAantal.Text != "" && int.TryParse(txtNiewAantal.Text, out int number) && number >= 0 && number.ToString().Contains(" ") == false)
            {

                if (number != Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal) && number < Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal))
                {
                    //aantal verminderen uit logboek
                    LogboekDA.LogUpdate(logList[lsvLogboek.SelectedIndices[0]].LogID, number);
                    MateriaalAanpassen(number);
                }
                else if (number == 0)
                {
                    btnAllesInleveren_Click(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Het nieuwe getal moet positief zijn en verschillen van de gehuurd hoeveelheid", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Het nieuwe getal moet positief zijn en verschillen van de gehuurd hoeveelheid", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvLogboek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLogboek.SelectedItems.Count > 0)
            {
                btnAllesInleveren.Enabled = true;
                btnKiesAantal.Enabled = true;
                lblAantalGehuurd.ResetText();
                lblLogID.ResetText();
                txtNiewAantal.ResetText();

                lblAantalGehuurd.Text = logList[lsvLogboek.SelectedIndices[0]].Aantal;
                lblLogID.Text = logList[lsvLogboek.SelectedIndices[0]].LogID.ToString();
            }
        }

        private void btnAllesInleveren_Click(object sender, EventArgs e)
        {
            //zeker weten
            DialogResult result = MessageBox.Show($"Wil je alle {logList[lsvLogboek.SelectedIndices[0]].Materiaal.MateriaalNaam} inleveren?", "Alles inleveren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //als je het wel wil doen
            if (result == DialogResult.Yes)
            {
                //log verwijderen
                LogboekDA.LogDelete(logList[lsvLogboek.SelectedIndices[0]].LogID);

                //bereken nieuwe voorraad
                int intNieuweVoorraad = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Voorraad + Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal);

                MateriaalAanpassen(0);
            }
        }
    }
}

