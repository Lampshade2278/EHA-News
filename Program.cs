using Microsoft.EntityFrameworkCore;
using EHA_News.Migration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Add EF Core DbContexts
builder.Services.AddDbContext<ArticleContextInfo>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ArticleContext")));

builder.Services.AddDbContext<AccountContextInfo>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountContext")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Article/Error"); // Updated to handle errors in ArticleController
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Update the default controller route to ArticleController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Article}/{action=Index}/{id?}");

app.Run();
