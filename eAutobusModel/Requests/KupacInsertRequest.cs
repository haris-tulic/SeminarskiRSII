using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KupacInsertRequest
    {
       
        
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Ime { get; set; }
      
        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Prezime { get; set; }
       
        [Required(AllowEmptyStrings =false)]
        [Phone]
        public string BrojTelefona { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public string AdresaStanovanja { get; set; }

        public int KartaID { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]

        public string PotrvrdaPassworda { get; set; }
    }
}
