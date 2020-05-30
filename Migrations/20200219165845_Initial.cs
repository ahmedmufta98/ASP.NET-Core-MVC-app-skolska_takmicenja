using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RS1_Ispit_asp.net_core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takmicenje",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    PredmetId = table.Column<int>(nullable: false),
                    Razred = table.Column<int>(nullable: false),
                    SkolaId = table.Column<int>(nullable: false),
                    Zakljucan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takmicenje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Takmicenje_Predmet_PredmetId",
                        column: x => x.PredmetId,
                        principalTable: "Predmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Takmicenje_Skola_SkolaId",
                        column: x => x.SkolaId,
                        principalTable: "Skola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TakmicenjeUcesnik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TakmicenjeId = table.Column<int>(nullable: false),
                    OdjeljenjeStavkaId = table.Column<int>(nullable: false),
                    Pristupio = table.Column<bool>(nullable: false),
                    Bodovi = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakmicenjeUcesnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TakmicenjeUcesnik_OdjeljenjeStavka_OdjeljenjeStavkaId",
                        column: x => x.OdjeljenjeStavkaId,
                        principalTable: "OdjeljenjeStavka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TakmicenjeUcesnik_Takmicenje_TakmicenjeId",
                        column: x => x.TakmicenjeId,
                        principalTable: "Takmicenje",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Takmicenje_PredmetId",
                table: "Takmicenje",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Takmicenje_SkolaId",
                table: "Takmicenje",
                column: "SkolaId");

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnik_OdjeljenjeStavkaId",
                table: "TakmicenjeUcesnik",
                column: "OdjeljenjeStavkaId");

            migrationBuilder.CreateIndex(
                name: "IX_TakmicenjeUcesnik_TakmicenjeId",
                table: "TakmicenjeUcesnik",
                column: "TakmicenjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TakmicenjeUcesnik");

            migrationBuilder.DropTable(
                name: "Takmicenje");
        }
    }
}
