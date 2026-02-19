using static NewMicroService.Shared.ServiceResult;

namespace NewMicroService.Discount.Api.Features.Discounts.GetDiscountByCode;

public record GetDiscountByCodeQuery(string Code) : IRequestByServiceResult<GetDiscountByCodeQueryResponse>;