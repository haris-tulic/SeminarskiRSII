using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KartaModel
    {
        public int KartaID { get; set; }
        public int KupacID { get; set; }
        public int TipKarteID { get; set; }
        public int VrstaKarteID { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
        public double Cijena { get; set; }
        public string TipKarte { get; set; }
        public string VrstaKarte { get; set; }
        public string NacinPlacanja { get; set; }
        public string ImePrezimeKupca { get; set; }
        public string Relacija { get; set; }
        public string CijenaString { get; set; }

    }
}
