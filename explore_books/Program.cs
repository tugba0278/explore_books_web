using explore_books;
using explore_books.Pages.PROJECT;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using MySqlConnector;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<db>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(7, 0, 0)),
    mysqlOptions => mysqlOptions.EnableRetryOnFailure())); // MySQL sunucunuzun versiyonuna göre ayarlayın
var app = builder.Build();


// Add services to the container.
//var firebaseConfig = builder.Configuration.GetSection("FirebaseConfig").Get<FirebaseConfig>();



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


