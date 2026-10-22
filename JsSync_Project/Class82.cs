using System;

internal static class Class82
{
	private static uint smethod_0(uint uint_0, uint uint_1, uint uint_2, int int_0, uint uint_3, uint[] uint_4)
	{
		return (((uint_2 >> 5) ^ (uint_1 << 2)) + ((uint_1 >> 3) ^ (uint_2 << 4))) ^ ((uint_0 ^ uint_1) + (uint_4[(int_0 & 3) ^ uint_3] ^ uint_2));
	}

	public static void smethod_1(byte[] byte_0, int int_0, int int_1, byte[] byte_1)
	{
		if (byte_0.Length != 0 && byte_0.Length != 0)
		{
			if (int_0 + int_1 > byte_0.Length || int_1 % 4 != 0 || int_1 < 8)
			{
				throw new ArgumentException(Class84.smethod_0(-994273159));
			}
			if (byte_1 == null || byte_1.Length > 16)
			{
				throw new ArgumentNullException(Class84.smethod_0(-994273164));
			}
			uint[] array = new uint[int_1 / 4];
			smethod_3(byte_0, int_0, int_1, array, 0);
			uint[] array2 = new uint[4];
			smethod_3(byte_1, 0, byte_1.Length, array2, 0);
			smethod_2(array, array2);
			smethod_4(array, 0, array.Length, byte_0, int_0);
		}
	}

	private static void smethod_2(uint[] uint_0, uint[] uint_1)
	{
		int num = uint_0.Length - 1;
		if (num < 1)
		{
			return;
		}
		uint uint_2 = uint_0[num];
		uint num2 = 0u;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 2654435769u;
			uint uint_3 = (num2 >> 2) & 3;
			int i;
			uint uint_4;
			for (i = 0; i < num; i++)
			{
				uint_4 = uint_0[i + 1];
				uint_2 = (uint_0[i] += smethod_0(num2, uint_4, uint_2, i, uint_3, uint_1));
			}
			uint_4 = uint_0[0];
			uint_2 = (uint_0[num] += smethod_0(num2, uint_4, uint_2, i, uint_3, uint_1));
		}
	}

	private static uint[] smethod_3(byte[] byte_0, int int_0, int int_1, uint[] uint_0, int int_2)
	{
		if (int_0 + int_1 > byte_0.Length)
		{
			throw new ArgumentException();
		}
		int num = int_1 / 4;
		if (int_2 + num > uint_0.Length)
		{
			throw new ArgumentException();
		}
		int num2 = int_0 + int_1;
		for (int i = int_0; i < num2; i += 4)
		{
			uint_0[int_2 + (i - int_0) / 4] = (uint)(byte_0[i] | (byte_0[i + 1] << 8) | (byte_0[i + 2] << 16) | (byte_0[i + 3] << 24));
		}
		return uint_0;
	}

	private static void smethod_4(uint[] uint_0, int int_0, int int_1, byte[] byte_0, int int_2)
	{
		if (int_0 + int_1 > uint_0.Length)
		{
			throw new ArgumentException();
		}
		int num = int_1 * 4;
		if (int_2 + num > byte_0.Length)
		{
			throw new ArgumentException();
		}
		int num2 = int_2 + num;
		for (int i = int_2; i < num2; i += 4)
		{
			uint num3 = uint_0[(i - int_2) / 4 + int_0];
			byte_0[i] = (byte)num3;
			byte_0[i + 1] = (byte)(num3 >> 8);
			byte_0[i + 2] = (byte)(num3 >> 16);
			byte_0[i + 3] = (byte)(num3 >> 24);
		}
	}
}
