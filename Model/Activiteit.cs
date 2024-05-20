using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.Model
{
    public class Activiteit
    {
        public int ActiviteitID { get; set; }
        public string Type { get; set; }
        public DateTime Datum { get; set; }
        public string Locatie { get; set; }
        public int Duur { get; set; }
        public Training Training { get; set; }
        public Wedstrijd Wedstrijd { get; set; }
        public Feest Feest { get; set; }
        public string Deelnemers { get; set; }
    }
}
