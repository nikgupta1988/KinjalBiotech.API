using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KinjalBiotech.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Category_CategoryID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_CategoryID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CategoruID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Sales");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoruID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CategoryID",
                table: "Sales",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Category_CategoryID",
                table: "Sales",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
