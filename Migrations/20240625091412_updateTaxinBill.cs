using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class updateTaxinBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Tax",
                table: "bills",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tax",
                table: "bills");
        }
    }
}
