using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NewMicroService.Catalog.API.Features.Categories.Dtos;
using NewMicroService.Catalog.API.Repositories;
using NewMicroService.Shared;
using NewMicroService.Shared.Extensions;

namespace NewMicroService.Catalog.API.Features.Categories.GetAll
{
    public class GetAllCategoriesQuery : IRequest<ServiceResult<List<CategoryDto>>>;

    public class GetAllCategoryQueryHandler(AppDbContext context, IMapper mapper)
        : IRequestHandler<GetAllCategoriesQuery, ServiceResult<List<CategoryDto>>>
    {
        public async Task<ServiceResult<List<CategoryDto>>> Handle(GetAllCategoriesQuery request,CancellationToken cancellationToken)
        {
            var categories = await context.Categories.ToListAsync(cancellationToken);
            var categoriesAsDto = mapper.Map<List<CategoryDto>>(categories);
            return ServiceResult<List<CategoryDto>>.SuccessAsOk(categoriesAsDto);
        }
    }

    public static class GetAllCategoriesEndpoint
    {
        public static RouteGroupBuilder GetAllCategoryGroupItemEndpoint(this RouteGroupBuilder group)
        {
            group.MapGet("/",
                    async (IMediator mediator) =>
                        (await mediator.Send(new GetAllCategoriesQuery())).ToGenericResult());


            return group;
        }
    }
}
