namespace JsSyncLinux.Services;

/// <summary>
/// Application-wide status tracking service.
/// Replaces the scattered state tracking across GForm17, Class348, etc.
/// </summary>
public class AppStatusService
{
    private readonly ConfigurationService _configService;
    private readonly DatabaseService _databaseService;
    private readonly JibasServerService _jibasServerService;
    private readonly TcpServerService _tcpServerService;

    private DateTime _startedAt = DateTime.UtcNow;
    private readonly List<LogEntry> _logEntries = new();
    private readonly object _logLock = new();

    public AppStatusService(
        ConfigurationService configService,
        DatabaseService databaseService,
        JibasServerService jibasServerService,
        TcpServerService tcpServerService)
    {
        _configService = configService;
        _databaseService = databaseService;
        _jibasServerService = jibasServerService;
        _tcpServerService = tcpServerService;
    }

    public void AddLog(string level, string source, string message)
    {
        lock (_logLock)
        {
            _logEntries.Add(new LogEntry
            {
                Timestamp = DateTime.UtcNow,
                Level = level,
                Source = source,
                Message = message
            });

            // Keep last 500 entries
            if (_logEntries.Count > 500)
                _logEntries.RemoveAt(0);
        }
    }

    public List<LogEntry> GetLogs(int count = 50)
    {
        lock (_logLock)
        {
            return _logEntries
                .OrderByDescending(l => l.Timestamp)
                .Take(count)
                .ToList();
        }
    }

    public DashboardData GetDashboardData()
    {
        var serverStatus = _jibasServerService.GetStatus();

        return new DashboardData
        {
            // App status
            Uptime = DateTime.UtcNow - _startedAt,
            Version = "1.0.0-linux",

            // School info
            SchoolName = _configService.Config.School.SchoolName,
            Npsn = _configService.Config.School.Npsn,
            AcademicYear = _configService.Config.School.AcademicYear,

            // Connection status
            ServerConnected = serverStatus.IsRegistered,
            ServerMessage = serverStatus.StatusMessage,
            AppServer = serverStatus.AppServer,

            // TCP status
            TcpPort = _configService.Config.Server.TcpPort,
            ConnectedClients = _tcpServerService.ConnectedClientsCount,
            ClientList = _tcpServerService.ConnectedClients.ToList(),

            // Database
            DbServer = _configService.Config.Database.GetDisplayAddress(),

            // Recent logs
            RecentLogs = GetLogs(20)
        };
    }
}

public class DashboardData
{
    public TimeSpan Uptime { get; set; }
    public string Version { get; set; } = "";
    public string SchoolName { get; set; } = "";
    public string Npsn { get; set; } = "";
    public string AcademicYear { get; set; } = "";
    public bool ServerConnected { get; set; }
    public string ServerMessage { get; set; } = "";
    public string AppServer { get; set; } = "";
    public int TcpPort { get; set; }
    public int ConnectedClients { get; set; }
    public List<ClientInfo> ClientList { get; set; } = new();
    public string DbServer { get; set; } = "";
    public List<LogEntry> RecentLogs { get; set; } = new();
}

public class LogEntry
{
    public DateTime Timestamp { get; set; }
    public string Level { get; set; } = "";
    public string Source { get; set; } = "";
    public string Message { get; set; } = "";
}
