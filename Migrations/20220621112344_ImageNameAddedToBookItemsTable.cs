using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class ImageNameAddedToBookItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "bookItemName",
                table: "Tb_BookItem",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "bookCategoryId",
                table: "Tb_BookItem",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bookItemImageName",
                table: "Tb_BookItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookItemImageName",
                table: "Tb_BookItem");

            migrationBuilder.AlterColumn<string>(
                name: "bookItemName",
                table: "Tb_BookItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "bookCategoryId",
                table: "Tb_BookItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
