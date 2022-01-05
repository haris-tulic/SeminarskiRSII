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
        public List<Garaza> Garaze { get; set; }
        public List<Korisnik> Korisnici { get; set; }
        public List<Stanica> Stanice  { get; set; }
    }
}