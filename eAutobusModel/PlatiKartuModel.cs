using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class PlatiKartuModel
    {
        public int PlatiKartuID { get; set; }
        public int KartaID { get; set; }
        public int KupacID { get; set; }
        public decimal Cijena { get; set; }
        public KartaModel Karta { get; set; }
        public KupacModel Kupac { get; set; }
    }
}
