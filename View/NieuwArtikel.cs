﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using prjSportnetKinda.DA;

namespace prjSportnetKinda.View
{
    public partial class NieuwArtikel : Form
    {
        //object van main maken
        Main main1;
        public NieuwArtikel(Main main)
        {
            InitializeComponent();

            //gelijkstellen aan het open Main formulier
            main1 = main;
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
                    txtFotoNieuw.Text = ofdFoto.FileName;
                    //preview weergeven
                    picNieuwArtikelPreview.ImageLocation = ofdFoto.FileName.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtTitelNieuw_TextChanged(object sender, EventArgs e)
        {
            //hoeveel karakters mag ik hebben
            lblLengte.BackColor = Color.Transparent;
            lblLengte.Text = txtTitelNieuw.TextLength + "/44";
            if (txtTitelNieuw.TextLength >44)
            {
                lblLengte.ForeColor = Color.Red;
            }
        }

        private void txtArtikelNieuw_TextChanged(object sender, EventArgs e)
        {
            //hoeveel karakters mag ik hebben
            lblLengteArtikel.BackColor = Color.Transparent;
            lblLengteArtikel.Text = txtArtikelNieuw.TextLength + "/50000";
            if (txtArtikelNieuw.TextLength > 50000)
            {
                lblLengteArtikel.ForeColor = Color.Red;
            }
        }

        private void btnArtikelOpslaan_Click(object sender, EventArgs e)
        {
            try
            {
                if (picNieuwArtikelPreview.Image != null)
                {
                    //foto's omzetten naar byte array
                    MemoryStream msProfiel = new MemoryStream();
                    picNieuwArtikelPreview.Image.Save(msProfiel, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrFoto = msProfiel.GetBuffer();

                    if (arrFoto.Length < 2000000)
                    {
                        //Is er een titel en beschrijving?
                        if (txtArtikelNieuw.Text == "" || txtTitelNieuw.Text == "")
                        {
                            MessageBox.Show("Vul alle velden in alstublieft");
                        }
                        else
                        {
                            ArtikelDA.ArtikelMaken(txtTitelNieuw.Text, txtArtikelNieuw.Text, arrFoto);
                            //refresh de artikel om nieuwe artikels ook weer te geven
                            main1.ArtikelRefresh();
                        }
                        //textboxes legen
                        txtArtikelNieuw.ResetText();
                        txtTitelNieuw.ResetText();
                        txtFotoNieuw.ResetText();
                        picNieuwArtikelPreview.Image = null;
                    }
                    else
                    {
                        //Foutmelding
                        MessageBox.Show("De foto is te groot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Foutmelding
                    MessageBox.Show("Voeg eerst een foto toe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                //Foutmelding
                MessageBox.Show("Er is heeft zich een fout opgetreden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }  
    }
}
