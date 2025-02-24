using FluentValidation;
using LibraryBookServiceApi.Models.ApiModels;

namespace LibraryBookServiceApi.cs.Models.Validators
{
    public class BookApiModelValidator : AbstractValidator<BookApiModel>
    {
        DateTime now = DateTime.UtcNow.Date;
        public BookApiModelValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Title is mandatory");

            RuleFor(x => x.Author)
                .NotEmpty()
                .WithMessage("Author is mandatory");

            RuleFor(x => x.DateOfPublication)
                .LessThan(DateOnly.FromDateTime(now))
                .WithMessage("DateOfPublication should be in past");
        }
    }
}
