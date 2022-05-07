using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class PlatiKartuUpsertRequest
    {
        public int PlatiKartuID { get; set; }
        [Required]
        public int KupacID { get; set; }
        
        [Required]
        public int KartaID { get; set; }
        
        [Required]
        public double Cijena { get; set; }
        
        [Required]
        public bool JeLiPlacena { get; set; }
        
        [Required]
        public DateTime DatumVadjenjaKarte { get; set; }
        
        [Required]
        public DateTime DatumVazenjaKarte { get; set; }

    }
}
