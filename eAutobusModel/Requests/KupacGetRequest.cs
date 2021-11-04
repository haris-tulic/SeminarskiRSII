﻿using System;
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
        public string Email { get; set; }
        public string AdresaStanovanja { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GradID { get; set; }
        public int TipKorisnikaID { get; set; }
        public bool? Prisutan { get; set; }

    }
}
