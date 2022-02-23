using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class NewChangesInKupacAndRecenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KupacOcjena");

            migrationBuilder.AddColumn<int>(
                name: "KupacID",
                table: "Recenzija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RasporedVoznjeID",
                table: "Recenzija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KupacID",
                table: "Recenzija",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_RasporedVoznjeID",
                table: "Recenzija",
                column: "RasporedVoznjeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_Kupac_KupacID",
                table: "Recenzija",
                column: "KupacID",
                principalTable: "Kupac",
                principalColumn: "KupacID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_RasporedVoznje_RasporedVoznjeID",
                table: "Recenzija",
                column: "RasporedVoznjeID",
                principalTable: "RasporedVoznje",
                principalColumn: "RasporedVoznjeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_Kupac_KupacID",
                table: "Recenzija");

            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_RasporedVoznje_RasporedVoznjeID",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_KupacID",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_RasporedVoznjeID",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "KupacID",
                table: "Recenzija");

            migrationBuilder.DropColumn(
                name: "RasporedVoznjeID",
                table: "Recenzija");

            migrationBuilder.CreateTable(
                name: "KupacOcjena",
                columns: table => new
                {
                    KupacOcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KupacID = table.Column<int>(nullable: false),
                    RasporedVoznjeID = table.Column<int>(nullable: false),
                    RecenzijaID = table.Column<int>(nullable: false),
                    VozacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupacOcjena", x => x.KupacOcjenaID);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Kupac_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupac",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_RasporedVoznje_RasporedVoznjeID",
                        column: x => x.RasporedVoznjeID,
                        principalTable: "RasporedVoznje",
                        principalColumn: "RasporedVoznjeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Recenzija_RecenzijaID",
                        column: x => x.RecenzijaID,
                        principalTable: "Recenzija",
                        principalColumn: "RecenzijaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Vozac_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KupacOcjena_KupacID",
                table: "KupacOcjena",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_KupacOcjena_RasporedVoznjeID",
                table: "KupacOcjena",
                column: "RasporedVoznjeID");

            migrationBuilder.CreateIndex(
                name: "IX_KupacOcjena_RecenzijaID",
                table: "KupacOcjena",
                column: "RecenzijaID");

            migrationBuilder.CreateIndex(
                name: "IX_KupacOcjena_VozacID",
                table: "KupacOcjena",
                column: "VozacID");
        }
    }
}
