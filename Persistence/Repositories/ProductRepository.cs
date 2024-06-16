using Application.Services.Repositories;
using Core.DataAccess.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public sealed class ProductRepository : EfCoreRepository<Product,Guid,BaseDbContext>, IProductRepository
{
    public ProductRepository(BaseDbContext context) : base(context)
    {
    }
}

