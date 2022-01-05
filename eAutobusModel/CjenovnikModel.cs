using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class CjenovnikModel
    {
        public int CjenovnikID { get; set; }

        public string Zona { get; set; }
        public int ZonaID { get; set; }
        public string VrstaKarte { get; set; }
        public int VrstaKarteID { get; set; }

        public string Tipkarte { get; set; }
        public int TipkarteID { get; set; }
        public int OdredisteID { get; set; }
        public int PolazisteID { get; set; }
        public string Odrediste { get; set; }
        public string Polaziste { get; set; }
        public double Cijena { get; set; }
        public string CijenaPrikaz { get; set; }
    }
}
