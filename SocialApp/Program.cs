using Data.Context;
using IOC.DependencyContainer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region DBCONTEXT
builder.Services.AddDbContext<SocialDbContext>(options =>
{
    options.UseSqlServer
    (builder.Configuration.GetConnectionString("SocialAppConnectionString"));
});
#endregion

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("mypolicy", policy =>
    {
        policy.AllowAnyMethod()
        .AllowAnyHeader()
        .WithOrigins("http://localhost:3000");
    });
});

builder.Services.RegisterServices();  


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
app.UseCors("mypolicy");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
