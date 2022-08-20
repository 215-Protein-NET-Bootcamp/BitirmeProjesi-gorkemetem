using Base;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public interface IProductService : IBaseService<ProductDto, Product>
    {
        Task<BaseResponse<IEnumerable<ProductDto>>> GetAllByCategoryIdAsync(int id);
        IDataResult<List<Product>> GetProductsByCategoryId(int id);
    }
}
