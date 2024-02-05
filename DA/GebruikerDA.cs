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
                Gebruiker gebruiker = new Gebruiker();

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
                    gebruiker.Email = reader["Email"].ToString();
                    gebruiker.Voornaam = reader["Voornaam"].ToString();
                    gebruiker.Naam = reader["Naam"].ToString();
                    gebruiker.Geslacht = reader["Geslacht"].ToString();
                    gebruiker.Adres = reader["Adres"].ToString();
                    gebruiker.Telefoonnr = reader["Telefoonnummer"].ToString();
                    gebruiker.Renner = Convert.ToInt32(reader["Renner"]);
                    gebruiker.Geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                    gebruiker.Lidsinds = Convert.ToDateTime(reader["LidSinds"]);

                    return gebruiker;
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
    }
}
