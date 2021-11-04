using eAutobusModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Naziv { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string AdresaStanovanja { get; set; }
        public string Email { get; set; }
        public int GradID { get; set; }
        public Grad Grad { get; set; }
        public int KupacID { get; set; }
        public List<Kupac> Kupac { get; set; }
        public int VozacID { get; set; }
        public List<Vozac> Vozac { get; set; }
        public int UpravaID { get; set; }
        public List<Uprava> Uprava { get; set; }
        public int TipKorisnikaID { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
    }
}
