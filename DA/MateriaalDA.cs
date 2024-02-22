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
                List<Materiaal> MateriaalList = new List<Materiaal>();

                //query
                //alle velden uit de tabel geordend op aflopend id (10, 9, 8, 7) --> recentst eerst
                string query = "SELECT * FROM tblMateriaal ORDER BY tblMateriaal.MateriaalID DESC";

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //commando maken
                MySqlCommand cmdArtikel = new MySqlCommand(query, conn);
                cmdArtikel.CommandText = query;

                //reader
                MySqlDataReader reader = cmdArtikel.ExecuteReader();


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
                System.Windows.Forms.MessageBox.Show(exc.Message);

                return null;
            }
        }

        //mehode schrijven om de gegevens vanuit ons model in een soort rij te steken
        private static Materiaal Create(IDataRecord record)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                byte[] arrFoto = (byte[])(record["foto"]);
                Image img;
                try
                {
                    MemoryStream ms = new MemoryStream(arrFoto);
                    img = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    img = null;
                }

                return new Materiaal()
                {
                    ID = Convert.ToInt16(record["id"]),
                    Naam = record["naam"].ToString(),
                    Beschrijving = record["beschrijving"].ToString(),
                    Foto = img
                };
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Materiaal();
            }
        }
    }
}
