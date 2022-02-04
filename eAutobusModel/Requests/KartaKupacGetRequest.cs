using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KartaKupacGetRequest
    {
        public int KartaKupacID { get; set; }
        public int KupacID { get; set; }
        public int KartaID { get; set; }
        public bool Aktivna { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public string PravacS { get; set; }
    }
}
