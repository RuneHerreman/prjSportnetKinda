using MySql.Data.MySqlClient;
using prjSportnetKinda.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjSportnetKinda.Helper;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjSportnetKinda.DA
{
    public class GebruikerDA
    {
        public static Gebruiker Inloggen(string email, string wachtwoord)
        {
            try
            {
                Gebruiker inloggen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                String query = "SELECT * from tblgebruiker WHERE Email=@Email AND Wachtwoord=@Wachtwoord";

                //Maken van het command
                MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                mysqlcmd.CommandType = CommandType.Text;

                //Parameters
                mysqlcmd.Parameters.AddWithValue("@Email", email);
                mysqlcmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);

                //Commando uitvoeren
                MySqlDataReader reader = mysqlcmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    inloggen.Email = reader["Email"].ToString();
                    inloggen.Voornaam = reader["Voornaam"].ToString();
                    inloggen.Naam = reader["Naam"].ToString();
                    inloggen.Wachtwoord = reader["Wachtwoord"].ToString();
                    inloggen.Geslacht = reader["Geslacht"].ToString();
                    inloggen.Adres = reader["Adres"].ToString();
                    inloggen.Telefoonnummer = Convert.ToInt32(reader["Telefoonnummer"]);
                    inloggen.Renner = Convert.ToInt32(reader["Renner"]);
                    inloggen.Beheerder = Convert.ToInt32(reader["Beheerder"]);
                    inloggen.Geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                    inloggen.Lidsinds = Convert.ToDateTime(reader["LidSinds"]);
                    reader.Close();

                    //Connection sluiten
                    Database.CloseConnection(conn);

                    return inloggen;
                }
                else 
                {
                    //Connection sluiten
                    Database.CloseConnection(conn);

                    return null;
                }

            }
            catch
            {
                return null;
            }
        }

        public static Gebruiker Registreren(string naam, string voornaam, string email, DateTime geboordtedatum, string wachtwoord)
        {
            try
            {
                Gebruiker registreren = new Gebruiker();

                //connectie maken met database
                MySqlConnection conn = Database.MakeConnection();

                //Controleren of Email al bestaat
                String query = "SELECT * from tblgebruiker WHERE Email=@Email";

                //Maken van het command
                MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                mysqlcmd.CommandType = CommandType.Text;

                //Parameters
                mysqlcmd.Parameters.AddWithValue("@Email", email);

                MySqlDataReader reader = mysqlcmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    reader.Read();
                    registreren.Email = reader["Email"].ToString();
                    reader.Close();
                    registreren.Email = "Bezet";
                    return registreren;
                }
                else
                {
                    reader.Close();
                    //sting maken met sql statement
                    query = "INSERT INTO tblgebruiker (Naam, Voornaam, Email, Geboortedatum, Wachtwoord, LidSinds, Renner) " +
                            "VALUES (@Naam, @Voornaam, @Email, @Geboortedatum, @Wachtwoord, @LidSinds, @Renner)";

                    //Maken van het command
                    mysqlcmd = new MySqlCommand(query, conn);

                    //Welk soort gegevens is het commando
                    mysqlcmd.CommandType = CommandType.Text;

                    //Parameters
                    mysqlcmd.Parameters.AddWithValue("@Naam", naam);
                    mysqlcmd.Parameters.AddWithValue("@Voornaam", voornaam);
                    mysqlcmd.Parameters.AddWithValue("@Email", email);
                    mysqlcmd.Parameters.AddWithValue("Geboortedatum", geboordtedatum);
                    mysqlcmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
                    mysqlcmd.Parameters.AddWithValue("@LidSinds", DateTime.Today);
                    mysqlcmd.Parameters.AddWithValue("@Renner", 1);

                    //Uivoeren
                    mysqlcmd.ExecuteNonQuery();

                    //Connection sluiten
                    Database.CloseConnection(conn);

                    return registreren;
                }
            }
            catch 
            {
                return null ;
            }
        }

        public static Gebruiker Verwijderen(string email)
        {
            try
            {
                Gebruiker verwijderen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                String query = "DELETE FROM tblgebruiker WHERE Email=@Email";

                //Maken van het command
                MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                mysqlcmd.CommandType = CommandType.Text;

                //Parameters
                mysqlcmd.Parameters.AddWithValue("@Email", email);

                //Hier wordt commando uitgevoerd en gaat hij resultaat bewaren in count
                mysqlcmd.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return verwijderen;
            }
            catch 
            {
                return null;
            }
        }

        public static Gebruiker Wijzigen(Gebruiker gebruiker)
        {
            try
            {
                Gebruiker wijzigen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                String query = "UPDATE tblgebruiker SET Voornaam=@Voornaam, Naam=@Naam, Geboortedatum=@Geboortedatum, Geslacht=@Geslacht, Adres=@Adres, Telefoonnummer=@Telefoonnummer WHERE Email=@Email";

                //Maken van het command
                MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                mysqlcmd.CommandType = CommandType.Text;

                //Parameters
                mysqlcmd.Parameters.AddWithValue("@Email", gebruiker.Email);
                mysqlcmd.Parameters.AddWithValue("@Voornaam", gebruiker.Voornaam);
                mysqlcmd.Parameters.AddWithValue("@Naam", gebruiker.Naam);
                mysqlcmd.Parameters.AddWithValue("@Geboortedatum", gebruiker.Geboortedatum);
                mysqlcmd.Parameters.AddWithValue("@Geslacht", gebruiker.Geslacht);
                mysqlcmd.Parameters.AddWithValue("@Adres", gebruiker.Adres);
                mysqlcmd.Parameters.AddWithValue("@Telefoonnummer", gebruiker.Telefoonnummer);

                //Commando uitvoeren
                mysqlcmd.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return wijzigen;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
