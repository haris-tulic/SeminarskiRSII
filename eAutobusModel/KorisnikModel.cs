using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KorisnikModel
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string AdresaStanovanja { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public int GradID { get; set; }
        public int UlogeID { get; set; }
        public string Uloga { get; set; }
        public UlogeModel Uloge { get; set; }
        public List<KorisniciUlogeModel> KorisnickeUloge { get; set; }
        
    }
}
