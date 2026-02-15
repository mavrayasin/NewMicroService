using Asp.Versioning.Builder;
using NewMicroService.Basket.Api.Features.Baskets.AddBasketItem;
using NewMicroService.Basket.Api.Features.Baskets.ApplyDiscountCoupon;
using NewMicroService.Basket.Api.Features.Baskets.DeleteBasketItem;
using NewMicroService.Basket.Api.Features.Baskets.GetBasket;
using NewMicroService.Basket.Api.Features.Baskets.RemoveDiscountCoupon;

namespace NewMicroService.Basket.Api.Features.Baskets;

public static class BasketEndpointExt
{
    public static void AddBasketGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/baskets").WithTags("Baskets")
            .WithApiVersionSet(apiVersionSet)
            .AddBasketItemGroupItemEndpoint()
            .DeleteBasketItemGroupItemEndpoint()
            .GetBasketGroupItemEndpoint()
            .ApplyDiscountCouponGroupItemEndpoint()
            .RemoveDiscountCouponGroupItemEndpoint()
            //.RequireAuthorization("Password")
            ;
    }
}