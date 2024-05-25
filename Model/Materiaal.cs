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
        public int ID {  get; set; }
        public string MateriaalNaam { get; set; }
        public string Beschrijving { get; set; }
        public int Voorraad { get; set; }
        public Image Foto { get; set; }
    }
}
