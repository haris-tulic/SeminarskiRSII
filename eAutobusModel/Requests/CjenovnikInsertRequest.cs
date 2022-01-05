using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class CjenovnikInsertRequest
    {

        [Required]
        public int ZonaID { get; set; }
     
        [Required]
        public int TipkarteID { get; set; }

        [Required]
        public int VrstakarteID { get; set; }

        [Required]
        public double Cijena { get; set; }
        [Required]
        public int OdredisteID { get; set; }
        [Required]
        public int PolazisteID { get; set; }
    }
}
