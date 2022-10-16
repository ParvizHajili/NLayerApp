using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Apple Iphone 11",
                    Price = 1200,
                    Stock = 50,
                    CreatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 2,
                    CategoryId = 2,
                    Name = "Trausers",
                    Price = 60,
                    Stock = 28,
                    CreatedDate = DateTime.Now,
                },
                new Product()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Samsung Galaxy A52",
                    Price = 600,
                    Stock = 120,
                    CreatedDate = DateTime.Now,
                });
        }
    }
}
