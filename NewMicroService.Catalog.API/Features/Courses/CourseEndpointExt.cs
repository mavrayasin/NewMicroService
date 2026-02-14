using Asp.Versioning.Builder;
using NewMicroService.Catalog.Api.Features.Courses.Delete;
using NewMicroService.Catalog.Api.Features.Courses.GetAllByUserId;
using NewMicroService.Catalog.Api.Features.Courses.Update;
using NewMicroService.Catalog.API.Features.Courses.Create;
using NewMicroService.Catalog.API.Features.Courses.GetAll;
using NewMicroService.Catalog.API.Features.Courses.GetById;

namespace NewMicroService.Catalog.API.Features.Courses
{
    public static class CourseEndpointExt
    {
        public static void AddCourseGroupEndpointExt(this WebApplication app, ApiVersionSet apiVersionSet)
        {
            app.MapGroup("api/v{version:apiVersion}/courses").WithTags("Courses").WithApiVersionSet(apiVersionSet)
                .CreateCourseGroupItemEndpoint()
                .GetAllCourseGroupItemEndpoint()
                .GetByIdCourseGroupItemEndpoint()
                .UpdateCourseGroupItemEndpoint()
                .DeleteCourseGroupItemEndpoint()
                .GetByUserIdCourseGroupItemEndpoint();
        }
    }
}
