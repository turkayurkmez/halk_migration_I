using basicDifferences.Services;

var builder = WebApplication.CreateBuilder(args);

//var builder = WebApplication.CreateBuilder(new WebApplicationOptions
//{
//    EnvironmentName = Environments.Production,
//    WebRootPath = "updatedwwwroot",
//    Args = args
//});




// Add services to the container.

//Eğer View (ekran) olacaksa:
builder.Services.AddControllersWithViews();
//Eğer REST API yazılıyorsa:
//builder.Services.AddControllers();
builder.Services.AddSession();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<IProductService, OzHakikiProductService>();
//builder.Configuration.
var connectionString = builder.Configuration.GetConnectionString("db");

builder.Logging.AddConsole();
//builder.Logging.AddJsonConsole();



var app = builder.Build();
//Dependency Injection olarak aldığınız instance'a aşağıdaki gibi erişebilirsiniz:
IProductService service = app.Services.GetRequiredService<IProductService>();
app.Logger.LogInformation($"servis içinde {service.GetProductNames().Count} eleman var: ${string.Join(",", service.GetProductNames().ToArray())}");

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


//Eğer 3.1'de databaseErrorPage kullandıysanız:
/*
 *  10. satırdaki servisi ekleyin.
 *  Aşağıdaki middleware'leri sırasıyla development moda ekleyin.
 *  
 */
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}


app.UseRouting();


/*
 * Dikkat!!!!
 * 3.1'de belirli bir URL adresine yönlendirme işlemi UseEndpoints middleware'i ile yapılırdı
 * 
 * app.UseEndpoints(builder => builder.MapGet("/test", () => "Merhaba"));
 * 
 * Fakat şimdi, WebApplication içerisinden erişilebiliyor:
 * 
 */

app.MapGet("/test", () => "Burasi test sayfasi");

app.UseCors();



app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
