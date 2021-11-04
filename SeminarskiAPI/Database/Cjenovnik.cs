﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class Cjenovnik
    {
        public int CjenovnikID { get; set; }

        public Zona Zona { get; set; }
        public int ZonaID { get; set; }
        public VrstaKarte VrstaKarte { get; set; }
        public int VrstaKarteID { get; set; }

        public TipKarte Tipkarte { get; set; }
        public int TipkarteID { get; set; }

        public float Cijena { get; set; }

       
    }
}
