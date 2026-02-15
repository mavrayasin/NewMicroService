
using NewMicroService.Shared;

namespace NewMicroService.Basket.Api.Features.Baskets.ApplyDiscountCoupon;

public record ApplyDiscountCouponCommand(string Coupon, float DiscountRate) : ServiceResult.IRequestByServiceResult;