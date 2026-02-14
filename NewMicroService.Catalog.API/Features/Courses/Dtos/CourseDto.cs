namespace NewMicroService.Catalog.API.Features.Courses.Dtos
{
    public record CourseDto(Guid Id, string Name, string Description, decimal Price, string PictureUrl, CategoryDto Category, FeatureDto Feature);
}
