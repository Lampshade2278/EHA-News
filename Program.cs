using Microsoft.EntityFrameworkCore;
using EHA_News.Migration;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ArticleContextInfo>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ArticleContext")));

builder.Services.AddDbContext<AccountContextInfo>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountContext")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Article/Error"); 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Article}/{action=Index}/{id?}");

app.Run();
