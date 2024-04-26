var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();

// Add Middleware to the pipelane.
var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

// Gelen requestion stringini yonlendirir.
app.MapDefaultControllerRoute();

app.UseStaticFiles(); // it access to use wwwroot files.

app.UseRouting();
app.UseEndpoints(endpoint => {
    endpoint.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
