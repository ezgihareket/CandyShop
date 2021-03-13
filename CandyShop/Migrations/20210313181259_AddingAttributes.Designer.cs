﻿// <auto-generated />
using System;
using CandyShop.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210313181259_AddingAttributes")]
    partial class AddingAttributes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.Property<int>("candyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("categoryId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("isOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("candyId");

                    b.HasIndex("categoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            candyId = 1,
                            categoryId = 1,
                            description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                            imageUrl = "\\Images\\chocolateCandy.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Assorted Chocolate Candy",
                            price = 4.95m
                        },
                        new
                        {
                            candyId = 2,
                            categoryId = 1,
                            description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                            imageUrl = "\\Images\\chocolateCandy2.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Another Assorted Chocolate Candy",
                            price = 3.95m
                        },
                        new
                        {
                            candyId = 3,
                            categoryId = 1,
                            description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                            imageUrl = "\\Images\\chocolateCandy3.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Another Chocolate Candy",
                            price = 5.75m
                        },
                        new
                        {
                            candyId = 4,
                            categoryId = 2,
                            description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                            imageUrl = "\\Images\\fruitCandy.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Assorted Fruit Candy",
                            price = 3.95m
                        },
                        new
                        {
                            candyId = 5,
                            categoryId = 2,
                            description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                            imageUrl = "\\Images\\fruitCandy2.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Fruit Candy",
                            price = 7.00m
                        },
                        new
                        {
                            candyId = 6,
                            categoryId = 2,
                            description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                            imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                            imageUrl = "\\Images\\fruitCandy3.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Another Assorted Fruit Candy",
                            price = 11.25m
                        },
                        new
                        {
                            candyId = 7,
                            categoryId = 3,
                            description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                            imageUrl = "\\Images\\gummyCandy.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Assorted Gummy Candy",
                            price = 3.95m
                        },
                        new
                        {
                            candyId = 8,
                            categoryId = 3,
                            description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                            imageUrl = "\\Images\\gummyCandy2.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Another Assorted Gummy Candy",
                            price = 1.95m
                        },
                        new
                        {
                            candyId = 9,
                            categoryId = 3,
                            description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                            imageUrl = "\\Images\\gummyCandy3.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Gummy Candy",
                            price = 13.95m
                        },
                        new
                        {
                            candyId = 10,
                            categoryId = 4,
                            description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                            imageUrl = "\\Images\\halloweenCandy.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Halloween Candy",
                            price = 1.95m
                        },
                        new
                        {
                            candyId = 11,
                            categoryId = 4,
                            description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                            imageUrl = "\\Images\\halloweenCandy2.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Assorted Halloween Candy",
                            price = 12.95m
                        },
                        new
                        {
                            candyId = 12,
                            categoryId = 4,
                            description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                            imageUrl = "\\Images\\halloweenCandy3.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Another Halloween Candy",
                            price = 21.95m
                        },
                        new
                        {
                            candyId = 13,
                            categoryId = 5,
                            description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy-small.jpg",
                            imageUrl = "\\Images\\hardCandy.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Hard Candy",
                            price = 6.95m
                        },
                        new
                        {
                            candyId = 14,
                            categoryId = 5,
                            description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                            imageUrl = "\\Images\\hardCandy2.jpg",
                            isInStock = true,
                            isOnSale = true,
                            name = "Another Hard Candy",
                            price = 2.95m
                        },
                        new
                        {
                            candyId = 15,
                            categoryId = 5,
                            description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                            imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                            imageUrl = "\\Images\\hardCandy3.jpg",
                            isInStock = true,
                            isOnSale = false,
                            name = "Best Hard Candy",
                            price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            categoryName = "Chocolate Candy"
                        },
                        new
                        {
                            categoryId = 2,
                            categoryName = "Fruit Candy"
                        },
                        new
                        {
                            categoryId = 3,
                            categoryName = "Gummy Candy"
                        },
                        new
                        {
                            categoryId = 4,
                            categoryName = "Halloween Candy"
                        },
                        new
                        {
                            categoryId = 5,
                            categoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CandyId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("candyId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("candyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CandyShop.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CandyShop.Models.OrderDetail", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candy");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("CandyShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("candyId");

                    b.Navigation("Candy");
                });

            modelBuilder.Entity("CandyShop.Models.Category", b =>
                {
                    b.Navigation("Candies");
                });

            modelBuilder.Entity("CandyShop.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
