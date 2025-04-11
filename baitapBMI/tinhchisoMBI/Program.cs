using Microsoft.EntityFrameworkCore;
using tinhchisoMBI.Models;
using tinhchisoMBI.Data;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình kết nối đến database (SQLite hoặc SQL Server tùy)
builder.Services.AddDbContext<ApplicationDbcontext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

// Thêm dịch vụ MVC
builder.Services.AddControllersWithViews();

// Ép môi trường thành Development để hiện lỗi rõ
Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

var app = builder.Build();

// ✅ Hiện lỗi chi tiết nếu đang ở môi trường Development
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // Nếu là production thì dùng error page riêng
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Cấu hình pipeline
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//  Cấu hình định tuyến cho các controller
app.MapControllerRoute(
    name: "home",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "employee",
    pattern: "employee/{action=Index}/{id?}",
    defaults: new { controller = "Employee" });

app.MapControllerRoute(
    name: "person",
    pattern: "person/{action=Index}/{id?}",
    defaults: new { controller = "Person" });

app.Run();
