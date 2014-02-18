using System;
using System.Linq;
using FluentValidation;

namespace AspNetMvcTalk.Web.Models.Comments.Validation
{
    public class NewModelValidator : AbstractValidator<NewModel>
    {
        public NewModelValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.Text).NotEmpty().Length(1, 250);
            RuleFor(m => m.Favorite).Must(BeAMember)
                .WithMessage("You must select a favorite One Direction member");
        }

        private static bool BeAMember(NewModel newModel, string s)
        {
            return newModel.Members.Any(m => m.Value.Equals(s, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}