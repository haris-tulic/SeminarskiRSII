using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiWebAPI.Database
{
    public partial class eAutobusi
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            //autobusi
            modelBuilder.Entity<Autobus>().HasData(new SeminarskiWebAPI.Database.Autobus()
            {
                AutobusID = 1,
                BrojAutobusa = 6,
                BrojSjedista = 55,
                DatumProizvodnje = DateTime.Now,
                GarazaID = 1,
                IsDeleted = false,
                Ispravan=true,
                MarkaAutobusa="MAN",

            }) ;
            modelBuilder.Entity<Autobus>().HasData(new SeminarskiWebAPI.Database.Autobus()
            {
                AutobusID = 2,
                BrojAutobusa = 10,
                BrojSjedista = 55,
                DatumProizvodnje = DateTime.Now,
                GarazaID = 2,
                IsDeleted = false,
                Ispravan = true,
                MarkaAutobusa = "Volvo",
                

            });
           
            //autobus vozac
            modelBuilder.Entity<AutobusVozac>().HasData(new SeminarskiWebAPI.Database.AutobusVozac()
            {
                AutobusVozacID = 1,
                AutobusID = 1,
                VozacID = 1,
                Smjena = 1,
                Pocetak = DateTime.Now,
                Kraj=DateTime.Now.AddHours(8),
            }) ;
            modelBuilder.Entity<AutobusVozac>().HasData(new SeminarskiWebAPI.Database.AutobusVozac()
            {
                AutobusVozacID = 2,
                AutobusID = 2,
                VozacID = 2,
                Smjena = 1,
                Pocetak = DateTime.Now,
                Kraj = DateTime.Now.AddHours(8),
            });

            //cjenovnik
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID=1,
                Cijena=5.00,
                IsDeleted=false,
                OdredisteID=1,
                PolazisteID=2,
                TipkarteID=1,
                VrstaKarteID=1,
                ZonaID=1
            });
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID = 2,
                Cijena = 40.00,
                IsDeleted = false,
                OdredisteID = 1,
                PolazisteID = 2,
                TipkarteID = 1,
                VrstaKarteID = 2,
                ZonaID = 1
            });
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID = 3,
                Cijena = 8.00,
                IsDeleted = false,
                OdredisteID = 1,
                PolazisteID = 2,
                TipkarteID = 2,
                VrstaKarteID = 1,
                ZonaID = 1
            });
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID = 4,
                Cijena = 60.00,
                IsDeleted = false,
                OdredisteID = 1,
                PolazisteID = 2,
                TipkarteID = 2,
                VrstaKarteID = 2,
                ZonaID = 1
            });
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID = 5,
                Cijena = 6.00,
                IsDeleted = false,
                OdredisteID = 1,
                PolazisteID = 2,
                TipkarteID = 3,
                VrstaKarteID = 1,
                ZonaID = 1
            });
            modelBuilder.Entity<Cjenovnik>().HasData(new SeminarskiWebAPI.Database.Cjenovnik()
            {
                CjenovnikID = 6,
                Cijena = 50.00,
                IsDeleted = false,
                OdredisteID = 1,
                PolazisteID = 2,
                TipkarteID = 3,
                VrstaKarteID = 2,
                ZonaID = 1
            });

            //tipkarte
            modelBuilder.Entity<TipKarte>().HasData(new SeminarskiWebAPI.Database.TipKarte()
            {
                TipKarteID=1,
                Informacije= "Važi samo za studente uz priloženu potvrdu!",
                Naziv="Studentska"
            });
            modelBuilder.Entity<TipKarte>().HasData(new SeminarskiWebAPI.Database.TipKarte()
            {
                TipKarteID = 2,
                Informacije = "Važi samo za radnike uz priloženu potvrdu!",
                Naziv = "Radnička"
            });
            modelBuilder.Entity<TipKarte>().HasData(new SeminarskiWebAPI.Database.TipKarte()
            {
                TipKarteID = 3,
                Informacije = "Važi samo za penzionere uz priloženu potvrdu!",
                Naziv = "Penzionerska"
            });
           
            //vrstakarte
            modelBuilder.Entity<VrstaKarte>().HasData(new SeminarskiWebAPI.Database.VrstaKarte()
            {
                VrstaKarteID=1,
                Naziv="Dnevna",
                Informacije="Traje jedan dan!",
            });
            modelBuilder.Entity<VrstaKarte>().HasData(new SeminarskiWebAPI.Database.VrstaKarte()
            {
                VrstaKarteID = 2,
                Naziv = "Mjesečna",
                Informacije = "Traje jedan mjesec!",
            });
            modelBuilder.Entity<VrstaKarte>().HasData(new SeminarskiWebAPI.Database.VrstaKarte()
            {
                VrstaKarteID = 3,
                Naziv = "Godišnja",
                Informacije = "Traje jednu godinu!",
            });
           
            //kupac
            modelBuilder.Entity<Kupac>().HasData(new SeminarskiWebAPI.Database.Kupac()
            {
                KupacID = 1,
                Ime = "Kupac1",
                Prezime = "Kupac1",
                Email = "kupac1@edu.fit.ba",
                BrojTelefona = "062333444",
                KorisnickoIme = "kupac1",
                LozinkaHash = "/VEfw6wmtify1fOTuLBJrXHXo0I=",
                LozinkaSalt = "ZneRfhOqwq8zu13rCRCrIQ==",
                AdresaStanovanja ="Zalik BB",
                
            });
            modelBuilder.Entity<Kupac>().HasData(new SeminarskiWebAPI.Database.Kupac()
            {
                KupacID = 2,
                Ime = "Kupac2",
                Prezime = "Kupac2",
                Email = "kupac2@edu.fit.ba",
                BrojTelefona = "062333555",
                KorisnickoIme = "kupac2",
                LozinkaHash = "/VEfw6wmtify1fOTuLBJrXHXo0I=",
                LozinkaSalt = "ZneRfhOqwq8zu13rCRCrIQ==",
                AdresaStanovanja = "Zalik BB",

            });

            //korisnici
            modelBuilder.Entity<Korisnik>().HasData(new SeminarskiWebAPI.Database.Korisnik()
            {
                KorisnikID = 1,
                Ime = "Admin",
                Prezime = "Admin",
                Email = "admin@gmail.com",
                BrojTelefona = "061222333",
                DatumRodjenja = new DateTime(1995, 11, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                KorisnickoIme = "desktop",
                LozinkaHash = "/VEfw6wmtify1fOTuLBJrXHXo0I=",
                LozinkaSalt = "ZneRfhOqwq8zu13rCRCrIQ==",
                IsDeleted = false,
                AdresaStanovanja="Zalik BB",
                GradID=2,
                UlogeID=1,
               
            });
            modelBuilder.Entity<Korisnik>().HasData(new SeminarskiWebAPI.Database.Korisnik()
            {
                KorisnikID = 2,
                Ime = "Vozač1",
                Prezime = "Vozač1",
                Email = "vozac1@gmail.com",
                BrojTelefona = "061444555",
                DatumRodjenja = new DateTime(1995, 11, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                KorisnickoIme = "vozac1",
                LozinkaHash = "/VEfw6wmtify1fOTuLBJrXHXo0I=",
                LozinkaSalt = "ZneRfhOqwq8zu13rCRCrIQ==",
                IsDeleted = false,
                AdresaStanovanja = "Zalik BB",
                GradID = 2,
                UlogeID = 2,

            });
            modelBuilder.Entity<Korisnik>().HasData(new SeminarskiWebAPI.Database.Korisnik()
            {
                KorisnikID = 3,
                Ime = "Vozač3",
                Prezime = "Vozač3",
                Email = "vozac3@gmail.com",
                BrojTelefona = "061014555",
                DatumRodjenja = new DateTime(1990, 10, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                KorisnickoIme = "vozac3",
                LozinkaHash = "/VEfw6wmtify1fOTuLBJrXHXo0I=",
                LozinkaSalt = "ZneRfhOqwq8zu13rCRCrIQ==",
                IsDeleted = false,
                AdresaStanovanja = "Dolina Sunca BB",
                GradID = 2,
                UlogeID = 3,

            });

            //korisnik-vozac
            modelBuilder.Entity<Vozac>().HasData(new SeminarskiWebAPI.Database.Vozac()
            {
                KorisnikID = 2,
                VozacID=1,
                VozackaKategorija="B,C,D,D1",
            });
            modelBuilder.Entity<Vozac>().HasData(new SeminarskiWebAPI.Database.Vozac()
            {
                KorisnikID = 3,
                VozacID = 2,
                VozackaKategorija = "B,C,D,D1",
            });
            
            //uloge
            modelBuilder.Entity<Uloge>().HasData(new SeminarskiWebAPI.Database.Uloge()
            {
                UlogeID = 1,
                Naziv = "Admin"
            });
            modelBuilder.Entity<Uloge>().HasData(new SeminarskiWebAPI.Database.Uloge()
            {
                UlogeID = 2,
                Naziv = "Vozač"
            });
            modelBuilder.Entity<Uloge>().HasData(new SeminarskiWebAPI.Database.Uloge()
            {
                UlogeID = 3,
                Naziv = "Kondukter"
            });

            //korisnici-uloge
            modelBuilder.Entity<KorisniciUloge>().HasData(new SeminarskiWebAPI.Database.KorisniciUloge()
            {
               KorisniciUlogeID=1,
               KorisnikID=1,
               UlogaID=1,
               DatumIzmjene = DateTime.Now
            });
            modelBuilder.Entity<KorisniciUloge>().HasData(new SeminarskiWebAPI.Database.KorisniciUloge()
            {
                KorisniciUlogeID = 2,
                KorisnikID = 2,
                UlogaID = 2,
                DatumIzmjene = DateTime.Now
            });
            modelBuilder.Entity<KorisniciUloge>().HasData(new SeminarskiWebAPI.Database.KorisniciUloge()
            {
                KorisniciUlogeID = 3,
                KorisnikID = 3,
                UlogaID = 2,
                DatumIzmjene = DateTime.Now
            });

            //garaza
            modelBuilder.Entity<Garaza>().HasData(new SeminarskiWebAPI.Database.Garaza()
            {
              GarazaID=1,
              GradID = 1,
              BrojGaraze=1,
              BrojMjesta=10,
              IsPopunjeno=false,
              NazivGaraze="Garaža-Mostar",
              TrenutnoAutobusa=1,
            });
            modelBuilder.Entity<Garaza>().HasData(new SeminarskiWebAPI.Database.Garaza()
            {
                GarazaID = 2,
                GradID = 2,
                BrojGaraze = 2,
                BrojMjesta = 10,
                IsPopunjeno = false,
                NazivGaraze = "Garaža-Sarajevo",
                TrenutnoAutobusa = 1,
            });
            
            //grad
            modelBuilder.Entity<Grad>().HasData(new SeminarskiWebAPI.Database.Grad()
            {
               GradID=1,
               NazivGrada="Sarajevo",
               PostanskiBroj=88000,
            });
            modelBuilder.Entity<Grad>().HasData(new SeminarskiWebAPI.Database.Grad()
            {
                GradID = 2,
                NazivGrada = "Mostar",
                PostanskiBroj = 87000,
            });
            modelBuilder.Entity<Grad>().HasData(new SeminarskiWebAPI.Database.Grad()
            {
                GradID = 3,
                NazivGrada = "Konjic",
                PostanskiBroj = 88400,
            });
           
            //karta
            modelBuilder.Entity<Karta>().HasData(new SeminarskiWebAPI.Database.Karta()
            {
                KartaID=1,
                Cijena=5.00,
                IsDeleted=false,
                NacinPlacanja="Preuzećem",
                OdredisteID=1,
                PolazisteID=2,
                TipKarteID=1,
                VrstaKarteID=1,
                //DatumObjave = new DateTime(2020, 5, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                //KorisnikId = 1
            });
            modelBuilder.Entity<Karta>().HasData(new SeminarskiWebAPI.Database.Karta()
            {
                KartaID = 2,
                Cijena = 10.00,
                IsDeleted = false,
                NacinPlacanja = "Online",
                OdredisteID = 2,
                PolazisteID = 1,
                TipKarteID = 1,
                VrstaKarteID = 2,
                //DatumObjave = new DateTime(2020, 5, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                //KorisnikId = 1
            });
           
            //kartakupac
            modelBuilder.Entity<KartaKupac>().HasData(new SeminarskiWebAPI.Database.KartaKupac()
            {
                
               KartaID = 1,
               Aktivna=true,
               KartaKupacID=1,
               DatumVadjenjaKarte=DateTime.Now,
               DatumVazenjaKarte=DateTime.Now.AddHours(12),
               KupacID=1,
               Pravac=true,
               PravacS="U jednom pravcu",
            });
            modelBuilder.Entity<KartaKupac>().HasData(new SeminarskiWebAPI.Database.KartaKupac()
            {
                KartaID = 2,
                Aktivna = true,
                KartaKupacID = 2,
                DatumVadjenjaKarte = DateTime.Now,
                DatumVazenjaKarte = DateTime.Now.AddMonths(1),
                KupacID = 2,
                Pravac = true,
                PravacS = "U oba pravca",
            });

            //platikartu
            modelBuilder.Entity<PlatiKartu>().HasData(new SeminarskiWebAPI.Database.PlatiKartu()
            {
                PlatiKartuID=1,
                KartaID = 2,
                KupacID=2,
                Cijena=10.00,
                JeLiPlacena=true,
                DatumVadjenjaKarte=DateTime.Now,
                DatumVazenjaKarte=DateTime.Now.AddMonths(1),
                
            });

            //rasporedvoznje
            modelBuilder.Entity<RasporedVoznje>().HasData(new SeminarskiWebAPI.Database.RasporedVoznje()
            {
                RasporedVoznjeID=1,
                AutobusID=1,
                BrojLinije=6,
                Datum=DateTime.Now,
                FinalOcjena=5,
                IsDeleted=false,
                KondukterID=1,
                OdredisteID=2,
                PolazisteID=1,
                VozacID=1,
                VrijemePolaska= DateTime.Now,
                VrijemeDolaska=DateTime.Now,
            });
            modelBuilder.Entity<RasporedVoznje>().HasData(new SeminarskiWebAPI.Database.RasporedVoznje()
            {
                RasporedVoznjeID = 2,
                AutobusID = 2,
                BrojLinije = 10,
                Datum = new DateTime(2022, 3, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190),
                FinalOcjena = 4,
                IsDeleted = false,
                KondukterID = 2,
                OdredisteID = 1,
                PolazisteID = 2,
                VozacID = 2,
                VrijemePolaska = new DateTime(2022, 3, 1, 12, 15, 00, 000, DateTimeKind.Local).AddTicks(8190),
                VrijemeDolaska = new DateTime(2022, 3, 1, 14, 30, 00, 000, DateTimeKind.Local).AddTicks(8190)
            });

           
            //recenzije
            modelBuilder.Entity<Recenzija>().HasData(new SeminarskiWebAPI.Database.Recenzija()
            {
              RecenzijaID = 1,
              RasporedVoznjeID = 1,
              KupacID=1,
              DatumRecenzije=DateTime.Now,
              VrstaUsluga="Osoblje",
              Komentar="Sve pohvale!",
              Ocjena=5,
            });
            modelBuilder.Entity<Recenzija>().HasData(new SeminarskiWebAPI.Database.Recenzija()
            {
                RecenzijaID = 2,
                RasporedVoznjeID = 2,
                KupacID = 2,
                DatumRecenzije = DateTime.Now,
                VrstaUsluga = "Vozilo",
                Komentar = "Nije očišćeno!",
                Ocjena = 3,
            });

            //stanice
            modelBuilder.Entity<Stanica>().HasData(new SeminarskiWebAPI.Database.Stanica()
            {
                StanicaID=1,
                GradID = 1,
                NazivLokacijeStanice="Stanica-Sarajevo",
            });
            modelBuilder.Entity<Stanica>().HasData(new SeminarskiWebAPI.Database.Stanica()
            {
                StanicaID = 2,
                GradID = 2,
                NazivLokacijeStanice = "Stanica-Mostar",
            });

            //zona
            modelBuilder.Entity<Zona>().HasData(new SeminarskiWebAPI.Database.Zona()
            {
                ZonaID=1,
                OznakaZone="Zona I",
            });
            modelBuilder.Entity<Zona>().HasData(new SeminarskiWebAPI.Database.Zona() 
            {
                ZonaID=2,
                OznakaZone="Zona II",
            });
            modelBuilder.Entity<Zona>().HasData(new SeminarskiWebAPI.Database.Zona()
            {
                ZonaID = 3,
                OznakaZone = "Zona III",
            });
        }

    }
}//Add-Migration InitData
