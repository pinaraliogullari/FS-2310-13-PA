using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingIdentityAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    PaymentType = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderState = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Product = table.Column<int>(type: "INTEGER", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7729), new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7751), new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 2, 7, 21, 43, 28, 42, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4033), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4050), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4086), new DateTime(2024, 2, 7, 21, 43, 28, 43, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5714), new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5733), new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5736), new DateTime(2024, 2, 6, 20, 55, 28, 249, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7729), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7755), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7758), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7760), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 2, 6, 20, 55, 28, 250, DateTimeKind.Local).AddTicks(7761) });
        }
    }
}
