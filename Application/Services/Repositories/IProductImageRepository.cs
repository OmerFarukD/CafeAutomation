using Core.DataAccess.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IProductImageRepository : IAsyncRepository<ProductImage,Guid>, IRepository<ProductImage,Guid>
{
    
}