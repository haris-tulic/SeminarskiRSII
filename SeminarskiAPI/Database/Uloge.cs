using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class Uloge
    {
        public int UlogeID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public List<Korisnik> Korisnik { get; set; }
    }
}