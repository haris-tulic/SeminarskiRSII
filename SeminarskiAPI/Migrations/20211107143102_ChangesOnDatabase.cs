using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesOnDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karta_RasporedVoznje_RasporedVoznjeID",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Korisnik_TipKorisnikaID",
                table: "Kupac");

            migrationBuilder.DropForeignKey(
                name: "FK_Uprava_Korisnik_TipKorisnikaID",
                table: "Uprava");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozac_Korisnik_TipKorisnikaID",
                table: "Vozac");

            migrationBuilder.RenameColumn(
                name: "TipKorisnikaID",
                table: "Vozac",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Vozac_TipKorisnikaID",
                table: "Vozac",
                newName: "IX_Vozac_KorisnikID");

            migrationBuilder.RenameColumn(
                name: "TipKorisnikaID",
                table: "Uprava",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Uprava_TipKorisnikaID",
                table: "Uprava",
                newName: "IX_Uprava_KorisnikID");

            migrationBuilder.RenameColumn(
                name: "TipKorisnikaID",
                table: "Kupac",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Kupac_TipKorisnikaID",
                table: "Kupac",
                newName: "IX_Kupac_KorisnikID");

            migrationBuilder.RenameColumn(
                name: "RasporedVoznjeID",
                table: "Karta",
                newName: "PolazisteID");

            migrationBuilder.RenameIndex(
                name: "IX_Karta_RasporedVoznjeID",
                table: "Karta",
                newName: "IX_Karta_PolazisteID");

            migrationBuilder.AddColumn<int>(
                name: "OdredisteID",
                table: "Karta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Karta_OdredisteID",
                table: "Karta",
                column: "OdredisteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_Stanica_OdredisteID",
                table: "Karta",
                column: "OdredisteID",
                principalTable: "Stanica",
                principalColumn: "StanicaID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_Stanica_PolazisteID",
                table: "Karta",
                column: "PolazisteID",
                principalTable: "Stanica",
                principalColumn: "StanicaID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikID",
                table: "Kupac",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Uprava_Korisnik_KorisnikID",
                table: "Uprava",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozac_Korisnik_KorisnikID",
                table: "Vozac",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karta_Stanica_OdredisteID",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "FK_Karta_Stanica_PolazisteID",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikID",
                table: "Kupac");

            migrationBuilder.DropForeignKey(
                name: "FK_Uprava_Korisnik_KorisnikID",
                table: "Uprava");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozac_Korisnik_KorisnikID",
                table: "Vozac");

            migrationBuilder.DropIndex(
                name: "IX_Karta_OdredisteID",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "OdredisteID",
                table: "Karta");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Vozac",
                newName: "TipKorisnikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Vozac_KorisnikID",
                table: "Vozac",
                newName: "IX_Vozac_TipKorisnikaID");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Uprava",
                newName: "TipKorisnikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Uprava_KorisnikID",
                table: "Uprava",
                newName: "IX_Uprava_TipKorisnikaID");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Kupac",
                newName: "TipKorisnikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Kupac_KorisnikID",
                table: "Kupac",
                newName: "IX_Kupac_TipKorisnikaID");

            migrationBuilder.RenameColumn(
                name: "PolazisteID",
                table: "Karta",
                newName: "RasporedVoznjeID");

            migrationBuilder.RenameIndex(
                name: "IX_Karta_PolazisteID",
                table: "Karta",
                newName: "IX_Karta_RasporedVoznjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_RasporedVoznje_RasporedVoznjeID",
                table: "Karta",
                column: "RasporedVoznjeID",
                principalTable: "RasporedVoznje",
                principalColumn: "RasporedVoznjeID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Korisnik_TipKorisnikaID",
                table: "Kupac",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Uprava_Korisnik_TipKorisnikaID",
                table: "Uprava",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozac_Korisnik_TipKorisnikaID",
                table: "Vozac",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
