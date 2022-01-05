using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class UlogeGetRequest
    {
        public int UlogeID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
