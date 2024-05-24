using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.DA
{

    public class LogboekDA
    {
        //maar van 1 persoon nodig
        public static List<Logboek> OphalenLogboek(int intGebruikerID)
        {
            try
            {
                //list aanmaken
                List<Logboek> LogboekList = new List<Logboek>();

                //query
                //alle velden uit de tabel geordend op aflopend id (10, 9, 8, 7) --> recentst eerst
                string query = "SELECT * FROM `tbllogboek` WHERE GebruikerID=@GebruikerID";

                //open connectie
                MySqlConnection conn = Database.MakeConnection();

                //commando maken
                MySqlCommand cmdLogboekOphalen = new MySqlCommand(query, conn);
                cmdLogboekOphalen.CommandText = query;

                cmdLogboekOphalen.Parameters.AddWithValue("@GebruikerID", intGebruikerID);

                //reader maken
                MySqlDataReader reader = cmdLogboekOphalen.ExecuteReader();

                //zorgen dat de reader de data in een List steekt
                while (reader.Read())
                {
                    LogboekList.Add(CreateLogboek(reader));
                }

                //connecties sluiten
                reader.Close();
                Database.CloseConnection(conn);

                return LogboekList;
            }
            catch (Exception exc)
            {
                //bericht in geval van error
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return null;
            }
        }

        public static Logboek CreateLogboek(IDataRecord record)
        {
            try
            {
                //de rest van de velden als records invoegen
                return new Logboek()
                {
                    GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                    GehuurdMateriaalID = record["GehuurdMateriaalID"].ToString(),
                    Aantal = record["Aantal"].ToString(),
                    Datum = Convert.ToDateTime(record["Datum"]),
                };
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Logboek();
            }
        }

        public static void HuurMateriaal(int intGebruikerID, int intAantal, int intMateriaalID, DateTime dtDatum)
        {
            //query
            string query = "INSERT INTO `tbllogboek`(`GebruikerID`,`Aantal`,`GehuurdMateriaalID`, `Datum`) VALUES (@GebruikerID,@Aantal,@GehuurdMateriaalID,@Datum)";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdLogboek = new MySqlCommand(query, conn);
            cmdLogboek.CommandText = query;

            //parameters
            cmdLogboek.Parameters.AddWithValue("@GebruikerID", intGebruikerID);
            cmdLogboek.Parameters.AddWithValue("@Aantal", intAantal);
            cmdLogboek.Parameters.AddWithValue("@GehuurdMateriaalID", intMateriaalID);
            cmdLogboek.Parameters.AddWithValue("@Datum", dtDatum);

            //uitvoeren
            cmdLogboek.ExecuteNonQuery();

            //connectie sluiten
            Database.CloseConnection(conn);
        }

        //hoeveel unieke gebruikers hebben logs lopende
        public static List<Logboek> AantalUniekeGebruikersEnHunIDs()
        {
            List<Logboek> AantalUniekeGebruikersEnHunIDsList = new List<Logboek>();
            //query
            //Hoeveel unieke userIDs in logboek?
            string query = "SELECT DISTINCT `GebruikerID` FROM `tbllogboek`";

            //open connectie
            MySqlConnection conn = Database.MakeConnection();

            //commando maken
            MySqlCommand cmdLogboekOphalen = new MySqlCommand(query, conn);
            cmdLogboekOphalen.CommandText = query;

            //reader maken
            MySqlDataReader reader = cmdLogboekOphalen.ExecuteReader();

            while (reader.Read())
            {
                AantalUniekeGebruikersEnHunIDsList.Add(CreateAantalUniekeGebruikersEnHunIDs(reader));
            }

            Database.CloseConnection(conn);
            return AantalUniekeGebruikersEnHunIDsList;
        }
        public static Logboek CreateAantalUniekeGebruikersEnHunIDs(IDataRecord record)
        {
            try
            {
                //de rest van de velden als records invoegen
                return new Logboek()
                {
                    GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                };
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                return new Logboek();
            }
        }
    }
}
