using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesinTableKorisnikAndUloga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_TipKorisnika_TipKorisnikaID",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "TipKorisnika");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_TipKorisnikaID",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "TipKorisnikaID",
                table: "Korisnik",
                newName: "UlogaID");

            migrationBuilder.AddColumn<int>(
                name: "UlogeID",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogeID);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisniciUlogeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisniciUlogeID);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogeID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_UlogeID",
                table: "Korisnik",
                column: "UlogeID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik",
                column: "UlogeID",
                principalTable: "Uloge",
                principalColumn: "UlogeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik");

            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropIndex(
                name: "IX_Korisnik_UlogeID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "UlogeID",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "UlogaID",
                table: "Korisnik",
                newName: "TipKorisnikaID");

            migrationBuilder.CreateTable(
                name: "TipKorisnika",
                columns: table => new
                {
                    TipKorisnikaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKorisnika", x => x.TipKorisnikaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_TipKorisnikaID",
                table: "Korisnik",
                column: "TipKorisnikaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_TipKorisnika_TipKorisnikaID",
                table: "Korisnik",
                column: "TipKorisnikaID",
                principalTable: "TipKorisnika",
                principalColumn: "TipKorisnikaID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
