using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class VrstaKarteInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
    }
}
