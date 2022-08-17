using AutoMapper;
using Base;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : BaseService<ProductDto, Product>, IProductService
    {
        IProductRepository _repository;
        public ProductService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(productRepository, mapper, unitOfWork)
        {
            _repository = productRepository;
        }

        public Task<BaseResponse<IEnumerable<ProductDto>>> GetAllByCategoryIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        [SecuredOperation("product.add, admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public override async Task<BaseResponse<ProductDto>> InsertAsync(ProductDto product)
        {
            try
            {
                var tempEntity = Mapper.Map<ProductDto, Product>(product);

                await _repository.InsertAsync(tempEntity);
                await UnitOfWork.CompleteAsync();

                return new BaseResponse<ProductDto>(Mapper.Map<Product, ProductDto>(tempEntity));
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Saving_Error", ex);
            }
        }
    }
}
