using Application.Features.Categories.Dtos.Requests;
using Application.Features.Categories.Dtos.Responses;
using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Results;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Update;

public static class UpdateCategory
{
    public sealed record Command(UpdateCategoryRequestDto Dto) : IRequest<ReturnModel<UpdateCategoryResponse>>;
    
    
    public class Handler(ICategoryRepository categoryRepository,
        IMapper mapper,
        CategoryBusinessRules businessRules
        ) : IRequestHandler<Command,ReturnModel<UpdateCategoryResponse>>
    {
        public async Task<ReturnModel<UpdateCategoryResponse>> Handle(Command request, CancellationToken cancellationToken)
        {
            await businessRules.CategoryNameMustBeUnique(request.Dto.Name);
            var category = mapper.Map<Category>(request.Dto);

            var updated = await categoryRepository.UpdateAsync(category);

            var response = mapper.Map<UpdateCategoryResponse>(updated);

            return response;
        }
    }
}