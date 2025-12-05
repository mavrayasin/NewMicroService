using MediatR;
using NewMicroService.Shared;

namespace NewMicroService.Catalog.API.Features.Categories.Create
{
    public record CreateCategoryCommand(string Name): IRequest<ServiceResult<CreateCategoryResponse>>
    {
    }
}
