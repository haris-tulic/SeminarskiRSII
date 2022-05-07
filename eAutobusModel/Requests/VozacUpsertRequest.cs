using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class VozacUpsertRequest
    {
        [Required]
        public int KorisnikID { get; set; }
        public string VozackaKategorija { get; set;}
    }
}
