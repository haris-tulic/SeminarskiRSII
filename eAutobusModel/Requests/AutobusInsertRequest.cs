using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class AutobusInsertRequest
    {
        [Required]
        public  int BrojAutobusa { get; set; }
        [Required]
        public string MarkaAutobusa { get; set; }
        [Required]
        public DateTime DatumProizvodnje { get; set; }
        [Required]
        public int BrojSjedista { get; set; }
        [Required]
        public int GarazaID{ get; set; }
        public bool Ispravan { get; set; }

    }
}
