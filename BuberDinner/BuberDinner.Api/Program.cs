using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
// Thiso scope for configuration or dependency injection
{
  builder.Services
      .AddApplication()
      .AddInfrastructure();
  builder.Services.AddControllers();
}

var app = builder.Build();

// request pipeline configuration
{
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}
