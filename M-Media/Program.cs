using M_Media.ModelInterfaces;
using M_Media.Models;
using M_Media.ViewModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IText, TextViewModel>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MMediaDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:MMediaDbContext"]);
});

var app = builder.Build();

if(app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseStaticFiles();
app.MapDefaultControllerRoute();
DBInitializer.Send(app);
app.Run();
