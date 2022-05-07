using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel.Requests
{
    public class GarazaUpsertRequest
    {
        public int GarazaID { get; set; }
        [Required]
        public string NazivGaraze { get; set; }

        [Required]
        public int BrojGaraze { get; set; }

        [Required]
        public int BrojMjesta { get; set; }
        public bool IsPopunjeno { get; set; }

        [Required]
        public int GradID { get; set; }
    }
}
