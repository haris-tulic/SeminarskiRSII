using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class RasporedVoznjeUpsertRequest
    {
        [Required]
        public int BrojLinije { get; set; }
        [Required]

        public int AutobusID { get; set; }
        [Required]

        public int PolazisteID { get; set; }
        [Required]

        public int OdredisteID { get; set; }
        [Required]

        public DateTime VrijemePolaska { get; set; }
        [Required]

        public DateTime VrijemeDolaska { get; set; }
        [Required]

        public int VozacID { get; set; }
        [Required]

        public int KondukterID { get; set; }
        [Required]

        public DateTime Datum { get; set; }

    }
}
