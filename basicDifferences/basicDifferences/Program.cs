var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Eğer View (ekran) olacaksa:
builder.Services.AddControllersWithViews();
//Eğer REST API yazılıyorsa:
//builder.Services.AddControllers();
builder.Services.AddSession();
//builder.Services.AddC
//builder.Configuration.
var connectionString = builder.Configuration.GetConnectionString("db");

builder.Logging.AddConsole();

var app = builder.Build();

app.Logger.LogInformation($"konfigürasyon dosyasındaki değer: {connectionString}");
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

app.UseCors();

app.UseExceptionHandler(new ExceptionHandlerOptions() { });

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
