using Core.DataAccess;

namespace Domain.Entities;

public class Category : Entity<Guid>
{
    public string? Name { get; set; }

    public ICollection<Product> Products { get; set; }
    
    
    public Category() 
    {
        Name = string.Empty;
        Products = new HashSet<Product>();
    }
    
}