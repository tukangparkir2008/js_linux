using JsSyncLinux.Services;

var builder = WebApplication.CreateBuilder(args);

// ─── Services Registration ─────────────────────────────────────

// Core services
builder.Services.AddSingleton<ConfigurationService>();
builder.Services.AddSingleton<DatabaseService>();
builder.Services.AddSingleton<JibasServerService>();
builder.Services.AddSingleton<AppStatusService>();

// TCP server as hosted background service
builder.Services.AddSingleton<TcpServerService>();
builder.Services.AddHostedService(sp => sp.GetRequiredService<TcpServerService>());

// HTTP client for JIBAS server communication
builder.Services.AddHttpClient("JibasServer");

// MVC controllers + JSON
builder.Services.AddControllers()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
    });

// ─── Build App ──────────────────────────────────────────────────

var app = builder.Build();

// ─── Load Configuration ─────────────────────────────────────────

var configService = app.Services.GetRequiredService<ConfigurationService>();
configService.Load();

// ─── Middleware Pipeline ────────────────────────────────────────

// Serve static files from wwwroot (dashboard HTML/CSS/JS)
app.UseDefaultFiles();
app.UseStaticFiles();

// API routes
app.MapControllers();

// Fallback to index.html for SPA-like navigation
app.MapFallbackToFile("index.html");

// ─── Start ──────────────────────────────────────────────────────

var webPort = configService.Config.Server.WebPort;
app.Urls.Add($"http://0.0.0.0:{webPort}");

app.Logger.LogInformation("═══════════════════════════════════════════════════");
app.Logger.LogInformation("  JIBAS SJS (JsSync-Linux) v1.0.0");
app.Logger.LogInformation("  Web Dashboard: http://localhost:{Port}", webPort);
app.Logger.LogInformation("  TCP Port: {TcpPort}", configService.Config.Server.TcpPort);
app.Logger.LogInformation("  DB Server: {DbServer}", configService.Config.Database.GetDisplayAddress());
app.Logger.LogInformation("═══════════════════════════════════════════════════");

app.Run();
