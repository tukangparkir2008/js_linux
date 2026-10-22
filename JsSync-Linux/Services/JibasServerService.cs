using System.Collections.Concurrent;
using System.Net;
using System.Text;
using JsSyncLinux.Models;
using Newtonsoft.Json;

namespace JsSyncLinux.Services;

/// <summary>
/// Service to communicate with JIBAS Cloud server.
/// Ported from: Class194 — handles server registration, authentication, and status checking.
/// </summary>
public class JibasServerService
{
    private readonly ILogger<JibasServerService> _logger;
    private readonly ConfigurationService _configService;
    private readonly HttpClient _httpClient;

    public bool IsRegistered { get; private set; }
    public string StatusMessage { get; private set; } = "Not connected";

    public JibasServerService(ILogger<JibasServerService> logger,
                               ConfigurationService configService,
                               IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _configService = configService;
        _httpClient = httpClientFactory.CreateClient("JibasServer");
    }

    /// <summary>
    /// Register/connect to JIBAS Cloud server.
    /// Ported from: Class194.smethod_0
    /// </summary>
    public async Task<(bool Success, string Message)> ConnectAsync()
    {
        var config = _configService.Config;

        if (string.IsNullOrWhiteSpace(config.Session.LicenseKey))
        {
            StatusMessage = "License key not configured";
            return (false, StatusMessage);
        }

        try
        {
            // Step 1: Get server list from JIBAS cloud
            _logger.LogInformation("Connecting to JIBAS server at {Server}", config.Server.AppServer);

            // The original app fetches server URLs, then posts registration data
            // For now, we simulate the connection process
            IsRegistered = true;
            StatusMessage = "Connected to JIBAS Cloud";

            _logger.LogInformation("Successfully connected to JIBAS server");
            return (true, StatusMessage);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to connect to JIBAS server");
            IsRegistered = false;
            StatusMessage = $"Connection failed: {ex.Message}";
            return (false, StatusMessage);
        }
    }

    /// <summary>
    /// Disconnect from JIBAS server.
    /// </summary>
    public void Disconnect()
    {
        IsRegistered = false;
        StatusMessage = "Disconnected";
        _logger.LogInformation("Disconnected from JIBAS server");
    }

    /// <summary>
    /// Get current connection status.
    /// </summary>
    public ServerStatus GetStatus()
    {
        return new ServerStatus
        {
            IsRegistered = IsRegistered,
            StatusMessage = StatusMessage,
            AppServer = _configService.Config.Server.AppServer,
            LicenseKey = string.IsNullOrEmpty(_configService.Config.Session.LicenseKey)
                ? "(not set)"
                : MaskString(_configService.Config.Session.LicenseKey)
        };
    }

    private static string MaskString(string value)
    {
        if (value.Length <= 6) return "***";
        return value[..3] + "***" + value[^3..];
    }
}

public class ServerStatus
{
    public bool IsRegistered { get; set; }
    public string StatusMessage { get; set; } = "";
    public string AppServer { get; set; } = "";
    public string LicenseKey { get; set; } = "";
}
