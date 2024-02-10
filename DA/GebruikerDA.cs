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

                //Hier wordt commando uitgevoerd en gaat hij resultaat bewaren in count
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
                    inloggen.Telefoonnr = reader["Telefoonnummer"].ToString();
                    inloggen.Renner = Convert.ToInt32(reader["Renner"]);
                    inloggen.Beheerder = Convert.ToInt32(reader["Beheerder"]);
                    inloggen.Geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                    inloggen.Lidsinds = Convert.ToDateTime(reader["LidSinds"]);

                    return inloggen;
                }
                else 
                {
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

                return verwijderen;
            }
            catch 
            {
                return null;
            }

        }

        public static Gebruiker Wijzigen(string email, string voornaam, string naam, DateTime geboortedatum, string geslacht, string Adres, int Telefoon)
        {
            try
            {
                Gebruiker wijzigen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                String query = "UPDATE tblgebruiker SET Voornaam=@Voornaam, Naam=@Naam, Geboortedatum=@Geboortedatum, Geslacht=@Geslacht, Adres=@Adres, Telefoonnnummer=@Telefoonnummer WHERE Email=@Email";

                //Maken van het command
                MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                mysqlcmd.CommandType = CommandType.Text;

                //Parameters
                mysqlcmd.Parameters.AddWithValue("@Email", email);
                mysqlcmd.Parameters.AddWithValue("@Voornaam", voornaam);
                mysqlcmd.Parameters.AddWithValue("@Naam", naam);
                mysqlcmd.Parameters.AddWithValue("@Geboortedatm", geboortedatum);
                mysqlcmd.Parameters.AddWithValue("@Geslacht", geslacht);
                mysqlcmd.Parameters.AddWithValue("@Adres", Adres);
                mysqlcmd.Parameters.AddWithValue("@Telefoonnummer", Telefoon);

                //Commando uitvoeren
                mysqlcmd.ExecuteNonQuery();

                return wijzigen;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
