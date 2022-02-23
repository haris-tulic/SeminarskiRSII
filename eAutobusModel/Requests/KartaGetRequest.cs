using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KartaGetRequest
    {

         public int ID { get; set; }

        public int KupacID { get; set; }

        public int TipKarteID { get; set; }

        public int VrstaKarteID { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
    }
}
