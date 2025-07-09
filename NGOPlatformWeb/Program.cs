<<<<<<< HEAD
using Microsoft.AspNetCore.Authentication.Cookies;
=======
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
using Microsoft.EntityFrameworkCore;
using NGOPlatformWeb.Models.Entity;


var builder = WebApplication.CreateBuilder(args);

// Service registration
builder.Services.AddControllersWithViews();
<<<<<<< HEAD
builder.Services.AddSession();
// Â¥[Â¤J DbContext
builder.Services.AddDbContext<NGODbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NGODb")));
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.ExpireTimeSpan = TimeSpan.FromHours(2);
    });
=======

// ¥[¤J DbContext
builder.Services.AddDbContext<NGODbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NGODb")));

>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
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
<<<<<<< HEAD
app.UseSession();
app.UseAuthentication();
=======

>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
<<<<<<< HEAD
    pattern: "{controller=Activity}/{action=CaseActivityIndex}/{id?}");

app.Run();
=======
    pattern: "{controller=Case}/{action=CasePurchaseList}/{id?}");

app.Run();
>>>>>>> 452d115560186ede5e06399a128f6c33e3e05d78
