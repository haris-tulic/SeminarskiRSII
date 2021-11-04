using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public  class Garaza
    {
        public int GarazaID { get; set; }
        public string NazivGaraze { get; set; }
        public int BrojGaraze { get; set; }
        public int BrojMjesta { get; set; }
        public bool IsPopunjeno { get; set; }
        public int GradID { get; set; }
        public Grad Grad { get; set; }
        public List<Autobus> Autobusi{ get; set; }
    }
}
