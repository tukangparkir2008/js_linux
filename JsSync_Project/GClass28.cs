using System;
using System.Reflection;
using System.Text;

[DefaultMember("#=zAKt$Eys=")]
public sealed class GClass28
{
	private byte[] byte_0;

	private long long_0;

	private long long_1;

	// C# has no syntax for parameterized property 'Item'.
	public byte get_Item(int int_0)
	{
		return byte_0[int_0];
	}

	public GClass28()
	{
		byte_0 = new byte[0];
		long_0 = 0L;
		long_1 = 0L;
	}

	public GClass28(long long_2)
	{
		byte_0 = new byte[long_2];
		long_0 = 0L;
		long_1 = 0L;
	}

	public GClass28(byte[] byte_1)
	{
		byte_0 = byte_1;
		long_0 = byte_1.Length;
		long_1 = 0L;
	}

	public bool method_0()
	{
		if (byte_0 != null)
		{
			return long_0 == 0L;
		}
		return true;
	}

	public byte[] method_1()
	{
		return byte_0;
	}

	public long method_2()
	{
		return byte_0.Length;
	}

	public long method_3()
	{
		return long_0;
	}

	public long method_4()
	{
		return long_1;
	}

	public override string ToString()
	{
		return method_6(0L, long_0);
	}

	public void method_5()
	{
		long_0 = 0L;
		long_1 = 0L;
	}

	public string method_6(long long_2, long long_3)
	{
		if (long_2 + long_3 > method_3())
		{
			throw new ArgumentException(Class84.smethod_0(-994208092), Class84.smethod_0(-994208063));
		}
		return Encoding.UTF8.GetString(byte_0, (int)long_2, (int)long_3);
	}

	public void method_7(long long_2, long long_3)
	{
		if (long_2 + long_3 > method_3())
		{
			throw new ArgumentException(Class84.smethod_0(-994208092), Class84.smethod_0(-994208004));
		}
		Array.Copy(byte_0, long_2 + long_3, byte_0, long_2, long_0 - long_3 - long_2);
		long_0 -= long_3;
		if (long_1 >= long_2 + long_3)
		{
			long_1 -= long_3;
		}
		else if (long_1 >= long_2)
		{
			long_1 -= long_1 - long_2;
			if (long_1 > method_3())
			{
				long_1 = method_3();
			}
		}
	}

	public void method_8(long long_2)
	{
		if (long_2 < 0L)
		{
			throw new ArgumentException(Class84.smethod_0(-994208009), Class84.smethod_0(-994207977));
		}
		if (long_2 > method_2())
		{
			byte[] destinationArray = new byte[Math.Max(long_2, 2L * method_2())];
			Array.Copy(byte_0, 0L, destinationArray, 0L, long_0);
			byte_0 = destinationArray;
		}
	}

	public void method_9(long long_2)
	{
		method_8(long_2);
		long_0 = long_2;
		if (long_1 > long_0)
		{
			long_1 = long_0;
		}
	}

	public void method_10(long long_2)
	{
		long_1 += long_2;
	}

	public void method_11(long long_2)
	{
		long_1 -= long_2;
	}

	public long method_12(byte[] byte_1)
	{
		method_8(long_0 + byte_1.Length);
		Array.Copy(byte_1, 0L, byte_0, long_0, byte_1.Length);
		long_0 += byte_1.Length;
		return byte_1.Length;
	}

	public long method_13(byte[] byte_1, long long_2, long long_3)
	{
		method_8(long_0 + long_3);
		Array.Copy(byte_1, long_2, byte_0, long_0, long_3);
		long_0 += long_3;
		return long_3;
	}

	public long method_14(string string_0)
	{
		method_8(long_0 + Encoding.UTF8.GetMaxByteCount(string_0.Length));
		long num = Encoding.UTF8.GetBytes(string_0, 0, string_0.Length, byte_0, (int)long_0);
		long_0 += num;
		return num;
	}
}
