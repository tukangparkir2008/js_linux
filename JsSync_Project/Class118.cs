using System;

internal sealed class Class118
{
	private byte[] byte_0;

	private int int_0;

	private long long_0;

	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private uint uint_3;

	private uint uint_4;

	private uint[] uint_5 = new uint[80];

	private int int_1;

	public Class118()
	{
		byte_0 = new byte[4];
		method_9();
	}

	public Class118(Class118 class118_0)
	{
		method_4(class118_0);
	}

	public void method_0(byte byte_1)
	{
		byte_0[int_0++] = byte_1;
		if (int_0 == byte_0.Length)
		{
			method_6(byte_0, 0);
			int_0 = 0;
		}
		long_0++;
	}

	public void method_1(byte[] byte_1, int int_2, int int_3)
	{
		int_3 = Math.Max(0, int_3);
		int i = 0;
		if (int_0 != 0)
		{
			while (i < int_3)
			{
				byte_0[int_0++] = byte_1[int_2 + i++];
				if (int_0 == 4)
				{
					method_6(byte_0, 0);
					int_0 = 0;
					break;
				}
			}
		}
		for (int num = ((int_3 - i) & -4) + i; i < num; i += 4)
		{
			method_6(byte_1, int_2 + i);
		}
		while (i < int_3)
		{
			byte_0[int_0++] = byte_1[int_2 + i++];
		}
		long_0 += int_3;
	}

	public void method_2()
	{
		long long_ = long_0 << 3;
		method_0(128);
		while (int_0 != 0)
		{
			method_0(0);
		}
		method_7(long_);
		method_10();
	}

	public int method_3()
	{
		return 64;
	}

	private void method_4(Class118 class118_0)
	{
		byte_0 = new byte[class118_0.byte_0.Length];
		Buffer.BlockCopy(class118_0.byte_0, 0, byte_0, 0, class118_0.byte_0.Length);
		int_0 = class118_0.int_0;
		long_0 = class118_0.long_0;
		uint_0 = class118_0.uint_0;
		uint_1 = class118_0.uint_1;
		uint_2 = class118_0.uint_2;
		uint_3 = class118_0.uint_3;
		uint_4 = class118_0.uint_4;
		Array.Copy(class118_0.uint_5, 0, uint_5, 0, class118_0.uint_5.Length);
		int_1 = class118_0.int_1;
	}

	public int method_5()
	{
		return 20;
	}

	public void method_6(byte[] byte_1, int int_2)
	{
		uint_5[int_1] = smethod_4(byte_1, int_2);
		if (++int_1 == 16)
		{
			method_10();
		}
	}

	public void method_7(long long_1)
	{
		if (int_1 > 14)
		{
			method_10();
		}
		uint_5[14] = (uint)((ulong)long_1 >> 32);
		uint_5[15] = (uint)long_1;
	}

	public int method_8(byte[] byte_1, int int_2)
	{
		method_2();
		smethod_3(uint_0, byte_1, int_2);
		smethod_3(uint_1, byte_1, int_2 + 4);
		smethod_3(uint_2, byte_1, int_2 + 8);
		smethod_3(uint_3, byte_1, int_2 + 12);
		smethod_3(uint_4, byte_1, int_2 + 16);
		method_9();
		return 20;
	}

	public void method_9()
	{
		long_0 = 0L;
		int_0 = 0;
		Array.Clear(byte_0, 0, byte_0.Length);
		uint_0 = 1732584193u;
		uint_1 = 4023233417u;
		uint_2 = 2562383102u;
		uint_3 = 271733878u;
		uint_4 = 3285377520u;
		int_1 = 0;
		Array.Clear(uint_5, 0, uint_5.Length);
	}

	private static uint smethod_0(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (~uint_6 & uint_8);
	}

	private static uint smethod_1(uint uint_6, uint uint_7, uint uint_8)
	{
		return uint_6 ^ uint_7 ^ uint_8;
	}

	private static uint smethod_2(uint uint_6, uint uint_7, uint uint_8)
	{
		return (uint_6 & uint_7) | (uint_6 & uint_8) | (uint_7 & uint_8);
	}

