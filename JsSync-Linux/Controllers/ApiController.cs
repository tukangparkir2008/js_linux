using JsSyncLinux.Models;
using JsSyncLinux.Services;
using Microsoft.AspNetCore.Mvc;

namespace JsSyncLinux.Controllers;

/// <summary>
/// REST API controller for the web dashboard.
/// Replaces GForm17 (Windows Forms main window) with HTTP endpoints.
/// </summary>
[ApiController]
[Route("api")]
public class ApiController : ControllerBase
{
    private readonly ConfigurationService _configService;
    private readonly DatabaseService _databaseService;
    private readonly JibasServerService _jibasServerService;
    private readonly AppStatusService _statusService;

    public ApiController(
        ConfigurationService configService,
        DatabaseService databaseService,
        JibasServerService jibasServerService,
        AppStatusService statusService)
    {
        _configService = configService;
        _databaseService = databaseService;
        _jibasServerService = jibasServerService;
        _statusService = statusService;
    }

    // ─── Dashboard ──────────────────────────────────────────────

    /// <summary>
    /// Get dashboard overview data.
    /// </summary>
    [HttpGet("dashboard")]
    public IActionResult GetDashboard()
    {
        return Ok(_statusService.GetDashboardData());
    }

    /// <summary>
    /// Get recent log entries.
    /// </summary>
    [HttpGet("logs")]
    public IActionResult GetLogs([FromQuery] int count = 50)
    {
        return Ok(_statusService.GetLogs(count));
    }

    // ─── Configuration ──────────────────────────────────────────

    /// <summary>
    /// Get current configuration (passwords masked).
    /// </summary>
    [HttpGet("config")]
    public IActionResult GetConfig()
    {
        var config = _configService.Config;
        return Ok(new
        {
            Database = new
            {
                config.Database.Server,
                config.Database.Port,
                config.Database.User,
                Password = string.IsNullOrEmpty(config.Database.Password) ? "" : "********",
                config.Database.Database
            },
            School = config.School,
            Server = config.Server,
            Timing = config.Timing,
            AdminPassword = string.IsNullOrEmpty(config.AdminPassword) ? "" : "********"
        });
    }

    /// <summary>
    /// Update database configuration.
    /// </summary>
    [HttpPut("config/database")]
    public IActionResult UpdateDatabaseConfig([FromBody] DatabaseConfig dbConfig)
    {
        _configService.Config.Database = dbConfig;
        _configService.Save();
        return Ok(new { message = "Database configuration updated" });
    }

    /// <summary>
    /// Update server configuration.
    /// </summary>
    [HttpPut("config/server")]
    public IActionResult UpdateServerConfig([FromBody] ServerConfig serverConfig)
    {
        _configService.Config.Server = serverConfig;
        _configService.Save();
        return Ok(new { message = "Server configuration updated" });
    }

    /// <summary>
    /// Update timing configuration.
    /// </summary>
    [HttpPut("config/timing")]
    public IActionResult UpdateTimingConfig([FromBody] TimingConfig timingConfig)
    {
        _configService.Config.Timing = timingConfig;
        _configService.Save();
        return Ok(new { message = "Timing configuration updated" });
    }

    // ─── Database ───────────────────────────────────────────────

    /// <summary>
    /// Test database connection.
    /// </summary>
    [HttpPost("database/test")]
    public async Task<IActionResult> TestDatabase()
    {
        var result = await _databaseService.TestConnectionAsync();
        return Ok(new { success = result.Success, message = result.Message });
    }

    /// <summary>
    /// Get database status.
    /// </summary>
    [HttpGet("database/status")]
    public async Task<IActionResult> GetDatabaseStatus()
    {
        var status = await _databaseService.GetStatusAsync();
        return Ok(status);
    }

    // ─── Server Connection ──────────────────────────────────────

    /// <summary>
    /// Connect to JIBAS cloud server.
    /// </summary>
    [HttpPost("server/connect")]
    public async Task<IActionResult> ConnectServer()
    {
        var result = await _jibasServerService.ConnectAsync();
        return Ok(new { success = result.Success, message = result.Message });
    }

    /// <summary>
    /// Disconnect from JIBAS server.
    /// </summary>
    [HttpPost("server/disconnect")]
    public IActionResult DisconnectServer()
    {
        _jibasServerService.Disconnect();
        return Ok(new { message = "Disconnected" });
    }

    /// <summary>
    /// Get server connection status.
    /// </summary>
    [HttpGet("server/status")]
    public IActionResult GetServerStatus()
    {
        return Ok(_jibasServerService.GetStatus());
    }
}
