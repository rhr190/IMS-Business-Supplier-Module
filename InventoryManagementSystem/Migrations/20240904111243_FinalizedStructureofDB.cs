using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class FinalizedStructureofDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_AspNetUsers_Id",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestSKUs_Managers_InventoryManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliedSKUs_Suppliers_ProductSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_Suppliers_AspNetUsers_Id",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Managers",
                table: "Managers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23d63b1e-c2a1-48ad-a2e9-ddde65c50eb7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9605d002-2202-4620-859c-4e32ccdc5e0c");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "ProductSuppliers");

            migrationBuilder.RenameTable(
                name: "Managers",
                newName: "InventoryManagers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSuppliers",
                table: "ProductSuppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryManagers",
                table: "InventoryManagers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5637f3fe-1c62-4ae0-8579-61c1bfde178c", null, "Manager", "MANAGER" },
                    { "86f228cc-a5ee-4077-9b88-a33b11521718", null, "Supplier", "SUPPLIER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryManagers_AspNetUsers_Id",
                table: "InventoryManagers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSuppliers_AspNetUsers_Id",
                table: "ProductSuppliers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestSKUs_InventoryManagers_InventoryManagerId",
                table: "RequestSKUs",
                column: "InventoryManagerId",
                principalTable: "InventoryManagers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliedSKUs_ProductSuppliers_ProductSupplierId",
                table: "SuppliedSKUs",
                column: "ProductSupplierId",
                principalTable: "ProductSuppliers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryManagers_AspNetUsers_Id",
                table: "InventoryManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSuppliers_AspNetUsers_Id",
                table: "ProductSuppliers");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestSKUs_InventoryManagers_InventoryManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliedSKUs_ProductSuppliers_ProductSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSuppliers",
                table: "ProductSuppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryManagers",
                table: "InventoryManagers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5637f3fe-1c62-4ae0-8579-61c1bfde178c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86f228cc-a5ee-4077-9b88-a33b11521718");

            migrationBuilder.RenameTable(
                name: "ProductSuppliers",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "InventoryManagers",
                newName: "Managers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Managers",
                table: "Managers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23d63b1e-c2a1-48ad-a2e9-ddde65c50eb7", null, "Manager", "MANAGER" },
                    { "9605d002-2202-4620-859c-4e32ccdc5e0c", null, "Supplier", "SUPPLIER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_AspNetUsers_Id",
                table: "Managers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestSKUs_Managers_InventoryManagerId",
                table: "RequestSKUs",
                column: "InventoryManagerId",
                principalTable: "Managers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliedSKUs_Suppliers_ProductSupplierId",
                table: "SuppliedSKUs",
                column: "ProductSupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suppliers_AspNetUsers_Id",
                table: "Suppliers",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
