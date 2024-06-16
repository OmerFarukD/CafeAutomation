using Application.Services.Repositories;
using Core.DataAccess.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ProductImageRepository : EfCoreRepository<ProductImage,Guid,BaseDbContext>, IProductImageRepository
{
    public ProductImageRepository(BaseDbContext context) : base(context)
    {
    }
}