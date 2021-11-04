using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KartaModel
    {
        public int KartaID { get; set; }

        public int KupacID { get; set; }
        public KupacModel Kupac { get; set; }

        public int TipKarteID { get; set; }
        public TipKarteModel TipKarte { get; set; }

        public int VrstaKarteID { get; set; }
        public VrstaKarteModel VrstaKarte { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }

        public int RasporedVoznjeID { get; set; }
        public RasporedVoznjeModel RasporedVoznje { get; set; }
        public bool Pravac { get; set; }
    }
}
