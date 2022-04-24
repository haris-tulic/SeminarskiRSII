using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class PlatiKartuModel
    {
        public int PlatiKartuID { get; set; }
        public int KartaID { get; set; }
        public int KupacID { get; set; }
        public double Cijena { get; set; }
        public KartaModel Karta { get; set; }
        public KupacModel Kupac { get; set; }
        public string ImePrezimeKupca { get; set; }
        public string TipKarteNaziv { get; set; }
        public string VrstaKarteNaziv { get; set; }
        public string PolazisteOdrediste { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public bool JeLiPlacena { get; set; }
        public string CijenaString { get; set; }

    }
}
