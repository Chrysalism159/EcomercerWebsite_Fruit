using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcomercerWebsite_Fruit.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "productTypes",
                columns: new[] { "ProductTypeID", "ProductTypeDescription", "ProductTypeName" },
                values: new object[,]
                {
                    { "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d", "Have a hard pit inside, surrounded by soft flesh.", "Stone Fruits" },
                    { "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "Contain one or more seeds inside", "Seeded Fruits" },
                    { "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c", "Have a hard shell protecting the inner flesh.", "Hard-Shell Fruits" },
                    { "4a1b7c3d-8e9f-4c2d-8a9b-1f7c3b9e4d5a", "Grow in subtropical regions.", "Subtropical Fruits" },
                    { "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f", "Grow in temperate regions.", "Temperate Fruits" },
                    { "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "Typically grow in tropical regions.", "Tropical Fruits" },
                    { "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f", "Have many small seeds distributed throughout the flesh.", "Berries" }
                });

            migrationBuilder.InsertData(
                table: "providers",
                columns: new[] { "ProviderID", "Email", "Logo", "ProviderAddress", "ProviderContact", "ProviderDescription", "ProviderName", "ProviderPhone" },
                values: new object[] { "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52", "fresh.fruit.inc@gmail.com", "logo.png", "23 Hoàng Văn Thái, Thanh Xuân, Hà Nội", "Nguyễn Hoàng Hà", "Fresh Fruit Inc. is integral to bringing fresh, nutritious fruits from farms to consumers around the world. They encompass a wide range of activities, from cultivation and quality control to distribution and marketing, all while striving for sustainability and innovation.", "Fresh Fruit Inc.", "0334564456" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "ProductCost", "ProductDate", "ProductDescription", "ProductDiscount", "ProductImage", "ProductName", "ProductNumberAccess", "ProductTypeID", "ProductUnit", "ProviderID" },
                values: new object[,]
                {
                    { "almond", 225000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Almonds are highly versatile nuts celebrated for their delicate flavor, crunchy texture, and numerous health benefits. They are one of the most widely cultivated tree nuts globally and are utilized in various culinary, medicinal, and cosmetic applications.", 0.0, "almond.jpg", "Almond", 10, "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "apple", 65000.0, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apples are sweet or tart fruits with a crisp texture. They come in various colors, including red, green, and yellow. Apples are commonly eaten raw, cooked, or used in desserts like pies and crumbles.", 0.0, "apple.jpg", "Apple", 30, "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "apricot", 40000.0, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apricots (Prunus armeniaca) are small, round stone fruits with a velvety skin and sweet-tart flavor. They are typically yellow to orange in color, often with a reddish blush.", 0.0, "apricot.jpg", "Apricot", 40, "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "banana", 45000.0, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bananas are long, yellow fruits with a soft, sweet flesh. They are high in potassium and are commonly eaten raw, used in baking, or added to smoothies.", 0.0, "banana.jpg", "Banana", 10, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "blueberry", 225000.0, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blueberries are small, round berries with a deep blue to purple-black hue. They are celebrated for their sweet flavor, antioxidant-rich profile, and versatility in culinary applications.", 0.0, "blueberry.jpg", "Blueberry", 20, "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "cantaloupe", 35000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cantaloupe, also known as muskmelon, is a sweet and refreshing melon with a vibrant orange flesh and a distinctively aromatic flavor. It is widely loved for its juicy texture and subtle sweetness, making it a popular choice for snacks, desserts, and fruit salads during the summer months.", 0.0, "cantaloupe.jpg", "Cantaloupe", 20, "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "cherry", 250000.0, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cherries are small, round stone fruits known for their vibrant color and sweet or tart flavor. They come in two main types: sweet cherries (Prunus avium) and sour cherries (Prunus cerasus).", 0.0, "cherry.jpg", "Cherry", 10, "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "coconut", 25000.0, new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The coconut is a versatile tropical fruit known for its large size, fibrous husk, and unique nutritional properties. It is prized for its sweet, refreshing water and creamy flesh, which are used in various culinary, medicinal, and industrial applications.", 0.10000000000000001, "coconut.jpg", "Coconut", 30, "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c", "fruit", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "durian", 185000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durian is a tropical fruit renowned for its distinctive aroma, large size, and custard-like flesh. Often referred to as the \"king of fruits,\" durian holds a special place in Southeast Asian cuisine and culture, despite its divisive smell.", 0.0, "durian.jpg", "durian", 30, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "grape", 125000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grapes are small, spherical fruits known for their sweet and juicy taste, often eaten fresh or processed into various products like wine, juice, and raisins. They grow in clusters on vines belonging to the Vitis genus.", 0.0, "grape.jpg", "Grape", 25, "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "kiwi", 250000.0, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The kiwi, also known as the kiwifruit, is a small, oval-shaped fruit with fuzzy brown skin and vibrant green flesh dotted with tiny edible black seeds. It is renowned for its unique flavor, nutritional richness, and distinctive appearance.", 0.0, "kiwi.jpg", "Kiwi", 25, "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "lemon", 25000.0, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lemons are citrus fruits with a bright yellow skin and sour, juicy flesh. They are rich in vitamin C and are used for their juice, zest, and in cooking and baking.", 0.0, "lemon.jpg", "Lemon", 35, "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "mandarin", 40000.0, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The mandarin (Citrus reticulata) is a small citrus tree fruit that belongs to the Rutaceae family. It is one of the original species of citrus and is known for its easy-to-peel skin, sweet flavor, and juicy segments. Mandarins are a popular fruit worldwide, enjoyed both fresh and in various culinary applications.", 0.0, "mandarin.jpg", "Mandarin", 40000, "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "mango", 35000.0, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mangoes are tropical fruits with a sweet, juicy, and fibrous flesh. They have a large pit and a tough skin that ranges from green to red or orange when ripe. Mangoes are eaten fresh, used in desserts, or made into smoothies.", 0.0, "mango.jpg", "Mango", 20, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "orange", 35000.0, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oranges are citrus fruits with a bright orange skin and juicy, sweet-tart flesh. They are rich in vitamin C and are commonly consumed fresh, juiced, or used in cooking.", 0.0, "orange.jpg", "Orange", 20, "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "papaya", 35000.0, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papayas are tropical fruits with a green or yellow skin and sweet, orange flesh. They contain black seeds and are eaten fresh, used in salads, or made into smoothies and juices.", 0.0, "papaya.jpg", "Papaya", 10, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "peach", 65000.0, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peaches are stone fruits with a fuzzy skin and juicy, sweet flesh. They come in yellow and white varieties and are eaten fresh, canned, or used in desserts.\r\n\r\n", 0.0, "peach.jpg", "Peach", 25, "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "pear", 55000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pears are sweet, juicy fruits with a smooth or slightly grainy texture. They come in various colors, including green, yellow, and red. Pears are eaten fresh, canned, or used in baking.", 0.0, "pear.jpg", "Pear", 20, "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "pineapple", 35000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pineapples are tropical fruits with a tough, spiky exterior and sweet, tangy flesh. They are commonly eaten fresh, canned, or used in cooking and baking.", 0.0, "pineapple.jpg", "Pineapple", 30, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "plum", 65000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plums are stone fruits with a smooth skin and juicy, sweet-tart flesh. They come in various colors, including purple, red, and yellow. Plums are eaten fresh, dried into prunes, or used in cooking.", 0.0, "plum.jpg", "Plum", 35, "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "pomegranate", 60000.0, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pomegranates are round fruits with a tough, reddish skin and a plethora of juicy, red seeds inside. They have a sweet-tart flavor and are eaten fresh or used in juices and cooking.", 0.0, "pomegranate.jpg", "Pomegranate", 30, "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "strawberry", 125000.0, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strawberries are juicy, red berries that are widely appreciated for their sweet flavor and aromatic fragrance. They are among the most popular and versatile fruits globally.", 0.0, "strawberry.jpg", "Strawberry", 25, "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "walnut", 335000.0, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walnuts are nutritious nuts known for their distinctively earthy flavor and crunchy texture. They are highly versatile and widely used in various culinary applications, from savory dishes to baked goods and desserts.", 0.10000000000000001, "walnut.jpg", "Walnut", 20, "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" },
                    { "watermelon", 15000.0, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watermelons are large, juicy fruits with a green rind and sweet, red or pink flesh. They are a popular summer fruit, eaten fresh or used in salads and beverages.\r\n\r\n", 0.0, "watermelon.jpg", "Watermelon", 35, "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc", "kilogram", "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "4a1b7c3d-8e9f-4c2d-8a9b-1f7c3b9e4d5a");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "almond");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apple");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "apricot");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "banana");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "blueberry");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cantaloupe");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "cherry");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "coconut");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "durian");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "grape");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "kiwi");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "lemon");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mandarin");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "mango");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "orange");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "papaya");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "peach");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pear");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pineapple");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "plum");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "pomegranate");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "strawberry");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "walnut");

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: "watermelon");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc");

            migrationBuilder.DeleteData(
                table: "productTypes",
                keyColumn: "ProductTypeID",
                keyValue: "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f");

            migrationBuilder.DeleteData(
                table: "providers",
                keyColumn: "ProviderID",
                keyValue: "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52");
        }
    }
}
