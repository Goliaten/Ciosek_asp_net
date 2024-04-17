using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ciosek_asp_net.Migrations
{
    public partial class plakat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nazwaPlakatu",
                table: "Filmy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2350), "plakatDune.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2395), "plakatIncepcja.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2405), "plakatIluzja.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2414), "plakatTroopers.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2422), "plakatStarWars.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2430), "plakatTheRing.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2438), "plakatAvatar.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2559), "plakatAvatarAang.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2573), "plakatMatrix.webp" });

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Data_dodania", "nazwaPlakatu" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 53, 10, 451, DateTimeKind.Local).AddTicks(2577), "plakatSzybcy.webp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nazwaPlakatu",
                table: "Filmy");

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 1,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 2,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 3,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 4,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 5,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 6,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 7,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 8,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 9,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Filmy",
                keyColumn: "Id",
                keyValue: 10,
                column: "Data_dodania",
                value: new DateTime(2024, 3, 6, 10, 31, 43, 815, DateTimeKind.Local).AddTicks(2141));
        }
    }
}
