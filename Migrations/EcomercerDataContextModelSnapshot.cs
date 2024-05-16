﻿// <auto-generated />
using System;
using EcomercerWebsite_Fruit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcomercerWebsite_Fruit.Migrations
{
    [DbContext(typeof(EcomercerDataContext))]
    partial class EcomercerDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Bill", b =>
                {
                    b.Property<Guid>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayBuy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DayDelivery")
                        .HasColumnType("datetime2");

                    b.Property<double>("DeliveryFee")
                        .HasColumnType("float");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StatementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StatementInformationStatementID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WayDelivery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StatementInformationStatementID");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.BillInformation", b =>
                {
                    b.Property<Guid>("BillInformationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BillInformationDiscount")
                        .HasColumnType("float");

                    b.Property<int>("BillInformationNumber")
                        .HasColumnType("int");

                    b.Property<double>("ProductCost")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BillInformationID");

                    b.HasIndex("BillID");

                    b.HasIndex("ProductID");

                    b.ToTable("billInformation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CustomerDoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerGender")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerRole")
                        .HasColumnType("int");

                    b.Property<string>("RandomKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Favorite", b =>
                {
                    b.Property<Guid>("FavoriteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FavoriteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PickDay")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FavoriteID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("favorites");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Product", b =>
                {
                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("ProductCost")
                        .HasColumnType("float");

                    b.Property<DateTime>("ProductDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductDiscount")
                        .HasColumnType("float");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductNumberAccess")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProviderID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductTypeID");

                    b.HasIndex("ProviderID");

                    b.ToTable("products");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.ProductType", b =>
                {
                    b.Property<Guid>("ProductTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductTypeID");

                    b.ToTable("productTypes");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Provider", b =>
                {
                    b.Property<Guid>("ProviderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProviderID");

                    b.ToTable("providers");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.StatementInformation", b =>
                {
                    b.Property<Guid>("StatementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StatementDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatementName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatementID");

                    b.ToTable("statementInformation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Bill", b =>
                {
                    b.HasOne("EcomercerWebsite_Fruit.Models.Customer", "CustomerNavigation")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomercerWebsite_Fruit.Models.StatementInformation", null)
                        .WithMany("Bills")
                        .HasForeignKey("StatementInformationStatementID");

                    b.Navigation("CustomerNavigation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.BillInformation", b =>
                {
                    b.HasOne("EcomercerWebsite_Fruit.Models.Bill", "BillNavigation")
                        .WithMany("BillInformations")
                        .HasForeignKey("BillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomercerWebsite_Fruit.Models.Product", "ProductNavigation")
                        .WithMany("BillInformations")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillNavigation");

                    b.Navigation("ProductNavigation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Favorite", b =>
                {
                    b.HasOne("EcomercerWebsite_Fruit.Models.Customer", "CustomerNavigation")
                        .WithMany("Favorites")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomercerWebsite_Fruit.Models.Product", "ProductNavigation")
                        .WithMany("Favorites")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerNavigation");

                    b.Navigation("ProductNavigation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Product", b =>
                {
                    b.HasOne("EcomercerWebsite_Fruit.Models.ProductType", "ProductTypeNavigation")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcomercerWebsite_Fruit.Models.Provider", "ProviderNavigation")
                        .WithMany("Products")
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductTypeNavigation");

                    b.Navigation("ProviderNavigation");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Bill", b =>
                {
                    b.Navigation("BillInformations");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Customer", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Product", b =>
                {
                    b.Navigation("BillInformations");

                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.Provider", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EcomercerWebsite_Fruit.Models.StatementInformation", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
