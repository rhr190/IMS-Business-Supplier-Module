using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5637f3fe-1c62-4ae0-8579-61c1bfde178c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f228cc-a5ee-4077-9b88-a33b11521718");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9923148-a419-4d53-bd2a-33d387ea3279", null, "Supplier", "SUPPLIER" },
                    { "ce561882-0aef-4242-9aa4-b98b9bf5122c", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9923148-a419-4d53-bd2a-33d387ea3279");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce561882-0aef-4242-9aa4-b98b9bf5122c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5637f3fe-1c62-4ae0-8579-61c1bfde178c", null, "Manager", "MANAGER" },
                    { "86f228cc-a5ee-4077-9b88-a33b11521718", null, "Supplier", "SUPPLIER" }
                });
        }
    }
}
