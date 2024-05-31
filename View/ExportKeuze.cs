using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using Microsoft.Office.Interop.Excel;
using prjSportnetKinda.DA;
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

namespace prjSportnetKinda.View
{
    public partial class ExportKeuze : Form
    {
        Gebruiker g1;
        public ExportKeuze(Gebruiker g)
        {
            InitializeComponent();

            //gebruiker om te check of iemand beheerder is
            g1 = g;
        }

        //list wordt gevuld met alle logs als je beheerder bent, gebruiker ziet alleen zijn eigen logs
        private List<Logboek> LogboekOphalenVoorExport()
        {
            List<Logboek> loglist = new List<Logboek>();
            //rijen onder de koppen vullen
            if (g1.Beheerder)
            {
                //Per persoon
                foreach (Logboek log in LogboekDA.AantalUniekeGebruikersEnHunIDs())
                {
                    //rijen opvullen met data
                    foreach (Logboek logboek in LogboekDA.OphalenLogboek(log.GebruikerID))
                    {
                        loglist.Add(logboek);
                    }
                }
            }
            else
            {
                loglist = LogboekDA.OphalenLogboek(g1.GebruikerID);
            }
            
            return loglist;
        }

        private void ExportPDF(List<Logboek> loglist, string pad)
        {
            //document maken uit klasse van ITextSharp (Plugin --> NuGet)
            Document document = new Document();
            try
            {
                PdfWriter.GetInstance(document, new FileStream(pad, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(5); //4 kolommen
                // Set column widths
                float[] kolombreedte = { 2f, 5f, 5f, 2f,2.5f }; // Adjust widths as necessary
                table.SetWidths(kolombreedte);

                // Adding headers
                table.AddCell("LogID");
                table.AddCell("Gehuurd door");
                table.AddCell("MateriaalNaam");
                table.AddCell("Aantal");
                table.AddCell("Voorraad");

                // Adding data rows
                foreach (Logboek logboek in loglist)
                {
                    table.AddCell(logboek.LogID.ToString());
                    table.AddCell(logboek.Gebruiker.Voornaam + logboek.Gebruiker.Naam);
                    table.AddCell(logboek.Materiaal.MateriaalNaam.ToString());
                    table.AddCell(logboek.Aantal.ToString());
                    table.AddCell(logboek.Materiaal.Voorraad.ToString());
                }

                document.Add(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                //list doorgeven
                List<Logboek> loglist = LogboekOphalenVoorExport();
                

                //bestand opslaan
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    //welk soort bestand word gemaakt?
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                    //toon pdf als eerste optie
                    saveFileDialog.FilterIndex = 1;

                    //onthouden waar het bestand is opgeslaan moest je nog iets willen opslaan in dezelfde directory
                    saveFileDialog.RestoreDirectory = true;

                    //als iemand een locatie gevonden heeft en "OK" klikt
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //pad opslaan
                        string pad = saveFileDialog.FileName;
                        //methode --> lijst en pad doorgeven
                        ExportPDF(loglist, pad);
                        //inlichten van de gebruiker
                        MessageBox.Show("Uw data werd succesvol geexporteerd!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                //kleine form sluiten --> proces compleet
                this.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //lijst opvullen
                List<Logboek> loglist = LogboekOphalenVoorExport();

                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls*", ValidateNames = true })
                {
                    //filedialog openen --> save locatie kiezen
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        //werkblad aanmaken in excel
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                        Worksheet ws = (Worksheet)app.ActiveSheet;

                        //autofit deed wel wat raar dus autofit met enkele aanpassingen
                        ws.Columns[9].ColumnWidth = 22;
                        ws.Columns[12].ColumnWidth = 18;
                        ws.Columns[13].ColumnWidth = 18;
                        app.Columns.AutoFit();
                        app.Rows.AutoFit();
                        app.Visible = false;

                        //titel van de kolommen
                        ws.Cells[1, 1] = "LogID";
                        ws.Cells[1, 2] = "GebruikerID";
                        ws.Cells[1, 3] = "Voornaam";
                        ws.Cells[1, 4] = "Naam";
                        ws.Cells[1, 5] = "GehuurdMateriaalID";
                        ws.Cells[1, 6] = "Datum";
                        ws.Cells[1, 7] = "MateriaalID";
                        ws.Cells[1, 8] = "MateriaalNaam";
                        ws.Cells[1, 9] = "Beschrijving";
                        ws.Cells[1, 10] = "Voorraad";
                        ws.Cells[1, 11] = "Email";
                        ws.Cells[1, 12] = "LidSinds";
                        ws.Cells[1, 13] = "Geboortedatum";
                        ws.Cells[1, 14] = "Renner";
                        ws.Cells[1, 15] = "Trainer";
                        ws.Cells[1, 16] = "Beheerder";

                        //rijen onder de koppen vullen
                        //Per persoon
                        int intTeller = 0;
                        foreach (Logboek logboek in loglist)
                        {
                            intTeller++;
                            ws.Cells[intTeller, 1] = logboek.LogID.ToString();
                            ws.Cells[intTeller, 2] = logboek.GebruikerID.ToString();
                            ws.Cells[intTeller, 3] = logboek.Gebruiker.Voornaam.ToString();
                            ws.Cells[intTeller, 4] = logboek.Gebruiker.Naam.ToString();
                            ws.Cells[intTeller, 5] = logboek.GehuurdMateriaalID.ToString();
                            ws.Cells[intTeller, 6] = logboek.Datum.ToString();
                            ws.Cells[intTeller, 7] = logboek.Materiaal.ID.ToString();
                            ws.Cells[intTeller, 8] = logboek.Materiaal.MateriaalNaam.ToString();
                            ws.Cells[intTeller, 9] = logboek.Materiaal.Beschrijving.ToString();
                            ws.Cells[intTeller, 10] = logboek.Materiaal.Voorraad.ToString();
                            ws.Cells[intTeller, 11] = logboek.Gebruiker.Email.ToString();
                            ws.Cells[intTeller, 12] = logboek.Gebruiker.Lidsinds.ToString();
                            ws.Cells[intTeller, 13] = logboek.Gebruiker.Geboortedatum.ToString();
                            ws.Cells[intTeller, 14] = logboek.Gebruiker.Renner.ToString();
                            ws.Cells[intTeller, 15] = logboek.Gebruiker.Trainer.ToString();
                            ws.Cells[intTeller, 16] = logboek.Gebruiker.Beheerder.ToString();
                    }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Uw data werd succesvol geexporteerd!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
