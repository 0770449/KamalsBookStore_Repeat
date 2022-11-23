using Microsoft.EntityFrameworkCore.Migrations;

namespace KamalsBooks.DataAccess.Migrations
{
    public partial class AddValidationToProductcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CoverTypes_CategoryId",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Product",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CoverTypeId",
                table: "Product",
                column: "CoverTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CoverTypes_CoverTypeId",
                table: "Product",
                column: "CoverTypeId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_CoverTypes_CoverTypeId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CoverTypeId",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CoverTypes_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "CoverTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
