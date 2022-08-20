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

        //[HttpGet("{id:int}")]
        //public new async Task<IActionResult> GetAllByCategoryIdAsync(int id)
        //{
        //    var result = await _productService.GetAllByCategoryIdAsync(id);

        //    if (!result.Success)
        //        return BadRequest(result);

        //    if (result.Response is null)
        //        return NoContent();

        //    return Ok(result);
        //}

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Employee with Id is {id}.");

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
            Log.Information($"{User.Identity?.Name}: create a Employee.");

            return await base.CreateAsync(resource);
        }

        [HttpPut("{id:int}")]
        public new async Task<IActionResult> UpdateAsync(int id, [FromBody] ProductDto resource)
        {
            Log.Information($"{User.Identity?.Name}: update a Department with Id is {id}.");

            return await base.UpdateAsync(id, resource);
        }


        [HttpDelete("{id:int}")]
        public new async Task<IActionResult> DeleteAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: delete a Department with Id is {id}.");

            return await base.DeleteAsync(id);
        }

    }
}
