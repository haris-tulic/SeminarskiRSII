using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class RecenzijaUpsertRequest
    {
        public int RasporedVoznjeID { get; set; }
        public string VrstaUsluga { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int KupacID { get; set; }
    }
}
