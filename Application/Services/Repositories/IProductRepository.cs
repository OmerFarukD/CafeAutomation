﻿using Core.DataAccess.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IProductRepository  : IAsyncRepository<Product,Guid>, IRepository<Product,Guid>
{
    
}