	private void method_10()
	{
		for (int i = 16; i < 80; i++)
		{
			uint num = uint_5[i - 3] ^ uint_5[i - 8] ^ uint_5[i - 14] ^ uint_5[i - 16];
			uint_5[i] = (num << 1) | (num >> 31);
		}
		uint num2 = uint_0;
		uint num3 = uint_1;
		uint num4 = uint_2;
		uint num5 = uint_3;
		uint num6 = uint_4;
		int num7 = 0;
		for (int j = 0; j < 4; j++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + smethod_0(num3, num4, num5) + uint_5[num7++] + 1518500249;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + smethod_0(num2, num3, num4) + uint_5[num7++] + 1518500249;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + smethod_0(num6, num2, num3) + uint_5[num7++] + 1518500249;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + smethod_0(num5, num6, num2) + uint_5[num7++] + 1518500249;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + smethod_0(num4, num5, num6) + uint_5[num7++] + 1518500249;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			num6 += ((num2 << 5) | (num2 >> 27)) + smethod_1(num3, num4, num5) + uint_5[num7++] + 1859775393;
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += ((num6 << 5) | (num6 >> 27)) + smethod_1(num2, num3, num4) + uint_5[num7++] + 1859775393;
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += ((num5 << 5) | (num5 >> 27)) + smethod_1(num6, num2, num3) + uint_5[num7++] + 1859775393;
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += ((num4 << 5) | (num4 >> 27)) + smethod_1(num5, num6, num2) + uint_5[num7++] + 1859775393;
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += ((num3 << 5) | (num3 >> 27)) + smethod_1(num4, num5, num6) + uint_5[num7++] + 1859775393;
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + smethod_2(num3, num4, num5) + uint_5[num7++]) + -1894007588);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + smethod_2(num2, num3, num4) + uint_5[num7++]) + -1894007588);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + smethod_2(num6, num2, num3) + uint_5[num7++]) + -1894007588);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + smethod_2(num5, num6, num2) + uint_5[num7++]) + -1894007588);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + smethod_2(num4, num5, num6) + uint_5[num7++]) + -1894007588);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			num6 += (uint)((int)(((num2 << 5) | (num2 >> 27)) + smethod_1(num3, num4, num5) + uint_5[num7++]) + -899497514);
			num3 = (num3 << 30) | (num3 >> 2);
			num5 += (uint)((int)(((num6 << 5) | (num6 >> 27)) + smethod_1(num2, num3, num4) + uint_5[num7++]) + -899497514);
			num2 = (num2 << 30) | (num2 >> 2);
			num4 += (uint)((int)(((num5 << 5) | (num5 >> 27)) + smethod_1(num6, num2, num3) + uint_5[num7++]) + -899497514);
			num6 = (num6 << 30) | (num6 >> 2);
			num3 += (uint)((int)(((num4 << 5) | (num4 >> 27)) + smethod_1(num5, num6, num2) + uint_5[num7++]) + -899497514);
			num5 = (num5 << 30) | (num5 >> 2);
			num2 += (uint)((int)(((num3 << 5) | (num3 >> 27)) + smethod_1(num4, num5, num6) + uint_5[num7++]) + -899497514);
			num4 = (num4 << 30) | (num4 >> 2);
		}
		uint_0 += num2;
		uint_1 += num3;
		uint_2 += num4;
		uint_3 += num5;
		uint_4 += num6;
		int_1 = 0;
		Array.Clear(uint_5, 0, 16);
	}

	private static void smethod_3(uint uint_6, byte[] byte_1, int int_2)
	{
		byte_1[int_2] = (byte)(uint_6 >> 24);
		byte_1[int_2 + 1] = (byte)(uint_6 >> 16);
		byte_1[int_2 + 2] = (byte)(uint_6 >> 8);
		byte_1[int_2 + 3] = (byte)uint_6;
	}

	private static uint smethod_4(byte[] byte_1, int int_2)
	{
		return (uint)((byte_1[int_2] << 24) | (byte_1[int_2 + 1] << 16) | (byte_1[int_2 + 2] << 8) | byte_1[int_2 + 3]);
	}

	public Class118 method_11()
	{
		return new Class118(this);
	}

	public void method_12(Class118 class118_0)
	{
		method_4(class118_0);
	}
}
