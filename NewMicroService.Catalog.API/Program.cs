using NewMicroService.Catalog.API;
using NewMicroService.Catalog.API.Features.Categories;
using NewMicroService.Catalog.API.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddOptions<MongoOption>()
//    .BindConfiguration(nameof(MongoOption))
//    .ValidateDataAnnotations()
//    .ValidateOnStart();

builder.Services.AddOptionsExt();
//builder.Services.AddSingleton<IMongoClient>(sp =>
//{
//    var mongoOption = sp.GetRequiredService<MongoOption>();
//    return new MongoClient(mongoOption.ConnectionString);
//});
//builder.Services.AddScoped<AppDbContext>(sp =>
//{
//    var mongoOption = sp.GetRequiredService<MongoOption>();
//    var mongoClient = sp.GetRequiredService<IMongoClient>();
//    var database = mongoClient.GetDatabase(mongoOption.DatabaseName);
//    return AppDbContext.Create(database);
//});
builder.Services.AddDatabaseServiceExt();

//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<CreateCategoryCommand>());
builder.Services.AddCommonServiceExt(typeof(CatalogAssembly));


var app = builder.Build();

//app.MapPost("/categories", async (CreateCategoryCommand command, IMediator mediator) =>
//{
//  var result = await mediator.Send(command);

//    return new ObjectResult(result)
//    {
//        StatusCode = result.Status.GetHashCode()
//    };

//});
app.AddCategoryGroupEndpointExt();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


await app.RunAsync();

