using Application.Features.Categories.Dtos.Responses;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Results;
using MediatR;

namespace Application.Features.Categories.Queries.GetList;

public static class GetListCategory
{
    public sealed record Query() : IRequest<ReturnModel<List<GetListCategoryResponse>>>;
    
    
    public class Handler(ICategoryRepository categoryRepository, IMapper mapper)  : IRequestHandler<Query,ReturnModel<List<GetListCategoryResponse>>>
    {
        public async Task<ReturnModel<List<GetListCategoryResponse>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var categories =await categoryRepository.GetListAsync();

            var response = mapper.Map<List<GetListCategoryResponse>>(categories);

            return response;
        }
    }
}