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
    public class CategoryController : BaseController<CategoryDto, Category>
    {

        public CategoryController(ICategoryService categoryService, IMapper mapper) : base(categoryService, mapper)
        {

        }

        [HttpGet("{id:int}")]
        public new async Task<IActionResult> GetByIdAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: get a Category with Id is {id}.");

            return await base.GetByIdAsync(id);
        }

        [HttpPost]
        public new async Task<IActionResult> CreateAsync([FromBody] CategoryDto resource)
        {
            Log.Information($"{User.Identity?.Name}: create a Category.");

            return await base.CreateAsync(resource);
        }

        [HttpPut("{id:int}")]
        public new async Task<IActionResult> UpdateAsync(int id, [FromBody] CategoryDto resource)
        {
            Log.Information($"{User.Identity?.Name}: update a Category with Id is {id}.");

            return await base.UpdateAsync(id, resource);
        }


        [HttpDelete("{id:int}")]
        public new async Task<IActionResult> DeleteAsync(int id)
        {
            Log.Information($"{User.Identity?.Name}: delete a Category with Id is {id}.");

            return await base.DeleteAsync(id);
        }

    }

}
