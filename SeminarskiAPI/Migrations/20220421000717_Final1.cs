using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class Final1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "GradID", "NazivGrada", "PostanskiBroj" },
                values: new object[,]
                {
                    { 1, "Sarajevo", 88000 },
                    { 2, "Mostar", 87000 },
                    { 3, "Konjic", 88400 }
                });

            migrationBuilder.InsertData(
                table: "Kupac",
                columns: new[] { "KupacID", "AdresaStanovanja", "BrojTelefona", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[,]
                {
                    { 1, "Zalik BB", "062333444", "kupac1@edu.fit.ba", "Kupac1", "kupac1", "/VEfw6wmtify1fOTuLBJrXHXo0I=", "ZneRfhOqwq8zu13rCRCrIQ==", "Kupac1" },
                    { 2, "Zalik BB", "062333555", "kupac2@edu.fit.ba", "Kupac2", "kupac2", "/VEfw6wmtify1fOTuLBJrXHXo0I=", "ZneRfhOqwq8zu13rCRCrIQ==", "Kupac2" }
                });

            migrationBuilder.InsertData(
                table: "TipKarte",
                columns: new[] { "TipKarteID", "Informacije", "Naziv" },
                values: new object[,]
                {
                    { 1, "Važi samo za studente uz priloženu potvrdu!", "Studentska" },
                    { 2, "Važi samo za radnike uz priloženu potvrdu!", "Radnička" },
                    { 3, "Važi samo za penzionere uz priloženu potvrdu!", "Penzionerska" }
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogeID", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 3, "Kondukter", null },
                    { 1, "Admin", null },
                    { 2, "Vozač", null }
                });

            migrationBuilder.InsertData(
                table: "VrstaKarte",
                columns: new[] { "VrstaKarteID", "Informacije", "Naziv" },
                values: new object[,]
                {
                    { 1, "Traje jedan dan!", "Dnevna" },
                    { 2, "Traje jedan mjesec!", "Mjesečna" },
                    { 3, "Traje jednu godinu!", "Godišnja" }
                });

            migrationBuilder.InsertData(
                table: "Zona",
                columns: new[] { "ZonaID", "OznakaZone" },
                values: new object[,]
                {
                    { 2, "Zona II" },
                    { 1, "Zona I" },
                    { 3, "Zona III" }
                });

            migrationBuilder.InsertData(
                table: "Garaza",
                columns: new[] { "GarazaID", "BrojGaraze", "BrojMjesta", "GradID", "IsPopunjeno", "NazivGaraze", "TrenutnoAutobusa" },
                values: new object[,]
                {
                    { 1, 1, 10, 1, false, "Garaža-Mostar", 1 },
                    { 2, 2, 10, 2, false, "Garaža-Sarajevo", 1 }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikID", "AdresaStanovanja", "BrojTelefona", "DatumRodjenja", "Email", "GradID", "Ime", "IsDeleted", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "UlogeID" },
                values: new object[,]
                {
                    { 1, "Zalik BB", "061222333", new DateTime(1995, 11, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), "admin@gmail.com", 2, "Admin", false, "desktop", "/VEfw6wmtify1fOTuLBJrXHXo0I=", "ZneRfhOqwq8zu13rCRCrIQ==", "Admin", 1 },
                    { 2, "Zalik BB", "061444555", new DateTime(1995, 11, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), "vozac1@gmail.com", 2, "Vozač1", false, "vozac1", "/VEfw6wmtify1fOTuLBJrXHXo0I=", "ZneRfhOqwq8zu13rCRCrIQ==", "Vozač1", 2 },
                    { 3, "Dolina Sunca BB", "061014555", new DateTime(1990, 10, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), "vozac3@gmail.com", 2, "Vozač3", false, "vozac3", "/VEfw6wmtify1fOTuLBJrXHXo0I=", "ZneRfhOqwq8zu13rCRCrIQ==", "Vozač3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Stanica",
                columns: new[] { "StanicaID", "GradID", "NazivLokacijeStanice" },
                values: new object[,]
                {
                    { 1, 1, "Stanica-Sarajevo" },
                    { 2, 2, "Stanica-Mostar" }
                });

            migrationBuilder.InsertData(
                table: "Autobus",
                columns: new[] { "AutobusID", "BrojAutobusa", "BrojSjedista", "DatumProizvodnje", "GarazaID", "IsDeleted", "Ispravan", "MarkaAutobusa" },
                values: new object[,]
                {
                    { 1, 6, 55, new DateTime(2022, 4, 21, 2, 7, 16, 731, DateTimeKind.Local).AddTicks(8820), 1, false, true, "MAN" },
                    { 2, 10, 55, new DateTime(2022, 4, 21, 2, 7, 16, 735, DateTimeKind.Local).AddTicks(1695), 2, false, true, "Volvo" }
                });

            migrationBuilder.InsertData(
                table: "Cjenovnik",
                columns: new[] { "CjenovnikID", "Cijena", "IsDeleted", "OdredisteID", "PolazisteID", "TipkarteID", "VrstaKarteID", "ZonaID" },
                values: new object[,]
                {
                    { 1, 5.0, false, 1, 2, 1, 1, 1 },
                    { 2, 40.0, false, 1, 2, 1, 2, 1 },
                    { 3, 8.0, false, 1, 2, 2, 1, 1 },
                    { 4, 60.0, false, 1, 2, 2, 2, 1 },
                    { 5, 6.0, false, 1, 2, 3, 1, 1 },
                    { 6, 50.0, false, 1, 2, 3, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaID", "Cijena", "IsDeleted", "NacinPlacanja", "OdredisteID", "PolazisteID", "TipKarteID", "VrstaKarteID" },
                values: new object[,]
                {
                    { 1, 5.0, false, "Preuzećem", 1, 2, 1, 1 },
                    { 2, 10.0, false, "Online", 2, 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "KorisniciUlogeID", "DatumIzmjene", "KorisnikID", "UlogaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 21, 2, 7, 16, 737, DateTimeKind.Local).AddTicks(3093), 1, 1 },
                    { 2, new DateTime(2022, 4, 21, 2, 7, 16, 737, DateTimeKind.Local).AddTicks(3926), 2, 2 },
                    { 3, new DateTime(2022, 4, 21, 2, 7, 16, 737, DateTimeKind.Local).AddTicks(3963), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Vozac",
                columns: new[] { "VozacID", "KorisnikID", "VozackaKategorija" },
                values: new object[,]
                {
                    { 1, 2, "B,C,D,D1" },
                    { 2, 3, "B,C,D,D1" }
                });

            migrationBuilder.InsertData(
                table: "AutobusVozac",
                columns: new[] { "AutobusVozacID", "AutobusID", "Kraj", "Pocetak", "Smjena", "VozacID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 21, 10, 7, 16, 735, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 4, 21, 2, 7, 16, 735, DateTimeKind.Local).AddTicks(4205), 1, 1 },
                    { 2, 2, new DateTime(2022, 4, 21, 10, 7, 16, 735, DateTimeKind.Local).AddTicks(5167), new DateTime(2022, 4, 21, 2, 7, 16, 735, DateTimeKind.Local).AddTicks(5156), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "KartaKupac",
                columns: new[] { "KartaKupacID", "Aktivna", "DatumVadjenjaKarte", "DatumVazenjaKarte", "KartaID", "KupacID", "Pravac", "PravacS" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 4, 21, 14, 7, 16, 738, DateTimeKind.Local).AddTicks(2108), 1, 1, true, "U jednom pravcu" },
                    { 2, true, new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 5, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(3381), 2, 2, true, "U oba pravca" }
                });

            migrationBuilder.InsertData(
                table: "PlatiKartu",
                columns: new[] { "PlatiKartuID", "Cijena", "DatumVadjenjaKarte", "DatumVazenjaKarte", "JeLiPlacena", "KartaID", "KupacID" },
                values: new object[] { 1, 10.0, new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(4992), new DateTime(2022, 5, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(5292), true, 2, 2 });

            migrationBuilder.InsertData(
                table: "RasporedVoznje",
                columns: new[] { "RasporedVoznjeID", "AutobusID", "BrojLinije", "Datum", "FinalOcjena", "IsDeleted", "KondukterID", "OdredisteID", "PolazisteID", "VozacID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 1, 1, 6, new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(6860), 5m, false, 1, 2, 1, 1, new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(9291), new DateTime(2022, 4, 21, 2, 7, 16, 738, DateTimeKind.Local).AddTicks(8971) },
                    { 2, 2, 10, new DateTime(2022, 3, 1, 14, 29, 18, 167, DateTimeKind.Local).AddTicks(8190), 4m, false, 2, 1, 2, 2, new DateTime(2022, 3, 1, 14, 30, 0, 0, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 3, 1, 12, 15, 0, 0, DateTimeKind.Local).AddTicks(8190) }
                });

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "RecenzijaID", "DatumRecenzije", "Komentar", "KupacID", "Ocjena", "RasporedVoznjeID", "VrstaUsluga" },
                values: new object[] { 1, new DateTime(2022, 4, 21, 2, 7, 16, 739, DateTimeKind.Local).AddTicks(988), "Sve pohvale!", 1, 5, 1, "Osoblje" });

            migrationBuilder.InsertData(
                table: "Recenzija",
                columns: new[] { "RecenzijaID", "DatumRecenzije", "Komentar", "KupacID", "Ocjena", "RasporedVoznjeID", "VrstaUsluga" },
                values: new object[] { 2, new DateTime(2022, 4, 21, 2, 7, 16, 739, DateTimeKind.Local).AddTicks(2373), "Nije očišćeno!", 2, 3, 2, "Vozilo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AutobusVozac",
                keyColumn: "AutobusVozacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AutobusVozac",
                keyColumn: "AutobusVozacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cjenovnik",
                keyColumn: "CjenovnikID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KartaKupac",
                keyColumn: "KartaKupacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KartaKupac",
                keyColumn: "KartaKupacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PlatiKartu",
                keyColumn: "PlatiKartuID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "RecenzijaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recenzija",
                keyColumn: "RecenzijaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaKarte",
                keyColumn: "VrstaKarteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zona",
                keyColumn: "ZonaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zona",
                keyColumn: "ZonaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kupac",
                keyColumn: "KupacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kupac",
                keyColumn: "KupacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RasporedVoznje",
                keyColumn: "RasporedVoznjeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RasporedVoznje",
                keyColumn: "RasporedVoznjeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipKarte",
                keyColumn: "TipKarteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipKarte",
                keyColumn: "TipKarteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zona",
                keyColumn: "ZonaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autobus",
                keyColumn: "AutobusID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autobus",
                keyColumn: "AutobusID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "StanicaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "StanicaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TipKarte",
                keyColumn: "TipKarteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vozac",
                keyColumn: "VozacID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vozac",
                keyColumn: "VozacID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VrstaKarte",
                keyColumn: "VrstaKarteID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VrstaKarte",
                keyColumn: "VrstaKarteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Garaza",
                keyColumn: "GarazaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Garaza",
                keyColumn: "GarazaID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "KorisnikID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "GradID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogeID",
                keyValue: 3);
        }
    }
}
