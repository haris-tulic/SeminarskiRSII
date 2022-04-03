using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class IzvjestajIzdanaKartaModel
    {
        public  string ImePrezime { get; set; }
        public  string AdresaStanovanja { get; set; }
        public string VrstaKarte { get; set; }
        public string TipKarte { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public DateTime DatumVadjenja { get; set; }
        public DateTime DatumVazenja { get; set; }
        public string Pravac { get; set; }
        public string Cijena { get; set; }
        
    }
}
