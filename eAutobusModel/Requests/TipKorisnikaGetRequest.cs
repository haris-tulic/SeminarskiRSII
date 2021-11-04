using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class TipKorisnikaGetRequest
    {
        public int TipKorisnikaID { get; set; }
        public int KupacID { get; set; }
        public int VozacID { get; set; }
        public int UpravaID { get; set; }

    }
}
