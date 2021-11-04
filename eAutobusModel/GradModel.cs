using System;
using System.ComponentModel.DataAnnotations;

namespace eAutobusModel
{
    public class GradModel
    {
        [Key]
        public int GradID { get; set; }
        public string NazivGrada { get; set; }
    }
}
