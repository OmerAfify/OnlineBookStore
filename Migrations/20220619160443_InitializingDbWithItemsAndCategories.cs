using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class InitializingDbWithItemsAndCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_BookCategory",
                columns: table => new
                {
                    bookCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BookCategory", x => x.bookCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tb_BookItem",
                columns: table => new
                {
                    bookItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookItemName = table.Column<string>(nullable: true),
                    salesPrice = table.Column<decimal>(nullable: false),
                    purchasePrice = table.Column<decimal>(nullable: false),
                    bookCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_BookItem", x => x.bookItemId);
                    table.ForeignKey(
                        name: "FK_Tb_BookItem_Tb_BookCategory_bookCategoryId",
                        column: x => x.bookCategoryId,
                        principalTable: "Tb_BookCategory",
                        principalColumn: "bookCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_BookItem_bookCategoryId",
                table: "Tb_BookItem",
                column: "bookCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_BookItem");

            migrationBuilder.DropTable(
                name: "Tb_BookCategory");
        }
    }
}
