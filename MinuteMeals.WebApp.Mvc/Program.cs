using Microsoft.EntityFrameworkCore;
using MinuteMeals.WebApp.Mvc.Database;


var builder = WebApplication.CreateBuilder(args);


// We voegen de InMemory Database en DbContext service toe
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("RecipeDatabase"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// initialiseren db
DatabaseInitializer.SeedData(app);

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
