using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "UlogaID",
                table: "Korisnik");

            migrationBuilder.AlterColumn<int>(
                name: "UlogeID",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik",
                column: "UlogeID",
                principalTable: "Uloge",
                principalColumn: "UlogeID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik");

            migrationBuilder.AlterColumn<int>(
                name: "UlogeID",
                table: "Korisnik",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UlogaID",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnik_Uloge_UlogeID",
                table: "Korisnik",
                column: "UlogeID",
                principalTable: "Uloge",
                principalColumn: "UlogeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
