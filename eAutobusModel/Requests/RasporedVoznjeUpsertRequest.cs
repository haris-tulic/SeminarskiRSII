using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class RasporedVoznjeUpsertRequest
    {
        
        public int BrojLinije { get; set; }
        public int AutobusID { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime VrijemeDolaska { get; set; }
        public int VozacID { get; set; }
        public int KondukterID { get; set; }
        public DateTime Datum { get; set; }

    }
}
