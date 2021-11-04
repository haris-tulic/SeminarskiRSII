using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class VozacUpsertRequest
    {
        [Required]
        [MinLength(3)]
        public string Ime { get; set; }
        [Required]
        [MinLength(3)]
        public string Prezime { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string VozackaKategorija { get; set; }
        [Required]
        public int TipKorisnikaID { get; set; }
    }
}
