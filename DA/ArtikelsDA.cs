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
using System.Windows.Forms;

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
                MySqlCommand cmdArtikelsOphalen = new MySqlCommand(query, conn);
                cmdArtikelsOphalen.CommandText = query;

                //reader
                MySqlDataReader reader = cmdArtikelsOphalen.ExecuteReader();


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
                
                return new Artikel()
                {
                    datum = Convert.ToDateTime(record["datum"]),
                    titel = record["titel"].ToString(),
                    artikel = record["artikel"].ToString(),
                    foto = img,
                    ID = Convert.ToInt32(record["ID"])
                };
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Artikel();
            }
        }

        public static void ArtikelMaken(string strTitel, string strArtikel, PictureBox pictureBox)
        {
            try
            {
                //foto omzetten naar byte array
                MemoryStream ms = new MemoryStream();
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                byte[] arrFoto = ms.GetBuffer();

                //huidige datum
                DateTime dtHuidigeDatum = DateTime.Now;

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //query maken
                string query = "INSERT INTO `tblartikels`(`datum`, `titel`, `artikel`, `foto`) VALUES (@datum,@titel,@artikel,@foto)";
                //commando maken
                MySqlCommand cmdArtikelMaken = new MySqlCommand(query, conn);
                cmdArtikelMaken.CommandText = query;

                cmdArtikelMaken.Parameters.AddWithValue("@datum", dtHuidigeDatum.Date);
                cmdArtikelMaken.Parameters.AddWithValue("@titel", strTitel);
                cmdArtikelMaken.Parameters.AddWithValue("@artikel", strArtikel);
                cmdArtikelMaken.Parameters.AddWithValue("@foto", arrFoto);

                cmdArtikelMaken.ExecuteNonQuery();

                //confirmatie
                System.Windows.MessageBox.Show("Artikel opgeslaan in database", "Artikel opgeslaan", MessageBoxButton.OK);
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message, "", MessageBoxButton.OK);
            }
        }

        public static void ArtikelUpdate(string strTitel, string strArtikel, PictureBox pictureBox, int intArtikelID)
        {
            try
            {
                //foto omzetten naar byte array
                MemoryStream ms = new MemoryStream();
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                byte[] arrFoto = ms.GetBuffer();

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //query maken
                string query = "UPDATE `tblartikels` SET `titel`=@Titel,`artikel`=@Artikel,`foto`=@Foto WHERE `id`=@ArtikelID";
                //commando maken
                MySqlCommand cmdArtikelUpdate = new MySqlCommand(query, conn);
                cmdArtikelUpdate.CommandText = query;

                cmdArtikelUpdate.Parameters.AddWithValue("@Titel", strTitel);
                cmdArtikelUpdate.Parameters.AddWithValue("@Artikel", strArtikel);
                cmdArtikelUpdate.Parameters.AddWithValue("@Foto", arrFoto);
                cmdArtikelUpdate.Parameters.AddWithValue("@ArtikelID", intArtikelID);

                cmdArtikelUpdate.ExecuteNonQuery();

                //confirmatie
                System.Windows.MessageBox.Show("Artikel aangepast in database", "Artikel aangepast", MessageBoxButton.OK);
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message);
            }
        }
        public static void ArtikelVerwijderen(int intArtikelID)
        {
            try
            {
                //query
                string query = "DELETE FROM `tblartikels` WHERE `id`=@ArtikelID";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();
                MySqlCommand cmdArtikelVerwijderen = new MySqlCommand(query, conn);
                cmdArtikelVerwijderen.CommandText = query;

                //parameters
                cmdArtikelVerwijderen.Parameters.AddWithValue("@ArtikelID", intArtikelID);

                //uitvoeren
                cmdArtikelVerwijderen.ExecuteNonQuery();

                //connectie sluiten
                Database.CloseConnection(conn);

                //mbox
                System.Windows.MessageBox.Show("Artikel verwijderd uit database", "Artikel verwijderd", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
