using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product { Id = 1, CategoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
            new Product { Id = 2, CategoryId = 1, Name = "Kalem 2", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
            new Product { Id = 3, CategoryId = 1, Name = "Kalem 3", Price = 350, Stock = 25, CreatedDate = DateTime.Now },
            new Product { Id = 4, CategoryId = 1, Name = "Kalem 4", Price = 150, Stock = 40, CreatedDate = DateTime.Now },
            new Product { Id = 5, CategoryId = 1, Name = "Kalem 5", Price = 100, Stock = 35, CreatedDate = DateTime.Now },
            new Product { Id = 6, CategoryId = 1, Name = "Kalem 6", Price = 400, Stock = 20, CreatedDate = DateTime.Now },
            new Product { Id = 7, CategoryId = 1, Name = "Kalem 7", Price = 300, Stock = 30, CreatedDate = DateTime.Now }
            );
        }
    }
}
