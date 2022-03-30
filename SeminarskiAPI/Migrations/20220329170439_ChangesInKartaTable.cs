using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInKartaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NacinPlacanja",
                table: "Karta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NacinPlacanja",
                table: "Karta");
        }
    }
}
