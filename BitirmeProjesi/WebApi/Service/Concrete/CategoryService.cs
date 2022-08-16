using AutoMapper;
using DataAccess;
using Entities;

namespace Service
{
    public class CategoryService : BaseService<CategoryDto, Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(categoryRepository, mapper, unitOfWork)
        {
        }
    }
}
