using Etic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etic.Data
{
    public class EticContext :DbContext
    {

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=185.242.162.113;User ID=db9_sinif1;Password=@Ss12345678");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(o =>
            new {
                o.CategoryId,o.ProductId
            });
        }

        public DbSet<User> Users { get; set; }
        //4. tablo buraya eklenmeli
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; } // BUUU
        public DbSet<ProductImage> ProductImages { get; set; }// BUUU
        public DbSet<ProductCategory> ProductCategories { get; set; }// BUUU
        public DbSet<Basket> Baskets { get; set; }// BUUU
        public DbSet<BasketProduct> BasketProducts { get; set; }// BUUU


    }
}
