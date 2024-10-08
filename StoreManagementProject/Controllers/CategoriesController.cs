using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreManagementProject.Web.Api.Contexts;
using StoreManagementProject.Web.Api.Models;
using StoreManagementProject.Web.Api.Models.Dtos;

namespace StoreManagementProject.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        MsSqlContext msSqlContext = new MsSqlContext();

        [HttpPost("Add(Yanlış yönetem Productla birlikte ekliyor.)")]
        public IActionResult Add(Category category)
        {
            msSqlContext.Categories.Add(category);
            msSqlContext.SaveChanges();
            return Ok(category);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            List<Category> categories = msSqlContext.Categories.ToList();
            return Ok(categories);

        }

        [HttpPost("Category")]
        public IActionResult CreateCategory([FromBody] CategoryDto categoryDto)
        {
            // Category nesnesini oluştur ve kaydet
            var category = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };
            msSqlContext.Categories.Add(category);
            msSqlContext.SaveChanges();
            return Ok(category);

        }


        [HttpGet("GetById")]

        public IActionResult GetById(int id)
        {
            Category category = msSqlContext.Categories.Find(id);
            return Ok(category);
        }

    }
}
