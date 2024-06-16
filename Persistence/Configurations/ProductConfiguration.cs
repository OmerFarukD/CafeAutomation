using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products").HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name");
        builder.Property(p => p.Price).HasColumnName("Price");
        builder.Property(p => p.Stock).HasColumnName("Stock");
        builder.Property(p => p.Description).HasColumnName("Description");
        builder.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
        builder.Property(P => P.UpdatedTime).HasColumnName("UpdatedTime");
        builder.HasOne(x => x.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        builder.HasMany(p => p.ProductImages)
            .WithOne(p => p.Product)
            .HasForeignKey(p => p.ProductId);
        
        
        builder.Navigation(p => p.ProductImages).AutoInclude();
        
        builder.Navigation(p => p.Category)
            .AutoInclude();
    }
}