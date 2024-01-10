using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModfiyNamesInVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateData",
                table: "Villas",
                newName: "Update_Data");

            migrationBuilder.RenameColumn(
                name: "CreatedData",
                table: "Villas",
                newName: "Created_Data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update_Data",
                table: "Villas",
                newName: "UpdateData");

            migrationBuilder.RenameColumn(
                name: "Created_Data",
                table: "Villas",
                newName: "CreatedData");
        }
    }
}
