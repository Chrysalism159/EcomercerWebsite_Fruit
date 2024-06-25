using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class updateFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteDescription",
                table: "favorites");

            migrationBuilder.DropColumn(
                name: "PickDay",
                table: "favorites");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteDescription",
                table: "favorites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickDay",
                table: "favorites",
                type: "datetime2",
                nullable: true);
        }
    }
}
