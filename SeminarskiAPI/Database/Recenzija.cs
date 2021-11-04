using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Recenzija
    {
        public int RecenzijaID { get; set; }
        public string VrstaUsluga { get; set; }
        public DateTime DatumRecenzije { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    }
}
