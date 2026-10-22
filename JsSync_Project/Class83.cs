using System;

internal sealed class Class83
{
	private readonly Class118 class118_0 = new Class118();

	private readonly int int_0;

	private readonly int int_1;

	private Class118 class118_1;

	private Class118 class118_2;

	private readonly byte[] byte_0;

	private readonly byte[] byte_1;

	public Class83()
	{
		int_0 = class118_0.method_5();
		int_1 = class118_0.method_3();
		byte_0 = new byte[int_1];
		byte_1 = new byte[int_1 + int_0];
	}

	public void method_0(byte[] byte_2)
	{
		class118_0.method_9();
		int num = byte_2.Length;
		if (num > int_1)
		{
			class118_0.method_1(byte_2, 0, num);
			class118_0.method_8(byte_0, 0);
			num = int_0;
		}
		else
		{
			Array.Copy(byte_2, 0, byte_0, 0, num);
		}
		Array.Clear(byte_0, num, int_1 - num);
		Array.Copy(byte_0, 0, byte_1, 0, int_1);
		smethod_0(byte_0, int_1, 54);
		smethod_0(byte_1, int_1, 92);
		class118_2 = class118_0.method_11();
		class118_2.method_1(byte_1, 0, int_1);
		class118_0.method_1(byte_0, 0, byte_0.Length);
		class118_1 = class118_0.method_11();
	}

	public int method_1()
	{
		return int_0;
	}

	public void method_2(byte[] byte_2, int int_2, int int_3)
	{
		class118_0.method_1(byte_2, int_2, int_3);
	}

	public int method_3(byte[] byte_2, int int_2)
	{
		class118_0.method_8(byte_1, int_1);
		class118_0.method_12(class118_2);
		class118_0.method_1(byte_1, int_1, class118_0.method_5());
		int result = class118_0.method_8(byte_2, int_2);
		Array.Clear(byte_1, int_1, int_0);
		class118_0.method_12(class118_1);
		return result;
	}

	private static void smethod_0(byte[] byte_2, int int_2, byte byte_3)
	{
		for (int i = 0; i < int_2; i++)
		{
			byte_2[i] ^= byte_3;
		}
	}
}
