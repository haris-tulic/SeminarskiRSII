﻿using Microsoft.EntityFrameworkCore;
using SeminarskiWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public class eAutobus:DbContext
    {
       
            public eAutobus()
            {
            }

            public eAutobus(DbContextOptions<eAutobus> options)
                : base(options)
            {
            }

            public virtual DbSet<Autobus> Autobus { get; set; }
            public virtual DbSet<AutobusVozac> AutobusVozac { get; set; }
            public virtual DbSet<Cjenovnik> Cjenovnik { get; set; }
            public virtual DbSet<Grad> Grad { get; set; }
            public virtual DbSet<Karta> Karta { get; set; }
            public virtual DbSet<Kupac> Kupac { get; set; }
            public virtual DbSet<RasporedVoznje> RasporedVoznje { get; set; }
            public virtual DbSet<Recenzija> Recenzija { get; set; }
            public virtual DbSet<Stanica> Stanica { get; set; }
            public virtual DbSet<TipKarte> TipKarte { get; set; }
            public virtual DbSet<Vozac> Vozac { get; set; }
            public virtual DbSet<VrstaKarte> VrstaKarte { get; set; }
            public virtual DbSet<Zona> Zona { get; set; }
            public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
            public virtual DbSet<Uloge> Uloge  { get; set; }
            public virtual DbSet<KupacOcjena> KupacOcjena { get; set; }
            public virtual DbSet<Garaza> Garaza { get; set; }
            public virtual DbSet<Korisnik> Korisnik { get; set; }




        protected override void OnModelCreating(ModelBuilder bilder)
            {
                base.OnModelCreating(bilder);
            }



    }
}
