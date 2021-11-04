using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class GradInsertRequest
    {
        [Required]
        public string NazivGrada { get; set; }
        [Required]
        public int PostanskiBroj { get; set; }
 
    }
}
