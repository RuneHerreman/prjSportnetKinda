using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjSportnetKinda.Model;
using MySql.Data.MySqlClient;
using System.Drawing;
using prjSportnetKinda.Helper;

namespace prjSportnetKinda.DA
{
    public class ArtikelDA
    {
        public static ArtikelDA Artiekel(string titel, DateTime datum, string artiekel, Image foto)
        {
            //query
            //alle velden uit de tabel geordend op aflopend id (10, 9, 8, 7) --> recentst eerst
            string query = "SELECT * FROM tblArtiekels ORDER BY tblArtiekels.id DESC";

            //open connectie
            MySqlConnection conn = Database.MakeConnection();

            //commando maken
            MySqlCommand cmdArtiekel = new MySqlCommand(query, conn);

            return new ArtikelDA();
        }
    }
}
