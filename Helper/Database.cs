using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace prjSportnetKinda.Helper
{
    public class Database
    {
        //verbinding met de databank
        public static MySqlConnection MakeConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "localhost";
                builder.Database = "zrc - sportnet";
                builder.UserID = "root";
                builder.Password = "usbw";
                builder.Port = 3307;
                builder.ConnectionTimeout = 60;
                builder.AllowZeroDateTime = true;

                //De eigensmijke verbinding aanmaken
                MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
                conn.Open();

                return conn;
            }
            catch
            {
                MessageBox.Show("Er is geen connectie met de database mogelijk.");
                return null;
            }
        }
    }
}
