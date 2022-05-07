using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class StanicaInsertRequest
    {   
        [Required]
        public string nazivLokacijeStanice { get; set; }

        public int GradID { get; set; }
    }
}
