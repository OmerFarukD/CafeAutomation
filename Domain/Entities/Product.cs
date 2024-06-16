using Core.DataAccess;

namespace Domain.Entities;

public class Product : Entity<Guid>
{
    public string? Name { get; set;}

    public decimal Price { get; set;}

    public int Stock { get; set;}

    public Guid CategoryId { get; set;}

    public Category Category { get; set; }

    public ICollection<ProductImage> ProductImages { get; set; }
    

    public string? Description { get; set;}


    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
        Category = new Category();
        ProductImages = new HashSet<ProductImage>();
    }


    public Product(string? name, decimal price, int stock, Guid categoryId, string? description)
    {
        Name = name;
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
        Description = description;
    }
    
    
}