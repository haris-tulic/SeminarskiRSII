using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class ChangesInRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradID",
                table: "Stanica",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stanica_GradID",
                table: "Stanica",
                column: "GradID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stanica_Grad_GradID",
                table: "Stanica",
                column: "GradID",
                principalTable: "Grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stanica_Grad_GradID",
                table: "Stanica");

            migrationBuilder.DropIndex(
                name: "IX_Stanica_GradID",
                table: "Stanica");

            migrationBuilder.DropColumn(
                name: "GradID",
                table: "Stanica");
        }
    }
}
