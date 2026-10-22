/**
 * JsSync-Linux — Dashboard JavaScript
 * Handles API calls, page navigation, and real-time updates.
 */

// ─── API Helper ────────────────────────────────────────

async function api(method, endpoint, body = null) {
    const options = {
        method,
        headers: { 'Content-Type': 'application/json' }
    };
    if (body) options.body = JSON.stringify(body);

    try {
        const res = await fetch(`/api/${endpoint}`, options);
        return await res.json();
    } catch (err) {
        console.error(`API error: ${method} /api/${endpoint}`, err);
        showToast(`Gagal menghubungi server: ${err.message}`, 'error');
        return null;
    }
}

// ─── Page Navigation ───────────────────────────────────

document.querySelectorAll('.nav-item').forEach(item => {
    item.addEventListener('click', (e) => {
        e.preventDefault();
        const page = item.dataset.page;

        // Update nav active state
        document.querySelectorAll('.nav-item').forEach(n => n.classList.remove('active'));
        item.classList.add('active');

        // Show target page
        document.querySelectorAll('.page').forEach(p => p.classList.remove('active'));
        const targetPage = document.getElementById(`page-${page}`);
        if (targetPage) targetPage.classList.add('active');

        // Load page-specific data
        if (page === 'dashboard') refreshDashboard();
        if (page === 'config') loadConfig();
        if (page === 'logs') refreshLogs();
    });
});

// ─── Dashboard ─────────────────────────────────────────

async function refreshDashboard() {
    const data = await api('GET', 'dashboard');
    if (!data) return;

    // School info
    document.getElementById('schoolName').textContent = data.schoolName || '(Belum dikonfigurasi)';
    document.getElementById('schoolNpsn').textContent = data.npsn ? `NPSN: ${data.npsn}` : '';

    // Server status
    const serverStatusEl = document.getElementById('serverStatus');
    serverStatusEl.textContent = data.serverConnected ? 'Terhubung' : 'Terputus';
    document.getElementById('serverAddress').textContent = data.appServer || '';

    // Update global status indicator
    const globalStatus = document.getElementById('globalStatus');
    const statusDot = globalStatus.querySelector('.status-dot');
    const statusText = globalStatus.querySelector('span');
    if (data.serverConnected) {
        statusDot.className = 'status-dot online';
        statusText.textContent = 'Connected';
    } else {
        statusDot.className = 'status-dot offline';
        statusText.textContent = 'Disconnected';
    }

    // Database
    document.getElementById('dbStatus').textContent = data.dbServer || '—';
    document.getElementById('dbAddress').textContent = '';

    // TCP / Clients
    document.getElementById('clientCount').textContent = data.connectedClients || '0';
    document.getElementById('tcpPort').textContent = `Port: ${data.tcpPort}`;

    // Service status
    document.getElementById('uptime').textContent = formatUptime(data.uptime);
    document.getElementById('appVersion').textContent = data.version || '—';
    document.getElementById('delayNotif').textContent = `${data.timing?.delaySendNotif || 2000} ms`;

    // Client list
    const clientPanel = document.getElementById('clientListPanel');
    if (data.clientList && data.clientList.length > 0) {
        clientPanel.innerHTML = data.clientList.map(c => `
            <div class="client-item">
                <div class="client-info">
                    <span class="client-id">${c.id}</span>
                    <span class="client-endpoint">${c.remoteEndpoint}</span>
                </div>
                <span class="card-sub">${formatTimeAgo(c.connectedAt)}</span>
            </div>
        `).join('');
    } else {
        clientPanel.innerHTML = `
            <div class="empty-state">
                <svg width="48" height="48" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5" opacity="0.3">
                    <path d="M12 18h.01M8 21h8a2 2 0 002-2V5a2 2 0 00-2-2H8a2 2 0 00-2 2v14a2 2 0 002 2z"/>
                </svg>
                <p>Belum ada klien terhubung</p>
            </div>
        `;
    }
}

// ─── Configuration ─────────────────────────────────────

async function loadConfig() {
    const data = await api('GET', 'config');
    if (!data) return;

    // Database
    document.getElementById('cfgDbServer').value = data.database?.server || '';
    document.getElementById('cfgDbPort').value = data.database?.port || '';
    document.getElementById('cfgDbUser').value = data.database?.user || '';
    document.getElementById('cfgDbName').value = data.database?.database || '';

    // Server
    document.getElementById('cfgAppServer').value = data.server?.appServer || '';
    document.getElementById('cfgTcpPort').value = data.server?.tcpPort || '';
    document.getElementById('cfgWebPort').value = data.server?.webPort || '';

    // Timing
    document.getElementById('cfgDelay').value = data.timing?.delaySendNotif || 2000;
    document.getElementById('cfgAutoStart').checked = data.timing?.autoStart || false;
}

