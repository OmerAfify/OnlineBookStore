using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class DiscountAndBookImageTablesIsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Slider",
                table: "Tb_Slider");

            migrationBuilder.RenameTable(
                name: "Tb_Slider",
                newName: "Slider");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Slider",
                table: "Slider",
                column: "sliderId");

            migrationBuilder.CreateTable(
                name: "BookItemImage",
                columns: table => new
                {
                    bookItemImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookImageName = table.Column<int>(nullable: false),
                    bookItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookItemImage", x => x.bookItemImageId);
                    table.ForeignKey(
                        name: "FK_BookItemImage_Tb_BookItem_bookItemId",
                        column: x => x.bookItemId,
                        principalTable: "Tb_BookItem",
                        principalColumn: "bookItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Discount",
                columns: table => new
                {
                    discountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discountName = table.Column<string>(nullable: true),
                    discountPercent = table.Column<decimal>(nullable: false),
                    discountStartingDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    discountEndingDate = table.Column<DateTime>(nullable: false),
                    bookItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Discount", x => x.discountId);
                    table.ForeignKey(
                        name: "FK_Tb_Discount_Tb_BookItem_bookItemId",
                        column: x => x.bookItemId,
                        principalTable: "Tb_BookItem",
                        principalColumn: "bookItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookItemImage_bookItemId",
                table: "BookItemImage",
                column: "bookItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Discount_bookItemId",
                table: "Tb_Discount",
                column: "bookItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookItemImage");

            migrationBuilder.DropTable(
                name: "Tb_Discount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Slider",
                table: "Slider");

            migrationBuilder.RenameTable(
                name: "Slider",
                newName: "Tb_Slider");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Slider",
                table: "Tb_Slider",
                column: "sliderId");
        }
    }
}
