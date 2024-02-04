using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjSportnetKinda.Model;
using MySql.Data.MySqlClient;
using System.Drawing;
using prjSportnetKinda.Helper;
using System.Data;
using System.Windows;
using System.IO;

namespace prjSportnetKinda.DA
{
    public class ArtikelDA
    {
        //methode om gegevens voor artikels op te halen uit de databank en opslaan in een List
        public static List<Artikel> OphalenArtikel()
        {
            try
            {
                //lijst maken
                List<Artikel> ArtikelList = new List<Artikel>();

                //query
                //alle velden uit de tabel geordend op aflopend id (10, 9, 8, 7) --> recentst eerst
                string query = "SELECT * FROM tblArtikels ORDER BY tblArtikels.id DESC";

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //commando maken
                MySqlCommand cmdArtikel = new MySqlCommand(query, conn);
                cmdArtikel.CommandText = query;

                //reader
                MySqlDataReader reader = cmdArtikel.ExecuteReader();


                while (reader.Read())
                {
                    ArtikelList.Add(Create(reader));
                }

                //connecties sluiten
                reader.Close();
                Database.CloseConnection(conn);

                return ArtikelList;
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        //mehode schrijven om de gegevens vanuit ons model in een soort rij te steken
        private static Artikel Create(IDataRecord record)
        {
            try
            {
                ////////////ImageConverter converter = new ImageConverter();
                return new Artikel()
                {
                    
                    datum = Convert.ToDateTime(record["datum"].ToString()),
                    titel = record["titel"].ToString(),
                    artikel = record["artikel"].ToString(),
                    ////////////////foto = (byte[])converter.ConvertTo(record["foto"].ToString(), typeof(byte[])),
                };
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Artikel();
            }
        }
    }
}
