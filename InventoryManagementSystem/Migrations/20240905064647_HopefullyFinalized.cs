using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class HopefullyFinalized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "523d5433-49e1-4326-a5a2-225cb6f56530", null, "Supplier", "SUPPLIER" },
                    { "843c3bff-1c95-44cb-840f-b2c63f7149ca", null, "Manager", "MANAGER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523d5433-49e1-4326-a5a2-225cb6f56530");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "843c3bff-1c95-44cb-840f-b2c63f7149ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b9923148-a419-4d53-bd2a-33d387ea3279", null, "Supplier", "SUPPLIER" },
                    { "ce561882-0aef-4242-9aa4-b98b9bf5122c", null, "Manager", "MANAGER" }
                });
        }
    }
}
