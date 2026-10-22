using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;

namespace JsSyncLinux.Services;

/// <summary>
/// TCP server service for handling Android client connections.
/// Ported from: Class319 (TcpServerService) + GClass54 (base TCP server) + GClass41 (client session).
///
/// The original app uses a custom TCP server with binary protocol:
///   - 4-byte length prefix (little-endian int32)
///   - Followed by serialized JsRequest payload
///   - Protocol routing via Class303 (ProtocolRouter)
/// </summary>
public class TcpServerService : BackgroundService
{
    private readonly ILogger<TcpServerService> _logger;
    private readonly ConfigurationService _configService;
    private TcpListener? _listener;

    // Track connected clients
    private readonly ConcurrentDictionary<string, ClientInfo> _clients = new();

    public int ConnectedClientsCount => _clients.Count;
    public IReadOnlyCollection<ClientInfo> ConnectedClients => _clients.Values.ToList().AsReadOnly();

    public TcpServerService(ILogger<TcpServerService> logger, ConfigurationService configService)
    {
        _logger = logger;
        _configService = configService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var port = _configService.Config.Server.TcpPort;

        // Check if port is available (ported from Class319.method_46)
        if (!IsPortAvailable(port))
        {
            _logger.LogError("TCP port {Port} is already in use", port);
            return;
        }

        _listener = new TcpListener(IPAddress.Any, port);

        try
        {
            _listener.Start();
            _logger.LogInformation("TCP server started on port {Port}", port);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var client = await _listener.AcceptTcpClientAsync(stoppingToken);
                    _ = HandleClientAsync(client, stoppingToken);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error accepting TCP client");
                }
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "TCP server error");
        }
        finally
        {
            _listener?.Stop();
            _logger.LogInformation("TCP server stopped");
        }
    }

    /// <summary>
    /// Handle individual client connection.
    /// Ported from: GClass41 (client session) — reads length-prefixed binary messages.
    /// </summary>
    private async Task HandleClientAsync(TcpClient tcpClient, CancellationToken ct)
    {
        var endpoint = tcpClient.Client.RemoteEndPoint?.ToString() ?? "unknown";
        var clientId = Guid.NewGuid().ToString("N")[..8];
        var clientInfo = new ClientInfo
        {
            Id = clientId,
            RemoteEndpoint = endpoint,
            ConnectedAt = DateTime.UtcNow
        };

        _clients.TryAdd(clientId, clientInfo);
        _logger.LogInformation("Client connected: {ClientId} from {Endpoint}", clientId, endpoint);

        try
        {
            using var stream = tcpClient.GetStream();
            var headerBuffer = new byte[4];

            while (!ct.IsCancellationRequested && tcpClient.Connected)
            {
                // Read 4-byte length prefix (ported from GClass41.vmethod_21)
                int bytesRead = await ReadFullAsync(stream, headerBuffer, 0, 4, ct);
                if (bytesRead < 4) break;

                int messageLength = BitConverter.ToInt32(headerBuffer, 0);
                if (messageLength <= 0 || messageLength > 50 * 1024 * 1024) // 50MB max
                {
                    _logger.LogWarning("Invalid message length from {ClientId}: {Length}", clientId, messageLength);
                    break;
                }

                // Read message body
                var bodyBuffer = new byte[messageLength];
                bytesRead = await ReadFullAsync(stream, bodyBuffer, 0, messageLength, ct);
                if (bytesRead < messageLength) break;

                clientInfo.LastActivityAt = DateTime.UtcNow;
                clientInfo.MessagesReceived++;

                // Process the message (protocol routing will be added in Fase 3)
                await ProcessMessageAsync(clientId, bodyBuffer, stream, ct);
            }
        }
        catch (Exception ex) when (ex is not OperationCanceledException)
        {
            _logger.LogError(ex, "Error handling client {ClientId}", clientId);
        }
        finally
        {
            _clients.TryRemove(clientId, out _);
            tcpClient.Close();
            _logger.LogInformation("Client disconnected: {ClientId}", clientId);
        }
    }

    /// <summary>
    /// Process received message — placeholder for ProtocolRouter integration.
    /// This is where Class303.smethod_0 will be called when protocol routing is implemented.
    /// </summary>
    private async Task ProcessMessageAsync(string clientId, byte[] data, NetworkStream stream, CancellationToken ct)
    {
        // TODO Fase 3: Deserialize JsRequest using BinSerializer and route via ProtocolRouter
        _logger.LogDebug("Received {Length} bytes from client {ClientId}", data.Length, clientId);

        // Echo back an acknowledgment (temporary)
        var ack = BitConverter.GetBytes(0); // Empty response
        await stream.WriteAsync(ack, ct);
    }

    /// <summary>
    /// Read exactly 'count' bytes from stream.
    /// </summary>
    private static async Task<int> ReadFullAsync(NetworkStream stream, byte[] buffer, int offset, int count, CancellationToken ct)
    {
        int totalRead = 0;
        while (totalRead < count)
        {
            int read = await stream.ReadAsync(buffer.AsMemory(offset + totalRead, count - totalRead), ct);
            if (read == 0) return totalRead;
            totalRead += read;
        }
        return totalRead;
    }

    /// <summary>
    /// Check if a port is available.
    /// Ported from: Class319.method_46
    /// </summary>
    private static bool IsPortAvailable(int port)
    {
        try
        {
            using var listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start();
            listener.Stop();
            return true;
        }
        catch
        {
            return false;
        }
    }
}

public class ClientInfo
{
    public string Id { get; set; } = "";
    public string RemoteEndpoint { get; set; } = "";
    public DateTime ConnectedAt { get; set; }
    public DateTime LastActivityAt { get; set; }
    public long MessagesReceived { get; set; }
}
