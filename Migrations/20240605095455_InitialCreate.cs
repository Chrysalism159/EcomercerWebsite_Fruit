using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGender = table.Column<bool>(type: "bit", nullable: false),
                    CustomerDoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerImages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CustomerRole = table.Column<int>(type: "int", nullable: false),
                    RandomKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "productTypes",
                columns: table => new
                {
                    ProductTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productTypes", x => x.ProductTypeID);
                });

            migrationBuilder.CreateTable(
                name: "providers",
                columns: table => new
                {
                    ProviderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_providers", x => x.ProviderID);
                });

            migrationBuilder.CreateTable(
                name: "statementInformations",
                columns: table => new
                {
                    StatementID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statementInformations", x => x.StatementID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductTypeID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCost = table.Column<double>(type: "float", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductDiscount = table.Column<double>(type: "float", nullable: false),
                    ProductNumberAccess = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_products_productTypes_ProductTypeID",
                        column: x => x.ProductTypeID,
                        principalTable: "productTypes",
                        principalColumn: "ProductTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_providers_ProviderID",
                        column: x => x.ProviderID,
                        principalTable: "providers",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    BillID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DayBuy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayDelivery = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WayDelivery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryFee = table.Column<double>(type: "float", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatementInformationStatementID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.BillID);
                    table.ForeignKey(
                        name: "FK_bills_customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "customers",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_bills_statementInformations_StatementInformationStatementID",
                        column: x => x.StatementInformationStatementID,
                        principalTable: "statementInformations",
                        principalColumn: "StatementID");
                });

            migrationBuilder.CreateTable(
                name: "favorites",
                columns: table => new
                {
                    FavoriteID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PickDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FavoriteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favorites", x => x.FavoriteID);
                    table.ForeignKey(
                        name: "FK_favorites_customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_favorites_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "billInformation",
                columns: table => new
                {
                    BillInformationID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductCost = table.Column<double>(type: "float", nullable: false),
                    BillInformationDiscount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_billInformation", x => x.BillInformationID);
                    table.ForeignKey(
                        name: "FK_billInformation_bills_BillID",
                        column: x => x.BillID,
                        principalTable: "bills",
                        principalColumn: "BillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_billInformation_products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_billInformation_BillID",
                table: "billInformation",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_billInformation_ProductID",
                table: "billInformation",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_bills_CustomerID",
                table: "bills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_bills_StatementInformationStatementID",
                table: "bills",
                column: "StatementInformationStatementID");

            migrationBuilder.CreateIndex(
                name: "IX_favorites_CustomerID",
                table: "favorites",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_favorites_ProductID",
                table: "favorites",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductTypeID",
                table: "products",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProviderID",
                table: "products",
                column: "ProviderID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "billInformation");

            migrationBuilder.DropTable(
                name: "favorites");

            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "statementInformations");

            migrationBuilder.DropTable(
                name: "productTypes");

            migrationBuilder.DropTable(
                name: "providers");
        }
    }
}
