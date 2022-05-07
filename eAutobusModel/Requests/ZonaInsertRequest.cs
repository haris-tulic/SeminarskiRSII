using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class ZonaInsertRequest
    {
        [Required]
        public string  OznakaZone { get; set; }
    }
}
