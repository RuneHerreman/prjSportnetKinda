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
            string query = "SELECT * FROM tblactiviteit WHERE Datum BETWEEN @selectedDateStart AND @selectedDateEnd ORDER BY Datum";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            //Parameters
            cmd.Parameters.AddWithValue("@selectedDateStart", dtSelectedDateStart);
            cmd.Parameters.AddWithValue("@selectedDateEnd", dtSelectedDateEnd);

            //reader
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Activiteiten.Add(CreateActiviteit(reader));
            }

            //reader sluiten
            reader.Close();

            //Connectie sluiten
            Database.CloseConnection(conn);

            return Activiteiten;
        }

        public static Activiteit CreateActiviteit(IDataRecord record)
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
                activiteit.ActiviteitID = Convert.ToInt32(reader["ActiviteitID"]);
                activiteit.Type = reader["Soort"].ToString();
                activiteit.Datum = Convert.ToDateTime(reader["Datum"]);
                activiteit.Locatie = reader["Locatie"].ToString();
                activiteit.Duur = Convert.ToInt32(reader["Duur"]);

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

                activiteit.Deelnemers = DeelnemersOphalen(a);

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

        public static List<Gebruiker> DeelnemersOphalen(Activiteit a)
        {
            try
            {
                //List om Deelnemers in op te slaan
                List<Gebruiker> Deelnemers = new List<Gebruiker>();

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();

                //Query
                string query = "SELECT tblgebruiker.GebruikerID, Naam, Voornaam FROM tbldeelnemersactiviteit INNER JOIN tblgebruiker ON tbldeelnemersactiviteit.GebruikerID = tblgebruiker.GebruikerID WHERE tbldeelnemersactiviteit.ActiviteitID = @ActiviteitID";

                //Maken van het command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.CommandType = CommandType.Text;

                //Parameters
                cmd.Parameters.AddWithValue("@activiteitID", a.ActiviteitID);

                //reader
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Deelnemers.Add(CreateDeelnemers(reader));
                }

                //reader sluiten
                reader.Close();

                //Connectie sluiten
                Database.CloseConnection(conn);

                return Deelnemers;
            }
            catch
            {
                return null;
            }
        }

        public static Gebruiker CreateDeelnemers(IDataRecord record)
        {
            try
            {
                return new Gebruiker()
                {
                    Naam = (record["Naam"]).ToString(),
                    Voornaam = (record["Voornaam"]).ToString(),
                    GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new Gebruiker();
            }
        }

        public static void DeelnemerToevoegen(int intActiviteitID, int intGebruikerID)
        {
            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();

            //Query
            string query = "INSERT INTO tbldeelnemersactiviteit (ActiviteitID, GebruikerID) VALUES (@ActiviteitID, @GebruikerID)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            //Parameters
            cmd.Parameters.AddWithValue("@ActiviteitID", intActiviteitID);
            cmd.Parameters.AddWithValue("@GebruikerID", intGebruikerID);

            cmd.ExecuteNonQuery();

            //Connection sluiten
            Database.CloseConnection(conn);
        }

        public static void DeelnemerVerwijderen(int intActiviteitID, int intGebruikerID)
        {
            //verbinding maken
            MySqlConnection conn = Database.MakeConnection();

            //Query
            string query = "DELETE FROM tbldeelnemersactiviteit WHERE ActiviteitID=@ActiviteitID AND GebruikerID=@GebruikerID";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.CommandText = query;

            //Parameters
            cmd.Parameters.AddWithValue("@ActiviteitID", intActiviteitID);
            cmd.Parameters.AddWithValue("@GebruikerID", intGebruikerID);

            cmd.ExecuteNonQuery();

            //Connection sluiten
            Database.CloseConnection(conn);
        }

        public static Activiteit ActiviteitWijzigen(Activiteit a)
        {
            try
            {
                string queryType = "";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();

                //Query voor tabel activiteit
                string queryActiviteit = "UPDATE tblactiviteit SET Datum=@Datum, Locatie=@Locatie, Duur=@Duur WHERE ActiviteitID=@ActiviteitID";

                MySqlCommand cmdActiviteit = new MySqlCommand(queryActiviteit, conn);
                cmdActiviteit.CommandText = queryActiviteit;

                //parameters
                cmdActiviteit.Parameters.AddWithValue("@ActiviteitID", a.ActiviteitID);
                cmdActiviteit.Parameters.AddWithValue("@Datum", a.Datum);
                cmdActiviteit.Parameters.AddWithValue("@Locatie", a.Locatie);
                cmdActiviteit.Parameters.AddWithValue("@Duur", a.Duur);

                MySqlCommand cmdType = new MySqlCommand(queryType, conn);

                //Query afhankelijk van type
                if (a.Training != null)
                {
                    //Query voor tabel activiteit
                    queryType = "UPDATE tbltraining SET Categorieen=@Categorieen, Trainer=@Trainer, Beschrijving=@Beschrijving WHERE ActiviteitID=@ActiviteitID";

                    cmdType.CommandText = queryType;

                    //Parameters Training
                    cmdType.Parameters.AddWithValue("@ActiviteitID", a.ActiviteitID);
                    cmdType.Parameters.AddWithValue("@Categorieen", a.Training.Categorieën);
                    cmdType.Parameters.AddWithValue("@Trainer", a.Training.Trainer);
                    cmdType.Parameters.AddWithValue("@Beschrijving", a.Training.Beschrijving);
                }
                else if (a.Wedstrijd != null)
                {
                    //Query voor tabel activiteit
                    queryType = "UPDATE tblWedstrijd SET Naam=@Naam, Type=@Type, Organisator=@Organisator WHERE ActiviteitID=@ActiviteitID";

                    cmdType.CommandText = queryType;

                    //Parameters Wedstrijd
                    cmdType.Parameters.AddWithValue("@ActiviteitID", a.ActiviteitID);
                    cmdType.Parameters.AddWithValue("@Naam", a.Wedstrijd.Naam);
                    cmdType.Parameters.AddWithValue("@Type", a.Wedstrijd.Type);
                    cmdType.Parameters.AddWithValue("@Organisator", a.Wedstrijd.Organisator);
                }
                else if (a.Feest != null)
                {
                    //Query voor tabel activiteit
                    queryType = "UPDATE tblFeest SET Organisator=@Organisator, Eten=@Eten, Beschrijving=@Beschrijving WHERE ActiviteitID=@ActiviteitID";

                    cmdType.CommandText = queryType;

                    //Parameters Feest
                    cmdType.Parameters.AddWithValue("@ActiviteitID", a.ActiviteitID);
                    cmdType.Parameters.AddWithValue("@Organisator", a.Feest.Organisator);
                    cmdType.Parameters.AddWithValue("@Eten", a.Feest.Eten);
                    cmdType.Parameters.AddWithValue("@Beschrijving", a.Feest.Beschrijving);
                }
                else
                {
                    return null;
                }

                //Commando's uitvoeren
                cmdActiviteit.ExecuteNonQuery();
                cmdType.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return new Activiteit();
            }
            catch
            {
                return null;
            }
        }

        public static Activiteit ActiviteitVerwijderen(Activiteit a)
        {
            try
            {
                string queryType = "";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();

                //Query activiteit verwijderen
                string queryActiviteit = "DELETE FROM tblactiviteit WHERE ActiviteitID=@activiteitID";

                MySqlCommand cmdActiviteit = new MySqlCommand(queryActiviteit, conn);
                cmdActiviteit.CommandText = queryActiviteit;

                //Parameter
                cmdActiviteit.Parameters.AddWithValue("@activiteitID", a.ActiviteitID);

                MySqlCommand cmdType = new MySqlCommand(queryType, conn);

                //Query afhankelijk van type
                if (a.Training != null)
                {
                    //Query voor tabel activiteit
                    queryType = "DELETE FROM tbltraining WHERE ActiviteitID=@activiteitID";

                    cmdType.CommandText = queryType;
                }
                else if (a.Wedstrijd != null)
                {
                    //Query voor tabel activiteit
                    queryType = "DELETE FROM tblwedstrijd WHERE ActiviteitID=@activiteitID";

                    cmdType.CommandText = queryType;
                }
                else if (a.Feest != null)
                {
                    //Query voor tabel activiteit
                    queryType = "DELETE FROM tblfeest WHERE ActiviteitID=@activiteitID";

                    cmdType.CommandText = queryType;
                }
                else
                {
                    return null;
                }

                //Parameter
                cmdType.Parameters.AddWithValue("@ActiviteitID", a.ActiviteitID);

                //Commando's uitvoeren
                cmdActiviteit.ExecuteNonQuery();
                cmdType.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return new Activiteit();
            }
            catch
            {
                return null;
            }
        }

        public static Activiteit ActiviteitToevoegen(Activiteit a)
        {
            try
            {
                string queryType = "";

                //verbinding maken
                MySqlConnection conn = Database.MakeConnection();

                //Query
                string query = "INSERT INTO tblactiviteit (Soort, Datum, Locatie, Duur) VALUES (@Soort, @Datum, @Locatie, @Duur)";

                MySqlCommand cmdActiviteit = new MySqlCommand(query, conn);
                cmdActiviteit.CommandText = query;

                //Parameters
                cmdActiviteit.Parameters.AddWithValue("@Soort", a.Type);
                cmdActiviteit.Parameters.AddWithValue("@Datum", a.Datum);
                cmdActiviteit.Parameters.AddWithValue("@Locatie", a.Locatie);
                cmdActiviteit.Parameters.AddWithValue("@Duur", a.Duur);

                //Commando uitvoeren
                cmdActiviteit.ExecuteNonQuery();

                //Id ophalen van activiteit die net ge-insert is
                int intID = Convert.ToInt32(cmdActiviteit.LastInsertedId);

                MySqlCommand cmdType = new MySqlCommand(queryType, conn);

                //Query afhankelijk van type
                if (a.Training != null)
                {
                    //Query voor tabel activiteit
                    queryType = "INSERT INTO tbltraining (ActiviteitID, Categorieen, Trainer, Beschrijving) VALUES (@ActiviteitID, @Categorieen, @Trainer, @Beschrijving)";

                    cmdType.CommandText = queryType;

                    //Parameters Training
                    cmdType.Parameters.AddWithValue("@ActiviteitID", intID);
                    cmdType.Parameters.AddWithValue("@Categorieen", a.Training.Categorieën);
                    cmdType.Parameters.AddWithValue("@Trainer", a.Training.Trainer);
                    cmdType.Parameters.AddWithValue("@Beschrijving", a.Training.Beschrijving);
                }
                else if (a.Wedstrijd != null)
                {
                    //Query voor tabel activiteit
                    queryType = "INSERT INTO tblwedstrijd (ActiviteitID, Naam, Type, Organisator) VALUES (@ActiviteitID, @Naam, @Type, @Organisator)";

                    cmdType.CommandText = queryType;

                    //Parameters Wedstrijd
                    cmdType.Parameters.AddWithValue("@ActiviteitID", intID);
                    cmdType.Parameters.AddWithValue("@Naam", a.Wedstrijd.Naam);
                    cmdType.Parameters.AddWithValue("@Type", a.Wedstrijd.Type);
                    cmdType.Parameters.AddWithValue("@Organisator", a.Wedstrijd.Organisator);
                }
                else if (a.Feest != null)
                {
                    //Query voor tabel activiteit
                    queryType = "INSERT INTO tblfeest (ActiviteitID, Organisator, Eten, Beschrijving) VALUES (@ActiviteitID, @Organisator, @Eten, @Beschrijving)";

                    cmdType.CommandText = queryType;

                    //Parameters Feest
                    cmdType.Parameters.AddWithValue("@ActiviteitID", intID);
                    cmdType.Parameters.AddWithValue("@Organisator", a.Feest.Organisator);
                    cmdType.Parameters.AddWithValue("@Eten", a.Feest.Eten);
                    cmdType.Parameters.AddWithValue("@Beschrijving", a.Feest.Beschrijving);
                }
                else
                {
                    return null;
                }

                //Commando uitvoeren
                cmdType.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return new Activiteit();
            }
            catch
            {
                return null;
            }
        }
    }
}
