using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventorySystem.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Details_Categories_CategoryId",
                table: "Invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Details_Invoices_InvoiceId",
                table: "Invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Details_Products_ProductId",
                table: "Invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Details_Invoices_InvoiceId",
                table: "Payment_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Categories_CategoryId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Suppliers_SupplierId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CategoryId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_Details_CategoryId",
                table: "Invoice_Details");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Supplier_Id",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Supplier_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Unit_Id",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Customer_id",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Invoice_Id",
                table: "Payment_Details");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Invoice_Details");

            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Invoice_Details");

            migrationBuilder.DropColumn(
                name: "Invoice_id",
                table: "Invoice_Details");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "Invoice_Details");

            migrationBuilder.RenameColumn(
                name: "Mobile_no",
                table: "Suppliers",
                newName: "MobileNo");

            migrationBuilder.RenameColumn(
                name: "Purchase_no",
                table: "Purchases",
                newName: "PurchaseNo");

            migrationBuilder.RenameColumn(
                name: "Buying_Qty",
                table: "Purchases",
                newName: "BuyingQty");

            migrationBuilder.RenameColumn(
                name: "Total_Amount",
                table: "Payments",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "Paid_Status",
                table: "Payments",
                newName: "PaidStatus");

            migrationBuilder.RenameColumn(
                name: "Paid_Amount",
                table: "Payments",
                newName: "PaidAmount");

            migrationBuilder.RenameColumn(
                name: "Invoice_Id",
                table: "Payments",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "Due_Amount",
                table: "Payments",
                newName: "DueAmount");

            migrationBuilder.RenameColumn(
                name: "Discount_Amount",
                table: "Payments",
                newName: "DiscountAmount");

            migrationBuilder.RenameColumn(
                name: "Current_Paid_Amount",
                table: "Payment_Details",
                newName: "CurrentPaidAmount");

            migrationBuilder.RenameColumn(
                name: "Invoice_No",
                table: "Invoices",
                newName: "InvoiceNo");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "Invoice_Details",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Selling_Qty",
                table: "Invoice_Details",
                newName: "SellingQty");

            migrationBuilder.RenameColumn(
                name: "Selling_Price",
                table: "Invoice_Details",
                newName: "SellingPrice");

            migrationBuilder.RenameColumn(
                name: "Mobile_no",
                table: "Customars",
                newName: "MobileNo");

            migrationBuilder.RenameColumn(
                name: "Customar_Image",
                table: "Customars",
                newName: "CustomarImage");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payment_Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Invoice_Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Invoice_Details",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Details_Invoices_InvoiceId",
                table: "Invoice_Details",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Details_Products_ProductId",
                table: "Invoice_Details",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Details_Invoices_InvoiceId",
                table: "Payment_Details",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Details_Invoices_InvoiceId",
                table: "Invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Details_Products_ProductId",
                table: "Invoice_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Details_Invoices_InvoiceId",
                table: "Payment_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases");

            migrationBuilder.RenameColumn(
                name: "MobileNo",
                table: "Suppliers",
                newName: "Mobile_no");

            migrationBuilder.RenameColumn(
                name: "PurchaseNo",
                table: "Purchases",
                newName: "Purchase_no");

            migrationBuilder.RenameColumn(
                name: "BuyingQty",
                table: "Purchases",
                newName: "Buying_Qty");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Payments",
                newName: "Total_Amount");

            migrationBuilder.RenameColumn(
                name: "PaidStatus",
                table: "Payments",
                newName: "Paid_Status");

            migrationBuilder.RenameColumn(
                name: "PaidAmount",
                table: "Payments",
                newName: "Paid_Amount");

            migrationBuilder.RenameColumn(
                name: "DueAmount",
                table: "Payments",
                newName: "Due_Amount");

            migrationBuilder.RenameColumn(
                name: "DiscountAmount",
                table: "Payments",
                newName: "Discount_Amount");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Payments",
                newName: "Invoice_Id");

            migrationBuilder.RenameColumn(
                name: "CurrentPaidAmount",
                table: "Payment_Details",
                newName: "Current_Paid_Amount");

            migrationBuilder.RenameColumn(
                name: "InvoiceNo",
                table: "Invoices",
                newName: "Invoice_No");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Invoice_Details",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "SellingQty",
                table: "Invoice_Details",
                newName: "Selling_Qty");

            migrationBuilder.RenameColumn(
                name: "SellingPrice",
                table: "Invoice_Details",
                newName: "Selling_Price");

            migrationBuilder.RenameColumn(
                name: "MobileNo",
                table: "Customars",
                newName: "Mobile_no");

            migrationBuilder.RenameColumn(
                name: "CustomarImage",
                table: "Customars",
                newName: "Customar_Image");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Purchases",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Purchases",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Supplier_Id",
                table: "Purchases",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Supplier_Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Unit_Id",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Customer_id",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payment_Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Invoice_Id",
                table: "Payment_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Invoice_Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Invoice_Details",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Invoice_Details",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Category_Id",
                table: "Invoice_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Invoice_id",
                table: "Invoice_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "Invoice_Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CategoryId",
                table: "Purchases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_SupplierId",
                table: "Purchases",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_Details_CategoryId",
                table: "Invoice_Details",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Details_Categories_CategoryId",
                table: "Invoice_Details",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Details_Invoices_InvoiceId",
                table: "Invoice_Details",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Details_Products_ProductId",
                table: "Invoice_Details",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Details_Invoices_InvoiceId",
                table: "Payment_Details",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                table: "Products",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Units_UnitId",
                table: "Products",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Categories_CategoryId",
                table: "Purchases",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Products_ProductId",
                table: "Purchases",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Suppliers_SupplierId",
                table: "Purchases",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }
    }
}
