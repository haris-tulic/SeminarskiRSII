using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class RasporedVoznjeGetRequest
    {
        public int RasporedVoznjeID { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
        public DateTime Datum { get; set; }

    }
}
