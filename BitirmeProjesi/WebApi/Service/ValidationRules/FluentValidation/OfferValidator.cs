using Entities;
using FluentValidation;

namespace Service
{
    public class OfferValidator : AbstractValidator<OfferDto>
    {
        public OfferValidator()
        {
            RuleFor(o => o.OfferAmount).GreaterThan(0).WithMessage("Offer must be greater than 0");
            RuleFor(o => o.OfferAmount).NotNull().WithMessage("Offer amount cannot be empty");
            RuleFor(o => o.UserId).NotNull().WithMessage("UserId amount cannot be empty");
            RuleFor(o => o.ProductId).NotNull().WithMessage("ProductId amount cannot be empty");

        }
    }
}
