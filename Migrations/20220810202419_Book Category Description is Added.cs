using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class BookCategoryDescriptionisAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.AddColumn<string>(
                name: "bookCategoryDescription",
                table: "Tb_BookCategory",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookCategoryDescription",
                table: "Tb_BookCategory");

        }
    }
}
