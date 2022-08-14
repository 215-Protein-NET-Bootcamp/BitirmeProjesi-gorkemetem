using AutoMapper;
using DataAccess;
using Entities;

namespace Service
{
    public class ProductService : BaseService<ProductDto, Product>, IProductService
    {
        public ProductService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(productRepository, mapper, unitOfWork)
        {
        }
    }
}
