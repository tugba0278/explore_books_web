using explore_books;
using explore_books.Pages.PROJECT;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using MySqlConnector;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDbContext<db>(options =>
{
    options.UseMySql("Server=192.168.213.242; Database=myDatabase; User=tuba; Password=29051453", ServerVersion.AutoDetect("Server=192.168.213.242; Database=myDatabase; User=tuba; Password=29051453"), null);
});
var app = builder.Build();


// Add services to the container.
builder.Services.AddRazorPages();
var firebaseConfig = builder.Configuration.GetSection("FirebaseConfig").Get<FirebaseConfig>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


