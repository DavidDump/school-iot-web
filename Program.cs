var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSingleton<LedController>();

var app = builder.Build();

app.Urls.Add("http://localhost:5000");
app.Urls.Add("http://192.168.0.151:5000");
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.MapRazorPages();
app.Run();
