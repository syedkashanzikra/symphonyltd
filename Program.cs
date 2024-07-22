using Microsoft.EntityFrameworkCore;
using SymphonyLtd.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcon"));
});

builder.Services.AddDistributedMemoryCache(); // Use a memory cache for session storage
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout.
    options.Cookie.HttpOnly = true; // Set the cookie to be HTTP-only.
    options.Cookie.IsEssential = true; // Make the session cookie essential.

});
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
app.UseSession(); // Add this to enable session management.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Admin}/{action=index}/{id?}");

app.Run();
