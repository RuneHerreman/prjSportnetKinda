using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjSportnetKinda.Model;
using prjSportnetKinda.DA;

namespace prjSportnetKinda.View
{
    public partial class ActiviteitToevoegen : Form
    {
        public ActiviteitToevoegen()
        {
            InitializeComponent();

            //Radiobutton checked op false zetten
            rdbTraining.Checked = false;

            //Textboxes hidden
            txtDatum.Visible = false;
            txtStart.Visible = false;
            txtLocatie.Visible = false;
            txtDuur.Visible = false;
            txtInfo1.Visible = false;
            txtInfo2.Visible = false;
            txtInfo3.Visible = false;

            //Labels hidden
            lblDatum.Visible = false;
            lblStart.Visible = false;
            lblLocatie.Visible = false;
            lblDuur.Visible = false;
            lblInfo1.Visible = false;
            lblInfo2.Visible = false;
            lblInfo3.Visible = false;

            //Button hidden
            btnToevoegen.Visible = false;
        }

        private void AllesTonen()
        {
            //Textboxes tonen
            txtDatum.Visible = true;
            txtStart.Visible = true;
            txtLocatie.Visible = true;
            txtDuur.Visible = true;
            txtInfo1.Visible = true;
            if (rdbFeest.Checked)
            {
                chkEten.Visible = true;
                txtInfo2.Visible = false;
            }
            else
            {
                txtInfo2.Visible = true;
                chkEten.Visible = false;
            }
            txtInfo3.Visible = true;

            //Labels tonen
            lblDatum.Visible = true;
            lblStart.Visible = true;
            lblLocatie.Visible = true;
            lblDuur.Visible = true;
            lblInfo1.Visible = true;
            lblInfo2.Visible = true;
            lblInfo3.Visible = true;

            //Textboxes legen
            txtInfo1.Clear();
            txtInfo2.Clear();
            txtInfo3.Clear();
            chkEten.Checked = false;

            //Button tonen
            btnToevoegen.Visible = true;
        }

        private void btnDeelnemen_Click(object sender, EventArgs e)
        {
            //Navragen
            DialogResult result = MessageBox.Show("Wil je deze activitiet toevoegen?", "Activiteit toevoegen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                try
                {
                    if (txtDatum.Text != "" && txtStart.Text != "" && txtLocatie.Text != "" && txtDuur.Text != "" && txtInfo1.Text != "" && txtInfo3.Text != "")
                    {
                        //Gegevens opslaan
                        Activiteit Activiteit = new Activiteit();

                        Activiteit.Datum = Convert.ToDateTime(txtDatum.Text).Date.Add(Convert.ToDateTime(txtStart.Text).TimeOfDay);
                        Activiteit.Locatie = txtLocatie.Text;
                        Activiteit.Duur = Convert.ToInt32(txtDuur.Text);

                        //gegevens afhankelijk van type
                        if (rdbTraining.Checked == true)
                        {
                            if (txtInfo2.Text != "")
                            {
                                Activiteit.Training = new Training();

                                Activiteit.Type = "Training";
                                Activiteit.Training.Categorieën = txtInfo1.Text;
                                Activiteit.Training.Trainer = txtInfo2.Text;
                                Activiteit.Training.Beschrijving = txtInfo3.Text;
                            }
                            else
                            {
                                //Foutmelding
                                MessageBox.Show("Alle velden moeten worden ingevuld", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (rdbWedstrijd.Checked == true)
                        {
                            if (txtInfo2.Text != "")
                            {
                                Activiteit.Wedstrijd = new Wedstrijd();

                                Activiteit.Type = "Wedstrijd";
                                Activiteit.Wedstrijd.Naam = txtInfo1.Text;
                                Activiteit.Wedstrijd.Type = txtInfo2.Text;
                                Activiteit.Wedstrijd.Organisator = txtInfo3.Text;
                            }
                            else
                            {
                                //Foutmelding
                                MessageBox.Show("Alle velden moeten worden ingevuld", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else if (rdbFeest.Checked == true)
                        {
                            Activiteit.Feest = new Feest();

                            Activiteit.Type = "Feest";
                            Activiteit.Feest.Organisator = txtInfo1.Text;
                            Activiteit.Feest.Eten = Convert.ToBoolean(chkEten.Checked);
                            Activiteit.Feest.Beschrijving = txtInfo3.Text;
                        }

                        //Activiteit toevoegen
                        if (ActiviteitDA.ActiviteitToevoegen(Activiteit) != null)
                        {
                            //Succes message
                            MessageBox.Show("De activiteit is toegevoegd");

                            //Textboxes legen
                            txtDatum.Clear();
                            txtStart.Clear();
                            txtLocatie.Clear();
                            txtDuur.Clear();
                            txtInfo1.Clear();
                            txtInfo2.Clear();
                            txtInfo3.Clear();
                            chkEten.Checked = false;
                        }
                        else
                        {
                            //Foutmelding
                            MessageBox.Show("Activiteit kon niet worden toegevoegd wegens een error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Foutmelding
                        MessageBox.Show("Alle velden moeten worden ingevuld", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    //Foutmelding
                    MessageBox.Show("Vul alle velden correct in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rdbTraining_CheckedChanged(object sender, EventArgs e)
        {
            //Labels aanpassen aan type
            lblInfo1.Text = "Categorieën:";
            lblInfo2.Text = "Trainer:";
            lblInfo3.Text = "Beschrijving:";

            //Alles tonen
            AllesTonen();
        }

        private void rdbWedstrijd_CheckedChanged(object sender, EventArgs e)
        {
            //Labels aanpassen aan type
            lblInfo1.Text = "Naam wedstrijd:";
            lblInfo2.Text = "Type:";
            lblInfo3.Text = "Organisator:";

            //Alles tonen
            AllesTonen();
        }

        private void rdbFeest_CheckedChanged(object sender, EventArgs e)
        {
            //Labels aanpassen aan type
            lblInfo1.Text = "Organisator:";
            lblInfo2.Text = "Eten:";
            lblInfo3.Text = "Beschrijving:";

            //Alles tonen
            AllesTonen();
        }
    }
}
