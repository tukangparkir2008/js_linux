using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public sealed class GClass37
{
	public static byte[] smethod_0(string string_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		MemoryStream memoryStream = new MemoryStream();
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		try
		{
			gZipStream.Write(bytes, 0, bytes.Length);
		}
		finally
		{
			((IDisposable)gZipStream).Dispose();
		}
		memoryStream.Position = 0L;
		byte[] array = new byte[memoryStream.Length];
		memoryStream.Read(array, 0, array.Length);
		byte[] array2 = new byte[array.Length + 4];
		Buffer.BlockCopy(array, 0, array2, 4, array.Length);
		Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
		return array2;
	}

	public static string smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			int num = BitConverter.ToInt32(byte_0, 0);
			memoryStream.Write(byte_0, 4, byte_0.Length - 4);
			byte[] array = new byte[num];
			memoryStream.Position = 0L;
			GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
			try
			{
				gZipStream.Read(array, 0, array.Length);
			}
			finally
			{
				((IDisposable)gZipStream).Dispose();
			}
			return Encoding.UTF8.GetString(array);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}
}
