using Core.DataAccess;

namespace Domain.Entities;

public class ProductImage : Entity<Guid>
{
    
    public string ImageUrl { get; set; }

    public Guid ProductId { get; set; }
    public Product Product { get; set; }


    public ProductImage()
    {
        ImageUrl = string.Empty;
        Product = new Product();
    }
    
    
}