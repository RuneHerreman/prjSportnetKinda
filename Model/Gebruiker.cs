using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.Model
{
    public class Gebruiker
    {
        public string Email { get; set; }
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Wachtwoord { get; set; }
        public string Geslacht { get; set; }
        public string Adres { get; set; }
        public string Telefoonnr { get; set; }
        public int Beheerder { get; set; }
        public int Trainer { get; set; }
        public int Renner { get; set; }
        public DateTime Geboortedatum { get; set; }
        public DateTime Lidsinds { get; set; }
    }
}
