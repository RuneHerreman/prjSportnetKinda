﻿using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace prjSportnetKinda.View
{
    public partial class MateriaalBewerken : Form
    {
        List<Materiaal> matList = new List<Materiaal>();
        
        public MateriaalBewerken()
        {
            InitializeComponent();

            //lijst maken laden
            matList = MateriaalDA.OphalenMateriaal();
            //listview opvullen
            foreach (Materiaal materiaal in matList)
            {
                lsvMateriaal.Items.Add(materiaal.Naam);
            }
        }

        private void lsvMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvMateriaal.SelectedIndices.Count == 0)
            {
                return;
            }
            //welk materiaal is geselecteerd?
            Materiaal materiaal = matList[lsvMateriaal.SelectedIndices[0]];
            txtNieuweNaam.Enabled = true;
            rtxtBeschrijving.Enabled = true;
            txtNieuweVoorraad.Enabled = true;
            btnBladeren.Enabled = true;
            btnToepassen.Enabled = true;
            //leeg alles
            txtNieuweNaam.Clear();
            rtxtBeschrijving.Clear();
            txtNieuweVoorraad.Clear();
            picNieuweAfbeelding.Image = null;
            lblMateriaalID.ResetText();

            //vul alles
            txtNieuweNaam.Text = materiaal.Naam;
            rtxtBeschrijving.Text = materiaal.Beschrijving;
            txtNieuweVoorraad.Text = materiaal.Voorraad.ToString();
            picNieuweAfbeelding.Image = materiaal.Foto;
            lblMateriaalID.Text = materiaal.ID.ToString();
        }

        private void btnToepassen_Click(object sender, EventArgs e)
        {
            //aanpassen in datatbase
            MateriaalDA.MateriaalUpdate(txtNieuweNaam.Text, rtxtBeschrijving.Text, Convert.ToInt16(txtNieuweVoorraad.Text), picNieuweAfbeelding, Convert.ToInt32(lblMateriaalID.Text));

            //niets geselecteerd --> ZONDER DIT CRASHT HET PROGRAMMA NA EEN VERANDERING
            lsvMateriaal.SelectedItems.Clear();
            //leeg listview
            lsvMateriaal.Items.Clear();
            //opnieuw opvullen met geüpdatete item
            foreach (Materiaal materiaal in MateriaalDA.OphalenMateriaal())
            {
                lsvMateriaal.Items.Add(materiaal.Naam);
            }
        }

        private void btnBladeren_Click(object sender, EventArgs e)
        {
            try
            {
                //openfiledialog = ofdFoto
                ofdFoto.Title = "Selecteer een bestand";
                ofdFoto.FileName = string.Empty;
                ofdFoto.ShowHelp = false;
                ofdFoto.Filter = "Image Files (*.JPG;*.PNG;*JPEG) |*.JPG;*.PNG;*JPEG";
                //open de verkenner
                DialogResult result = ofdFoto.ShowDialog();
                //als je niet op cancel klikt:
                if (result != DialogResult.Cancel)
                {
                    //textbox opvullen met bestandspad
                    txtNieuweFotoLocatie.Text = ofdFoto.FileName;
                    //preview weergeven
                    picNieuweAfbeelding.ImageLocation = ofdFoto.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}