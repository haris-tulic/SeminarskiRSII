﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class AddDateInPlatiKartu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVadjenjaKarte",
                table: "PlatiKartu",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumVazenjaKarte",
                table: "PlatiKartu",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumVadjenjaKarte",
                table: "PlatiKartu");

            migrationBuilder.DropColumn(
                name: "DatumVazenjaKarte",
                table: "PlatiKartu");
        }
    }
}
