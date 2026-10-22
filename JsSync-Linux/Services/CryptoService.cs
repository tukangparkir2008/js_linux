using System.Security.Cryptography;
using System.Text;

namespace JsSyncLinux.Services;

/// <summary>
/// AES/Rijndael encryption service.
/// Ported from: Class123 — uses same key derivation for config.ini password compatibility.
/// The salt bytes spell "Ivan Medvedev" in ASCII, which is the original developer's identifier.
/// </summary>
public static class CryptoService
{
    // Original: Class84.smethod_0(-994103630) — the passphrase used for key derivation
    // This must match the original application's passphrase for password decryption compatibility
    private static readonly string Passphrase = "J1b@s_S3cur3_K3y";

    private static readonly byte[] Salt = { 73, 118, 97, 110, 32, 77, 101, 100, 118, 101, 100, 101, 118 };

    /// <summary>
    /// Encrypt a string using AES (Rijndael).
    /// Ported from: Class123.smethod_1
    /// </summary>
    public static string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText)) return string.Empty;

        byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);

#pragma warning disable SYSLIB0041 // PasswordDeriveBytes is obsolete
        using var pdb = new PasswordDeriveBytes(Passphrase, Salt);
        byte[] key = pdb.GetBytes(32);
        byte[] iv = pdb.GetBytes(16);
#pragma warning restore SYSLIB0041

        byte[] encrypted = EncryptBytes(plainBytes, key, iv);
        return Convert.ToBase64String(encrypted);
    }

    /// <summary>
    /// Decrypt a Base64-encoded encrypted string.
    /// Ported from: Class123.smethod_4
    /// </summary>
    public static string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText)) return string.Empty;

        try
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

#pragma warning disable SYSLIB0041
            using var pdb = new PasswordDeriveBytes(Passphrase, Salt);
            byte[] key = pdb.GetBytes(32);
            byte[] iv = pdb.GetBytes(16);
#pragma warning restore SYSLIB0041

            byte[] decrypted = DecryptBytes(cipherBytes, key, iv);
            return Encoding.Unicode.GetString(decrypted);
        }
        catch
        {
            // If decryption fails, return the original text (might be plaintext)
            return cipherText;
        }
    }

    /// <summary>
    /// Ported from: Class123.smethod_0 — raw byte encryption
    /// </summary>
    private static byte[] EncryptBytes(byte[] data, byte[] key, byte[] iv)
    {
        using var ms = new MemoryStream();
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        using var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
        cs.Write(data, 0, data.Length);
        cs.FlushFinalBlock();
        return ms.ToArray();
    }

    /// <summary>
    /// Ported from: Class123.smethod_3 — raw byte decryption
    /// </summary>
    private static byte[] DecryptBytes(byte[] data, byte[] key, byte[] iv)
    {
        using var ms = new MemoryStream();
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
        cs.Write(data, 0, data.Length);
        cs.FlushFinalBlock();
        return ms.ToArray();
    }
}
