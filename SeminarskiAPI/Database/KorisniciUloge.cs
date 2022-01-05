﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class KorisniciUloge
    {
        public int KorisniciUlogeID { get; set; }
        public int KorisnikID { get; set; }
        public int UlogaID { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public  Korisnik Korisnik { get; set; }
        public virtual Uloge Uloga { get; set; }
    }
}