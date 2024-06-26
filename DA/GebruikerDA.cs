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
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing;
using System.IO;
using MessageBox = System.Windows.Forms.MessageBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                
                //Encryptie toevoegen
                byte[] data = System.Text.Encoding.ASCII.GetBytes(wachtwoord);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                string hash = System.Text.Encoding.ASCII.GetString(data);

                //sting maken met sql statement
                string query = "SELECT * from tblgebruiker WHERE Email=@Email AND Wachtwoord=@Wachtwoord";

                //Maken van het command
                MySqlCommand cmdInloggen = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                cmdInloggen.CommandType = CommandType.Text;

                //Parameters
                cmdInloggen.Parameters.AddWithValue("@Email", email);
                cmdInloggen.Parameters.AddWithValue("@Wachtwoord", hash);

                //Commando uitvoeren
                MySqlDataReader reader = cmdInloggen.ExecuteReader();
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
                    inloggen.Renner = Convert.ToBoolean(reader["Renner"]);
                    inloggen.Trainer = Convert.ToBoolean(reader["Trainer"]);
                    inloggen.Beheerder = Convert.ToBoolean(reader["Beheerder"]);
                    inloggen.Geboortedatum = Convert.ToDateTime(reader["Geboortedatum"]);
                    inloggen.Lidsinds = Convert.ToDateTime(reader["LidSinds"]);
                    inloggen.GebruikerID = Convert.ToInt16(reader["GebruikerID"]);

                    //Foto's ophalen
                    ImageConverter converter = new ImageConverter();
                    byte[] arrProfielfoto = (byte[])(reader["ProfielFoto"]);
                    byte[] arrBannerfoto = (byte[])(reader["BannerFoto"]);

                    try
                    {
                        MemoryStream ms = new MemoryStream(arrProfielfoto);
                        inloggen.Profielfoto = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {
                        inloggen.Profielfoto = null;
                    }

                    try
                    {
                        MemoryStream ms = new MemoryStream(arrBannerfoto);
                        inloggen.Bannerfoto = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {
                        inloggen.Bannerfoto = null;
                    }

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

                //Wachtwoord beveiligen met encrytie
                byte[] data = System.Text.Encoding.ASCII.GetBytes(wachtwoord);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String hash = System.Text.Encoding.ASCII.GetString(data);

                //sting maken met sql statement
                string queryRegistreren = "INSERT INTO tblgebruiker (Naam, Voornaam, Email, Geboortedatum, Wachtwoord, LidSinds, Renner, Trainer, Beheerder) " +
                        "VALUES (@Naam, @Voornaam, @Email, @Geboortedatum, @Wachtwoord, @LidSinds, @Renner, @Trainer, @Beheerder)";

                //Maken van het command
                MySqlCommand cmdRegistreren = new MySqlCommand(queryRegistreren, conn);

                //Welk soort gegevens is het commando
                cmdRegistreren.CommandType = CommandType.Text;

                //Parameters
                cmdRegistreren.Parameters.AddWithValue("@Naam", naam);
                cmdRegistreren.Parameters.AddWithValue("@Voornaam", voornaam);
                cmdRegistreren.Parameters.AddWithValue("@Email", email);
                cmdRegistreren.Parameters.AddWithValue("@Geboortedatum", geboordtedatum);
                cmdRegistreren.Parameters.AddWithValue("@Wachtwoord", hash);
                cmdRegistreren.Parameters.AddWithValue("@LidSinds", DateTime.Today);
                cmdRegistreren.Parameters.AddWithValue("@Renner", 1);
                cmdRegistreren.Parameters.AddWithValue("@Trainer", 0);
                cmdRegistreren.Parameters.AddWithValue("@Beheerder", 0);

                //Uivoeren
                cmdRegistreren.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return registreren;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null ;
            }
        }

        public static Gebruiker Verwijderen(Gebruiker g)
        {
            try
            {
                Gebruiker verwijderen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //Delete query's maken
                string queryVerwijderenGebruiker = "DELETE FROM tblgebruiker WHERE GebruikerID=@GebruikerID";
                string queryVerwijderenDeelnemer = "DELETE FROM tbldeelnemersactiviteit WHERE GebruikerID=@GebruikerID";
                string queryVerwijderenLogboek = "DELETE FROM tbllogboek WHERE GebruikerID=@GebruikerID";

                //Maken van het command
                MySqlCommand cmdVerwijderenGebruiker = new MySqlCommand(queryVerwijderenGebruiker, conn);
                MySqlCommand cmdVerwijderenDeelnemer = new MySqlCommand(queryVerwijderenDeelnemer, conn);
                MySqlCommand cmdVerwijderenLogboek = new MySqlCommand(queryVerwijderenLogboek, conn);

                //Welk soort gegevens is het commando
                cmdVerwijderenGebruiker.CommandType = CommandType.Text;
                cmdVerwijderenDeelnemer.CommandType = CommandType.Text;
                cmdVerwijderenLogboek.CommandType = CommandType.Text;

                //Parameters
                cmdVerwijderenGebruiker.Parameters.AddWithValue("@GebruikerID", g.GebruikerID);
                cmdVerwijderenDeelnemer.Parameters.AddWithValue("@GebruikerID", g.GebruikerID);
                cmdVerwijderenLogboek.Parameters.AddWithValue("@GebruikerID", g.GebruikerID);

                //Hier wordt commando uitgevoerd en gaat hij resultaat bewaren in count
                cmdVerwijderenGebruiker.ExecuteNonQuery();
                cmdVerwijderenDeelnemer.ExecuteNonQuery();
                cmdVerwijderenLogboek.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return verwijderen;
            }
            catch 
            {
                return null;
            }
        }

        public static Gebruiker Wijzigen(Gebruiker g, byte[] arrProfielFoto, byte[] arrBannerfoto)
        {
            try
            {
                Gebruiker wijzigen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                string query = "UPDATE tblgebruiker SET Voornaam=@Voornaam, Naam=@Naam, Geboortedatum=@Geboortedatum, Geslacht=@Geslacht, Adres=@Adres, Telefoonnummer=@Telefoonnummer, ProfielFoto=@ProfielFoto, BannerFoto=@BannerFoto WHERE Email=@Email";

                //Maken van het command
                MySqlCommand cmdGebruikerWijzigen = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                cmdGebruikerWijzigen.CommandType = CommandType.Text;

                //Parameters
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Email", g.Email);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Voornaam", g.Voornaam);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Naam", g.Naam);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Geboortedatum", g.Geboortedatum);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Geslacht", g.Geslacht);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Adres", g.Adres);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@Telefoonnummer", g.Telefoonnummer);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@ProfielFoto", arrProfielFoto);
                cmdGebruikerWijzigen.Parameters.AddWithValue("@BannerFoto", arrBannerfoto);

                //Commando uitvoeren
                cmdGebruikerWijzigen.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return wijzigen;
            }
            catch
            {
                return null;
            }
        }

        public static List<Gebruiker> OphalenGebruikers()
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            //Connection openen
            MySqlConnection conn = Database.MakeConnection();

            //sting maken met sql statement
            string query = "SELECT * from tblgebruiker";

            //Maken van het command
            MySqlCommand cmdGebruikersOphalen = new MySqlCommand(query, conn);

            //Welk soort gegevens is het commando
            cmdGebruikersOphalen.CommandType = CommandType.Text; 

            //Reader
            MySqlDataReader reader = cmdGebruikersOphalen.ExecuteReader();

            while (reader.Read())
            {
                gebruikers.Add(Create(reader));
            }

            //reader sluiten
            reader.Close();

            //Connection sluiten
            Database.CloseConnection(conn);

            return gebruikers;
        }

        public static Gebruiker Create(IDataRecord record)
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

                return new Gebruiker()
                {
                    Voornaam = record["Voornaam"].ToString(),
                    Naam = record["Naam"].ToString(),
                    Email = record["Email"].ToString(),
                    Renner = Convert.ToBoolean(record["Renner"]),
                    Trainer = Convert.ToBoolean(record["Trainer"]),
                    Beheerder = Convert.ToBoolean(record["Beheerder"]),
                    GebruikerID = Convert.ToInt32(record["GebruikerID"]),
                    Profielfoto = img,
                };
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return new Gebruiker();
            }
        }

        public static Gebruiker WijzigenRollen(Gebruiker g)
        {
            try
            {
                Gebruiker wijzigen = new Gebruiker();

                //Connection openen
                MySqlConnection conn = Database.MakeConnection();

                //sting maken met sql statement
                string query = "UPDATE tblgebruiker SET Renner=@Renner, Trainer=@Trainer, Beheerder=@Beheerder WHERE Email=@Email";

                //Maken van het command
                MySqlCommand cmdGebruikerRolWijzigen = new MySqlCommand(query, conn);

                //Welk soort gegevens is het commando
                cmdGebruikerRolWijzigen.CommandType = CommandType.Text;

                //Parameters
                cmdGebruikerRolWijzigen.Parameters.AddWithValue("@Email", g.Email);
                cmdGebruikerRolWijzigen.Parameters.AddWithValue("@Renner", g.Renner);
                cmdGebruikerRolWijzigen.Parameters.AddWithValue("@Trainer", g.Trainer);
                cmdGebruikerRolWijzigen.Parameters.AddWithValue("@Beheerder", g.Beheerder);

                //Commando uitvoeren
                cmdGebruikerRolWijzigen.ExecuteNonQuery();

                //Connection sluiten
                Database.CloseConnection(conn);

                return wijzigen;
            }
            catch
            {
                return null;
            }
        }

        public static void WWWijzigen(string Email, string Wachtwoord)
        {
            //Connection openen
            MySqlConnection conn = Database.MakeConnection();

            //Encryptie toevoegen
            byte[] data = System.Text.Encoding.ASCII.GetBytes(Wachtwoord);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);

            //sting maken met sql statement
            string query = "UPDATE tblgebruiker SET Wachtwoord=@Wachtwoord WHERE Email=@Email";

            //Maken van het command
            MySqlCommand cmdWijzigen = new MySqlCommand(query, conn);

            //Welk soort gegevens is het commando
            cmdWijzigen.CommandType = CommandType.Text;

            //Parameters
            cmdWijzigen.Parameters.AddWithValue("@Email", Email);
            cmdWijzigen.Parameters.AddWithValue("@Wachtwoord", hash);

            //Commando uitvoeren
            cmdWijzigen.ExecuteNonQuery();

            //Connection sluiten
            Database.CloseConnection(conn);
        }

        public static Gebruiker ControleEmail(string Email)
        {
            //Connection openen
            MySqlConnection conn = Database.MakeConnection();

            //sting maken met sql statement
            string query = "SELECT * FROM tblgebruiker WHERE Email=@Email";

            //Maken van het command
            MySqlCommand cmdControle = new MySqlCommand(query, conn);

            //Welk soort gegevens is het commando
            cmdControle.CommandType = CommandType.Text;

            //Parameters
            cmdControle.Parameters.AddWithValue("@Email", Email);

            //Commando uitvoeren
            MySqlDataReader reader = cmdControle.ExecuteReader();

            // Commando uitvoeren
            if (reader.HasRows == true)
            {
                //Connection sluiten
                Database.CloseConnection(conn);

                return new Gebruiker();
            }
            else
            {
                //Connection sluiten
                Database.CloseConnection(conn);

                return null;
            }
        }
    }
}
