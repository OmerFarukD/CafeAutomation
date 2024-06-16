using Application.Services.Repositories;
using Core.DataAccess.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public sealed class CategoryRepository :EfCoreRepository<Category,Guid,BaseDbContext>, ICategoryRepository
{
    public CategoryRepository(BaseDbContext context) : base(context)
    {
    }
}