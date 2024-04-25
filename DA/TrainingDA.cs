using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.DA
{
    public class TrainingDA
    {
        public static List<Training> OphalenTraining()
        {
            List<Training> Trainingen = new List<Training>();

            //SQL query
            string query = "SELECT * FROM tbltraining WHERE @datum>=Datum";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdTraining = new MySqlCommand(query, conn);
            cmdTraining.CommandText = query;

            //parameters
            cmdTraining.Parameters.AddWithValue("@datum", DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"));

            //reader
            MySqlDataReader reader = cmdTraining.ExecuteReader();

            while (reader.Read())
            {
                Trainingen.Add(Create(reader));
            }

            //reader sluiten
            reader.Close();
            Database.CloseConnection(conn);

            return Trainingen;
        }

        public static Training Create(IDataRecord record)
        {
            try
            {
                return new Training()
                {
                    Locatie = record["locatie"].ToString(),
                    Categorie = record["categorie"].ToString(),
                    Datum = Convert.ToDateTime(record["datum"].ToString()),
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new Training();
            }
        }
    }
}
