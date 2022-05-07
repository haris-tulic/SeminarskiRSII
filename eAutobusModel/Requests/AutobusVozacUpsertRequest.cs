using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class AutobusVozacUpsertRequest
    {
        public DateTime pocetak { get; set; }
        public DateTime kraj { get; set; }
        public int smjena { get; set; }
        [Required]
        public int autobusID { get; set; }
        [Required]
        public int VozacID { get; set; }
    }
}
