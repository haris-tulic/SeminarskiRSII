﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarskiWebAPI.Database;

namespace SeminarskiWebAPI.Migrations
{
    [DbContext(typeof(eAutobus))]
    partial class eAutobusModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeminarskiWebAPI.Database.Autobus", b =>
                {
                    b.Property<int>("AutobusID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojAutobusa");

                    b.Property<int>("BrojSjedista");

                    b.Property<DateTime>("DatumProizvodnje");

                    b.Property<int>("GarazaID");

                    b.Property<bool>("Ispravan");

                    b.Property<string>("MarkaAutobusa");

                    b.HasKey("AutobusID");

                    b.HasIndex("GarazaID");

                    b.ToTable("Autobus");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.AutobusVozac", b =>
                {
                    b.Property<int>("AutobusVozacID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutobusID");

                    b.Property<DateTime>("Kraj");

                    b.Property<DateTime>("Pocetak");

                    b.Property<int>("Smjena");

                    b.Property<int>("VozacID");

                    b.HasKey("AutobusVozacID");

                    b.HasIndex("AutobusID");

                    b.HasIndex("VozacID");

                    b.ToTable("AutobusVozac");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Cjenovnik", b =>
                {
                    b.Property<int>("CjenovnikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena");

                    b.Property<int>("TipkarteID");

                    b.Property<int>("VrstaKarteID");

                    b.Property<int>("ZonaID");

                    b.HasKey("CjenovnikID");

                    b.HasIndex("TipkarteID");

                    b.HasIndex("VrstaKarteID");

                    b.HasIndex("ZonaID");

                    b.ToTable("Cjenovnik");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Garaza", b =>
                {
                    b.Property<int>("GarazaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojGaraze");

                    b.Property<int>("BrojMjesta");

                    b.Property<int>("GradID");

                    b.Property<bool>("IsPopunjeno");

                    b.Property<string>("NazivGaraze");

                    b.HasKey("GarazaID");

                    b.HasIndex("GradID");

                    b.ToTable("Garaza");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivGrada");

                    b.Property<int?>("PostanskiBroj");

                    b.HasKey("GradID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Karta", b =>
                {
                    b.Property<int>("KartaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVadjenjaKarte");

                    b.Property<DateTime>("DatumVazenjaKarte");

                    b.Property<int>("KupacID");

                    b.Property<bool>("Pravac");

                    b.Property<int>("RasporedVoznjeID");

                    b.Property<int>("TipKarteID");

                    b.Property<int>("VrstaKarteID");

                    b.HasKey("KartaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("RasporedVoznjeID");

                    b.HasIndex("TipKarteID");

                    b.HasIndex("VrstaKarteID");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaStanovanja");

                    b.Property<string>("BrojTelefona");

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<string>("Email");

                    b.Property<int>("GradID");

                    b.Property<string>("Ime");

                    b.Property<int>("KupacID");

                    b.Property<string>("Naziv");

                    b.Property<string>("Prezime");

                    b.Property<int>("TipKorisnikaID");

                    b.Property<int>("UpravaID");

                    b.Property<int>("VozacID");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.HasIndex("TipKorisnikaID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Kupac", b =>
                {
                    b.Property<int>("KupacID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<bool?>("Prisutan");

                    b.Property<int>("TipKorisnikaID");

                    b.HasKey("KupacID");

                    b.HasIndex("TipKorisnikaID");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.KupacOcjena", b =>
                {
                    b.Property<int>("KupacOcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KupacID");

                    b.Property<int>("RasporedVoznjeID");

                    b.Property<int>("RecenzijaID");

                    b.Property<int>("VozacID");

                    b.HasKey("KupacOcjenaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("RasporedVoznjeID");

                    b.HasIndex("RecenzijaID");

                    b.HasIndex("VozacID");

                    b.ToTable("KupacOcjena");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.RasporedVoznje", b =>
                {
                    b.Property<int>("RasporedVoznjeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutobusID");

                    b.Property<int>("BrojLinije");

                    b.Property<DateTime>("Datum");

                    b.Property<int>("KondukterID");

                    b.Property<int>("OdredisteID");

                    b.Property<int>("PolazisteID");

                    b.Property<int>("VozacID");

                    b.Property<DateTime>("VrijemeDolaska");

                    b.Property<DateTime>("VrijemePolaska");

                    b.HasKey("RasporedVoznjeID");

                    b.HasIndex("AutobusID");

                    b.HasIndex("KondukterID");

                    b.HasIndex("OdredisteID");

                    b.HasIndex("PolazisteID");

                    b.HasIndex("VozacID");

                    b.ToTable("RasporedVoznje");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Recenzija", b =>
                {
                    b.Property<int>("RecenzijaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRecenzije");

                    b.Property<string>("Komentar");

                    b.Property<int>("Ocjena");

                    b.Property<string>("VrstaUsluga");

                    b.HasKey("RecenzijaID");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Stanica", b =>
                {
                    b.Property<int>("StanicaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivLokacijeStanice");

                    b.HasKey("StanicaID");

                    b.ToTable("Stanica");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.TipKarte", b =>
                {
                    b.Property<int>("TipKarteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Informacije");

                    b.Property<string>("Naziv");

                    b.HasKey("TipKarteID");

                    b.ToTable("TipKarte");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.TipKorisnika", b =>
                {
                    b.Property<int>("TipKorisnikaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("TipKorisnikaID");

                    b.ToTable("TipKorisnika");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Uprava", b =>
                {
                    b.Property<int>("UpravaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PasswordSalt");

                    b.Property<bool?>("Prisutan");

                    b.Property<int>("TipKorisnikaID");

                    b.HasKey("UpravaID");

                    b.HasIndex("TipKorisnikaID");

                    b.ToTable("Uprava");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Vozac", b =>
                {
                    b.Property<int>("VozacID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TipKorisnikaID");

                    b.Property<string>("VozackaKategorija");

                    b.HasKey("VozacID");

                    b.HasIndex("TipKorisnikaID");

                    b.ToTable("Vozac");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.VrstaKarte", b =>
                {
                    b.Property<int>("VrstaKarteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Informacije");

                    b.Property<string>("Naziv");

                    b.HasKey("VrstaKarteID");

                    b.ToTable("VrstaKarte");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Zona", b =>
                {
                    b.Property<int>("ZonaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OznakaZone");

                    b.HasKey("ZonaID");

                    b.ToTable("Zona");
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Autobus", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Garaza", "Garaza")
                        .WithMany("Autobusi")
                        .HasForeignKey("GarazaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.AutobusVozac", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Autobus", "Autobus")
                        .WithMany("Vozaci")
                        .HasForeignKey("AutobusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Vozac", "Vozac")
                        .WithMany("Autobusi")
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Cjenovnik", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.TipKarte", "Tipkarte")
                        .WithMany()
                        .HasForeignKey("TipkarteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.VrstaKarte", "VrstaKarte")
                        .WithMany()
                        .HasForeignKey("VrstaKarteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Zona", "Zona")
                        .WithMany()
                        .HasForeignKey("ZonaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Garaza", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Karta", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.RasporedVoznje", "RasporedVoznje")
                        .WithMany()
                        .HasForeignKey("RasporedVoznjeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.TipKarte", "TipKarte")
                        .WithMany()
                        .HasForeignKey("TipKarteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.VrstaKarte", "VrstaKarte")
                        .WithMany()
                        .HasForeignKey("VrstaKarteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Korisnik", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.TipKorisnika", "TipKorisnika")
                        .WithMany()
                        .HasForeignKey("TipKorisnikaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Kupac", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Korisnik", "TipKorisnika")
                        .WithMany("Kupac")
                        .HasForeignKey("TipKorisnikaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.KupacOcjena", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.RasporedVoznje", "RasporedVoznje")
                        .WithMany()
                        .HasForeignKey("RasporedVoznjeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Recenzija", "Recenzija")
                        .WithMany()
                        .HasForeignKey("RecenzijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.RasporedVoznje", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Autobus", "Autobus")
                        .WithMany()
                        .HasForeignKey("AutobusID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Vozac", "Kondukter")
                        .WithMany()
                        .HasForeignKey("KondukterID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Stanica", "Odrediste")
                        .WithMany()
                        .HasForeignKey("OdredisteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Stanica", "Polaziste")
                        .WithMany()
                        .HasForeignKey("PolazisteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SeminarskiWebAPI.Database.Vozac", "Vozac")
                        .WithMany()
                        .HasForeignKey("VozacID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Uprava", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Korisnik", "TipKorisnika")
                        .WithMany("Uprava")
                        .HasForeignKey("TipKorisnikaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SeminarskiWebAPI.Database.Vozac", b =>
                {
                    b.HasOne("SeminarskiWebAPI.Database.Korisnik", "TipKorisnika")
                        .WithMany("Vozac")
                        .HasForeignKey("TipKorisnikaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
