using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class AutobusiModel
    {
        public int AutobusID { get; set; }
        public int BrojAutobusa { get; set; }
        public int BrojSjedista { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public bool Ispravan { get; set; }
        public string MarkaAutobusa { get; set; }
        public int GarazaID { get; set; }
        public string NazivGaraze { get; set; }
        public string PrikazAutobusa { get; set; }
    }
}
