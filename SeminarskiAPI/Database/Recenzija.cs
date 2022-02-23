using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Recenzija
    {
        public int RecenzijaID { get; set; }
        public string VrstaUsluga { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int RasporedVoznjeID { get; set; }
        public RasporedVoznje RasporedVoznje { get; set; }
        public int KupacID { get; set; }
        public Kupac Kupac { get; set; }
    }
}
