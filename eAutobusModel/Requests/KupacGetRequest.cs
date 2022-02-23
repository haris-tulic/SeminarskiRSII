using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
     public class KupacGetRequest
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string AdresaStanovanja { get; set; }
        public int KartaID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
