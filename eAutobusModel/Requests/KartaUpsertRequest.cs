using System;
using System.Collections.Generic;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KartaUpsertRequest
    {
        public int KupacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string AdresaStanovanja { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public int TipKarteID { get; set; }
        public int VrstaKarteID { get; set; }
        public DateTime DatumVadjenjaKarte { get; set; }
        public DateTime DatumVazenjaKarte { get; set; }
        public int OdredisteID { get; set; }
        public int PolazisteID { get; set; }
        public bool? Pravac { get; set; }
        public double Cijena { get; set; }
        public int KartaID { get; set; }
        public string PravacS { get; set; }
        public string NacinPlacanja { get; set; }
    }
}
