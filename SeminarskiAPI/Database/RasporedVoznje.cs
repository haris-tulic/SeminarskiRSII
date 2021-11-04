using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class RasporedVoznje
    {
        public int RasporedVoznjeID { get; set; }
        public int BrojLinije { get; set; }
        public Autobus Autobus { get; set; }
        public int AutobusID { get; set; }
        public Stanica Polaziste { get; set; }
        public int PolazisteID { get; set; }
        public Stanica Odrediste { get; set; }
        public int OdredisteID { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime VrijemeDolaska { get; set; }
        public Vozac Vozac { get; set; }
        public int VozacID { get; set; }
        public int KondukterID { get; set; }
        public Vozac Kondukter { get; set; }
        public DateTime Datum { get; set; }
    }
}
