using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class FKReviewtoProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductID",
                table: "reviews",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewID",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "almond",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apple",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apricot",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "banana",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "blueberry",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cantaloupe",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cherry",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "coconut",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "durian",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "grape",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "kiwi",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "lemon",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mandarin",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mango",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "orange",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "papaya",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "peach",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pear",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pineapple",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "plum",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pomegranate",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "strawberry",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "walnut",
                column: "ReviewID",
                value: null);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "watermelon",
                column: "ReviewID",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_reviews_ProductID",
                table: "reviews",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_products_ProductID",
                table: "reviews",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ProductID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_reviews_products_ProductID",
                table: "reviews");

            migrationBuilder.DropIndex(
                name: "IX_reviews_ProductID",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "products");
        }
    }
}
