using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karta_Kupac_KupacID",
                table: "Karta");

            migrationBuilder.DropTable(
                name: "Uprava");

            migrationBuilder.DropIndex(
                name: "IX_Karta_KupacID",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Prisutan",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KupacID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "UpravaID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "VozacID",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "Naziv",
                table: "Korisnik",
                newName: "LozinkaSalt");

            migrationBuilder.AddColumn<int>(
                name: "KartaID",
                table: "Kupac",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KartaID",
                table: "Kupac",
                column: "KartaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac",
                column: "KartaID",
                principalTable: "Karta",
                principalColumn: "KartaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac");

            migrationBuilder.DropIndex(
                name: "IX_Kupac_KartaID",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KartaID",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Korisnik");

            migrationBuilder.RenameColumn(
                name: "LozinkaSalt",
                table: "Korisnik",
                newName: "Naziv");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Prisutan",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KupacID",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UpravaID",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VozacID",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Uprava",
                columns: table => new
                {
                    UpravaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikID = table.Column<int>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Prisutan = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uprava", x => x.UpravaID);
                    table.ForeignKey(
                        name: "FK_Uprava_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Karta_KupacID",
                table: "Karta",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Uprava_KorisnikID",
                table: "Uprava",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_Kupac_KupacID",
                table: "Karta",
                column: "KupacID",
                principalTable: "Kupac",
                principalColumn: "KupacID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
