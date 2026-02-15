using NewMicroService.Shared;

namespace NewMicroService.Basket.Api.Features.Baskets.DeleteBasketItem;

public record DeleteBasketItemCommand(Guid Id) : ServiceResult.IRequestByServiceResult;