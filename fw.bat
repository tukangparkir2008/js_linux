@ECHO OFF
netsh advfirewall firewall show rule name="JIBAS_PORTS_1" > NUL 2>&1
IF %ERRORLEVEL% EQU 1 (
        netsh advfirewall firewall add rule name= "JIBAS_PORTS_1" dir=in action=allow protocol=TCP localport=80,3434,8100-8105
		ECHO "Berhasil menambahkan firewall rules"
) ELSE (
        ECHO "Firewall rules untuk JIBAS telah dibuat"
)