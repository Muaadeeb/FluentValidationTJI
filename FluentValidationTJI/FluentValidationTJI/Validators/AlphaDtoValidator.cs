using FluentValidation;
using FluentValidationTJI.Models.Dto;

namespace FluentValidationTJI.Validators
{
    public class AlphaDtoValidator : AbstractValidator<AlphaDto>
    {
        public AlphaDtoValidator()
        {
            Include(new AlphaDtoSimpleValidator());
            Include(new AlphaDtoComplexValidator());
        }
    }

    public class AlphaDtoSimpleValidator : AbstractValidator<AlphaDto>
    {
        public AlphaDtoSimpleValidator()
        {
            RuleFor(x => x.ModelName).NotEmpty().NotNull();
            RuleFor(x => x.ModelType).NotEmpty().NotNull();
            RuleFor(x => x.IsActive).NotNull();
            RuleFor(x => x.ChangeReason).NotNull().MaximumLength(20);
        }
    }

    public class AlphaDtoComplexValidator : AbstractValidator<AlphaDto>
    {
        public AlphaDtoComplexValidator()
        {
            RuleFor(x => x.ChangeReason).Must(y => y?.ToLower().Contains("abc") == true).WithMessage("abc!");
            RuleForEach(y => y.SomeString).SetValidator(new SomeStringValidator());
        }
    }


    public class SomeStringValidator : AbstractValidator<SomeString>
    {
        public SomeStringValidator()
        {
            RuleFor(x => x.someString).NotEmpty().NotNull();
        }
    }
}
