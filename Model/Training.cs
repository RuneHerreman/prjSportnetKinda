using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.Model
{
    public class Training
    {
        public int TrainingID { get; set; }
        public string Locatie { get; set; }
        public string Categorie { get; set; }
        public DateTime Datum { get; set; }
        public string Deelnemers { get; set; }
        public string Trainer { get; set; }
    }
}
