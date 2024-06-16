using Application.Features.Categories.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Features.Categories.Rules;

public class CategoryBusinessRules(ICategoryRepository categoryRepository) : BaseBusinessRules
{

    public async Task CategoryNameMustBeUnique(string name)
    {
        var category = await categoryRepository.AnyAsync(x => x.Name == name);
        if (category)
        {
            throw new BusinessException(CategoryMessages.CategoryMustBeUnique);
        }
    }
    
    
    
}