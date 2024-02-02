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
    public class zrc___SportnetDA
    {
        public static zrc___Sportnet Inloggen(string email, string wachtwoord)
        {
            try
            {
                zrc___Sportnet Login = new zrc___Sportnet();

                //sting maken met ons sql statement
                String query = "SELECT * from tblgebruiker WHERE Email=@Email AND Wachtwoord=@Wachtwoord";
                MySqlConnection conn = Database.MakeConnection();

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
                    Login.email = reader["Email"].ToString();
                    Login.Voornaam = reader["Voornaam"].ToString();
                    Login.Naam = reader["Naam"].ToString();

                    return Login;
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
    }
}
