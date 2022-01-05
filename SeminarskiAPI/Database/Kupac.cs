using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Kupac
    {
            public int KupacID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string AdresaStanovanja { get; set; }
            public string BrojTelefona { get; set; }
            public int KartaID { get; set; }
            public Karta Karta { get; set; }
    }

}
