using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class GarazaGetRequest
    {
        public int GarazaID { get; set; }
        public string NazivGaraze { get; set; }
        public int BrojGaraze { get; set; }
        public int BrojMjesta { get; set; }
        public bool IsPopunjeno { get; set; }
    }
}
