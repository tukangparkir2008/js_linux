namespace JsSyncLinux.Models;

/// <summary>
/// Database connection configuration.
/// Mapped from: Class224.Class228
/// </summary>
public class DatabaseConfig
{
    public string Server { get; set; } = "localhost";
    public string Port { get; set; } = "3434";
    public string User { get; set; } = "root";
    public string Password { get; set; } = "";
    public string Database { get; set; } = "jbsakad";

    /// <summary>
    /// Build MySQL connection string using MySqlConnector format.
    /// Original: Class228.smethod_0() → "Server={0};Port={1};Uid={2};Pwd={3};Database={4}"
    /// </summary>
    public string GetConnectionString()
    {
        return $"Server={Server};Port={Port};Uid={User};Pwd={Password};Database={Database};";
    }

    /// <summary>
    /// Returns server:port display string.
    /// Original: Class228.smethod_1()
    /// </summary>
    public string GetDisplayAddress()
    {
        return $"{Server}:{Port}";
    }
}

/// <summary>
/// School identity configuration.
/// Mapped from: Class224.Class227
/// </summary>
public class SchoolConfig
{
    /// <summary>Original: string_0 — NPSN (School ID)</summary>
    public string Npsn { get; set; } = "";

    /// <summary>Original: string_1 — School Name</summary>
    public string SchoolName { get; set; } = "";

    /// <summary>Original: string_2 — Academic Year</summary>
    public string AcademicYear { get; set; } = "";

    /// <summary>Original: string_3 — City</summary>
    public string City { get; set; } = "";

    /// <summary>Original: string_4 — Province</summary>
    public string Province { get; set; } = "";

    /// <summary>Original: string_5 — NPSN 2</summary>
    public string Npsn2 { get; set; } = "";

    /// <summary>Original: string_6 — School Level (SD/SMP/SMA)</summary>
    public string Level { get; set; } = "";

    /// <summary>Original: string_7 — Token</summary>
    public string Token { get; set; } = "";

    /// <summary>Original: string_8 — Secret</summary>
    public string Secret { get; set; } = "";

    /// <summary>Original: int_0 — Active Year</summary>
    public int ActiveYear { get; set; } = 2022;

    /// <summary>
    /// Display name: NPSN - SchoolName - Province
    /// Original: Class227.smethod_0()
    /// </summary>
    public string GetDisplayName()
    {
        return $"{Npsn} - {SchoolName} - {Province}";
    }
}

/// <summary>
/// JIBAS cloud server configuration.
/// Mapped from: Class224.Class229
/// </summary>
public class ServerConfig
{
    /// <summary>Original: string_0 — App server address</summary>
    public string AppServer { get; set; } = "localhost";

    /// <summary>Original: int_0 — TCP port for Android connections</summary>
    public int TcpPort { get; set; } = 8105;

    /// <summary>Web dashboard port (new for Linux version)</summary>
    public int WebPort { get; set; } = 5080;
}

/// <summary>
/// Timing/intervals configuration.
/// Mapped from: Class224.Class226
/// </summary>
public class TimingConfig
{
    /// <summary>Original: int_0 — Connection timeout (ms)</summary>
    public int ConnectionTimeout { get; set; } = 60000;

    /// <summary>Original: int_1 — Retry interval (ms)</summary>
    public int RetryInterval { get; set; } = 3000;

    /// <summary>Original: int_2 — Heartbeat interval (ms)</summary>
    public int HeartbeatInterval { get; set; } = 180000;

    /// <summary>Original: int_3 — Sync interval (ms)</summary>
    public int SyncInterval { get; set; } = 180000;

    /// <summary>Original: int_4 — Reconnect interval (ms)</summary>
    public int ReconnectInterval { get; set; } = 600000;

    /// <summary>Original: int_5 — Ping interval (ms)</summary>
    public int PingInterval { get; set; } = 60000;

    /// <summary>Original: int_9 — Token refresh interval (45 mins)</summary>
    public int TokenRefreshInterval { get; set; } = 2700000;

    /// <summary>Original: int_11 — Delay send notification (ms)</summary>
    public int DelaySendNotif { get; set; } = 2000;

    /// <summary>Original: bool_0 — Auto start on boot</summary>
    public bool AutoStart { get; set; } = false;
}

/// <summary>
/// FCM / Firebase configuration.
/// Mapped from: Class224.Class233 + Class348
/// </summary>
public class FcmConfig
{
    /// <summary>Original: Class233.string_0 — FCM Project ID</summary>
    public string ProjectId { get; set; } = "";

    /// <summary>Original: Class233.string_1 — Sender ID</summary>
    public string SenderId { get; set; } = "";

    /// <summary>Original: Class233.string_2 — API Key</summary>
    public string ApiKey { get; set; } = "";

    /// <summary>Original: Class233.string_3 — Firebase Messaging URL</summary>
    public string MessagingUrl { get; set; } = "https://fcm.googleapis.com/v1/projects/{0}/messages:send";

    /// <summary>FCM API scope for OAuth2</summary>
    public string Scope { get; set; } = "https://www.googleapis.com/auth/firebase.messaging";

    /// <summary>Path to service-account JSON file</summary>
    public string ServiceAccountPath { get; set; } = "fcm-service-account.json";
}

/// <summary>
/// Session/registration info from JIBAS server.
/// Mapped from: Class348
/// </summary>
public class SessionConfig
{
    /// <summary>Original: Class352.string_0 — License key</summary>
    public string LicenseKey { get; set; } = "";

    /// <summary>Original: Class352.string_2 — Registration token</summary>
    public string RegistrationToken { get; set; } = "";

    /// <summary>Original: Class349.bool_0 — Connection established</summary>
    public bool IsConnected { get; set; } = false;
}

/// <summary>
/// Root configuration model — aggregates all sub-configs.
/// </summary>
public class AppConfig
{
    public DatabaseConfig Database { get; set; } = new();
    public SchoolConfig School { get; set; } = new();
    public ServerConfig Server { get; set; } = new();
    public TimingConfig Timing { get; set; } = new();
    public FcmConfig Fcm { get; set; } = new();
    public SessionConfig Session { get; set; } = new();
    public string AdminPassword { get; set; } = "";
}
