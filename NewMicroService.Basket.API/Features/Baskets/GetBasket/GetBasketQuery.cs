
using NewMicroService.Basket.Api.Dto;
using NewMicroService.Shared;

namespace NewMicroService.Basket.Api.Features.Baskets.GetBasket;

public record GetBasketQuery : ServiceResult.IRequestByServiceResult<BasketDto>;