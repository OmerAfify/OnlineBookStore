using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStore.Migrations
{
    public partial class OrdersTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    orderStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderStatusType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.orderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Orders",
                columns: table => new
                {
                    orderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<string>(nullable: true),
                    orderStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Orders", x => x.orderId);
                    table.ForeignKey(
                        name: "FK_Tb_Orders_OrderStatus_orderStatusId",
                        column: x => x.orderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "orderStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Orders_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tb_OrderDetails",
                columns: table => new
                {
                    orderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderId = table.Column<int>(nullable: false),
                    firstName = table.Column<string>(nullable: true),
                    lastName = table.Column<string>(nullable: true),
                    phoneNumber = table.Column<int>(nullable: false),
                    country = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    departmentNo = table.Column<int>(nullable: false),
                    payementType = table.Column<string>(nullable: true),
                    totalPrice = table.Column<decimal>(nullable: false),
                    totalQuantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_OrderDetails", x => x.orderDetailsId);
                    table.ForeignKey(
                        name: "FK_Tb_OrderDetails_Tb_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Tb_Orders",
                        principalColumn: "orderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_OrderedItems",
                columns: table => new
                {
                    orderDetailsId = table.Column<int>(nullable: false),
                    bookItemId = table.Column<int>(nullable: false),
                    totalItemQuantity = table.Column<int>(nullable: false),
                    totalItemPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_OrderedItems", x => new { x.orderDetailsId, x.bookItemId });
                    table.ForeignKey(
                        name: "FK_Tb_OrderedItems_Tb_BookItem_bookItemId",
                        column: x => x.bookItemId,
                        principalTable: "Tb_BookItem",
                        principalColumn: "bookItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_OrderedItems_Tb_OrderDetails_orderDetailsId",
                        column: x => x.orderDetailsId,
                        principalTable: "Tb_OrderDetails",
                        principalColumn: "orderDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_OrderDetails_orderId",
                table: "Tb_OrderDetails",
                column: "orderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_OrderedItems_bookItemId",
                table: "Tb_OrderedItems",
                column: "bookItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Orders_orderStatusId",
                table: "Tb_Orders",
                column: "orderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Orders_userId",
                table: "Tb_Orders",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_OrderedItems");

            migrationBuilder.DropTable(
                name: "Tb_OrderDetails");

            migrationBuilder.DropTable(
                name: "Tb_Orders");

            migrationBuilder.DropTable(
                name: "OrderStatus");
        }
    }
}
