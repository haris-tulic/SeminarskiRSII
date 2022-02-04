using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInKupac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac");

            migrationBuilder.AlterColumn<int>(
                name: "KartaID",
                table: "Kupac",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac",
                column: "KartaID",
                principalTable: "Karta",
                principalColumn: "KartaID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac");

            migrationBuilder.AlterColumn<int>(
                name: "KartaID",
                table: "Kupac",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Karta_KartaID",
                table: "Kupac",
                column: "KartaID",
                principalTable: "Karta",
                principalColumn: "KartaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
