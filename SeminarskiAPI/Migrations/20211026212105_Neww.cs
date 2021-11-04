using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class Neww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_TipKorisnik_TipKorisnikaID",
                table: "Kupac");

            migrationBuilder.DropForeignKey(
                name: "FK_TipKorisnik_Grad_GradID",
                table: "TipKorisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_TipKorisnik_TipKorisnika_TipKorisnikaID",
                table: "TipKorisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Uprava_TipKorisnik_TipKorisnikaID",
                table: "Uprava");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozac_TipKorisnik_TipKorisnikaID",
                table: "Vozac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipKorisnik",
                table: "TipKorisnik");

            migrationBuilder.RenameTable(
                name: "TipKorisnik",
                newName: "Korisnik");

            migrationBuilder.RenameIndex(
                name: "IX_TipKorisnik_TipKorisnikaID",
                table: "Korisnik",
                newName: "IX_Korisnik_TipKorisnikaID");

            migrationBuilder.RenameIndex(
                name: "IX_TipKorisnik_GradID",
                table: "Korisnik",
                newName: "IX_Korisnik_GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Grad_GradID",
                table: "Korisnik",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_TipKorisnika_TipKorisnikaID",
                table: "Korisnik",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnika",
                principalColumn: "TipKorisnikaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Korisnik_TipKorisnikaID",
                table: "Kupac",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uprava_Korisnik_TipKorisnikaID",
                table: "Uprava",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozac_Korisnik_TipKorisnikaID",
                table: "Vozac",
                column: "TipKorisnikaID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Grad_GradID",
                table: "Korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_TipKorisnika_TipKorisnikaID",
                table: "Korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Korisnik_TipKorisnikaID",
                table: "Kupac");

            migrationBuilder.DropForeignKey(
                name: "FK_Uprava_Korisnik_TipKorisnikaID",
                table: "Uprava");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozac_Korisnik_TipKorisnikaID",
                table: "Vozac");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik");

            migrationBuilder.RenameTable(
                name: "Korisnik",
                newName: "TipKorisnik");

            migrationBuilder.RenameIndex(
                name: "IX_Korisnik_TipKorisnikaID",
                table: "TipKorisnik",
                newName: "IX_TipKorisnik_TipKorisnikaID");

            migrationBuilder.RenameIndex(
                name: "IX_Korisnik_GradID",
                table: "TipKorisnik",
                newName: "IX_TipKorisnik_GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipKorisnik",
                table: "TipKorisnik",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_TipKorisnik_TipKorisnikaID",
                table: "Kupac",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipKorisnik_Grad_GradID",
                table: "TipKorisnik",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipKorisnik_TipKorisnika_TipKorisnikaID",
                table: "TipKorisnik",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnika",
                principalColumn: "TipKorisnikaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uprava_TipKorisnik_TipKorisnikaID",
                table: "Uprava",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozac_TipKorisnik_TipKorisnikaID",
                table: "Vozac",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
