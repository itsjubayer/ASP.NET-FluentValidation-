using FluentValidation;
using WebFluentValidation.Models;

namespace WebFluentValidation.Validators
{
    public class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            RuleFor(x => x.AddressLine1).NotNull().NotEmpty();
            RuleFor(x => x.Country).NotNull().NotEmpty();
            RuleFor(x => x.State).NotNull().NotEmpty();
            RuleFor(x => x.PostalCode).NotNull().NotEmpty();
        }
    }
}
