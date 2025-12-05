using MongoDB.Driver;
using NewMicroService.Catalog.API.Options;
using NewMicroService.Catalog.API.Repositories;

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


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.Run();

