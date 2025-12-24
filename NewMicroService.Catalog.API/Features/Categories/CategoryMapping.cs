using AutoMapper;
using NewMicroService.Catalog.API.Features.Categories.Dtos;

namespace NewMicroService.Catalog.API.Features.Categories
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
