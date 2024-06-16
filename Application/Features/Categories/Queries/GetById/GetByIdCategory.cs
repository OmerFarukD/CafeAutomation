using Application.Features.Categories.Dtos.Responses;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Results;
using MediatR;
namespace Application.Features.Categories.Queries.GetById;

public static class GetByIdCategory
{
    public sealed record Query(Guid Id) : IRequest<ReturnModel<GetByIdCategoryResponse>>;
    
    public class Handler(ICategoryRepository categoryRepository, IMapper mapper) : IRequestHandler<Query,ReturnModel<GetByIdCategoryResponse>>
    {
        public async Task<ReturnModel<GetByIdCategoryResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var category = await categoryRepository.GetAsync(x => x.Id == request.Id, cancellationToken: cancellationToken);

            var response = mapper.Map<GetByIdCategoryResponse>(category);

            return (response);
        }
    }
}
