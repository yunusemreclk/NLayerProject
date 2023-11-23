using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
            new ProductFeature { Id = 1, Color = "Kırmızı", Height = 100, Width = 200, ProductId = 1 },
            new ProductFeature { Id = 2, Color = "Mavi", Height = 140, Width = 180, ProductId = 3 },
            new ProductFeature { Id = 3, Color = "Sarı", Height = 110, Width = 250, ProductId = 2 },
            new ProductFeature { Id = 4, Color = "Yeşil", Height = 150, Width = 200, ProductId = 5 }
            );
        }
    }
}
