using Application.Features.Categories.Dtos.Requests;
using Application.Features.Categories.Dtos.Responses;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Categories.Profiles;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<CreateCategoryRequestDto, Category>();
        CreateMap<Category, CreateCategoryResponse>();

        CreateMap<Category, GetListCategoryResponse>();
        CreateMap<Category, GetByIdCategoryResponse>();
    }
}