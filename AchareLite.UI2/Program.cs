using App.Domain.AppServices;
using App.Domain.Core.CategoryService.AppServices;
using App.Domain.Core.CategoryService.Data.Repositories;
using App.Domain.Core.CategoryService.Services;
using App.Domain.Services;
using App.Infra.DataAccess.Repo.Ef;
using App.Infra.DB.SqlServer.EF.DB_Achare.Ef;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryRepository, MainCategoryRepository>();
builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<ISubCategoryAppService, SubCategoryAppService>();

builder.Services.AddDbContext<AchareDbContext>(options
    => options.UseSqlServer(
        "Data Source =.; Initial Catalog = AchareCodefirst; Integrated Security = True; TrustServerCertificate = True"));

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
