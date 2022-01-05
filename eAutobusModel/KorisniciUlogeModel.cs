using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KorisniciUlogeModel
    {
        public int KorisnikID { get; set; }
        public int UlogaID { get; set; }
        public UlogeModel Uloga { get; set; }
        public DateTime? DatumIzmjene { get; set; }
    }
}
