using CandyShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//16.ADIM Adding Entity Framework and DbContext
namespace CandyShop.Views
{
    //53.ADIM Adding Identity To Project
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
           base(options)
        {
        }

        public DbSet<Candy> Candies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; } //46.ADIM Creating Order and Order Detail Models
        public DbSet<OrderDetail> OrderDetails { get; set; } //46.ADIM Creating Order and Order Detail Models


        //21.ADIM Seeding the Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 1, categoryName = "Chocolate Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 2, categoryName = "Fruit Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 3, categoryName = "Gummy Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 4, categoryName = "Halloween Candy" });
            modelBuilder.Entity<Category>().HasData(new Category { categoryId = 5, categoryName = "Hard Candy" });

            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 1,
                name = "Assorted Chocolate Candy",
                price = 4.95M,
                description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                categoryId = 1,
                imageUrl = "\\Images\\chocolateCandy.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 2,
                name = "Another Assorted Chocolate Candy",
                price = 3.95M,
                description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                categoryId = 1,
                imageUrl = "\\Images\\chocolateCandy2.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 3,
                name = "Another Chocolate Candy",
                price = 5.75M,
                description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                categoryId = 1,
                imageUrl = "\\Images\\chocolateCandy3.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 4,
                name = "Assorted Fruit Candy",
                price = 3.95M,
                description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                categoryId = 2,
                imageUrl = "\\Images\\fruitCandy.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 5,
                name = "Fruit Candy",
                price = 7.00M,
                description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                categoryId = 2,
                imageUrl = "\\Images\\fruitCandy2.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 6,
                name = "Another Assorted Fruit Candy",
                price = 11.25M,
                description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                categoryId = 2,
                imageUrl = "\\Images\\fruitCandy3.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 7,
                name = "Assorted Gummy Candy",
                price = 3.95M,
                description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                categoryId = 3,
                imageUrl = "\\Images\\gummyCandy.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 8,
                name = "Another Assorted Gummy Candy",
                price = 1.95M,
                description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                categoryId = 3,
                imageUrl = "\\Images\\gummyCandy2.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 9,
                name = "Gummy Candy",
                price = 13.95M,
                description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                categoryId = 3,
                imageUrl = "\\Images\\gummyCandy3.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 10,
                name = "Halloween Candy",
                price = 1.95M,
                description = "Vitae congue eu consequat ac felis donec et odio. Tellus orci ac auctor augue mauris augue. Feugiat sed lectus vestibulum mattis ullamcorper velit sed. Sit amet consectetur adipiscing elit pellentesque habitant morbi tristique senectus. Sed pulvinar proin gravida hendrerit lectus a.",
                categoryId = 4,
                imageUrl = "\\Images\\halloweenCandy.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 11,
                name = "Assorted Halloween Candy",
                price = 12.95M,
                description = "Hac habitasse platea dictumst quisque sagittis purus sit. Dui nunc mattis enim ut. Mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et.",
                categoryId = 4,
                imageUrl = "\\Images\\halloweenCandy2.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy2-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 12,
                name = "Another Halloween Candy",
                price = 21.95M,
                description = "Pulvinar neque laoreet suspendisse interdum consectetur libero id faucibus. Ultrices vitae auctor eu augue ut lectus arcu bibendum at. Vulputate eu scelerisque felis imperdiet proin fermentum.",
                categoryId = 4,
                imageUrl = "\\Images\\halloweenCandy3.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\halloweenCandy3-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 13,
                name = "Hard Candy",
                price = 6.95M,
                description = "Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare massa. Arcu cursus euismod quis viverra.",
                categoryId = 5,
                imageUrl = "\\Images\\hardCandy.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy-small.jpg",
                isInStock = true,
                isOnSale = false
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 14,
                name = "Another Hard Candy",
                price = 2.95M,
                description = "Blandit massa enim nec dui nunc mattis enim ut tellus. Duis at consectetur lorem donec massa sapien faucibus et. At auctor urna nunc id cursus metus. Ut enim blandit volutpat maecenas volutpat blandit.",
                categoryId = 5,
                imageUrl = "\\Images\\hardCandy2.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy2-small.jpg",
                isInStock = true,
                isOnSale = true
            });
            modelBuilder.Entity<Candy>().HasData(new Candy
            {
                candyId = 15,
                name = "Best Hard Candy",
                price = 16.95M,
                description = "Nisi lacus sed viverra tellus in. Morbi non arcu risus quis varius quam quisque id. Cras adipiscing enim eu turpis egestas. Tristique nulla aliquet enim tortor. Quisque id diam vel quam. Id faucibus nisl tincidunt eget nullam.",
                categoryId = 5,
                imageUrl = "\\Images\\hardCandy3.jpg",
                imageThumbnailUrl = "\\Images\\thumbnails\\hardCandy3-small.jpg",
                isInStock = true,
                isOnSale = false
            });
        }
    }
}
