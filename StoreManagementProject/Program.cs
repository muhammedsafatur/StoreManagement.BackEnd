using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StoreManagementProject.Web.Api.Contexts;
using FluentValidation;
using FluentValidation.AspNetCore;
using StoreManagementProject.Web.Api.Repositories;
using StoreManagementProject.Web.Api.ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

// FluentValidation ve AutoMapper'� ekleyelim
builder.Services.AddControllers().AddFluentValidation(static fv =>
    fv.RegisterValidatorsFromAssemblyContaining<ProductDTOValidator>());

// AutoMapper servisini kaydet
builder.Services.AddAutoMapper(typeof(Program));

// DbContext'i kaydet
builder.Services.AddDbContext<MsSqlContext>();

// Swagger/OpenAPI yap�land�rmas�
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Dependency repository and services
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
var app = builder.Build();
// Development ortam�nda Swagger'� etkinle�tirelim
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

