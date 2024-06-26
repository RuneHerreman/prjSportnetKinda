﻿using Microsoft.VisualBasic;
using prjSportnetKinda.DA;
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
        List<Materiaal> MandjeMateriaalList;
        string strGehuurd;
        Gebruiker gebruiker = new Gebruiker();

        Main main1;

        public frmMandje(List<Materiaal> HuurList, List<int> MandjeAantalList, Gebruiker login, Main main)
        {
            InitializeComponent();
            //omzetten naar lijst in dit formulier om leegmaken mogelijk te maken
            MandjeAantallenList = MandjeAantalList;
            MandjeMateriaalList = HuurList;

            //gebruiker doorgeven
            gebruiker = login;

            main1 = main;

            ListViewOpvullen();
        }

        private void ListViewOpvullen()
        {
            lsvMandje.Items.Clear();
            foreach (Materiaal materiaal in MandjeMateriaalList)
            {
                //in item
                ListViewItem listViewItem = new ListViewItem(materiaal.MateriaalNaam);
                //subitem aantal van dit item
                listViewItem.SubItems.Add(MandjeAantallenList[MandjeMateriaalList.IndexOf(materiaal)].ToString());
                //toevoegen aan listview
                lsvMandje.Items.Add(listViewItem);
            }
        }


        private void btnArtikelVerwijderen_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count != 0)
            {
                //index van het geselecteerde item
                int intSelectedIndex = lsvMandje.SelectedItems[0].Index;

                //verwijderen uit lijst van Mandje.cs, dit zal ook de lijst in Main.cs veranderen
                MandjeAantallenList.RemoveAt(intSelectedIndex);
                MandjeMateriaalList.RemoveAt(intSelectedIndex);

                //item uit listview verwijderen
                lsvMandje.Items.RemoveAt(intSelectedIndex);
            }
            else
            {
                MessageBox.Show("Geen artikel geselecteerd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aantal in mandje aanpassen
            main1.TelAanpassen();
        }

        private void btnMandjeLegen_Click(object sender, EventArgs e)
        {
            if (lsvMandje.Items.Count != 0)
            {
                //Lijsten legen, dit zal ook de lijst uit Main.cs legen
                MandjeAantallenList.Clear();
                MandjeMateriaalList.Clear();

                //listview legen
                lsvMandje.Items.Clear();
            }
            else
            {
                MessageBox.Show("Geen artikels in het mandje", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //aantal in mandje aanpassen
            main1.TelAanpassen();
        }

        private void btnHurenLijst_Click_1(object sender, EventArgs e)
        {
            if (lsvMandje.Items.Count > 0)
            {
                //string leegmaken in geval van meerdere "bestellingen"
                strGehuurd = "";
                //zeker dat je wil huren?
                DialogResult result = MessageBox.Show("Weet je zeker dat je dit wil huren?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //ja?
                if (result == DialogResult.Yes)
                {
                    //alle
                    foreach (Materiaal materiaal in MandjeMateriaalList)
                    {
                        //nieuwe voorraad berekenen
                        int intNieuweVoorraad = materiaal.Voorraad - MandjeAantallenList[MandjeMateriaalList.IndexOf(materiaal)];
                        //verlaag de voorraad van alle artikels
                        MateriaalDA.HuurMateriaal(intNieuweVoorraad, materiaal.ID);
                        //logboek aanvullen
                        LogboekDA.HuurMateriaal(gebruiker.GebruikerID, MandjeAantallenList[MandjeMateriaalList.IndexOf(materiaal)], materiaal.ID, DateTime.Now);
                        //alle gehuurde artikels in een string plaatsen
                        strGehuurd += MandjeAantallenList[MandjeMateriaalList.IndexOf(materiaal)].ToString() + " " + materiaal.MateriaalNaam + "\n";
                    }
                    //Toon wat je gehuurd hebt
                    MessageBox.Show($"Je huurde:\n\n{strGehuurd}", "Details", MessageBoxButtons.OK);

                    //Lijsten legen, dit zal ook de lijst uit Main.cs legen
                    MandjeAantallenList.Clear();
                    MandjeMateriaalList.Clear();

                    //listview legen
                    lsvMandje.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Er zit niets in je mandje!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //aantal in mandje aanpassen
            main1.TelAanpassen();

            //sluit frmMandje
            this.Close();
            
            //refresh materiaal pagina
            main1.MateriaalRefresh();
        }

        private void btnAantalAanpassen_Click(object sender, EventArgs e)
        {
            if (lsvMandje.SelectedItems.Count != 0)
            {
                string strAantal = (Interaction.InputBox($"Hoeveel van dit exemplaar wil je huren?\nHuidig aantal: {MandjeAantallenList[lsvMandje.SelectedIndices[0]]}", "Geef een nummer in"));
                if (strAantal != "" && int.TryParse(strAantal, out int number) && number >= 0)
                {
                    //is het getal anders dan de gehuurde hoeveelheid, niet nul
                    if (number != MandjeAantallenList[lsvMandje.SelectedIndices[0]] && number != 0 && number <= MandjeMateriaalList[lsvMandje.SelectedIndices[0]].Voorraad)
                    {
                        //index van het geselecteerde item
                        int intSelectedIndex = lsvMandje.SelectedItems[0].Index;

                        //verwijder het vorige aantal
                        MandjeAantallenList.RemoveAt(intSelectedIndex);
                        //voeg het nieuwe aantal toe
                        MandjeAantallenList.Insert(intSelectedIndex, number);
                    }
                    //is het getal nul?
                    else if (number == 0)
                    {
                        //index van het geselecteerde item
                        int intSelectedIndex = lsvMandje.SelectedItems[0].Index;

                        //verwijderen uit lijst van Mandje.cs, dit zal ook de lijst in Main.cs veranderen
                        MandjeAantallenList.RemoveAt(intSelectedIndex);
                        MandjeMateriaalList.RemoveAt(intSelectedIndex);

                        //item uit listview verwijderen
                        lsvMandje.Items.RemoveAt(intSelectedIndex);
                    }
                    else
                    {
                        //foutmelding
                        MessageBox.Show($"Het nieuwe getal moet positief zijn en mag niet groter zijn dan de voorraad\nHuidige voorraad: {MandjeMateriaalList[lsvMandje.SelectedIndices[0]].Voorraad}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //foutmelding
                    MessageBox.Show($"Het nieuwe getal moet positief zijn en mag niet groter zijn dan de voorraad\nHuidige voorraad: {MandjeMateriaalList[lsvMandje.SelectedIndices[0]].Voorraad}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Je hebt niets geselecteerd!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //nieuwe aantallen weergeven
            ListViewOpvullen();
            //aantal in mandje aanpassen
            main1.TelAanpassen();


        }
    }
}
