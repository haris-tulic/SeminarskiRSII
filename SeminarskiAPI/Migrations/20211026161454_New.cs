using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiWebAPI.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGrada = table.Column<string>(nullable: true),
                    PostanskiBroj = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    RecenzijaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VrstaUsluga = table.Column<string>(nullable: true),
                    DatumRecenzije = table.Column<DateTime>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.RecenzijaID);
                });

            migrationBuilder.CreateTable(
                name: "Stanica",
                columns: table => new
                {
                    StanicaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivLokacijeStanice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanica", x => x.StanicaID);
                });

            migrationBuilder.CreateTable(
                name: "TipKarte",
                columns: table => new
                {
                    TipKarteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Informacije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKarte", x => x.TipKarteID);
                });

            migrationBuilder.CreateTable(
                name: "TipKorisnika",
                columns: table => new
                {
                    TipKorisnikaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKorisnika", x => x.TipKorisnikaID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaKarte",
                columns: table => new
                {
                    VrstaKarteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Informacije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKarte", x => x.VrstaKarteID);
                });

            migrationBuilder.CreateTable(
                name: "Zona",
                columns: table => new
                {
                    ZonaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OznakaZone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zona", x => x.ZonaID);
                });

            migrationBuilder.CreateTable(
                name: "Garaza",
                columns: table => new
                {
                    GarazaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGaraze = table.Column<string>(nullable: true),
                    BrojGaraze = table.Column<int>(nullable: false),
                    BrojMjesta = table.Column<int>(nullable: false),
                    IsPopunjeno = table.Column<bool>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garaza", x => x.GarazaID);
                    table.ForeignKey(
                        name: "FK_Garaza_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipKorisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    BrojTelefona = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    AdresaStanovanja = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false),
                    KupacID = table.Column<int>(nullable: false),
                    VozacID = table.Column<int>(nullable: false),
                    UpravaID = table.Column<int>(nullable: false),
                    TipKorisnikaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipKorisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_TipKorisnik_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TipKorisnik_TipKorisnika_TipKorisnikaID",
                        column: x => x.TipKorisnikaID,
                        principalTable: "TipKorisnika",
                        principalColumn: "TipKorisnikaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cjenovnik",
                columns: table => new
                {
                    CjenovnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZonaID = table.Column<int>(nullable: false),
                    VrstaKarteID = table.Column<int>(nullable: false),
                    TipkarteID = table.Column<int>(nullable: false),
                    Cijena = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cjenovnik", x => x.CjenovnikID);
                    table.ForeignKey(
                        name: "FK_Cjenovnik_TipKarte_TipkarteID",
                        column: x => x.TipkarteID,
                        principalTable: "TipKarte",
                        principalColumn: "TipKarteID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cjenovnik_VrstaKarte_VrstaKarteID",
                        column: x => x.VrstaKarteID,
                        principalTable: "VrstaKarte",
                        principalColumn: "VrstaKarteID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cjenovnik_Zona_ZonaID",
                        column: x => x.ZonaID,
                        principalTable: "Zona",
                        principalColumn: "ZonaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Autobus",
                columns: table => new
                {
                    AutobusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojAutobusa = table.Column<int>(nullable: false),
                    BrojSjedista = table.Column<int>(nullable: false),
                    DatumProizvodnje = table.Column<DateTime>(nullable: false),
                    Ispravan = table.Column<bool>(nullable: false),
                    MarkaAutobusa = table.Column<string>(nullable: true),
                    GarazaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autobus", x => x.AutobusID);
                    table.ForeignKey(
                        name: "FK_Autobus_Garaza_GarazaID",
                        column: x => x.GarazaID,
                        principalTable: "Garaza",
                        principalColumn: "GarazaID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    KupacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipKorisnikaID = table.Column<int>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Prisutan = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.KupacID);
                    table.ForeignKey(
                        name: "FK_Kupac_TipKorisnik_TipKorisnikaID",
                        column: x => x.TipKorisnikaID,
                        principalTable: "TipKorisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Uprava",
                columns: table => new
                {
                    UpravaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipKorisnikaID = table.Column<int>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true),
                    Prisutan = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uprava", x => x.UpravaID);
                    table.ForeignKey(
                        name: "FK_Uprava_TipKorisnik_TipKorisnikaID",
                        column: x => x.TipKorisnikaID,
                        principalTable: "TipKorisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    VozacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipKorisnikaID = table.Column<int>(nullable: false),
                    VozackaKategorija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.VozacID);
                    table.ForeignKey(
                        name: "FK_Vozac_TipKorisnik_TipKorisnikaID",
                        column: x => x.TipKorisnikaID,
                        principalTable: "TipKorisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AutobusVozac",
                columns: table => new
                {
                    AutobusVozacID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Pocetak = table.Column<DateTime>(nullable: false),
                    Kraj = table.Column<DateTime>(nullable: false),
                    Smjena = table.Column<int>(nullable: false),
                    AutobusID = table.Column<int>(nullable: false),
                    VozacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutobusVozac", x => x.AutobusVozacID);
                    table.ForeignKey(
                        name: "FK_AutobusVozac_Autobus_AutobusID",
                        column: x => x.AutobusID,
                        principalTable: "Autobus",
                        principalColumn: "AutobusID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AutobusVozac_Vozac_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RasporedVoznje",
                columns: table => new
                {
                    RasporedVoznjeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojLinije = table.Column<int>(nullable: false),
                    AutobusID = table.Column<int>(nullable: false),
                    PolazisteID = table.Column<int>(nullable: false),
                    OdredisteID = table.Column<int>(nullable: false),
                    VrijemePolaska = table.Column<DateTime>(nullable: false),
                    VrijemeDolaska = table.Column<DateTime>(nullable: false),
                    VozacID = table.Column<int>(nullable: false),
                    KondukterID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedVoznje", x => x.RasporedVoznjeID);
                    table.ForeignKey(
                        name: "FK_RasporedVoznje_Autobus_AutobusID",
                        column: x => x.AutobusID,
                        principalTable: "Autobus",
                        principalColumn: "AutobusID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RasporedVoznje_Vozac_KondukterID",
                        column: x => x.KondukterID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RasporedVoznje_Stanica_OdredisteID",
                        column: x => x.OdredisteID,
                        principalTable: "Stanica",
                        principalColumn: "StanicaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RasporedVoznje_Stanica_PolazisteID",
                        column: x => x.PolazisteID,
                        principalTable: "Stanica",
                        principalColumn: "StanicaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RasporedVoznje_Vozac_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    KartaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KupacID = table.Column<int>(nullable: false),
                    TipKarteID = table.Column<int>(nullable: false),
                    VrstaKarteID = table.Column<int>(nullable: false),
                    DatumVadjenjaKarte = table.Column<DateTime>(nullable: false),
                    DatumVazenjaKarte = table.Column<DateTime>(nullable: false),
                    RasporedVoznjeID = table.Column<int>(nullable: false),
                    Pravac = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karta", x => x.KartaID);
                    table.ForeignKey(
                        name: "FK_Karta_Kupac_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupac",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Karta_RasporedVoznje_RasporedVoznjeID",
                        column: x => x.RasporedVoznjeID,
                        principalTable: "RasporedVoznje",
                        principalColumn: "RasporedVoznjeID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Karta_TipKarte_TipKarteID",
                        column: x => x.TipKarteID,
                        principalTable: "TipKarte",
                        principalColumn: "TipKarteID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Karta_VrstaKarte_VrstaKarteID",
                        column: x => x.VrstaKarteID,
                        principalTable: "VrstaKarte",
                        principalColumn: "VrstaKarteID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KupacOcjena",
                columns: table => new
                {
                    KupacOcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KupacID = table.Column<int>(nullable: false),
                    RasporedVoznjeID = table.Column<int>(nullable: false),
                    VozacID = table.Column<int>(nullable: false),
                    RecenzijaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupacOcjena", x => x.KupacOcjenaID);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Kupac_KupacID",
                        column: x => x.KupacID,
                        principalTable: "Kupac",
                        principalColumn: "KupacID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_RasporedVoznje_RasporedVoznjeID",
                        column: x => x.RasporedVoznjeID,
                        principalTable: "RasporedVoznje",
                        principalColumn: "RasporedVoznjeID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Recenzija_RecenzijaID",
                        column: x => x.RecenzijaID,
                        principalTable: "Recenzija",
                        principalColumn: "RecenzijaID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KupacOcjena_Vozac_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autobus_GarazaID",
                table: "Autobus",
                column: "GarazaID");

            migrationBuilder.CreateIndex(
                name: "IX_AutobusVozac_AutobusID",
                table: "AutobusVozac",
                column: "AutobusID");

            migrationBuilder.CreateIndex(
                name: "IX_AutobusVozac_VozacID",
                table: "AutobusVozac",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_TipkarteID",
                table: "Cjenovnik",
                column: "TipkarteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_VrstaKarteID",
                table: "Cjenovnik",
                column: "VrstaKarteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cjenovnik_ZonaID",
                table: "Cjenovnik",
                column: "ZonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Garaza_GradID",
                table: "Garaza",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_KupacID",
                table: "Karta",
                column: "KupacID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_RasporedVoznjeID",
                table: "Karta",
                column: "RasporedVoznjeID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_TipKarteID",
                table: "Karta",
                column: "TipKarteID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_VrstaKarteID",
                table: "Karta",
                column: "VrstaKarteID");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_TipKorisnikaID",
                table: "Kupac",
                column: "TipKorisnikaID");

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

            migrationBuilder.CreateIndex(
                name: "IX_RasporedVoznje_AutobusID",
                table: "RasporedVoznje",
                column: "AutobusID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedVoznje_KondukterID",
                table: "RasporedVoznje",
                column: "KondukterID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedVoznje_OdredisteID",
                table: "RasporedVoznje",
                column: "OdredisteID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedVoznje_PolazisteID",
                table: "RasporedVoznje",
                column: "PolazisteID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedVoznje_VozacID",
                table: "RasporedVoznje",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_TipKorisnik_GradID",
                table: "TipKorisnik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_TipKorisnik_TipKorisnikaID",
                table: "TipKorisnik",
                column: "TipKorisnikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Uprava_TipKorisnikaID",
                table: "Uprava",
                column: "TipKorisnikaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozac_TipKorisnikaID",
                table: "Vozac",
                column: "TipKorisnikaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutobusVozac");

            migrationBuilder.DropTable(
                name: "Cjenovnik");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "KupacOcjena");

            migrationBuilder.DropTable(
                name: "Uprava");

            migrationBuilder.DropTable(
                name: "Zona");

            migrationBuilder.DropTable(
                name: "TipKarte");

            migrationBuilder.DropTable(
                name: "VrstaKarte");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "RasporedVoznje");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Autobus");

            migrationBuilder.DropTable(
                name: "Vozac");

            migrationBuilder.DropTable(
                name: "Stanica");

            migrationBuilder.DropTable(
                name: "Garaza");

            migrationBuilder.DropTable(
                name: "TipKorisnik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "TipKorisnika");
        }
    }
}
