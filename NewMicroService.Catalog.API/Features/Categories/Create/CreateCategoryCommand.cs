
namespace NewMicroService.Catalog.API.Features.Categories.Create
{
    public record CreateCategoryCommand(string Name) : ServiceResult.IRequestByServiceResult<CreateCategoryResponse>
    {
    }
}
