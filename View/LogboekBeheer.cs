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

            logboekform1 = logboekform;
            item1 = item;
            logList = LogboekDA.OphalenLogboek(item1.logListPar[0].Gebruiker.GebruikerID);

            LogboekListRefresh();
        }


        //methodes
        private void DeleteLog()
        {
            //vragen om bevestiging
            DialogResult result = MessageBox.Show($"Wil je alle exemplaren van {logList[lsvLogboek.SelectedIndices[0]].Materiaal.MateriaalNaam} inleveren?", "Alles inleveren?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //als je het wel wil doen
            if (result == DialogResult.Yes)
            {
                //log verwijderen
                LogboekDA.LogDelete(logList[lsvLogboek.SelectedIndices[0]].LogID);

                //bereken nieuwe voorraad
                int intNieuweVoorraad = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Voorraad + Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal);

                //materiaal in database aanpassen
                MateriaalAanpassen(0);
            }
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
            //foto van het materiaal invullen in een picturebox voor de methode
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Foto;

            //nieuwe voorraad berekenen (huidige voorraad + verschil tussen het geleend aantal en het gewenst resterende aantal(-->hoeveel teruggeven))
            int intNieuweVoorraad = logList[lsvLogboek.SelectedIndices[0]].Materiaal.Voorraad + (Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal) - intNumber);

            //materiaal aanpassen in de database
            MateriaalDA.MateriaalUpdate(logList[lsvLogboek.SelectedIndices[0]].Materiaal.MateriaalNaam, logList[lsvLogboek.SelectedIndices[0]].Materiaal.Beschrijving, intNieuweVoorraad, pictureBox, logList[lsvLogboek.SelectedIndices[0]].Materiaal.ID);

            //listview verversen
            LogboekListRefresh();
            //openstaand formulier ook verversen
            logboekform1.LogboekRefresh();
        }
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------
        private void btnKiesAantal_Click(object sender, EventArgs e)
        {
            //is het een getal, positief of nul?
            if (txtNiewAantal.Text != "" && int.TryParse(txtNiewAantal.Text, out int number) && number >= 0)
            {
                //is het getal anders dan de gehuurde hoeveelheid, niet nul
                if (number != Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal) && number < Convert.ToInt32(logList[lsvLogboek.SelectedIndices[0]].Aantal) && number !=0)
                {
                    //aantal verminderen uit logboek
                    LogboekDA.LogUpdate(logList[lsvLogboek.SelectedIndices[0]].LogID, number);
                    MateriaalAanpassen(number);
                }
                //is het getal nul?
                else if (number == 0)
                {
                    //verwijderen
                    DeleteLog();
                }
                else
                {
                    //foutmelding
                    MessageBox.Show("Het nieuwe getal moet positief zijn en verschillen van de gehuurd hoeveelheid", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //foutmelding
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
            //verwijderen
            DeleteLog();
        }
    }
}

