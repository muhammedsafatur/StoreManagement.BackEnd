using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StoreManagementProject.Web.Api.Models.Dtos;
using StoreManagementProject.Web.Api.ServiceLayer;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductsController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] ProductDto productDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _productService.AddAsync(productDto);
        return CreatedAtAction(nameof(GetAll), productDto); // ID'yi göndermiyoruz
    }

    [HttpGet("Get All")]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productService.GetAllAsync();
        return Ok(products);
    }

    [HttpGet("Find by {id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productService.GetByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    // Diğer metodlar...
}
