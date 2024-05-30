using iTextSharp.text;
using iTextSharp.text.pdf;
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
        public ExportKeuze()
        {
            InitializeComponent();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf*", ValidateNames = true })
                {
                    //filedialog openen --> save locatie kiezen
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        var pdfDoc = new Document(PageSize.A4, 40f, 40f, 60f, 60f);
                        PdfWriter.GetInstance(pdfDoc, new FileStream(sfd.FileName, FileMode.OpenOrCreate));


                        var foto = Properties.Resources.download;
                        

                        var spacer = new Paragraph("")
                        {
                            SpacingBefore = 10f,
                            SpacingAfter = 10f,
                        };

                        pdfDoc.Add(spacer);
                        var kolombreedtes = new[] { 0.75f, 1f, 1.5f, 1f, 1f, 1f, 1f, 1f};

                        var tabel = new PdfPTable(kolombreedtes)
                        {
                            HorizontalAlignment = Left,
                            WidthPercentage = 75,
                            DefaultCell = { MinimumHeight = 22f }
                        };

                        var cel = new PdfPCell(new Phrase("Logboek Tabel"))
                        {
                            Colspan = 10,
                            HorizontalAlignment = 1, //0=links 1=middel 2=rechts
                            MinimumHeight = 30f
                        };

                        tabel.AddCell(cel);

                        foreach (Logboek log in LogboekDA.AantalUniekeGebruikersEnHunIDs())
                        {
                            //rijen opvullen met data
                            foreach (Logboek logboek in LogboekDA.OphalenLogboek(log.GebruikerID))
                            {
                                tabel.AddCell(logboek.LogID.ToString());
                                tabel.AddCell(logboek.GebruikerID.ToString());
                                tabel.AddCell(logboek.GehuurdMateriaalID.ToString());
                                tabel.AddCell(logboek.Aantal.ToString());
                            }
                        }

                        pdfDoc.Add(tabel);
                        pdfDoc.Close();

                        MessageBox.Show("Uw data werd succesvol geexporteerd");
                    }
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
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
                        foreach (Logboek log in LogboekDA.AantalUniekeGebruikersEnHunIDs())
                        {
                            //op welke rij zitten we 1 --> 0 = koppen
                            int intTeller = 1;

                            //rijen opvullen met data
                            foreach (Logboek logboek in LogboekDA.OphalenLogboek(log.GebruikerID))
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
                        }
                        wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                        app.Quit();
                        MessageBox.Show("Uw data werd succesvol geexporteerd");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
