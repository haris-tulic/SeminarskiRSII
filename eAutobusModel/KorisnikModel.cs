using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KorisnikModel
    {
        public int KorisnikID { get; set; }
        public string Naziv { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string AdresaStanovanja { get; set; }
        public int TipKorisnikaID { get; set; }
        public string TipKorisnika { get; set; }
    }
}
