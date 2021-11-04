using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class KupacOcjena
    {
        public int KupacOcjenaID { get; set; }
        public Kupac Kupac { get; set; }
        public int KupacID { get; set; }
        public int RasporedVoznjeID { get; set; }
        public RasporedVoznje RasporedVoznje { get; set; }
        public int VozacID { get; set; }
        public Vozac Vozac { get; set; }
        public int RecenzijaID { get; set; }
        public Recenzija Recenzija { get; set; }
    }
}
