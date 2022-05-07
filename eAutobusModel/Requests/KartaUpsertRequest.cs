using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KartaUpsertRequest
    {
        public int KupacID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]

        public string Prezime { get; set; }
        [Required]

        public string AdresaStanovanja { get; set; }
        public string Email { get; set; }
        [Required]

        public string BrojTelefona { get; set; }
        [Required]

        public int TipKarteID { get; set; }
        [Required]

        public int VrstaKarteID { get; set; }
        [Required]

        public DateTime DatumVadjenjaKarte { get; set; }
        [Required]

        public DateTime DatumVazenjaKarte { get; set; }
        [Required]

        public int OdredisteID { get; set; }
        [Required]

        public int PolazisteID { get; set; }
        public bool? Pravac { get; set; }
        [Required]

        public double Cijena { get; set; }

        public int KartaID { get; set; }
        public string PravacS { get; set; }
        public string NacinPlacanja { get; set; }
    }
}
