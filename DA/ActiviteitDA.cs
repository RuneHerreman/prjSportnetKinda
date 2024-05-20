using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace prjSportnetKinda.DA
{
    public class ActiviteitDA
    {
        public static List<Activiteit> OphalenActiviteiten(DateTime dtSelectedDateStart, DateTime dtSelectedDateEnd)
        {
            List<Activiteit> Activiteiten = new List<Activiteit>();

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();

            //SQL query
            string query = "SELECT * FROM tblactiviteit WHERE Datum BETWEEN @selectedDateStart AND @selectedDateEnd";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            //Parameters
            cmd.Parameters.AddWithValue("@selectedDateStart", dtSelectedDateStart);
            cmd.Parameters.AddWithValue("@selectedDateEnd", dtSelectedDateEnd);

            //reader
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Activiteiten.Add(Create(reader));
            }

            //reader sluiten
            reader.Close();

            //Connectie sluiten
            Database.CloseConnection(conn);

            return Activiteiten;
        }

        public static Activiteit Create(IDataRecord record)
        {
            try
            {
                return new Activiteit()
                {
                    ActiviteitID = Convert.ToInt32(record["ActiviteitID"]),
                    Type = record["Soort"].ToString(),
                    Datum = Convert.ToDateTime(record["Datum"].ToString()),
                    Locatie = record["Locatie"].ToString(),
                    Duur = Convert.ToInt32(record["Duur"]),
                    Deelnemers = record["Deelnemers"].ToString(),
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new Activiteit();
            }
        }
        
        public static Activiteit AllesOphalen(Activiteit a)
        {
            Activiteit activiteit = new Activiteit();

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();

            //SQL query met INNER JOIN afhankelijk van type activiteit
            string query = $"SELECT * FROM tblactiviteit INNER JOIN tbl{a.Type.ToLower()} ON tblactiviteit.ActiviteitID = tbl{a.Type.ToLower()}.ActiviteitID WHERE tblactiviteit.ActiviteitID = {a.ActiviteitID}";

            //Maken van het command
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //Welk soort gegevens is het commando
            cmd.CommandType = CommandType.Text;

            //Commando uitvoeren
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                reader.Read();
                activiteit.Type = reader["Soort"].ToString();
                activiteit.Datum = Convert.ToDateTime(reader["Datum"]);
                activiteit.Locatie = reader["Locatie"].ToString();
                activiteit.Duur = Convert.ToInt32(reader["Duur"]);
                activiteit.Deelnemers = reader["Deelnemers"].ToString();

                if (a.Type == "Training") //Alleen voor type training
                {
                    activiteit.Training = new Training();

                    activiteit.Training.Categorieën = reader["Categorieen"].ToString();
                    activiteit.Training.Trainer = reader["Trainer"].ToString();
                    activiteit.Training.Beschrijving = reader["Beschrijving"].ToString();
                }
                else if (a.Type == "Wedstrijd") //Alleen voor type wedstrijd
                {
                    activiteit.Wedstrijd = new Wedstrijd();

                    activiteit.Wedstrijd.Naam = reader["Naam"].ToString();
                    activiteit.Wedstrijd.Type = reader["Type"].ToString();
                    activiteit.Wedstrijd.Organisator = reader["Organisator"].ToString();
                }
                else if (a.Type == "Feest") //Alleen voor type feest
                {
                    activiteit.Feest = new Feest();

                    activiteit.Feest.Organisator = reader["Organisator"].ToString();
                    activiteit.Feest.Eten = Convert.ToBoolean(reader["Eten"]);
                    activiteit.Feest.Beschrijving = reader["Beschrijving"].ToString();
                }

                reader.Close();

                //Connection sluiten
                Database.CloseConnection(conn);

                return activiteit;
            }
            else
            {
                return null;
            }
        }

        public static void DeelnemerToevoegen(int intActiviteitID, int intGebruikerID)
        {
            //oude deelnemers opvangen
            string strDeelnemers;
            //huidige deelnemers ophalen
            string DeelnemersOudOphalen = "SELECT `Deelnemers` FROM `tblactiviteit` WHERE `ActiviteitID`=@activiteitID";
            //SQL query
            string DeelnemersUpdate = "UPDATE `tblactiviteit` SET `Deelnemers`=@deelnemersNieuw  WHERE `ActiviteitID`=@activiteitID";

            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();
            MySqlCommand cmdDeelnemersOud = new MySqlCommand(DeelnemersOudOphalen, conn);
            cmdDeelnemersOud.CommandText = DeelnemersOudOphalen;

            //parameters
            cmdDeelnemersOud.Parameters.AddWithValue("@activiteitID", intActiviteitID);

            //deelnemers ophalen en opslaan
            strDeelnemers = cmdDeelnemersOud.ExecuteScalar().ToString();

            //zijn er al deelnemers
            if (strDeelnemers == "")
            {
                strDeelnemers = intGebruikerID.ToString();

                //Succes
                System.Windows.Forms.MessageBox.Show("Je neemt nu deel aan deze activiteit");
            }
            //Heb je al deel genomen???
            else if (strDeelnemers.Contains(intGebruikerID.ToString()) == false)
            {
                //waarde toevoegen waarmee ze laten de IDs kan splitsen (-)
                strDeelnemers += "-" + intGebruikerID.ToString();

                //Succes
                System.Windows.Forms.MessageBox.Show("Je neemt nu deel aan deze activiteit");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Je neemt al deel aan deze activiteit", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            //commando UPDATE deelnemers
            MySqlCommand cmdDeelnemerToevoegen = new MySqlCommand(DeelnemersUpdate, conn);
            cmdDeelnemerToevoegen.CommandText = DeelnemersUpdate;

            //parameters
            cmdDeelnemerToevoegen.Parameters.AddWithValue("@deelnemersNieuw", strDeelnemers);
            cmdDeelnemerToevoegen.Parameters.AddWithValue("@activiteitID", intActiviteitID);

            cmdDeelnemerToevoegen.ExecuteNonQuery();
        }
    }
}
