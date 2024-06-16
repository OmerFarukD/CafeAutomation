using Application.Features.Categories.Dtos.Requests;
using Application.Features.Categories.Dtos.Responses;
using Application.Features.Categories.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Results;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create;

public static class CreateCategory
{
    public sealed record Command(CreateCategoryRequestDto Dto) : IRequest<ReturnModel<CreateCategoryResponse>>;
    
    
    public sealed class Handler(
        ICategoryRepository categoryRepository,
        IMapper mapper,
        CategoryBusinessRules businessRules)
        : IRequestHandler<Command, ReturnModel<CreateCategoryResponse>>
    {
    

        public async Task<ReturnModel<CreateCategoryResponse>> Handle(Command request, CancellationToken cancellationToken)
        {

            await businessRules.CategoryNameMustBeUnique(request.Dto.Name);
            
            var category = mapper.Map<Category>(request.Dto);

            category.Id = new Guid();

            var created =await categoryRepository.AddAsync(category);

            var response = mapper.Map<CreateCategoryResponse>(created);

            return (response);
        }
    }
    
}