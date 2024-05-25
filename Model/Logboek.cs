using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace prjSportnetKinda.Model
{
    public class Logboek
    {
        public int LogID { get; set; }
        public int GebruikerID { get; set; }
        public string GehuurdMateriaalID { get; set; }
        public string Aantal { get; set; }
        public DateTime Datum { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public Materiaal Materiaal { get; set; }
    }
}
