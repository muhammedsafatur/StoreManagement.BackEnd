namespace StoreManagementProject.Web.Api.Models.Dtos;

public class ProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public string CategoryName { get; set; }
    public int CategoryId { get; set; } // Sadece category ID gerekli
}
