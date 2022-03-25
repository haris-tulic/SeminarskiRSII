using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class PlatiKartuOnlineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlatiKartu",
                columns: table => new
                {
                    PlatiKartuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KartaID = table.Column<int>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false),
                    JeLiPlacena = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlatiKartu", x => x.PlatiKartuID);
                    table.ForeignKey(
                        name: "FK_PlatiKartu_Karta_KartaID",
                        column: x => x.KartaID,
                        principalTable: "Karta",
                        principalColumn: "KartaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlatiKartu_Kupac_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupac",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlatiKartu_KartaID",
                table: "PlatiKartu",
                column: "KartaID");

            migrationBuilder.CreateIndex(
                name: "IX_PlatiKartu_KupacID",
                table: "PlatiKartu",
                column: "KupacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlatiKartu");
        }
    }
}
