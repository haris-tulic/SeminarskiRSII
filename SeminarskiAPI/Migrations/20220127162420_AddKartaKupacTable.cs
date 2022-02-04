using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class AddKartaKupacTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "DatumVadjenjaKarte",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "DatumVazenjaKarte",
                table: "Karta");

            migrationBuilder.CreateTable(
                name: "KartaKupac",
                columns: table => new
                {
                    KartaKupacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KupacID = table.Column<int>(nullable: false),
                    KartaID = table.Column<int>(nullable: false),
                    Aktivna = table.Column<bool>(nullable: false),
                    DatumVadjenjaKarte = table.Column<DateTime>(nullable: false),
                    DatumVazenjaKarte = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartaKupac", x => x.KartaKupacID);
                    table.ForeignKey(
                        name: "FK_KartaKupac_Karta_KartaID",
                        column: x => x.KartaID,
                        principalTable: "Karta",
                        principalColumn: "KartaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KartaKupac_Kupac_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupac",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KartaKupac_KartaID",
                table: "KartaKupac",
                column: "KartaID");

            migrationBuilder.CreateIndex(
                name: "IX_KartaKupac_KupacID",
                table: "KartaKupac",
                column: "KupacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KartaKupac");

            migrationBuilder.AddColumn<int>(
                name: "KartaID",
                table: "Kupac",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVadjenjaKarte",
                table: "Karta",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVazenjaKarte",
                table: "Karta",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
