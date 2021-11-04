using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Autobus
    {
       
            public int AutobusID { get; set; }
            public int BrojAutobusa { get; set; }
            public int BrojSjedista { get; set; }
            public DateTime DatumProizvodnje  { get; set; }
            public bool Ispravan { get; set; }
            public string MarkaAutobusa { get; set; }
            public int GarazaID { get; set; }
            public Garaza Garaza { get; set; }
            public List<AutobusVozac> Vozaci { get; set; }
    }
}
