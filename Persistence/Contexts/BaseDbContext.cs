﻿using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts;

public  class BaseDbContext :DbContext
{
  protected IConfiguration Configuration { get; set; }
  
  public DbSet<Product> Products { get; set; }
  public DbSet<Category> Categories { get; set; }
  public DbSet<ProductImage> ProductImages { get; set; }
  
  public BaseDbContext(DbContextOptions<BaseDbContext> options,IConfiguration configuration) : base(options)
  {
    Configuration = configuration;
  }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

}