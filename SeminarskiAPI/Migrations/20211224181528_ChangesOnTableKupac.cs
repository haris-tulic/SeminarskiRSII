using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesOnTableKupac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikID",
                table: "Kupac");

            migrationBuilder.DropIndex(
                name: "IX_Kupac_KorisnikID",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KorisnikID",
                table: "Kupac");

            migrationBuilder.AddColumn<string>(
                name: "AdresaStanovanja",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrojTelefona",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OdredisteID",
                table: "Cjenovnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PolazisteID",
                table: "Cjenovnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_OdredisteID",
                table: "Cjenovnik",
                column: "OdredisteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_PolazisteID",
                table: "Cjenovnik",
                column: "PolazisteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cjenovnik_Stanica_OdredisteID",
                table: "Cjenovnik",
                column: "OdredisteID",
                principalTable: "Stanica",
                principalColumn: "StanicaID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Cjenovnik_Stanica_PolazisteID",
                table: "Cjenovnik",
                column: "PolazisteID",
                principalTable: "Stanica",
                principalColumn: "StanicaID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cjenovnik_Stanica_OdredisteID",
                table: "Cjenovnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Cjenovnik_Stanica_PolazisteID",
                table: "Cjenovnik");

            migrationBuilder.DropIndex(
                name: "IX_Cjenovnik_OdredisteID",
                table: "Cjenovnik");

            migrationBuilder.DropIndex(
                name: "IX_Cjenovnik_PolazisteID",
                table: "Cjenovnik");

            migrationBuilder.DropColumn(
                name: "AdresaStanovanja",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "BrojTelefona",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "OdredisteID",
                table: "Cjenovnik");

            migrationBuilder.DropColumn(
                name: "PolazisteID",
                table: "Cjenovnik");

            migrationBuilder.AddColumn<int>(
                name: "KorisnikID",
                table: "Kupac",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KorisnikID",
                table: "Kupac",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikID",
                table: "Kupac",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
