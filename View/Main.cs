using prjSportnetKinda.DA;
using prjSportnetKinda.Model;
using prjSportnetKinda.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace prjSportnetKinda
{
    public partial class Main : Form
    {
        public Main(Model.Gebruiker login)
        {
            InitializeComponent();
            tcMain.Appearance = TabAppearance.FlatButtons;
            tcMain.ItemSize = new Size(0, 1);
            tcMain.SizeMode = TabSizeMode.Fixed;

            try
            {
                int intTellerArtikels = 0;
                foreach (Artikel artikel in ArtikelDA.OphalenArtikel())
                {

                    intTellerArtikels++;
                    WelkomItem item = new WelkomItem();
                    WelkomItem.ArtikelOpvullen(artikel.titel, artikel.artikel, artikel.datum, item); ;

                    fpnlArtiekelContainer.Controls.Add(item);

                }
            }
            catch (Exception)
            {

                throw;
            }


            for (int intTeller = 1; intTeller < 10; intTeller++)
            {
                MateriaalItem materiaalItem= new MateriaalItem();
                fpnlMateriaalContainer.Controls.Add(materiaalItem);

            }


            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_select;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_select;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            //data invullen
            this.lblNaamVoornaam.Text = "Welkom " + login.Voornaam + " " + login.Naam;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //verander tab
            tcMain.SelectTab(tabStart);

            //toon alleen geselecteerde tab
            this.btnStart.NormaalFoto1 = Properties.Resources.home_select;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            //verander tab
            tcMain.SelectTab(tabKalender);

            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_select;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
        }

        private void btnMateriaal_Click(object sender, EventArgs e)
        {
            //verander tab
            tcMain.SelectTab(tabMateriaal);

            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_select;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.Image = Properties.Resources.user_standard;
            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_standard;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
        }

        private void btnProfiel_Click(object sender, EventArgs e)
        {
            //toon alleen geselecteerde tab
            this.btnStart.Image = Properties.Resources.home_standard;
            this.btnStart.NormaalFoto1 = Properties.Resources.home_standard;
            this.btnStart.HoverFoto1 = Properties.Resources.home_select;

            this.btnKalender.Image = Properties.Resources.calendar_standard;
            this.btnKalender.NormaalFoto1 = Properties.Resources.calendar_standard;
            this.btnKalender.HoverFoto1 = Properties.Resources.calendar_select;

            this.btnMateriaal.Image = Properties.Resources.cart_standard;
            this.btnMateriaal.NormaalFoto1 = Properties.Resources.cart_standard;
            this.btnMateriaal.HoverFoto1 = Properties.Resources.cart_select;

            this.btnProfiel.NormaalFoto1 = Properties.Resources.user_select;
            this.btnProfiel.HoverFoto1 = Properties.Resources.user_select;
            //verander tab
            tcMain.SelectTab(tabProfiel);
        }

        private void btnArtiekelToevoegen_Click(object sender, EventArgs e)
        {
            NieuwArtiekel nieuwArtiekel = new NieuwArtiekel();
            nieuwArtiekel.ShowDialog();
        }
    }
}
