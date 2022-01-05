using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class GarazaModel
    {
        public int GarazaID { get; set; }
        public string NazivGaraze { get; set; }
        public int BrojGaraze { get; set; }
        public int BrojMjesta { get; set; }
        public bool IsPopunjeno { get; set; }
        public int TrenutnoAutobusa { get; set; }
        public int GradID { get; set; }
    }
}
