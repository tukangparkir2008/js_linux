using JsSyncLinux.Models;

namespace JsSyncLinux.Services;

/// <summary>
/// Reads/writes configuration from config.ini file.
/// Ported from: Class205 — INI-style config file parser.
/// 
/// Original config.ini format:
///   DBSERVER = localhost
///   DBPORT = 3434
///   DBUSER = root
///   DBPASSWORD = (encrypted base64)
///   APPSERVER = localhost
///   AUTOSTART = False
///   ADMINPASSWORD = (encrypted base64)
///   DELAYSENDNOTIF = 2000
/// </summary>
public class ConfigurationService
{
    private readonly ILogger<ConfigurationService> _logger;
    private readonly string _configPath;
    private AppConfig _config = new();

    public AppConfig Config => _config;

    public ConfigurationService(ILogger<ConfigurationService> logger, IConfiguration appSettings)
    {
        _logger = logger;

        // Config file path — same directory as executable, or override via appsettings
        var configDir = appSettings["ConfigDirectory"]
                        ?? AppContext.BaseDirectory;
        _configPath = Path.Combine(configDir, "config.ini");
    }

    /// <summary>
    /// Load configuration from config.ini.
    /// Ported from: Class205.smethod_0
    /// </summary>
    public void Load()
    {
        if (!File.Exists(_configPath))
        {
            _logger.LogWarning("Config file not found at {Path}, using defaults", _configPath);
            return;
        }

        _logger.LogInformation("Loading config from {Path}", _configPath);

        using var reader = new StreamReader(_configPath);
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            line = line.Trim();

            // Skip empty lines and comments
            if (line.Length == 0 || line.StartsWith("#"))
                continue;

            int eqIdx = line.IndexOf('=');
            if (eqIdx < 0)
                continue;

            string key = line[..eqIdx].Trim();
            string value = line[(eqIdx + 1)..].Trim();

            switch (key)
            {
                // Database config — maps to Class224.Class228
                case "DBSERVER":
                    _config.Database.Server = value;
                    break;
                case "DBPORT":
                    _config.Database.Port = value;
                    break;
                case "DBUSER":
                    _config.Database.User = value;
                    break;
                case "DBPASSWORD":
                    _config.Database.Password = DecryptValue(value);
                    break;

                // Server config — maps to Class224.Class229
                case "APPSERVER":
                    _config.Server.AppServer = value;
                    break;

                // Timing/behavior — maps to Class224.Class226
                case "AUTOSTART":
                    _config.Timing.AutoStart = ParseBool(value);
                    break;
                case "ADMINPASSWORD":
                    _config.AdminPassword = DecryptValue(value);
                    break;
                case "DELAYSENDNOTIF":
                    _config.Timing.DelaySendNotif = ParseDelay(value);
                    break;
            }
        }

        _logger.LogInformation("Config loaded. DB={Server}:{Port}, AppServer={AppServer}",
            _config.Database.Server, _config.Database.Port, _config.Server.AppServer);
    }

    /// <summary>
    /// Save configuration back to config.ini.
    /// Ported from: Class205.smethod_1
    /// </summary>
    public void Save()
    {
        _logger.LogInformation("Saving config to {Path}", _configPath);

        using var writer = new StreamWriter(_configPath, false);
        writer.WriteLine("#-----------------------------------------------------");
        writer.WriteLine("# JIBAS SINKRONISASI JENDELA SEKOLAH CONFIGURATION");
        writer.WriteLine("#-----------------------------------------------------");
        writer.WriteLine();
        writer.WriteLine($"DBSERVER = {_config.Database.Server}");
        writer.WriteLine($"DBPORT = {_config.Database.Port}");
        writer.WriteLine($"DBUSER = {_config.Database.User}");
        writer.WriteLine($"DBPASSWORD = {EncryptValue(_config.Database.Password)}");
        writer.WriteLine();
        writer.WriteLine($"APPSERVER = {_config.Server.AppServer}");
        writer.WriteLine();
        writer.WriteLine($"AUTOSTART = {_config.Timing.AutoStart}");
        writer.WriteLine($"ADMINPASSWORD = {EncryptValue(_config.AdminPassword)}");
        writer.WriteLine();
        writer.WriteLine($"DELAYSENDNOTIF = {_config.Timing.DelaySendNotif}");

        _logger.LogInformation("Config saved");
    }

    /// <summary>
    /// Update config from an external AppConfig object (e.g., from web API).
    /// </summary>
    public void Update(AppConfig newConfig)
    {
        _config = newConfig;
        Save();
    }

    private static string DecryptValue(string value)
    {
        return string.IsNullOrEmpty(value) ? string.Empty : CryptoService.Decrypt(value);
    }

    private static string EncryptValue(string value)
    {
        return string.IsNullOrEmpty(value) ? string.Empty : CryptoService.Encrypt(value);
    }

    /// <summary>
    /// Ported from: Class159.smethod_3 — parse boolean string
    /// </summary>
    private static bool ParseBool(string value)
    {
        return value.Equals("True", StringComparison.OrdinalIgnoreCase)
               || value.Equals("1", StringComparison.Ordinal);
    }

    /// <summary>
    /// Ported from: Class205 inline — only allow specific delay values (1000-5000 in steps of 1000)
    /// </summary>
    private static int ParseDelay(string value)
    {
        if (int.TryParse(value, out int delay))
        {
            if (delay is 1000 or 2000 or 3000 or 4000 or 5000)
                return delay;
        }
        return 2000; // default
    }
}
