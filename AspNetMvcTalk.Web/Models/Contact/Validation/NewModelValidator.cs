using FluentValidation;

namespace AspNetMvcTalk.Web.Models.Contact.Validation
{
    public class NewModelValidator : AbstractValidator<NewModel>
    {
        public NewModelValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Email).NotEmpty().EmailAddress();
            RuleFor(m => m.Message).NotEmpty();
        }
    }
}