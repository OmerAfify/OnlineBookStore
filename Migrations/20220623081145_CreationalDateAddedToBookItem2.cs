using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class CreationalDateAddedToBookItem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creationalDate",
                table: "Tb_BookItem",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 6, 23, 10, 7, 37, 164, DateTimeKind.Local).AddTicks(7151));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creationalDate",
                table: "Tb_BookItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 6, 23, 10, 7, 37, 164, DateTimeKind.Local).AddTicks(7151),
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "getdate()");
        }
    }
}
