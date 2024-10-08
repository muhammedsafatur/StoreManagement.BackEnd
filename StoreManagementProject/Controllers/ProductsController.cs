using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreManagementProject.Web.Api.Contexts;
using StoreManagementProject.Web.Api.Models;
using StoreManagementProject.Web.Api.Models.Dtos;

namespace StoreManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        MsSqlContext msSqlContext = new MsSqlContext();

        [HttpPost("Add(Yanlış yöntem categoryle birlikte ekliyor)")]
        public IActionResult Add(Product product)
        {
            msSqlContext.Products.Add(product);
            msSqlContext.SaveChanges();
            return Ok(product);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            // List<ProductDTO> türünde bir sonuç oluşturuyoruz
            List<ProductDto> products = msSqlContext.Products
                                                     .Include(p => p.Category) // Kategoriyi de dahil ediyoruz
                                                     .Select(p => new ProductDto
                                                     {
                                                         
                                                         Name = p.Name,
                                                         Price=p.Price,
                                                         Description=p.Description,
                                                         CategoryId = p.CategoryId,
                                                         CategoryName = p.Category.Name
                                                     })
                                                     .ToList(); // Listeyi alıyoruz

            return Ok(products);
        }


        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            // Product ile birlikte Category verisini de çekiyoruz
            var product = msSqlContext.Products
                                      .Include(p => p.Category) // Category bilgisini de dahil ediyoruz
                                      .Where(p => p.Id == id)
                                      .Select(p => new ProductDto
                                      {
                                          
                                          Name = p.Name,
                                          Description = p.Description,
                                          Price= p.Price,
                                          CategoryId = p.CategoryId,
                                          CategoryName = p.Category.Name
                                      })
                                      .FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


        [HttpPost("ADD(Doğru Yöntem)")]
        public IActionResult CreateProduct([FromBody] ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = (int)productDto.Price,
                CategoryId = productDto.CategoryId // Sadece CategoryId ile ilişkilendir
            };
            msSqlContext.Products.Add(product);
            msSqlContext.SaveChanges();
            return Ok(product);
        }


    }
}
