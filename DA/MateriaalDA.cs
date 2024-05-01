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
                MySqlCommand cmdArtikel = new MySqlCommand(query, conn);
                cmdArtikel.CommandText = query;

                //reader maken
                MySqlDataReader reader = cmdArtikel.ExecuteReader();

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
                    Naam = record["naam"].ToString(),
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
    }
}
