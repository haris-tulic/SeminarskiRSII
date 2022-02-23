using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class NewChangesInKartaAndKartaKupac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pravac",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "PravacS",
                table: "Karta");

            migrationBuilder.AddColumn<bool>(
                name: "Pravac",
                table: "KartaKupac",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PravacS",
                table: "KartaKupac",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pravac",
                table: "KartaKupac");

            migrationBuilder.DropColumn(
                name: "PravacS",
                table: "KartaKupac");

            migrationBuilder.AddColumn<bool>(
                name: "Pravac",
                table: "Karta",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PravacS",
                table: "Karta",
                nullable: true);
        }
    }
}
