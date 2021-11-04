using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class TipKarteInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        
        public string Informacije { get; set; }
    }
}
