using Base;
using Entities;
using System.Collections.Generic;

namespace Service
{
    public interface IProductService : IBaseService<ProductDto, Product>
    {
        IDataResult<List<Product>> GetProductsByCategoryId(int id);
    }
}
