using MySql.Data.MySqlClient;
using prjSportnetKinda.Helper;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
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
                string query = 
                    "SELECT * " +
                    "FROM `tbllogboek` " +
                    "INNER JOIN `tblgebruiker` " +
                    "ON `tbllogboek`.`GebruikerID`=`tblgebruiker`.`GebruikerID` " +
                    "INNER JOIN `tblmateriaal` " +
                    "ON `tbllogboek`.`GehuurdMateriaalID`=`tblmateriaal`.`MateriaalID` " +
                    "WHERE `tbllogboek`.`GebruikerID`=@GebruikerID";

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
                ImageConverter converter = new ImageConverter();
                byte[] arrFoto = (byte[])(record["ProfielFoto"]);
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

                //zet de byte array om naam een foto
                //maak een convertor aan
                ImageConverter converter1 = new ImageConverter();
                //record toevoegen
                byte[] arrFoto1 = (byte[])(record["foto"]);
                //het object dat de foto zal opvangen
                Image img1;
                try
                {
                    //array in een memorystream doen
                    MemoryStream ms = new MemoryStream(arrFoto1);
                    //het image object van daarnet is gelijk aan de image die je uit de byte array haalt
                    img1 = Image.FromStream(ms);
                }
                catch (Exception)
                {
                    //foto leeg laten als er een erroro
                    img1 = null;
                }

                //de rest van de velden als records invoegen
                return new Logboek()
                {
                    LogID = Convert.ToInt32(record["LogID"]),
                    GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                    GehuurdMateriaalID = record["GehuurdMateriaalID"].ToString(),
                    Aantal = record["Aantal"].ToString(),
                    Datum = Convert.ToDateTime(record["Datum"]),
                    Gebruiker = new Gebruiker()
                    {
                        Voornaam = record["Voornaam"].ToString(),
                        Naam = record["Naam"].ToString(),
                        Email = record["Email"].ToString(),
                        Renner = Convert.ToBoolean(record["Renner"]),
                        Trainer = Convert.ToBoolean(record["Trainer"]),
                        Beheerder = Convert.ToBoolean(record["Beheerder"]),
                        GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                        Adres = record["Adres"].ToString(),
                        Geboortedatum = Convert.ToDateTime(record["Geboortedatum"]),
                        Geslacht = record["Geslacht"].ToString(),
                        Lidsinds = Convert.ToDateTime(record["Lidsinds"]),
                        Telefoonnummer = Convert.ToInt32(record["Telefoonnummer"]),
                        Profielfoto = img,
                    },
                    Materiaal = new Materiaal()
                    {
                        //id is nodig om te identificeren welke userControl er wordt gebruikt
                        ID = Convert.ToInt32(record["MateriaalID"]),
                        MateriaalNaam = record["materiaalnaam"].ToString(),
                        Beschrijving = record["beschrijving"].ToString(),
                        //foto van hierboven
                        Foto = img1,
                        Voorraad = Convert.ToInt32(record["voorraad"].ToString())
                    },                    
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

        public static void LogDelete(int intLogID)
        {
            //query
            string query = "DELETE FROM `tbllogboek` WHERE `LogID`=@LogID";

            //open connectie
            MySqlConnection conn = Database.MakeConnection();

            //commando maken
            MySqlCommand cmdLogDelete = new MySqlCommand(query, conn);
            cmdLogDelete.CommandText = query;

            //parameters
            cmdLogDelete.Parameters.AddWithValue("@LogID", intLogID);

            //reader maken
            cmdLogDelete.ExecuteNonQuery();            

            Database.CloseConnection(conn);
        }
        public static void LogUpdate(int intLogID, int intNieuwAantal)
        {
            //query
            string query = "UPDATE `tbllogboek` SET `Aantal`=@NieuwAantal WHERE `LogID`=@LogID";

            //open connectie
            MySqlConnection conn = Database.MakeConnection();

            //commando maken
            MySqlCommand cmdLogUpdate = new MySqlCommand(query, conn);
            cmdLogUpdate.CommandText = query;

            //parameters
            cmdLogUpdate.Parameters.AddWithValue("@LogID", intLogID);
            cmdLogUpdate.Parameters.AddWithValue("@NieuwAantal", intNieuwAantal);

            //reader maken
            cmdLogUpdate.ExecuteNonQuery();

            Database.CloseConnection(conn);
        }
    }
}
