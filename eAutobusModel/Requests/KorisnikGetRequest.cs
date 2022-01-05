using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KorisnikGetRequest
    {
        public string Ime { get; set; }
        public string  Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public int UlogaID { get; set; }
    }
}
