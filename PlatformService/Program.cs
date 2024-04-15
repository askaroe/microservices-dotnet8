using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseInMemoryDatabase("InMem");
});
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();


app.MapControllers();

PrepDb.PrepPopulation(app);

app.Run();