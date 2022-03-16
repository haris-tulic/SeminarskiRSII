using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class PlatiKartu
    {
        public int PlatiKartuID { get; set; }
        public int KartaID { get; set; }
        public int KupacID { get; set; }
        public decimal Cijena { get; set; }
        public Karta Karta { get; set; }
        public Kupac Kupac { get; set; }
    }
}
