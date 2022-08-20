using Entities;
using FluentValidation;

namespace Service
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator()
        {
           RuleFor(p => p.CategoryName).MaximumLength(100).WithMessage("CATEGORY name must be maximum 200 characters");
           RuleFor(p => p.CategoryName).NotNull().WithMessage("Category name cannot be empty");
        }
    }
}
