using FluentValidation;

namespace Application.Features.Categories.Commands.Create;

public class CreateCategoryValidator : AbstractValidator<CreateCategory.Command>
{
    public CreateCategoryValidator()
    {
        RuleFor(x => x.Dto.Name)
            .NotEmpty()
            .NotNull();
    }
}