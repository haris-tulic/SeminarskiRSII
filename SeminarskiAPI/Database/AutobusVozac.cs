using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class AutobusVozac
    {
            public int AutobusVozacID { get; set; }
            public DateTime Pocetak { get; set; }
            public DateTime Kraj { get; set; }
            public int Smjena { get; set; }
            public int AutobusID { get; set; }
            public Autobus Autobus { get; set; }

            public int VozacID { get; set; }
            public Vozac Vozac { get; set; }

       
    }
}
