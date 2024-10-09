﻿using StoreManagementProject.Web.Api.Models;

namespace StoreManagementProject.Web.Api.Repositories;
public interface IProductRepository
{
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}
