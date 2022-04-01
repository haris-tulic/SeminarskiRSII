using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eAutobusModel
{
    public class RasporedVoznjeModel
    {
        public int RasporedVoznjeID { get; set; }
        public int BrojLinije { get; set; }
        public int AutobusID { get; set; }
        public int ZonaID { get; set; }
        public int PolazisteID { get; set; }
        public int OdredisteID { get; set; }
        public DateTime VrijemePolaska { get; set; }
        public DateTime VrijemeDolaska { get; set; }
        public VozacModel Vozac { get; set; }
        public string VozacIme { get; set; }
        public int VozacID { get; set; }
        public int KondukterID { get; set; }
        public DateTime Datum { get; set; }
        public string Polazak { get; set; }
        public string Odlazak { get; set; }
        public int BrojAutobusa { get; set; }
        public string NazivLinije { get; set; }
        public decimal FinalOcjena { get; set; }
    }
}