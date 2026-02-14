using NewMicroService.Shared.Filters;
using Refit;

namespace NewMicroService.Catalog.API.Features.Courses.Create
{
    public static class CreateCourseCommandEndpoint
    {
        public static RouteGroupBuilder CreateCourseGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapPost("/",
                    async (CreateCourseCommand command, IMediator mediator) =>
                        (await mediator.Send(command)).ToGenericResult())
                .WithName("CreateCourse")
                .Produces<Guid>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status404NotFound)
                .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
                .Produces<ProblemDetails>(StatusCodes.Status500InternalServerError)
                .MapToApiVersion(1, 0)
                .AddEndpointFilter<ValidationFilter<CreateCourseCommand>>();

            return group;
        }
    }
}
