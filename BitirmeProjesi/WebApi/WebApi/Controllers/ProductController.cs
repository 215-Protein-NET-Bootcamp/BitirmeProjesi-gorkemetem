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

        public ProductController(IProductService EmployeeService, IMapper mapper) : base(EmployeeService, mapper)
        {

        }

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Employee with Id is {id}.");

            return await base.GetByIdAsync(id);
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
