using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Karta
    {
        public int KartaID { get; set; }

        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }

        public TipKarte TipKarte { get; set; }
        public int TipKarteID { get; set; }
        public int PolazisteID { get; set; }
        public Stanica Polaziste { get; set; }
        public int OdredisteID { get; set; }
        public Stanica Odrediste { get; set; }
        public VrstaKarte VrstaKarte { get; set; }
        public int VrstaKarteID { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
       
        public bool Pravac { get; set; }
     
    }
}
