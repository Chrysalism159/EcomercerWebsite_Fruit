using EcomercerWebsite_Fruit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace EcomercerWebsite_Fruit.Models
{
    public class EcomercerDataContext : DbContext
    {
        public EcomercerDataContext()
        {
        }

        public EcomercerDataContext(DbContextOptions<EcomercerDataContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Bill> bills { get; set; }
        public virtual DbSet<BillInformation> billInformation { get; set; }
        public virtual DbSet<Customer> customers { get; set; }
        public virtual DbSet<Favorite> favorites { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<ProductType> productTypes { get; set; }
        public virtual DbSet<Provider> providers { get; set; }
        public virtual DbSet<StatementInformation> statementInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            new DbInitialSeedData(modelbuilder).Seed();
        }
    }
    public class DbInitialSeedData
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitialSeedData(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Provider>().HasData(
                new Provider
                {
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                    ProviderAddress = "23 Hoàng Văn Thái, Thanh Xuân, Hà Nội",
                    ProviderName = "Fresh Fruit Inc.",
                    ProviderContact = "Nguyễn Hoàng Hà",
                    ProviderPhone = "0334564456",
                    Logo = "logo.png",
                    Email = "fresh.fruit.inc@gmail.com",
                    ProviderDescription = "Fresh Fruit Inc. is integral to bringing fresh, nutritious fruits from farms to consumers around the world. They encompass a wide range of activities, from cultivation and quality control to distribution and marketing, all while striving for sustainability and innovation."
                }
            );
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductTypeName = "Seeded Fruits",
                    ProductTypeDescription = "Contain one or more seeds inside"
                },
                new ProductType
                {
                    ProductTypeID = "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d",
                    ProductTypeName = "Stone Fruits",
                    ProductTypeDescription = "Have a hard pit inside, surrounded by soft flesh."
                },
                new ProductType
                {
                    ProductTypeID = "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f",
                    ProductTypeName = "Berries",
                    ProductTypeDescription = "Have many small seeds distributed throughout the flesh."
                },
                new ProductType
                {
                    ProductTypeID = "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c",
                    ProductTypeName = "Hard-Shell Fruits",
                    ProductTypeDescription = "Have a hard shell protecting the inner flesh."
                },
                new ProductType
                {
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductTypeName = "Tropical Fruits",
                    ProductTypeDescription = "Typically grow in tropical regions."
                },
                new ProductType
                {
                    ProductTypeID = "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f",
                    ProductTypeName = "Temperate Fruits",
                    ProductTypeDescription = "Grow in temperate regions."
                },
                new ProductType
                {
                    ProductTypeID = "4a1b7c3d-8e9f-4c2d-8a9b-1f7c3b9e4d5a",
                    ProductTypeName = "Subtropical Fruits",
                    ProductTypeDescription = "Grow in subtropical regions."
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = "apple",
                    ProductName = "Apple",
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductUnit = "kilogram",
                    ProductCost = 65000,
                    ProductImage = "apple.jpg",
                    ProductDate = DateTime.ParseExact("02/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess= 30,
                    ProductDescription= "Apples are sweet or tart fruits with a crisp texture. They come in various colors, including red, green, and yellow. Apples are commonly eaten raw, cooked, or used in desserts like pies and crumbles.",
                    ProviderID= "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "pear",
                    ProductName = "Pear",
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductUnit = "kilogram",
                    ProductCost = 55000,
                    ProductImage = "pear.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 20,
                    ProductDescription = "Pears are sweet, juicy fruits with a smooth or slightly grainy texture. They come in various colors, including green, yellow, and red. Pears are eaten fresh, canned, or used in baking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "lemon",
                    ProductName = "Lemon",
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductUnit = "kilogram",
                    ProductCost = 25000,
                    ProductImage = "lemon.jpg",
                    ProductDate = DateTime.ParseExact("30/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 35,
                    ProductDescription = "Lemons are citrus fruits with a bright yellow skin and sour, juicy flesh. They are rich in vitamin C and are used for their juice, zest, and in cooking and baking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "orange",
                    ProductName = "Orange",
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductUnit = "kilogram",
                    ProductCost = 35000,
                    ProductImage = "orange.jpg",
                    ProductDate = DateTime.ParseExact("02/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 20,
                    ProductDescription = "Oranges are citrus fruits with a bright orange skin and juicy, sweet-tart flesh. They are rich in vitamin C and are commonly consumed fresh, juiced, or used in cooking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "mandarin",
                    ProductName = "Mandarin",
                    ProductTypeID = "2c1f5b4e-3a4e-4db4-85c3-89a7c3179e7d",
                    ProductUnit = "kilogram",
                    ProductCost = 40000,
                    ProductImage = "mandarin.jpg",
                    ProductDate = DateTime.ParseExact("02/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 40000,
                    ProductDescription = "The mandarin (Citrus reticulata) is a small citrus tree fruit that belongs to the Rutaceae family. It is one of the original species of citrus and is known for its easy-to-peel skin, sweet flavor, and juicy segments. Mandarins are a popular fruit worldwide, enjoyed both fresh and in various culinary applications.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "peach",
                    ProductName = "Peach",
                    ProductTypeID = "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d",
                    ProductUnit = "kilogram",
                    ProductCost = 65000,
                    ProductImage = "peach.jpg",
                    ProductDate = DateTime.ParseExact("03/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 25,
                    ProductDescription = "Peaches are stone fruits with a fuzzy skin and juicy, sweet flesh. They come in yellow and white varieties and are eaten fresh, canned, or used in desserts.\r\n\r\n",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "plum",
                    ProductName = "Plum",
                    ProductTypeID = "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d",
                    ProductUnit = "kilogram",
                    ProductCost = 65000,
                    ProductImage = "plum.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 35,
                    ProductDescription = "Plums are stone fruits with a smooth skin and juicy, sweet-tart flesh. They come in various colors, including purple, red, and yellow. Plums are eaten fresh, dried into prunes, or used in cooking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "apricot",
                    ProductName = "Apricot",
                    ProductTypeID = "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d",
                    ProductUnit = "kilogram",
                    ProductCost = 40000,
                    ProductImage = "apricot.jpg",
                    ProductDate = DateTime.ParseExact("04/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 40,
                    ProductDescription = "Apricots (Prunus armeniaca) are small, round stone fruits with a velvety skin and sweet-tart flavor. They are typically yellow to orange in color, often with a reddish blush.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "cherry",
                    ProductName = "Cherry",
                    ProductTypeID = "1a90c514-3e9f-4a2b-8ab9-8e9a7357b30d",
                    ProductUnit = "kilogram",
                    ProductCost = 250000,
                    ProductImage = "cherry.jpg",
                    ProductDate = DateTime.ParseExact("05/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 10,
                    ProductDescription = "Cherries are small, round stone fruits known for their vibrant color and sweet or tart flavor. They come in two main types: sweet cherries (Prunus avium) and sour cherries (Prunus cerasus).",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "strawberry",
                    ProductName = "Strawberry",
                    ProductTypeID = "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f",
                    ProductUnit = "kilogram",
                    ProductCost = 125000,
                    ProductImage = "strawberry.jpg",
                    ProductDate = DateTime.ParseExact("04/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 25,
                    ProductDescription = "Strawberries are juicy, red berries that are widely appreciated for their sweet flavor and aromatic fragrance. They are among the most popular and versatile fruits globally.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "blueberry",
                    ProductName = "Blueberry",
                    ProductTypeID = "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f",
                    ProductUnit = "kilogram",
                    ProductCost = 225000,
                    ProductImage = "blueberry.jpg",
                    ProductDate = DateTime.ParseExact("03/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 20,
                    ProductDescription = "Blueberries are small, round berries with a deep blue to purple-black hue. They are celebrated for their sweet flavor, antioxidant-rich profile, and versatility in culinary applications.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "grape",
                    ProductName = "Grape",
                    ProductTypeID = "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f",
                    ProductUnit = "kilogram",
                    ProductCost = 125000,
                    ProductImage = "grape.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 25,
                    ProductDescription = "Grapes are small, spherical fruits known for their sweet and juicy taste, often eaten fresh or processed into various products like wine, juice, and raisins. They grow in clusters on vines belonging to the Vitis genus.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "kiwi",
                    ProductName = "Kiwi",
                    ProductTypeID = "e18b417d-fc87-4e0d-9c50-74a8b9c9b77f",
                    ProductUnit = "kilogram",
                    ProductCost = 250000,
                    ProductImage = "kiwi.jpg",
                    ProductDate = DateTime.ParseExact("04/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 25,
                    ProductDescription = "The kiwi, also known as the kiwifruit, is a small, oval-shaped fruit with fuzzy brown skin and vibrant green flesh dotted with tiny edible black seeds. It is renowned for its unique flavor, nutritional richness, and distinctive appearance.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "coconut",
                    ProductName = "Coconut",
                    ProductTypeID = "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c",
                    ProductUnit = "fruit",
                    ProductCost = 25000,
                    ProductImage = "coconut.jpg",
                    ProductDate = DateTime.ParseExact("22/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0.1,
                    ProductNumberAccess = 30,
                    ProductDescription = "The coconut is a versatile tropical fruit known for its large size, fibrous husk, and unique nutritional properties. It is prized for its sweet, refreshing water and creamy flesh, which are used in various culinary, medicinal, and industrial applications.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "walnut",
                    ProductName = "Walnut",
                    ProductTypeID = "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c",
                    ProductUnit = "kilogram",
                    ProductCost = 335000,
                    ProductImage = "walnut.jpg",
                    ProductDate = DateTime.ParseExact("12/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0.1,
                    ProductNumberAccess = 20,
                    ProductDescription = "Walnuts are nutritious nuts known for their distinctively earthy flavor and crunchy texture. They are highly versatile and widely used in various culinary applications, from savory dishes to baked goods and desserts.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "almond",
                    ProductName = "Almond",
                    ProductTypeID = "2f72c7e1-5a4e-4b79-a8a7-b9e4cf2d9a8c",
                    ProductUnit = "kilogram",
                    ProductCost = 225000,
                    ProductImage = "almond.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 10,
                    ProductDescription = "Almonds are highly versatile nuts celebrated for their delicate flavor, crunchy texture, and numerous health benefits. They are one of the most widely cultivated tree nuts globally and are utilized in various culinary, medicinal, and cosmetic applications.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "mango",
                    ProductName = "Mango",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 35000,
                    ProductImage = "mango.jpg",
                    ProductDate = DateTime.ParseExact("04/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 20,
                    ProductDescription = "Mangoes are tropical fruits with a sweet, juicy, and fibrous flesh. They have a large pit and a tough skin that ranges from green to red or orange when ripe. Mangoes are eaten fresh, used in desserts, or made into smoothies.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "pineapple",
                    ProductName = "Pineapple",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 35000,
                    ProductImage = "pineapple.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 30,
                    ProductDescription = "Pineapples are tropical fruits with a tough, spiky exterior and sweet, tangy flesh. They are commonly eaten fresh, canned, or used in cooking and baking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "banana",
                    ProductName = "Banana",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 45000,
                    ProductImage = "banana.jpg",
                    ProductDate = DateTime.ParseExact("05/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 10,
                    ProductDescription = "Bananas are long, yellow fruits with a soft, sweet flesh. They are high in potassium and are commonly eaten raw, used in baking, or added to smoothies.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "papaya",
                    ProductName = "Papaya",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 35000,
                    ProductImage = "papaya.jpg",
                    ProductDate = DateTime.ParseExact("05/06/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 10,
                    ProductDescription = "Papayas are tropical fruits with a green or yellow skin and sweet, orange flesh. They contain black seeds and are eaten fresh, used in salads, or made into smoothies and juices.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "durian",
                    ProductName = "durian",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 185000,
                    ProductImage = "durian.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 30,
                    ProductDescription = "Durian is a tropical fruit renowned for its distinctive aroma, large size, and custard-like flesh. Often referred to as the \"king of fruits,\" durian holds a special place in Southeast Asian cuisine and culture, despite its divisive smell.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "watermelon",
                    ProductName = "Watermelon",
                    ProductTypeID = "b1a3e54f-c18f-47c1-87d1-4a2d8f9b77bc",
                    ProductUnit = "kilogram",
                    ProductCost = 15000,
                    ProductImage = "watermelon.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 35,
                    ProductDescription = "Watermelons are large, juicy fruits with a green rind and sweet, red or pink flesh. They are a popular summer fruit, eaten fresh or used in salads and beverages.\r\n\r\n",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "cantaloupe",
                    ProductName = "Cantaloupe",
                    ProductTypeID = "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f",
                    ProductUnit = "kilogram",
                    ProductCost = 35000,
                    ProductImage = "cantaloupe.jpg",
                    ProductDate = DateTime.ParseExact("31/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 20,
                    ProductDescription = "Cantaloupe, also known as muskmelon, is a sweet and refreshing melon with a vibrant orange flesh and a distinctively aromatic flavor. It is widely loved for its juicy texture and subtle sweetness, making it a popular choice for snacks, desserts, and fruit salads during the summer months.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                },
                new Product
                {
                    ProductID = "pomegranate",
                    ProductName = "Pomegranate",
                    ProductTypeID = "6c3b90d1-4e9f-4b7a-8b9e-1f4a2d8c9b7f",
                    ProductUnit = "kilogram",
                    ProductCost = 60000,
                    ProductImage = "pomegranate.jpg",
                    ProductDate = DateTime.ParseExact("12/05/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ProductDiscount = 0,
                    ProductNumberAccess = 30,
                    ProductDescription = "Pomegranates are round fruits with a tough, reddish skin and a plethora of juicy, red seeds inside. They have a sweet-tart flavor and are eaten fresh or used in juices and cooking.",
                    ProviderID = "9a0f35a4-f431-4a0d-8427-fbf9b60a8e52",
                }
                );
            
        }
    }
}
