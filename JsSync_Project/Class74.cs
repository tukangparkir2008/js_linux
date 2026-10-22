using System;
using System.Runtime.CompilerServices;

internal sealed class Class74 : Interface4, IDisposable
{
	private Class101 class101_0;

	private byte[] byte_0;

	private readonly int int_0;

	private readonly int int_1;

	public Class74(Class101 class101_1)
	{
		if (class101_1 == null)
		{
			throw new ArgumentNullException();
		}
		if (class101_1.method_0())
		{
			throw new NotSupportedException();
		}
		class101_0 = class101_1;
		byte_0 = new byte[class101_1.imethod_1()];
		int_0 = method_0();
		int_1 = method_1();
	}

	private int method_0()
	{
		return class101_0.imethod_0();
	}

	private int method_1()
	{
		return class101_0.imethod_1() - 10;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_1()
	{
		return int_1;
	}

	public int imethod_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4)
	{
		return method_2(byte_1, int_2, int_3, byte_2, int_4);
	}

	private int method_2(byte[] byte_1, int int_2, int int_3, byte[] byte_2, int int_4)
	{
		int num = class101_0.imethod_1();
		byte[] array = byte_0;
		class101_0.imethod_2(byte_1, int_2, int_3, array, 0);
		byte b = array[0];
		bool flag = b != 2;
		int num2 = smethod_0(b, array, 0, num);
		num2++;
		if (flag | (num2 < 10))
		{
			throw new InvalidOperationException(Class84.smethod_0(-994273252));
		}
		int num3 = num - num2;
		Buffer.BlockCopy(array, num2, byte_2, int_4, num3);
		return num3;
	}

	private static int smethod_0(byte byte_1, byte[] byte_2, int int_2, int int_3)
	{
		int num = int_2 + 1;
		while (true)
		{
			if (num != int_2 + int_3)
			{
				if (byte_2[num] == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public void Dispose()
	{
		if (class101_0 != null)
		{
			class101_0.Dispose();
			class101_0 = null;
		}
	}
}
