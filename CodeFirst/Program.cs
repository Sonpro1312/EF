using CodeFirst.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CompaniesDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CompaniesDatabase") ?? throw new InvalidOperationException("Connection string CompaniesDatabase not found."));
});
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.MapControllers();
app.Run();