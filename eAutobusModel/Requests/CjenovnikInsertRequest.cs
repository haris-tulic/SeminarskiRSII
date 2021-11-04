using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class CjenovnikInsertRequest
    {
        
       
        [Required]

        public int zonaID { get; set; }
     
        [Required]

        public int tipkarteID { get; set; }
        [Required]

        public int vrstakarteID { get; set; }
        [Required]

        public float Cijena { get; set; }
    }
}
