
using MediatR;
using NewMicroService.Shared.Extensions;
using NewMicroService.Shared.Filters;

namespace NewMicroService.Basket.Api.Features.Baskets.ApplyDiscountCoupon;

public static class ApplyDiscountCouponEndpoint
{
    public static RouteGroupBuilder ApplyDiscountCouponGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPut("/apply-discount-coupon",
                async (ApplyDiscountCouponCommand command, IMediator mediator) =>
                    (await mediator.Send(command)).ToGenericResult())
            .WithName("ApplyDiscountCoupon")
            .MapToApiVersion(1, 0)
            .AddEndpointFilter<ValidationFilter<ApplyDiscountCouponCommand>>();
        return group;
    }
}