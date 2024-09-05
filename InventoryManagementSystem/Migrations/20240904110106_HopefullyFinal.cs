using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class HopefullyFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestSKUs_Managers_InventoryManagerManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropForeignKey(
                name: "FK_SuppliedSKUs_Suppliers_ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_SuppliedSKUs_ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropIndex(
                name: "IX_RequestSKUs_InventoryManagerManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Managers",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ProductSupplierSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropColumn(
                name: "SKUQuantity",
                table: "SKUs");

            migrationBuilder.DropColumn(
                name: "InventoryManagerManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Managers");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Suppliers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductSupplierId",
                table: "SuppliedSKUs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "SKUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InventoryManagerId",
                table: "RequestSKUs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Managers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_SuppliedSKUs_ProductSupplierId",
                table: "SuppliedSKUs",
                column: "ProductSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestSKUs_InventoryManagerId",
                table: "RequestSKUs",
                column: "InventoryManagerId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_SuppliedSKUs_ProductSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropIndex(
                name: "IX_RequestSKUs_InventoryManagerId",
                table: "RequestSKUs");

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

            migrationBuilder.DropColumn(
                name: "ProductSupplierId",
                table: "SuppliedSKUs");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "SKUs");

            migrationBuilder.DropColumn(
                name: "InventoryManagerId",
                table: "RequestSKUs");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Suppliers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductSupplierSupplierId",
                table: "SuppliedSKUs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SKUQuantity",
                table: "SKUs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InventoryManagerManagerId",
                table: "RequestSKUs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Managers",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupplierId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Managers",
                table: "Managers",
                column: "ManagerId");

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
    }
}
