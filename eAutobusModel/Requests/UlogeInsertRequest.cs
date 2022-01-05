using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class UlogeInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
