using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lesson06.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Username = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    Password = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Picture = table.Column<string>(type: "varchar(512)", unicode: false, maxLength: 512, nullable: true),
                    Email = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Phone = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account__349DA5A639834322", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__19093A0B5D657022", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publishe__4C657FABB6A6D449", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "OrderBook",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AccountId = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: true),
                    ReceiveAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    ReceivePhone = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: true),
                    OrderReceive = table.Column<DateTime>(type: "datetime", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    Status = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderBoo__C3905BCF4BD18232", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK__OrderBook__Accou__412EB0B6",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Release = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Book__3DE0C207D643A213", x => x.BookId);
                    table.ForeignKey(
                        name: "FK__Book__CategoryId__3C69FB99",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK__Book__PublisherI__3B75D760",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<string>(type: "varchar(16)", unicode: false, maxLength: 16, nullable: true),
                    BookId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    TotalMoney = table.Column<int>(type: "int", nullable: true, computedColumnSql: "([Quantity]*[Price])", stored: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderDet__D3B9D36CA1A30663", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK__OrderDeta__BookI__44FF419A",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId");
                    table.ForeignKey(
                        name: "FK__OrderDeta__Order__440B1D61",
                        column: x => x.OrderId,
                        principalTable: "OrderBook",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderBook_AccountId",
                table: "OrderBook",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_BookId",
                table: "OrderDetail",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "OrderBook");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
