using Entities;
using FluentValidation;

namespace Service
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MaximumLength(100).WithMessage("Product name must be maximum 100 characters");
            RuleFor(p => p.ProductName).NotNull().WithMessage("Product name cannot be empty");
            RuleFor(p => p.Description).MaximumLength(500).WithMessage("Description must be maximum 500 characters");
            RuleFor(p => p.Description).NotNull().WithMessage("Description cannot be empty");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greter than 0.");
            RuleFor(p => p.Price).NotNull().WithMessage("Price cannot be empty");
        }
    }
}
