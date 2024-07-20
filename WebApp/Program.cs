var builder = WebApplication.CreateBuilder(args);

// Add services required by MapControllerRoute method to work
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure app to serve static files
app.UseStaticFiles();

// Configure routing service and middleware
app.UseRouting();

// Map default controller route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
