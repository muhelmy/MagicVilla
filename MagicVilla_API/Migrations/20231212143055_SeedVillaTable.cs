using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Balcony, Parking", new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1634), 123, "https://t4.ftcdn.net/jpg/03/70/64/43/360_F_370644357_MDF4UXLAXTyyi2OyuK66tWW9cA2f8svL.jpg", "Cozy Apartment", 2, 1200.5, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Gym, Pool", new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1692), 456, "https://im.proptiger.com/1/3232159/6/scape-villas-elevation-146125154.jpeg", "Modern Loft", 4, 2000.75, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Garden, Fireplace", new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1695), 789, "https://sky119191.b-cdn.net/wp-content/uploads/2023/02/word-image-50349-1-1.jpeg", "Charming House", 6, 2500.25, 1500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Beach Access, Ocean View", new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1698), 101, "https://amazingarchitecture.com/storage/711/Deep-Villa-Atrey-and-Associates-New-Delhi-ndia-Amazing-Architecture-House.jpg", "Seaside Villa", 8, 3500.0, 2000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "City View, Concierge", new DateTime(2023, 12, 12, 16, 30, 54, 639, DateTimeKind.Local).AddTicks(1701), 112, "https://speed.damacproperties.com/sites/default/files/2021-05/premier-villas-hero-banner-mobile.jpg", "Downtown Penthouse", 4, 2800.5, 1800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
