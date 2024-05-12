using FluentValidation;
using WebFluentValidation.Models;

namespace WebFluentValidation.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required.");
            RuleFor(x => x.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(x => x.Height).ScalePrecision(1, 3);
            RuleFor(x => x.Age).InclusiveBetween(18, 50);

            RuleFor(x => x.Phone).Must(phone =>
                !string.IsNullOrEmpty(phone) && phone.StartsWith("+")
            ).WithMessage("Phone must starts with + sign.");
        }
    
    }
}
