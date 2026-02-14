using NewMicroService.Catalog.API.Features.Courses.Create;
using NewMicroService.Catalog.API.Features.Courses.Dtos;
using NewMicroService.Shared.Filters;

namespace NewMicroService.Catalog.API.Features.Courses.GetAll
{
    public record GetAllCoursesQuery() : ServiceResult.IRequestByServiceResult<List<CourseDto>>;

    public class GetAllCoursesQueryHandler(AppDbContext context,IMapper mapper) : IRequestHandler<GetAllCoursesQuery, ServiceResult<List<CourseDto>>>
    {
 
        public async Task<ServiceResult<List<CourseDto>>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {

            var courses = await context.Courses.ToListAsync(cancellationToken:cancellationToken);
            var category = await context.Categories.ToListAsync(cancellationToken:cancellationToken);

            foreach (var course in courses)
            {
                course.Category = category.First(x => x.Id == course.CategoryId);
            }
            var courseAsDto = mapper.Map<List<CourseDto>>(courses);
            return ServiceResult<List<CourseDto>>.SuccessAsOk(courseAsDto);

        }
    }
    public static class GetAllCourseEndPoint
    {
        public static RouteGroupBuilder GetAllCourseGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapGet("/",
                    async (IMediator mediator) =>
                        (await mediator.Send(new GetAllCoursesQuery())).ToGenericResult())
                .WithName("GetAllCourses")
                .MapToApiVersion(1, 0);

            return group;
        }
    }
}
