using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.DA
{
    public class LogboekDA
    {
        public static void HuurMateriaal(int intGebruikerID, string strGehuurdMateriaal, DateTime dtDatum)
        {
            //query
            string query = "INSERT INTO `tbllogboek`(`GebruikerID`, `GehuurdMateriaal`, `Datum`) VALUES (@GebruikerID,@GehuurdMateriaal,@Datum)";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdLogboek = new MySqlCommand(query, conn);
            cmdLogboek.CommandText = query;

            //parameters
            cmdLogboek.Parameters.AddWithValue("@GebruikerID", intGebruikerID);
            cmdLogboek.Parameters.AddWithValue("@GehuurdMateriaal", strGehuurdMateriaal);
            cmdLogboek.Parameters.AddWithValue("@Datum", dtDatum);

            //uitvoeren
            cmdLogboek.ExecuteNonQuery();

            //connectie sluiten
            Database.CloseConnection(conn);
        }
    }
}
