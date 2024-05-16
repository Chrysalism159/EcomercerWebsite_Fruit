using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDayNeedInBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayNeed",
                table: "bills");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DayNeed",
                table: "bills",
                type: "datetime2",
                nullable: true);
        }
    }
}
