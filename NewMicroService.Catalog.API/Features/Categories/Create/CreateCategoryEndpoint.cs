using MediatR;
using NewMicroService.Shared.Extensions;
using NewMicroService.Shared.Filters;

namespace NewMicroService.Catalog.API.Features.Categories.Create
{
    public static class CreateCategoryEndpoint
    {
        public static RouteGroupBuilder CreateCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/",
                    async (CreateCategoryCommand command, IMediator mediator) =>
                        (await mediator.Send(command)).ToGenericResult()).AddEndpointFilter<ValidationFilter<CreateCategoryCommand>>();
              
            return group;
        }
    }
}
