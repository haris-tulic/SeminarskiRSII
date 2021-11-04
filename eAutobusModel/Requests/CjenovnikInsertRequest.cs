using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class CjenovnikInsertRequest
    {

        public int CjenovnikID { get; set; }
        [Required]
        public int ZonaID { get; set; }
     
        [Required]
        public int TipkarteID { get; set; }

        [Required]
        public int VrstakarteID { get; set; }

        [Required]
        public float Cijena { get; set; }
    }
}
