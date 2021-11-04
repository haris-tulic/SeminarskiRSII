using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class UpravaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Prezime { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Phone]
        public string BrojTelefona { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]

        public string ConfirmPassword { get; set; }
        [Required]
        public string AdresaStanovanja { get; set; }
        [Required]

        public DateTime DatumRodjenja { get; set; }
        [Required]
        public int GradID { get; set; }

        public bool Prisutan { get; set; }

    }
}
