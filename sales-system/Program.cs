using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sales_system.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<sales_systemContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("sales_systemContext"),
    new MySqlServerVersion(new Version(9, 0, 1)),
    mySqlOptions => mySqlOptions.MigrationsAssembly("sales-system")));

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
