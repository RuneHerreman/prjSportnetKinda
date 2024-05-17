using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int Telefoonnummer { get; set; }
        public bool Beheerder { get; set; }
        public bool Trainer { get; set; }
        public bool Renner { get; set; }
        public DateTime Geboortedatum { get; set; }
        public DateTime Lidsinds { get; set; }
        public int GebruikerID { get; set; }
        public string Categorie { get; set; }
        public Image Profielfoto { get; set; }
        public Image Bannerfoto { get; set; }

    }
}
