using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class KartaKupacUpsertRequest
    {
        public int KartaKupacID { get; set; }
        
        [Required]
        public int KupacID { get; set; }
        
        [Required]
        public int KartaID { get; set; }
        
        [Required]
        public bool Aktivna { get; set; }
        
        [Required]
        public DateTime DatumVadjenjaKarte { get; set; }
        
        [Required]
        public DateTime DatumVazenjaKarte { get; set; }
        
        [Required]
        public bool? Pravac { get; set; }
        
        [Required]
        public string PravacS { get; set; }
    }
}
