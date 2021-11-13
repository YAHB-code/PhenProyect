using PhenProyect.Context;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var serv= new MySqlServerVersion(new Version(10,4,17));
//inclusion del servicio de entity framework para usar base de datos mysql(una mierda hacer esto)
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySql(
         builder.Configuration.GetConnectionString(
             "AppDbConectionString"),serv));
//antes del builder se asigna la llamada al servicio ya murio el startup.cs
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
