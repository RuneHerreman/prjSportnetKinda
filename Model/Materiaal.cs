using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.Model
{
    public class Materiaal
    {
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public int Voorraad { get; set; }
        public Image Foto { get; set; }
    }
}
