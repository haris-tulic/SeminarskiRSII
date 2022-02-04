using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class KartaKupac
    {
        public int KartaKupacID { get; set; }
        public int KupacID { get; set; }
        public Kupac Kupac { get; set; }
        public int KartaID { get; set; }
        public Karta Karta { get; set; }
        public bool Aktivna { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public bool Pravac { get; set; }
        public string PravacS { get; set; }
    }
}
