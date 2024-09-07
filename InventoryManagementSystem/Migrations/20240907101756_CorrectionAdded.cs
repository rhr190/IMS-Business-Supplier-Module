using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523d5433-49e1-4326-a5a2-225cb6f56530");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "843c3bff-1c95-44cb-840f-b2c63f7149ca");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "52aa9782-eb43-429c-b6c0-9a75c0305b46", null, "Manager", "MANAGER" },
                    { "8aa4e47f-2eff-49e7-beb6-617d80df5e1b", null, "Supplier", "SUPPLIER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52aa9782-eb43-429c-b6c0-9a75c0305b46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aa4e47f-2eff-49e7-beb6-617d80df5e1b");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "523d5433-49e1-4326-a5a2-225cb6f56530", null, "Supplier", "SUPPLIER" },
                    { "843c3bff-1c95-44cb-840f-b2c63f7149ca", null, "Manager", "MANAGER" }
                });
        }
    }
}
