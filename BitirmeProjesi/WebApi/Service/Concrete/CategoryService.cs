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

        //[SecuredOperation("product.add, admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
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
                throw new MessageResultException("Category_Saving_Error", ex);
            }
        }

        //[SecuredOperation("product.add, admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public override async Task<BaseResponse<CategoryDto>> UpdateAsync(int id, CategoryDto updateResource)
        {
            try
            {
                var tempEntity = await _repository.GetByIdAsync(id);
                if (tempEntity is null)
                    return new BaseResponse<CategoryDto>("NoData");
                Mapper.Map(updateResource, tempEntity);

                await UnitOfWork.CompleteAsync();
                var resource = Mapper.Map<Category, CategoryDto>(tempEntity);

                return new BaseResponse<CategoryDto>(resource);
            }
            catch (Exception ex)
            {
                throw new MessageResultException("Category_Updating_Error", ex);
            }
        }
    }
}
