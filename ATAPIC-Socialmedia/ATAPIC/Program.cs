using ATAPIC.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ISocialService, MockSocialService>();

var app = builder.Build();

// Middleware
app.UseStaticFiles(); // <<✅ now placed after app is declared
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Socials}/{action=Index}/{id?}");

app.Run();
