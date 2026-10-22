using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal sealed class Class123
{
	private static string string_0 = Class84.smethod_0(-994103630);

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = byte_1;
		rijndael.IV = byte_2;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string smethod_1(string string_1)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_1);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return Convert.ToBase64String(smethod_0(bytes, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16)));
	}

	public static void smethod_2(string string_1, string string_2)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(string_2, FileMode.OpenOrCreate, FileAccess.Write);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		CryptoStream cryptoStream = new CryptoStream(stream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		int count = 4096;
		byte[] buffer = new byte[4096];
		int num;
		do
		{
			num = fileStream.Read(buffer, 0, count);
			cryptoStream.Write(buffer, 0, num);
		}
		while (num != 0);
		cryptoStream.Close();
		fileStream.Close();
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = byte_1;
		rijndael.IV = byte_2;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string smethod_4(string string_1)
	{
		byte[] byte_ = Convert.FromBase64String(string_1);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		byte[] bytes = smethod_3(byte_, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
		return Encoding.Unicode.GetString(bytes);
	}

	public static byte[] smethod_5(byte[] byte_0)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return smethod_3(byte_0, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
	}

	public static void smethod_6(string string_1, string string_2)
	{
		FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(string_2, FileMode.OpenOrCreate, FileAccess.Write);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		CryptoStream cryptoStream = new CryptoStream(stream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		int count = 4096;
		byte[] buffer = new byte[4096];
		int num;
		do
		{
			num = fileStream.Read(buffer, 0, count);
			cryptoStream.Write(buffer, 0, num);
		}
		while (num != 0);
		cryptoStream.Close();
		fileStream.Close();
	}
}
