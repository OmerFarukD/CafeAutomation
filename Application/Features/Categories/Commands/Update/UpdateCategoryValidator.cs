using FluentValidation;

namespace Application.Features.Categories.Commands.Update;

public class UpdateCategoryValidator : AbstractValidator<UpdateCategory.Command>
{
    public UpdateCategoryValidator()
    {
        RuleFor(x => x.Dto.Name).NotEmpty().NotNull();
    }
}