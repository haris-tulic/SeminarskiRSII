using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Vozac
    {
        public int VozacID { get; set; }
        public string VozackaKategorija { get; set; }
        public int KorisnikID { get; set; }
        public Korisnik Korisnik { get; set; }
        public List<AutobusVozac> Autobusi { get; set; }
    }
}
