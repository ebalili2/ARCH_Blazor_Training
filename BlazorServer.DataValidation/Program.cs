using BlazorServer.DataValidation.Helpers;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ConfirmDialogHelper>();

var baseDir = AppDomain.CurrentDomain.BaseDirectory;
var logFile = Path.Combine(baseDir, "Logs", "log.txt");
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .WriteTo.File(logFile, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 90)
    .CreateLogger();
builder.Services.AddLogging(log =>
{
    log.AddSerilog(logger);
});

LogHelper.Initiate(logger);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
