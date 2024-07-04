using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class AddComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberProductSell",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    ReviewID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayReview = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_reviews_customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "almond",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apple",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apricot",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "banana",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "blueberry",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cantaloupe",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cherry",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "coconut",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "durian",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "grape",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "kiwi",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "lemon",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mandarin",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mango",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "orange",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "papaya",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "peach",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pear",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pineapple",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "plum",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pomegranate",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "strawberry",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "walnut",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "watermelon",
                column: "NumberProductSell",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_reviews_CustomerID",
                table: "reviews",
                column: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropColumn(
                name: "NumberProductSell",
                table: "products");
        }
    }
}
