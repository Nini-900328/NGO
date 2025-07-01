using Caseshopping0625.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//目的：讓 ASP.NET Core 的 DI 系統知道要怎麼建立這個 DbContext。
//builder.Services.AddDbContext 會自動幫你建立資料庫連線
//.UseSqlServer(...) 指定連線方式與連線字串
builder.Services.AddDbContext<CaseShoppingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CaseShoppingContext")));

builder.Services.AddDbContext<ActivityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ActivityContext")));


// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Activity}/{action=Signup}/{id?}")
    .WithStaticAssets();


app.Run();
