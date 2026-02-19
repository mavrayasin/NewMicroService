using NewMicroService.Discount.Api.Features.Discounts;
using NewMicroService.Discount.Api.Options;
using NewMicroService.Discount.Api.Repositories;
using NewMicroService.Discount.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOptionsExt();
builder.Services.AddDatabaseServiceExt();
builder.Services.AddCommonServiceExt(typeof(DiscountAssembly));
builder.Services.AddVersioningExt();
//builder.Services.AddAuthenticationAndAuthorizationExt(builder.Configuration);

var app = builder.Build();
app.AddDiscountGroupEndpointExt(app.AddVersionSetExt());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}


app.Run();

