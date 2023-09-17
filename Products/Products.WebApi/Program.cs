using Microsoft.EntityFrameworkCore;
using Products.Business.Interfaces.Repositories;
using Products.Business.Interfaces.Services;
using Products.Business.Services;
using Products.Data;
using Products.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<ProductsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConecction"));
});

builder.Services.AddScoped<IProductsService, ProductsServices>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();

var app = builder.Build();



//builder.Services.AddScoped(typeof(IProductsService), typeof(ProductsServices));
//builder.Services.AddScoped(typeof(IProductsRepository), typeof(ProductsRepository));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
