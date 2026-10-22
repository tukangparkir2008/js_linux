using System;
using System.IO;

internal static class Class112
{
	public static byte[] smethod_0(object object_0, ulong ulong_0, Interface4 interface4_0)
	{
		return smethod_1(smethod_3(object_0), smethod_7(ulong_0), interface4_0);
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1, Interface4 interface4_0)
	{
		int num = byte_0.Length;
		if (num == 0)
		{
			throw new ArgumentException();
		}
		int num2 = interface4_0.imethod_0();
		int num3 = interface4_0.imethod_1();
		int num4 = num % num2;
		int num5 = (num + (num2 - 1)) / num2;
		byte[] array;
		if (num4 == 0)
		{
			array = new byte[num];
			Buffer.BlockCopy(byte_0, 0, array, 0, num);
		}
		else
		{
			int int_ = smethod_2(num4);
			byte[] bytes = new Class44(byte_0, byte_1, int_).GetBytes(num2);
			if (num5 == 1)
			{
				array = bytes;
			}
			else
			{
				array = new byte[num2 * num5];
				Buffer.BlockCopy(bytes, 0, array, num2 * (num5 - 1), num2);
			}
			Buffer.BlockCopy(byte_0, 0, array, 0, byte_0.Length);
		}
		Class82.smethod_1(array, 0, array.Length / 4 * 4, byte_1);
		byte[] array2 = new byte[interface4_0.imethod_1() * num5];
		for (int i = 0; i < num5; i++)
		{
			interface4_0.imethod_2(array, num2 * i, num2, array2, num3 * i);
		}
		return array2;
	}

	private static int smethod_2(int int_0)
	{
		if (int_0 < 8)
		{
			return 200;
		}
		return 1;
	}

	public static byte[] smethod_3(object object_0)
	{
		if (object_0 is sbyte b)
		{
			return new byte[1] { (byte)b };
		}
		if (object_0 is byte b2)
		{
			return new byte[1] { b2 };
		}
		if (object_0 is int int_)
		{
			return smethod_4(int_);
		}
		if (object_0 is uint uint_)
		{
			return smethod_5(uint_);
		}
		if (object_0 is long long_)
		{
			return smethod_6(long_);
		}
		if (object_0 is ulong ulong_)
		{
			return smethod_7(ulong_);
		}
		if (!(object_0 is byte[] result))
		{
			if (!(object_0 is Array array))
			{
				throw new InvalidOperationException();
			}
			MemoryStream memoryStream = new MemoryStream();
			foreach (object item in array)
			{
				byte[] array2 = smethod_3(item);
				memoryStream.Write(array2, 0, array2.Length);
			}
			return memoryStream.ToArray();
		}
		return result;
	}

	private static byte[] smethod_4(int int_0)
	{
		byte[] array = new byte[4];
		array[3] = (byte)int_0;
		array[2] = (byte)(int_0 >> 8);
		array[1] = (byte)(int_0 >> 16);
		array[0] = (byte)(int_0 >> 24);
		return array;
	}

	private static byte[] smethod_5(uint uint_0)
	{
		byte[] array = new byte[4];
		array[3] = (byte)uint_0;
		array[2] = (byte)(uint_0 >> 8);
		array[1] = (byte)(uint_0 >> 16);
		array[0] = (byte)(uint_0 >> 24);
		return array;
	}

	private static byte[] smethod_6(long long_0)
	{
		byte[] array = new byte[8];
		array[7] = (byte)long_0;
		array[6] = (byte)(long_0 >> 8);
		array[5] = (byte)(long_0 >> 16);
		array[4] = (byte)(long_0 >> 24);
		array[3] = (byte)(long_0 >> 32);
		array[2] = (byte)(long_0 >> 40);
		array[1] = (byte)(long_0 >> 48);
		array[0] = (byte)(long_0 >> 56);
		return array;
	}

	private static byte[] smethod_7(ulong ulong_0)
	{
		byte[] array = new byte[8];
		array[7] = (byte)ulong_0;
		array[6] = (byte)(ulong_0 >> 8);
		array[5] = (byte)(ulong_0 >> 16);
		array[4] = (byte)(ulong_0 >> 24);
		array[3] = (byte)(ulong_0 >> 32);
		array[2] = (byte)(ulong_0 >> 40);
		array[1] = (byte)(ulong_0 >> 48);
		array[0] = (byte)(ulong_0 >> 56);
		return array;
	}
}
