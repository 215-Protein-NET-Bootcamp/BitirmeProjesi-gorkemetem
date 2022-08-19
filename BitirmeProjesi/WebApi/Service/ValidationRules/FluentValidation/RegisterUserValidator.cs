using Entities;
using FluentValidation;

namespace Service
{
    public class RegisterUserValidator : AbstractValidator<UserForRegisterDto>
    {
        public RegisterUserValidator()
        {
            RuleFor(u => u.FirstName).NotNull().WithMessage("FirstName cannot be empty");
            RuleFor(u => u.LastName).NotNull().WithMessage("LastName cannot be empty");
            RuleFor(u => u.Email).NotNull().WithMessage("Email cannot be empty");
            RuleFor(u => u.Password).NotNull().WithMessage("Password cannot be empty");
            RuleFor(u => u.Password).MinimumLength(8).WithMessage("Password must be minumum 8 characters");
            RuleFor(u => u.Password).MaximumLength(20).WithMessage("Password must be maximum 20 characters");
            RuleFor(u => u.Email).EmailAddress().WithMessage("A valid email address is required.");
        }
    }

}
