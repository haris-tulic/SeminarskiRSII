using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KartaKupacModel
    {
        public int KartaKupacID { get; set; }
        public int KupacID { get; set; }
        public string Kupac { get; set; }
        public int KartaID { get; set; }
        public string Karta { get; set; }
        public bool Aktivna { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public bool Pravac { get; set; }
        public string PravacS { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
    }
}
