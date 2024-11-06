using ECommerseAPI.Models;
using ECommerseAPI.Services;

var builder = WebApplication.CreateBuilder(args);
{
    // Configure services (DI)
    builder.Services.AddSingleton<IProductService, ProductService>();
    builder.Services.AddControllers();
}
var app = builder.Build();
{
    // configure request pipeline
    app.MapControllers();
}

app.Run();