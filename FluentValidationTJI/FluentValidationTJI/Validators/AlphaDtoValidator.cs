using FluentValidation;
using FluentValidationTJI.Models.Dto;

namespace FluentValidationTJI.Validators
{
    public class AlphaDtoValidator : AbstractValidator<AlphaDto>
    {
        public AlphaDtoValidator()
        {
            RuleFor(x => x.ModelName).NotEmpty().NotNull();
            RuleFor(x => x.ModelType).NotEmpty().NotNull();
            RuleFor(x => x.IsActive).NotNull();
            RuleFor(x => x.ChangeReason).NotNull().MaximumLength(20);
            RuleFor(x => x.ChangeReason).Must(y => y?.ToLower().Contains("abc") == true).WithMessage("abc!");
        }
    }
}
