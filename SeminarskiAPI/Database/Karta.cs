using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Karta
    {
        public int KartaID { get; set; }

       
        public List<KartaKupac> KupacList { get; set; }

        public TipKarte TipKarte { get; set; }
        public int TipKarteID { get; set; }
        public int PolazisteID { get; set; }
        public Stanica Polaziste { get; set; }
        public int OdredisteID { get; set; }
        public Stanica Odrediste { get; set; }
        public int VrstaKarteID { get; set; }
        public VrstaKarte VrstaKarte { get; set; }
        public double  Cijena { get; set; }

    }
}
