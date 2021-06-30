using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TagValidator : AbstractValidator<Tag>
    {
        public TagValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
        }
    }
}