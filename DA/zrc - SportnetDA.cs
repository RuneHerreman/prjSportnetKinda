﻿using MySql.Data.MySqlClient;
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

namespace prjSportnetKinda.DA
{
    public class zrc___SportnetDA
    {
        public static zrc___Sportnet Inloggen(string email, string wachtwoord)
        {
            //sting maken met ons sql statement
            String query = "SELECT COUNT(1) from login.tblgebruikers WHERE Username=@Gebruikersnaam AND Pass=@Wachtwoord";
            MySqlConnection conn = Database.MakeConnection();

            //Maken van het command
            MySqlCommand mysqlcmd = new MySqlCommand(query, conn);

            //Welk soort gegevens is het commando
            mysqlcmd.CommandType = CommandType.Text;

            //Parameters
            mysqlcmd.Parameters.AddWithValue("@Gebruikersnaam", email);
            mysqlcmd.Parameters.AddWithValue("@Wachtwoord", wachtwoord);

            //Hier wordt commando uitgevoerd en gaat hij resultaat bewaren in count
            int count = Convert.ToInt32(mysqlcmd.ExecuteScalar());

            return null;
        }
    }
}
