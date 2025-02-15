using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KinjalBiotech.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Category_CategoryId",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductID",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Sales",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CategoryId",
                table: "Sales",
                newName: "IX_Sales_CategoryID");

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductsProductID",
                table: "Sales",
                column: "ProductsProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Category_CategoryID",
                table: "Sales",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductsProductID",
                table: "Sales",
                column: "ProductsProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Category_CategoryID",
                table: "Sales");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Product_ProductsProductID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProductsProductID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ProductsProductID",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Sales",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_CategoryID",
                table: "Sales",
                newName: "IX_Sales_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductID",
                table: "Sales",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Category_CategoryId",
                table: "Sales",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Product_ProductID",
                table: "Sales",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
