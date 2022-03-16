using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInRasporedVoznjeCijena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "FinalOcjena",
                table: "RasporedVoznje",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FinalOcjena",
                table: "RasporedVoznje",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
