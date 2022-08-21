using AutoMapper;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Service;
using System.Threading.Tasks;

namespace WebApi
{
    [Route("api/final/protein/[controller]")]
    [ApiController]
    public class ProductController : BaseController<ProductDto, Product>
    {
        IProductService _productService;
        public ProductController(IProductService productService, IMapper mapper) : base(productService, mapper)
        {
            _productService = productService;
        }

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Product with Id is {id}.");

            return await base.GetByIdAsync(id);
        }

        [Route("GetByCategoryId")]
        [HttpGet]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var result = _productService.GetProductsByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public new async Task<IActionResult> CreateAsync([FromBody] ProductDto resource)
        {
            Log.Information($"{User.Identity?.Name}: create a Product.");

            return await base.CreateAsync(resource);
        }

        [HttpPut("{id:int}")]
        public new async Task<IActionResult> UpdateAsync(int id, [FromBody] ProductDto resource)
        {
            Log.Information($"{User.Identity?.Name}: update a Product with Id is {id}.");

            return await base.UpdateAsync(id, resource);
        }

        [Route("Buy")]
        [HttpPut]
        public new async Task<IActionResult> BuyProductAsync([FromQuery] int productId)
        {
            Log.Information($"{User.Identity?.Name}: update a Product with Id is {productId}.");
            var productResult = await _productService.GetByIdAsync(productId);
            productResult.Response.IsSold = 1;
            productResult.Response.IsOfferable = 0;
            var result = await _productService.UpdateAsync(productId, productResult.Response);

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public new async Task<IActionResult> DeleteAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: delete a Product with Id is {id}.");

            return await base.DeleteAsync(id);
        }

    }
}
