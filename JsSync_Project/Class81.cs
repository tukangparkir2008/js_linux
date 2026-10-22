using System;
using System.IO;

internal static class Class81
{
	private static readonly uint[] uint_0 = new uint[5] { 52200625u, 614125u, 7225u, 85u, 1u };

	public static byte[] smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			throw new Exception();
		}
		MemoryStream memoryStream = new MemoryStream(string_0.Length * 4 / 5);
		try
		{
			int num = 0;
			uint num2 = 0u;
			int num3 = 0;
			while (true)
			{
				if (num3 < string_0.Length)
				{
					char c = string_0[num3];
					if (c == 'z' && num == 0)
					{
						smethod_1(memoryStream, num2, 0);
					}
					else
					{
						if (c < '!' || c > 'u')
						{
							throw new Exception();
						}
						num2 = checked(num2 + (uint)(uint_0[num] * (c - 33)));
						num++;
						if (num == 5)
						{
							smethod_1(memoryStream, num2, 0);
							num = 0;
							num2 = 0u;
						}
					}
					num3++;
					continue;
				}
				if (num == 1)
				{
					throw new Exception();
				}
				if (num > 1)
				{
					for (int i = num; i < 5; i++)
					{
						num2 = checked(num2 + 84 * uint_0[i]);
					}
					smethod_1(memoryStream, num2, 5 - num);
				}
				break;
			}
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private static void smethod_1(Stream stream_0, uint uint_1, int int_0)
	{
		stream_0.WriteByte((byte)(uint_1 >> 24));
		if (int_0 == 3)
		{
			return;
		}
		stream_0.WriteByte((byte)(uint_1 >> 16));
		if (int_0 != 2)
		{
			stream_0.WriteByte((byte)(uint_1 >> 8));
			if (int_0 != 1)
			{
				stream_0.WriteByte((byte)uint_1);
			}
		}
	}
}
