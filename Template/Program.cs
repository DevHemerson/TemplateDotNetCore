using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Template.Application.Interfaces;
using Template.Application.Services;
using Template.Data.Context;
using Template.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var connetionString = builder.Configuration.GetConnectionString("TemplateDB") ?? string.Empty;

builder.Services.AddSqlServer<TemplateContext>(connetionString);

builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
