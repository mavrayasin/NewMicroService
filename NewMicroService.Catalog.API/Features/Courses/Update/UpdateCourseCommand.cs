namespace NewMicroService.Catalog.Api.Features.Courses.Update;

public record UpdateCourseCommand(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    string? PictureUrl,
    Guid CategoryId) : ServiceResult.IRequestByServiceResult;