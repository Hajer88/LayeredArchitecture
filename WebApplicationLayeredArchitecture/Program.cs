using Microsoft.EntityFrameworkCore;
using WebApplicationLayeredArchitecture.Models;
using WebApplicationLayeredArchitecture.Repositories;
using WebApplicationLayeredArchitecture.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connstring = builder.Configuration
    .GetConnectionString("Default");
builder.Services.AddDbContext<Appdbcontext>
    (options => options.UseSqlite(connstring));
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IMoviesGenericService, MoviesGenericService>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

