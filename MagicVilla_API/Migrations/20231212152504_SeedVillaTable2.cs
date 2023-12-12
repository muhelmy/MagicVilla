using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1732), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1784), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1787), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1790), "" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 17, 25, 2, 973, DateTimeKind.Local).AddTicks(1793), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Details",
                table: "Villas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1634), 123 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1692), 456 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1695), 789 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1698), 101 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1701), 112 });
        }
    }
}
