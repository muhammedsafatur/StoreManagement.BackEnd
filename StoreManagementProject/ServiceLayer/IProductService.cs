using StoreManagementProject.Web.Api.Models.Dtos;

namespace StoreManagementProject.Web.Api.ServiceLayer;
public interface IProductService
{
    Task<ProductDto> GetByIdAsync(int id);
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task AddAsync(ProductDto productDto);
    Task UpdateAsync(ProductDto productDto);
    Task DeleteAsync(int id);
}
