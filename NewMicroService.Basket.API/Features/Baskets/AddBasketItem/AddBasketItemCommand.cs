
using NewMicroService.Shared;
namespace NewMicroService.Basket.Api.Features.Baskets.AddBasketItem;

public record AddBasketItemCommand(Guid CourseId, string CourseName, decimal CoursePrice, string? ImageUrl)
    : ServiceResult.IRequestByServiceResult;