using SeminarskiWebAPI.Database;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeminarskiWebAPI.Database
{
    public  class Grad
    {
        [Key]

        public int GradID { get; set; }
        public string NazivGrada { get; set; }
        public int? PostanskiBroj { get; set; }
    }
}