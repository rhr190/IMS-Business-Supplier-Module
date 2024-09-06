using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSupplierSupplierId",
                table: "SuppliedSKUs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InventoryManagerManagerId",
                table: "RequestSKUs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuppliedSKUs_ProductSupplierSupplierId",
                table: "SuppliedSKUs",
                column: "ProductSupplierSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSKUs_InventoryManagerManagerId",
                table: "RequestSKUs",
                column: "InventoryManagerManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestSKUs_Managers_InventoryManagerManagerId",
                table: "RequestSKUs",
                column: "InventoryManagerManagerId",
                principalTable: "Managers",
                principalColumn: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuppliedSKUs_Suppliers_ProductSupplierSupplierId",
                table: "SuppliedSKUs",
                column: "ProductSupplierSupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestSKUs_Managers_InventoryManagerManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliedSKUs_Suppliers_ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropIndex(
                name: "IX_SuppliedSKUs_ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropIndex(
                name: "IX_RequestSKUs_InventoryManagerManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropColumn(
                name: "ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropColumn(
                name: "InventoryManagerManagerId",
                table: "RequestSKUs");
        }
    }
}
