using BlazorApp1.Server.Context;
using LocalizationServer.Shared;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddControllers();
//builder.Services.AddEntityFrameworkSqlServer()
//             .AddDbContext<ApplicationDbContext>(
//             options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database"))
//             );

builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionStrings:Database"]);

//builder.Services.AddScoped<ICartaoPontoService, CartaoPontoService>();
var app = builder.Build();
app.UseRequestLocalization("de");

// Register the locale service to localize the  SyncfusionBlazor components.

    
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

