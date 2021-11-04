using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class UpravaGetRequest
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string AdresaStanovanja { get; set; }
    }
}
