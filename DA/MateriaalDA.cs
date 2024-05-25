using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace prjSportnetKinda.DA
{
    public class MateriaalDA
    {
        //methode om gegevens voor artikels op te halen uit de databank en opslaan in een List
        public static List<Materiaal> OphalenMateriaal()
        {
            try
            {
                //list aanmaken
                List<Materiaal> MateriaalList = new List<Materiaal>();

                //query
                //alle velden uit de tabel geordend op aflopend id (10, 9, 8, 7) --> recentst eerst
                string query = "SELECT * FROM tblMateriaal ORDER BY tblMateriaal.MateriaalID DESC";

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //commando maken
                MySqlCommand cmdMateriaalOphalen = new MySqlCommand(query, conn);
                cmdMateriaalOphalen.CommandText = query;

                //reader maken
                MySqlDataReader reader = cmdMateriaalOphalen.ExecuteReader();

                //zorgen dat de reader de data in een List steekt
                while (reader.Read())
                {
                    MateriaalList.Add(Create(reader));
                }

                //connecties sluiten
                reader.Close();
                Database.CloseConnection(conn);

                return MateriaalList;
            }
            catch (Exception exc)
            {
                //bericht in geval van error
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return null;
            }
        }

        //mehode schrijven om de gegevens vanuit ons model in een soort rij te steken
        private static Materiaal Create(IDataRecord record)
        {
            try
            {
                //zet de byte array om naam een foto
                //maak een convertor aan
                ImageConverter converter = new ImageConverter();
                //record toevoegen
                byte[] arrFoto = (byte[])(record["foto"]);
                //het object dat de foto zal opvangen
                Image img;
                try
                {
                    //array in een memorystream doen
                    MemoryStream ms = new MemoryStream(arrFoto);
                    //het image object van daarnet is gelijk aan de image die je uit de byte array haalt
                    img = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    //foto leeg laten als er een erroro
                    img = null;
                }

                //de rest van de velden als records invoegen
                return new Materiaal()
                {
                    //id is nodig om te identificeren welke userControl er wordt gebruikt
                    ID = Convert.ToInt16(record["MateriaalID"]),
                    MateriaalNaam = record["materiaalnaam"].ToString(),
                    Beschrijving = record["beschrijving"].ToString(),
                    //foto van hierboven
                    Foto = img,
                    Voorraad = Convert.ToInt32(record["voorraad"].ToString())
                };
            }
            catch (Exception exc)
            {
                //toon de error message als er iets mis gaat en return een Materiaal met lege waarden
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Materiaal();
            }
        }

        public static void HuurMateriaal(int intNieuweVoorraad, int intMateriaalID)
        {
            try
            {
                //query
                string query = "UPDATE `tblmateriaal` SET `Voorraad`=@Voorraad WHERE `MateriaalID`=@MateriaalID";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();
                MySqlCommand cmdHuurMateriaal = new MySqlCommand(query, conn);
                cmdHuurMateriaal.CommandText = query;

                //parameters
                cmdHuurMateriaal.Parameters.AddWithValue("@Voorraad", intNieuweVoorraad);
                cmdHuurMateriaal.Parameters.AddWithValue("@MateriaalID", intMateriaalID);

                //uitvoeren
                cmdHuurMateriaal.ExecuteNonQuery();

                //connectie sluiten
                Database.CloseConnection(conn);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void MateriaalMaken(string strNaam, string strBeschrijving, int intVoorraad, PictureBox pictureBox)
        {
            try
            {
                //foto omzetten naar byte array
                MemoryStream ms = new MemoryStream();
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrFoto = ms.GetBuffer();

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //query maken
                string query = "INSERT INTO `tblmateriaal`(`MateriaalNaam`, `Beschrijving`, `Voorraad`, `Foto`) VALUES (@Naam, @Beschrijving, @Voorraad, @Foto)";
                //commando maken
                MySqlCommand cmdMateriaalMaken = new MySqlCommand(query, conn);
                cmdMateriaalMaken.CommandText = query;

                cmdMateriaalMaken.Parameters.AddWithValue("@Naam", strNaam);
                cmdMateriaalMaken.Parameters.AddWithValue("@Beschrijving", strBeschrijving);
                cmdMateriaalMaken.Parameters.AddWithValue("@Voorraad", intVoorraad);
                cmdMateriaalMaken.Parameters.AddWithValue("@Foto", arrFoto);

                cmdMateriaalMaken.ExecuteNonQuery();

                //confirmatie
                System.Windows.MessageBox.Show("Nieuw materiaal opgeslaan in database", "Nieuwe Materiaal opgeslaan", MessageBoxButton.OK);
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message);
            }
        }

        public static void MateriaalUpdate(string strNaam, string strBeschrijving, int intVoorraad, PictureBox pictureBox, int intMateriaalID)
        {
            try
            {
                //foto omzetten naar byte array
                MemoryStream ms = new MemoryStream();
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrFoto = ms.GetBuffer();

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //query maken
                string query = "UPDATE `tblmateriaal` SET `MateriaalNaam`=@Naam,`Beschrijving`=@Beschrijving,`Voorraad`=@Voorraad,`Foto`=@Foto WHERE `MateriaalID`=@MateriaalID";
                //commando maken
                MySqlCommand cmdMateriaalUpdate = new MySqlCommand(query, conn);
                cmdMateriaalUpdate.CommandText = query;

                cmdMateriaalUpdate.Parameters.AddWithValue("@Naam", strNaam);
                cmdMateriaalUpdate.Parameters.AddWithValue("@Beschrijving", strBeschrijving);
                cmdMateriaalUpdate.Parameters.AddWithValue("@Voorraad", intVoorraad);
                cmdMateriaalUpdate.Parameters.AddWithValue("@Foto", arrFoto);
                cmdMateriaalUpdate.Parameters.AddWithValue("@MateriaalID", intMateriaalID);

                cmdMateriaalUpdate.ExecuteNonQuery();

                //confirmatie
                System.Windows.MessageBox.Show("Materiaal aangepast in database", "Materiaal aangepast opgeslaan", MessageBoxButton.OK);
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message);
            }
        }
        public static void MateriaalVerwijderen(int intMateriaalID)
        {
            try
            {
                //query
                string query = "DELETE FROM `tblmateriaal` WHERE MateriaalID=@MateriaalID";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();
                MySqlCommand cmdMateriaalVerwijderen = new MySqlCommand(query, conn);
                cmdMateriaalVerwijderen.CommandText = query;

                //parameters
                cmdMateriaalVerwijderen.Parameters.AddWithValue("@MateriaalID", intMateriaalID);

                //uitvoeren
                cmdMateriaalVerwijderen.ExecuteNonQuery();

                //connectie sluiten
                Database.CloseConnection(conn);

                //mbox
                System.Windows.MessageBox.Show("Materiaal verwijderd uit database", "Materiaal verwijderd", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }


    }
}
