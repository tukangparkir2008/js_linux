using System;

internal sealed class Class115
{
	private Class45 class45_0;

	private int int_0;

	private int int_1;

	private int int_2;

	public void method_0(bool bool_0, Class45 class45_1)
	{
		class45_0 = class45_1;
		int_0 = class45_0.method_1().method_1();
		method_2(smethod_0(int_0, bool_0));
		method_4(smethod_1(int_0, bool_0));
	}

	public int method_1()
	{
		return int_1;
	}

	private void method_2(int int_3)
	{
		int_1 = int_3;
	}

	public int method_3()
	{
		return int_2;
	}

	private void method_4(int int_3)
	{
		int_2 = int_3;
	}

	private static int smethod_0(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 + 7) / 8;
		}
		return (int_3 - 1) / 8;
	}

	private static int smethod_1(int int_3, bool bool_0)
	{
		if (!bool_0)
		{
			return (int_3 - 1) / 8;
		}
		return (int_3 + 7) / 8;
	}

	public Class117 method_5(byte[] byte_0, int int_3, int int_4)
	{
		return new Class117(1, byte_0, int_3, int_4);
	}

	public int method_6(Class117 class117_0, byte[] byte_0, int int_3)
	{
		int num = method_3() - class117_0.method_10();
		Array.Clear(byte_0, int_3, num);
		int_3 += num;
		class117_0.method_11(byte_0, int_3);
		return method_3();
	}

	public Class117 method_7(Class117 class117_0)
	{
		return class117_0.method_5(class45_0.method_2(), class45_0.method_1());
	}
}
