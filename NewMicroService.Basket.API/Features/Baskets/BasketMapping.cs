
using AutoMapper;
using NewMicroService.Basket.Api.Data;
using NewMicroService.Basket.Api.Dto;

namespace NewMicroService.Basket.Api.Features.Baskets;

public class BasketMapping : Profile
{
    public BasketMapping()
    {
        CreateMap<BasketDto, Data.Basket>().ReverseMap();
        CreateMap<BasketItemDto, BasketItem>().ReverseMap();
    }
}