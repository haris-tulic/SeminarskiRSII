using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class CjenovnikSearchRequest
    {
        public int ID { get; set; }

        public string Zona { get; set; }
        public int ZonaID { get; set; }
        public string Tipkarte { get; set; }
        public int TipkarteID { get; set; }
        public int VrstaKarteID { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
    }
}
