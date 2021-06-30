using System.Data;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.Title).NotEmpty();
        }
    }
}