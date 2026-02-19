
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NewMicroService.File.Api.Features.File.Upload;
using NewMicroService.Shared.Extensions;

namespace NewMicroService.Discount.Api.Features.Discounts.CreateDiscount;

public static class UploadFileCommandEndpoint
{
    public static RouteGroupBuilder UploadFileGroupItemEndpoint(this RouteGroupBuilder group)
    {
        group.MapPost("/",
                async (IFormFile file, IMediator mediator) =>
                    (await mediator.Send(new UploadFileCommand(file))).ToGenericResult())
            .WithName("upload")
            .MapToApiVersion(1, 0)
            .Produces<Guid>(StatusCodes.Status201Created)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status500InternalServerError).DisableAntiforgery();

        return group;
    }
}