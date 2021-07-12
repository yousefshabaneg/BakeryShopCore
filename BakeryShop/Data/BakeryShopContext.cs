using BakeryShop.Data.Configurations;
using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public class BakeryShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configure DBContext to Use SQLite
            optionsBuilder.UseSqlite(@"Data Source=BakeryDB.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}
