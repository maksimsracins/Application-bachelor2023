using app_banking.Models;
using app_banking.Models.Interfaces;
using app_banking.Models.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*builder.Services.AddScoped<IUserRepository, MockUserRepository>();
builder.Services.AddScoped<IAccountRepository, MockAccountRepository>();*/

builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Configuration.Bind("Project", new Config());

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseMySQL(@Config.ConnectionString);

});


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
    pattern: "{controller=Dashboard}/{action=Statistics}/{id?}");

app.Run();
