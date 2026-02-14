namespace NewMicroService.Catalog.API.Features.Courses.Create
{
    public record CreateCourseCommand(
        string Name,
        string Description,
        decimal Price,
        string? PictureUrl,
        Guid CategoryId) : ServiceResult.IRequestByServiceResult<Guid>;
}
