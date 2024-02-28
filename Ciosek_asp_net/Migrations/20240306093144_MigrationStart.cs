using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ciosek_asp_net.Migrations
{
    public partial class MigrationStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rezyser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data_dodania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmy_Kategorie_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategorie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, "Kosmiczne fantasy", "AA" },
                    { 2, "Fikcja naukowa", "BB" },
                    { 3, "Horror", "CC" },
                    { 4, "Magiczne fantasy", "DD" },
                    { 5, "Wyścigowy", "EE" }
                });

            migrationBuilder.InsertData(
                table: "Filmy",
                columns: new[] { "Id", "Cena", "Data_dodania", "KategoriaId", "Opis", "Rezyser", "Tytul" },
                values: new object[,]
                {
                    { 1, 19m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2088), 1, "Piasek", "A", "Diuna" },
                    { 2, 20m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2122), 2, "Łyżeczka", "B", "Incepcja" },
                    { 3, 15m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2125), 2, "Karty", "C", "Iluzja" },
                    { 4, 10m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2127), 1, "Robaki", "B", "Starship Troopers" },
                    { 5, 20m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2129), 1, "High ground", "D", "Gwiedne Wojny" },
                    { 6, 18m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2132), 3, "Telewizor", "E", "The Ring" },
                    { 7, 18m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2134), 1, "Niebiescy indianie", "E", "Avatar" },
                    { 8, 17m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2136), 4, "Chińska magia", "F", "Avatar" },
                    { 9, 16m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2138), 2, "Okulary", "B", "Matrix" },
                    { 10, 14m, new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2141), 5, "Rodzina", "D", "Szybcy  i Wściekli" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmy_KategoriaId",
                table: "Filmy",
                column: "KategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmy");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