async function saveDatabaseConfig() {
    const config = {
        server: document.getElementById('cfgDbServer').value,
        port: document.getElementById('cfgDbPort').value,
        user: document.getElementById('cfgDbUser').value,
        password: document.getElementById('cfgDbPassword').value,
        database: document.getElementById('cfgDbName').value
    };

    const result = await api('PUT', 'config/database', config);
    if (result) showToast(result.message || 'Konfigurasi database disimpan', 'success');
}

async function saveServerConfig() {
    const config = {
        appServer: document.getElementById('cfgAppServer').value,
        tcpPort: parseInt(document.getElementById('cfgTcpPort').value) || 8105,
        webPort: parseInt(document.getElementById('cfgWebPort').value) || 5080
    };

    const result = await api('PUT', 'config/server', config);
    if (result) showToast(result.message || 'Konfigurasi server disimpan', 'success');
}

async function saveTimingConfig() {
    const config = {
        delaySendNotif: parseInt(document.getElementById('cfgDelay').value) || 2000,
        autoStart: document.getElementById('cfgAutoStart').checked
    };

    const result = await api('PUT', 'config/timing', config);
    if (result) showToast(result.message || 'Konfigurasi timing disimpan', 'success');
}

// ─── Actions ───────────────────────────────────────────

async function testDatabase() {
    showToast('Menguji koneksi database...', 'info');
    const result = await api('POST', 'database/test');
    if (result) {
        showToast(
            result.success ? '✓ Koneksi database berhasil!' : `✗ Gagal: ${result.message}`,
            result.success ? 'success' : 'error'
        );
    }
}

async function connectServer() {
    showToast('Menghubungkan ke server JIBAS...', 'info');
    const result = await api('POST', 'server/connect');
    if (result) {
        showToast(
            result.success ? '✓ Terhubung ke server JIBAS' : `✗ ${result.message}`,
            result.success ? 'success' : 'error'
        );
        refreshDashboard();
    }
}

async function disconnectServer() {
    const result = await api('POST', 'server/disconnect');
    if (result) {
        showToast('Server diputuskan', 'info');
        refreshDashboard();
    }
}

// ─── Logs ──────────────────────────────────────────────

async function refreshLogs() {
    const data = await api('GET', 'logs?count=100');
    const container = document.getElementById('logContainer');

    if (!data || data.length === 0) {
        container.innerHTML = '<div class="empty-state"><p>Belum ada log</p></div>';
        return;
    }

    container.innerHTML = data.map(log => `
        <div class="log-entry">
            <span class="log-time">${formatDate(log.timestamp)}</span>
            <span class="log-level ${log.level.toLowerCase()}">${log.level}</span>
            <span class="log-message">${escapeHtml(log.message)}</span>
        </div>
    `).join('');
}

// ─── Toast Notifications ───────────────────────────────

function showToast(message, type = 'info') {
    const container = document.getElementById('toastContainer');
    const toast = document.createElement('div');
    toast.className = `toast ${type}`;
    toast.textContent = message;
    container.appendChild(toast);

    setTimeout(() => toast.remove(), 3000);
}

// ─── Utility ───────────────────────────────────────────

function formatUptime(uptimeStr) {
    if (!uptimeStr) return '0d 0h 0m';

    // Parse .NET TimeSpan format: "HH:MM:SS" or "D.HH:MM:SS"
    const parts = uptimeStr.split(/[.:]/);
    if (parts.length >= 3) {
        let days = 0, hours = 0, mins = 0;
        if (parts.length === 4) {
            days = parseInt(parts[0]) || 0;
            hours = parseInt(parts[1]) || 0;
            mins = parseInt(parts[2]) || 0;
        } else {
            hours = parseInt(parts[0]) || 0;
            mins = parseInt(parts[1]) || 0;
        }
        return `${days}d ${hours}h ${mins}m`;
    }
    return uptimeStr;
}

function formatDate(dateStr) {
    if (!dateStr) return '';
    const d = new Date(dateStr);
    return d.toLocaleString('id-ID', {
        year: 'numeric', month: '2-digit', day: '2-digit',
        hour: '2-digit', minute: '2-digit', second: '2-digit'
    });
}

function formatTimeAgo(dateStr) {
    if (!dateStr) return '';
    const secs = Math.floor((Date.now() - new Date(dateStr).getTime()) / 1000);
    if (secs < 60) return `${secs}s ago`;
    if (secs < 3600) return `${Math.floor(secs / 60)}m ago`;
    return `${Math.floor(secs / 3600)}h ago`;
}

function escapeHtml(str) {
    const div = document.createElement('div');
    div.textContent = str;
    return div.innerHTML;
}

// ─── Auto-refresh ──────────────────────────────────────

// Refresh dashboard every 10 seconds
setInterval(() => {
    const activePage = document.querySelector('.page.active');
    if (activePage && activePage.id === 'page-dashboard') {
        refreshDashboard();
    }
}, 10000);

// Initial load
document.addEventListener('DOMContentLoaded', () => {
    refreshDashboard();
});
