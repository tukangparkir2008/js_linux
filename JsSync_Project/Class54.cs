using System;

internal sealed class Class54 : Class53
{
	public Class54(byte[] byte_0, long long_0)
		: base(byte_0, long_0)
	{
	}

	public byte[] method_1(Class67 class67_0, Interface5 interface5_0)
	{
		byte[] array = new byte[4];
		smethod_6(class67_0, array, 0, array.Length);
		int num = Class53.smethod_4(method_0(array, bool_0: false), 0);
		int num2 = Class53.smethod_1(num);
		int value = num2 - 4;
		byte[] array2 = new byte[num2];
		smethod_6(class67_0, array2, 4, value);
		Buffer.BlockCopy(array, 0, array2, 0, 4);
		byte[] src = method_0(array2, bool_0: false);
		byte[] array3 = new byte[num];
		Buffer.BlockCopy(src, 4, array3, 0, num);
		return array3;
	}

	public byte[] method_2(byte[] byte_0)
	{
		byte[] array = method_0(byte_0, bool_0: false);
		int num = Class53.smethod_4(array, 0);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(array, 4, array2, 0, num);
		return array2;
	}

	private static void smethod_6(Class67 class67_0, byte[] byte_0, int int_0, int? nullable_0)
	{
		int num = nullable_0 ?? (byte_0.Length - int_0);
		int num2;
		while ((num2 = class67_0.vmethod_11(byte_0, int_0, num)) > 0)
		{
			int_0 += num2;
			num -= num2;
		}
	}
}
