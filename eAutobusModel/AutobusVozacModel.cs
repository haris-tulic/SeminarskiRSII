using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class AutobusVozacModel
    {
        public int AutobusVozacID { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime LKraj { get; set; }
        public int Smjena { get; set; }
        public AutobusiModel Autobus { get; set; }
        public int AutobusID { get; set; }

        public int VozacID { get; set; }
        public VozacModel Vozac { get; set; }
    }
}
