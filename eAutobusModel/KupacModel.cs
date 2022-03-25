using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel
{
    public class KupacModel
    {
        public int KupacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Adresa { get; set; }
        public int KartaID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<KartaKupacModel> KartaKupacs { get; set; }
        public List<RecenzijaModel> Recenzije { get; set; }

    }
}
