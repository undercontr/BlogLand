using System.Data;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Username).NotEmpty();
        }
    }
}