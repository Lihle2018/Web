using Web.Services;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); ;
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddScoped<FirebaseService>();
builder.Services.AddScoped<EmailService>();
var app = builder.Build();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.MapControllerRoute(
    name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
