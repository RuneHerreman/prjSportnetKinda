using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace prjSportnetKinda.DA
{
    public class TrainingDA
    {
        public static List<Training> OphalenTraining(DateTime dtSelectedDateStart, DateTime dtSelectedDateEnd)
        {
            List<Training> Trainingen = new List<Training>();

            //SQL query
            string query = "SELECT * FROM tbltraining WHERE Datum BETWEEN @selectedDateStart AND @selectedDateEnd";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdTraining = new MySqlCommand(query, conn);
            cmdTraining.CommandText = query;

            //parameters
            cmdTraining.Parameters.AddWithValue("@datum", DateTime.Now.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"));
            cmdTraining.Parameters.AddWithValue("@selectedDateStart", dtSelectedDateStart);
            cmdTraining.Parameters.AddWithValue("@selectedDateEnd", dtSelectedDateEnd);

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
                    TrainingID = Convert.ToInt32(record["trainingID"]),
                    Locatie = record["locatie"].ToString(),
                    Categorie = record["categorie"].ToString(),
                    Datum = Convert.ToDateTime(record["datum"].ToString()),
                    Deelnemers = record["deelnemers"].ToString(),
                    Trainer = record["trainer"].ToString(),
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new Training();
            }
        }

        //Deelnemer toevoegen aan training
        public static void DeelnemerToevoegen(int intTrainingID, int intGebruikerID)
        {
            //oude deelnemers opvangen
            string strDeelnemers;
            //huidige deelnemers ophalen
            string DeelnemersOudOphalen = "SELECT `Deelnemers` FROM `tbltraining` WHERE `TrainingID`=@trainingID";
            //SQL query
            string DeelnemersUpdate = "UPDATE `tbltraining` SET `Deelnemers`=@deelnemersNieuw  WHERE `TrainingID`=@trainingID";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdDeelnemersOud= new MySqlCommand(DeelnemersOudOphalen, conn);
            cmdDeelnemersOud.CommandText = DeelnemersOudOphalen;

            //parameters
            cmdDeelnemersOud.Parameters.AddWithValue("@trainingID", intTrainingID);

            //deelnemers ophalen en opslaan
            strDeelnemers = cmdDeelnemersOud.ExecuteScalar().ToString();

            //zijn er al deelnemers
            if (strDeelnemers == "")
            {
                strDeelnemers = intGebruikerID.ToString();
            }
            //Heb je al deel genomen???
            else if(strDeelnemers.Contains(intGebruikerID.ToString()) == false)
            {
                //waarde toevoegen waarmee ze laten de IDs kan splitsen (-)
                strDeelnemers += "-" + intGebruikerID.ToString();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Je doet al mee met deze wedstrijd", "Fout", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            //commando UPDATE deelnemers
            MySqlCommand cmdDeelnemerToevoegen = new MySqlCommand(DeelnemersUpdate, conn);
            cmdDeelnemerToevoegen.CommandText = DeelnemersUpdate;

            //parameters
            cmdDeelnemerToevoegen.Parameters.AddWithValue("@deelnemersNieuw", strDeelnemers);
            cmdDeelnemerToevoegen.Parameters.AddWithValue("@trainingID", intTrainingID);

            cmdDeelnemerToevoegen.ExecuteNonQuery();
        }
    }
}
