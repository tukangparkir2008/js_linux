using System;

internal static class Class66
{
	private static int int_0;

	private static int int_1;

	public static void smethod_0(ref byte byte_0)
	{
		byte_0 = (byte)int_0;
		int_1 = byte_0;
	}

	public static void smethod_1(ref int int_2)
	{
		int_2 = int_0;
		int_1 = int_2;
	}

	public static void smethod_2(ref long long_0)
	{
		long_0 = int_0;
		int_1 = (int)long_0;
	}

	public static void smethod_3(ref char char_0)
	{
		char_0 = (char)int_0;
		int_1 = char_0;
	}

	public static void smethod_4(Array array_0, int int_2, int int_3)
	{
		Array.Clear(array_0, int_2, int_3);
	}

	public static void smethod_5(Array array_0)
	{
		smethod_4(array_0, 0, array_0.GetLength(0));
	}
}
