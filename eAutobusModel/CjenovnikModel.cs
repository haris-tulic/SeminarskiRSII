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

        public float Cijena { get; set; }
    }
}
