using Caseshopping0625.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//�ت��G�� ASP.NET Core �� DI �t�Ϊ��D�n���إ߳o�� DbContext�C
//builder.Services.AddDbContext �|�۰����A�إ߸�Ʈw�s�u
//.UseSqlServer(...) ���w�s�u�覡�P�s�u�r��
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
