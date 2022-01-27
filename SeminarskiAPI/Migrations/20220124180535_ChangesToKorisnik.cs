using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesToKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaHash",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LozinkaSalt",
                table: "Kupac",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "LozinkaHash",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "LozinkaSalt",
                table: "Kupac");
        }
    }
}
