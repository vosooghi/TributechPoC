using Ground.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddGroundNewtonSoftSerializer();

builder.Services.AddHttpClient("PoCWebAPI", c =>
{
    c.BaseAddress = new Uri("http://localhost:8080/api/");
});
builder.Services.AddHttpClient("testPlatform", c =>
{
    c.BaseAddress = new Uri("https://testplatform.io/values/double?");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
