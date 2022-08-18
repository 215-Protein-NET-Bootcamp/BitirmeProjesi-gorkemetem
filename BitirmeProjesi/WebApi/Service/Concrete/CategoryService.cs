using AutoMapper;
using Base;
using DataAccess;
using Entities;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : BaseService<CategoryDto, Category>, ICategoryService
    {
        ICategoryRepository _repository;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(categoryRepository, mapper, unitOfWork)
        {
            _repository = categoryRepository;   
        }

        [SecuredOperation("product.add, admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        public override async Task<BaseResponse<CategoryDto>> InsertAsync(CategoryDto product)
        {
            try
            {
                var tempEntity = Mapper.Map<CategoryDto, Category>(product);

                await _repository.InsertAsync(tempEntity);
                await UnitOfWork.CompleteAsync();

                return new BaseResponse<CategoryDto>(Mapper.Map<Category, CategoryDto>(tempEntity));
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Saving_Error", ex);
            }
        }
    }
}
