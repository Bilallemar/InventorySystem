using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventorySystem.Migrations
{
    /// <inheritdoc />
    public partial class modelsUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Accounts_AccountId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Products_ProductID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Accounts_AccountId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProductID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_AccountId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_AccountId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Sales",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Sales",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Sales",
                newName: "Discount");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_ProductID",
                table: "Sales",
                newName: "IX_Sales_ProductId");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Purchases",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Purchases",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Purchases",
                newName: "Price");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_ProductID",
                table: "Purchases",
                newName: "IX_Purchases_ProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Accounts_SupplierId",
                table: "Purchases",
                column: "SupplierId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Accounts_CustomerId",
                table: "Sales",
                column: "CustomerId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Accounts_SupplierId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Accounts_CustomerId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Products_ProductId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Sales",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Sales",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "Discount",
                table: "Sales",
                newName: "UnitPrice");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                newName: "IX_Sales_ProductID");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Purchases",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Purchases",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Purchases",
                newName: "UnitPrice");

            migrationBuilder.RenameIndex(
                name: "IX_Purchases_ProductId",
                table: "Purchases",
                newName: "IX_Purchases_ProductID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_AccountId",
                table: "Sales",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_AccountId",
                table: "Purchases",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryID",
                table: "Products",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Accounts_AccountId",
                table: "Purchases",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Products_ProductID",
                table: "Purchases",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Accounts_AccountId",
                table: "Sales",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Products_ProductID",
                table: "Sales",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
