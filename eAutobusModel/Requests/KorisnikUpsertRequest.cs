using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KorisnikUpsertRequest
    {
        public int? KorisnikID { get; set; }
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DatumRodjenja { get; set; }
        [Required]
        public string BrojTelefona { get; set; }
        [Required]
        public string AdresaStanovanja { get; set; }
        [Required]
        public int GradID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotrvda { get; set; }

       [Required]
        public int UlogeID { get; set; }
    }
}
