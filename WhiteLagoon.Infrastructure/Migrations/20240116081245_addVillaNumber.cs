using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addVillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    Villa_Number = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.Villa_Number);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(957), new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 1, 16, 13, 42, 45, 127, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8195), new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Data", "Update_Data" },
                values: new object[] { new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 1, 10, 13, 49, 50, 397, DateTimeKind.Local).AddTicks(8211) });
        }
    }
}
