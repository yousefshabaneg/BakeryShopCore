using BakeryShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryShop.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Carrot Cake",
                    Description = "Carrot Cake Desc",
                    ImageName = "carrot_cake.jpg",
                    Price = 20
                },
                new Product
                {
                    Id = 2,
                    Name = "Lemon Tart",
                    Description = "Lemon Tart Desc",
                    ImageName = "lemon_tart.jpg",
                    Price = 30
                },
                new Product
                {
                    Id = 3,
                    Name = "Cup Cakes",
                    Description = "Cup Cakes Desc",
                    ImageName = "cupcakes.jpg",
                    Price = 50
                },
                new Product
                {
                    Id = 4,
                    Name = "Bread",
                    Description = "Bread Cakes Desc",
                    ImageName = "bread.jpg",
                    Price = 15
                }
                );
            return modelBuilder;
        }
    }
}
