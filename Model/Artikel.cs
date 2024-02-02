using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSportnetKinda.Model
{
    public class Artikel
    {
        public int ID { get; set; }
        public DateTime datum { get; set; }
        public string titel { get; set; }
        public string artiekel { get; set; }
        public Image foto { get; set; }
    }
}
