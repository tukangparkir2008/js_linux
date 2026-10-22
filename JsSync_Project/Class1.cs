using System;
using System.IO;

internal static class Class1
{
	private static readonly Class117 class117_0 = Class117.smethod_18(65537uL);

	private static readonly byte[] byte_0 = smethod_1();

	private static Class101 class101_0;

	private static readonly object object_0 = new object();

	private static bool bool_0;

	private static void smethod_0()
	{
		if (bool_0)
		{
			return;
		}
		lock (object_0)
		{
			if (!bool_0)
			{
				Class117 class117_ = new Class117(1, byte_0);
				Class45 class45_ = new Class45(bool_1: false, class117_, class117_0);
				class101_0 = new Class101(bool_3: true, class45_);
				bool_0 = true;
			}
		}
	}

	private static byte[] smethod_1()
	{
		return null;
	}

	public static bool smethod_2(object object_1, byte[] byte_1, ulong ulong_0)
	{
		if (byte_1 == null)
		{
			return false;
		}
		if (object_1 == null)
		{
			return false;
		}
		smethod_0();
		byte[] byte_2 = Class112.smethod_0(object_1, ulong_0, class101_0);
		return smethod_3(byte_1, byte_2);
	}

	private static bool smethod_3(byte[] byte_1, byte[] byte_2)
	{
		if (byte_1.Length != byte_2.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < byte_1.Length)
			{
				if (byte_1[num] != byte_2[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static byte[] smethod_4(object[] object_1, byte[] byte_1, ulong ulong_0)
	{
		if (object_1 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994272828));
		}
		if (byte_1 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994272769));
		}
		byte[] array2;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			for (int i = 0; i < object_1.Length; i++)
			{
				byte[] array = Class112.smethod_3(object_1[i]);
				memoryStream.Write(array, 0, array.Length);
			}
			array2 = memoryStream.ToArray();
		}
		return new Class54(array2, (long)ulong_0).method_2(byte_1);
	}
}
