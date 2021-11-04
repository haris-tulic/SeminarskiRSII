using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eAutobusModel
{
    public class VozacModel
    {
        [Key]
        public int VozacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string VozackaKategorija { get; set; }
        public int TipKorisnikaID { get; set; }
    }
}