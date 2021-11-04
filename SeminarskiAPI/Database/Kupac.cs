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
            public int KorisnikID { get; set; }
            public Korisnik Korisnik  { get; set; }
            public string PasswordHash { get; set; }
            public string PasswordSalt { get; set; }
            public bool ?Prisutan { get; set; }

    }
}
