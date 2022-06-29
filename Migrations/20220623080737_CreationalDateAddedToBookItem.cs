using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class CreationalDateAddedToBookItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "creationalDate",
                table: "Tb_BookItem",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 23, 10, 7, 37, 164, DateTimeKind.Local).AddTicks(7151));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "creationalDate",
                table: "Tb_BookItem");
        }
    }
}
