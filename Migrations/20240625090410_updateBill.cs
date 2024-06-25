using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class updateBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalMoney",
                table: "bills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NumberBuyPerProduct",
                table: "billInformation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalMoney",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "NumberBuyPerProduct",
                table: "billInformation");
        }
    }
}
