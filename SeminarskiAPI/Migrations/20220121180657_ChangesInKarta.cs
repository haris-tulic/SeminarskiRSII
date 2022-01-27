using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInKarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PravacS",
                table: "Karta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PravacS",
                table: "Karta");
        }
    }
}
