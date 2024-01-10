using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Data", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Update_Data" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8195), "Description for Villa 1", "https://placehold.co/600x401", "Villa 1", 4, 1000.0, 2000, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8206) },
                    { 2, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8209), "Description for Villa 2", "https://placehold.co/600x401", "Villa 2", 4, 1000.0, 2000, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8209) },
                    { 3, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8211), "Description for Villa 3", "https://placehold.co/600x401", "Villa 3", 4, 1000.0, 2000, new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8211) }
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
        }
    }
}
