using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class PlatiKartuGetRequest
    {
        public int PlatiKartuID { get; set; }
        public int KartaID { get; set; }
        public int KupacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
