using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Stock).IsRequired();
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");

            builder.ToTable("Products");

            builder.HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryId);
        }
    }
}
