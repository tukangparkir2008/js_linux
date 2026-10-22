using System.Data;
using MySqlConnector;

namespace JsSyncLinux.Services;

/// <summary>
/// MySQL database helper service.
/// Ported from: Class280 — provides CRUD operations using MySqlConnector (replaces MySql.Data).
/// </summary>
public class DatabaseService
{
    private readonly ILogger<DatabaseService> _logger;
    private readonly ConfigurationService _configService;
    private readonly List<string> _batchCommands = new();

    public DatabaseService(ILogger<DatabaseService> logger, ConfigurationService configService)
    {
        _logger = logger;
        _configService = configService;
    }

    private string ConnectionString => _configService.Config.Database.GetConnectionString();

    /// <summary>
    /// Test database connection.
    /// </summary>
    public async Task<(bool Success, string Message)> TestConnectionAsync()
    {
        try
        {
            await using var conn = new MySqlConnection(ConnectionString);
            await conn.OpenAsync();
            await conn.CloseAsync();
            return (true, "Connection successful");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Database connection test failed");
            return (false, ex.Message);
        }
    }

    /// <summary>
    /// Open a new connection (caller is responsible for closing).
    /// Ported from: Class280.smethod_0
    /// </summary>
    public async Task<MySqlConnection> OpenConnectionAsync()
    {
        var conn = new MySqlConnection(ConnectionString);
        await conn.OpenAsync();
        return conn;
    }

    /// <summary>
    /// Execute a non-query SQL command using existing connection.
    /// Ported from: Class280.smethod_1
    /// </summary>
    public async Task ExecuteNonQueryAsync(MySqlConnection conn, string sql)
    {
        try
        {
            await using var cmd = new MySqlCommand(sql, conn);
            await cmd.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteNonQuery failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Execute a non-query SQL command with auto-connection.
    /// Ported from: Class280.smethod_2
    /// </summary>
    public async Task ExecuteNonQueryAsync(string sql)
    {
        await using var conn = new MySqlConnection(ConnectionString);
        try
        {
            await conn.OpenAsync();
            await using var cmd = new MySqlCommand(sql, conn);
            await cmd.ExecuteNonQueryAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteNonQuery failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Execute scalar query with existing connection and default value.
    /// Ported from: Class280.smethod_3
    /// </summary>
    public async Task<object?> ExecuteScalarAsync(MySqlConnection conn, string sql, object? defaultValue = null)
    {
        try
        {
            await using var cmd = new MySqlCommand(sql, conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            return await reader.ReadAsync() ? reader[0] : defaultValue;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteScalar failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Execute scalar query with auto-connection.
    /// Ported from: Class280.smethod_5
    /// </summary>
    public async Task<object?> ExecuteScalarAsync(string sql)
    {
        await using var conn = new MySqlConnection(ConnectionString);
        try
        {
            await conn.OpenAsync();
            await using var cmd = new MySqlCommand(sql, conn);
            return await cmd.ExecuteScalarAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteScalar failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Execute query and return DataTable with existing connection.
    /// Ported from: Class280.smethod_6
    /// </summary>
    public async Task<DataTable> ExecuteQueryAsync(MySqlConnection conn, string sql)
    {
        try
        {
            await using var cmd = new MySqlCommand(sql, conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteQuery failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Execute query and return DataTable with auto-connection.
    /// Ported from: Class280.smethod_7
    /// </summary>
    public async Task<DataTable> ExecuteQueryAsync(string sql)
    {
        await using var conn = new MySqlConnection(ConnectionString);
        try
        {
            await conn.OpenAsync();
            await using var cmd = new MySqlCommand(sql, conn);
            await using var reader = await cmd.ExecuteReaderAsync();
            var table = new DataTable();
            table.Load(reader);
            return table;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "ExecuteQuery failed: {Sql}", sql);
            throw;
        }
    }

    /// <summary>
    /// Clear batch command list.
    /// Ported from: Class280.smethod_8
    /// </summary>
    public void BatchClear()
    {
        _batchCommands.Clear();
    }

    /// <summary>
    /// Add command to batch.
    /// Ported from: Class280.smethod_9
    /// </summary>
    public void BatchAdd(string sql)
    {
        _batchCommands.Add(sql);
    }

    /// <summary>
    /// Execute all batched commands in a transaction.
    /// Ported from: Class280.smethod_10
    /// </summary>
    public async Task BatchExecuteAsync()
    {
        await using var conn = new MySqlConnection(ConnectionString);
        MySqlTransaction? transaction = null;
        try
        {
            await conn.OpenAsync();
            transaction = await conn.BeginTransactionAsync(IsolationLevel.ReadCommitted);

            await using var cmd = new MySqlCommand { Connection = conn, Transaction = transaction };

            foreach (var sql in _batchCommands)
            {
                cmd.CommandText = sql;
                await cmd.ExecuteNonQueryAsync();
            }

            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            if (transaction != null)
                await transaction.RollbackAsync();
            _logger.LogError(ex, "Batch execute failed");
            throw;
        }
        finally
        {
            _batchCommands.Clear();
        }
    }

    /// <summary>
    /// Get database status info for dashboard.
    /// </summary>
    public async Task<DatabaseStatus> GetStatusAsync()
    {
        var status = new DatabaseStatus();
        try
        {
            await using var conn = new MySqlConnection(ConnectionString);
            await conn.OpenAsync();

            status.IsConnected = true;
            status.ServerVersion = conn.ServerVersion;

            // Get database name
            status.DatabaseName = _configService.Config.Database.Database;

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            status.IsConnected = false;
            status.ErrorMessage = ex.Message;
        }
        return status;
    }
}

public class DatabaseStatus
{
    public bool IsConnected { get; set; }
    public string ServerVersion { get; set; } = "";
    public string DatabaseName { get; set; } = "";
    public string ErrorMessage { get; set; } = "";
}
