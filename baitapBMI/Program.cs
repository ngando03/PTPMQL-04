using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using tinhchisoMBI.Data;

var builder = WebApplication.CreateBuilder(args);
// ⚠ Gọi trước khi bất kỳ chỗ nào dùng ExcelPackage
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbcontext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("chisoBMI")));


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
    pattern: "{controller=chisoBMI}/{action=Index}/{id?}");

app.Run();
