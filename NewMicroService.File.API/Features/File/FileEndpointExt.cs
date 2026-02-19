
using Asp.Versioning.Builder;
using NewMicroService.Discount.Api.Features.Discounts.CreateDiscount;
using NewMicroService.File.Api.Features.File.Delete;

namespace NewMicroService.File.Api.Features.File;

public static class FileEndpointExt
{
    public static void AddFileGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
    {
        app.MapGroup("api/v{version:apiVersion}/files").WithTags("files").WithApiVersionSet(apiVersionSet)
            .UploadFileGroupItemEndpoint().DeleteFileGroupItemEndpoint()//.RequireAuthorization()
            ;
    }
}