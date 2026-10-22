using System;

internal sealed class Class117
{
	private static readonly int[] int_0;

	public static readonly Class117 class117_0;

	public static readonly Class117 class117_1;

	private static readonly byte[] byte_0;

	private int[] int_1;

	private int int_2;

	private int int_3 = -1;

	private int int_4;

	static Class117()
	{
		int_0 = new int[0];
		byte_0 = new byte[256]
		{
			0, 1, 2, 2, 3, 3, 3, 3, 4, 4,
			4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8,
			8, 8, 8, 8, 8, 8
		};
		class117_0 = new Class117(0, int_0, bool_0: false);
		class117_0.int_3 = 0;
		class117_1 = smethod_17(1uL);
	}

	public Class117(int int_5, int[] int_6, bool bool_0)
	{
		if (bool_0)
		{
			int i;
			for (i = 0; i < int_6.Length && int_6[i] == 0; i++)
			{
			}
			if (i == int_6.Length)
			{
				int_2 = 0;
				int_1 = int_0;
				return;
			}
			int_2 = int_5;
			if (i == 0)
			{
				int_1 = int_6;
				return;
			}
			int_1 = new int[int_6.Length - i];
			Array.Copy(int_6, i, int_1, 0, int_1.Length);
		}
		else
		{
			int_2 = int_5;
			int_1 = int_6;
		}
	}

	public Class117(int int_5, byte[] byte_1)
		: this(int_5, byte_1, 0, byte_1.Length)
	{
	}

	public Class117(int int_5, byte[] byte_1, int int_6, int int_7)
	{
		if (int_5 == 0)
		{
			int_2 = 0;
			int_1 = int_0;
		}
		else
		{
			int_1 = smethod_1(byte_1, int_6, int_7);
			int_2 = ((int_1.Length >= 1) ? int_5 : 0);
		}
	}

	public int[] method_0()
	{
		return int_1;
	}

	private static int smethod_0(int int_5)
	{
		return (int_5 + 8 - 1) / 8;
	}

	private static int[] smethod_1(byte[] byte_1, int int_5, int int_6)
	{
		int num = int_5 + int_6;
		int i;
		for (i = int_5; i < num && byte_1[i] == 0; i++)
		{
		}
		if (i >= num)
		{
			return int_0;
		}
		int num2 = (num - i + 3) / 4;
		int num3 = (num - i) % 4;
		if (num3 == 0)
		{
			num3 = 4;
		}
		if (num2 < 1)
		{
			return int_0;
		}
		int[] array = new int[num2];
		int num4 = 0;
		int num5 = 0;
		for (int j = i; j < num; j++)
		{
			num4 <<= 8;
			num4 |= byte_1[j] & 0xFF;
			num3--;
			if (num3 <= 0)
			{
				array[num5] = num4;
				num5++;
				num3 = 4;
				num4 = 0;
			}
		}
		if (num5 < array.Length)
		{
			array[num5] = num4;
		}
		return array;
	}

	private static int smethod_2(int int_5, int int_6, int[] int_7)
	{
		while (true)
		{
			if (int_6 < int_7.Length)
			{
				if (int_7[int_6] != 0)
				{
					break;
				}
				int_6++;
				continue;
			}
			return 0;
		}
		int num = 32 * (int_7.Length - int_6 - 1);
		int int_8 = int_7[int_6];
		return num + smethod_3(int_8);
	}

	public int method_1()
	{
		if (int_3 == -1)
		{
			int_3 = ((int_2 != 0) ? smethod_2(int_2, 0, int_1) : 0);
		}
		return int_3;
	}

	private static int smethod_3(int int_5)
	{
		uint num = (uint)int_5 >> 24;
		if (num != 0)
		{
			return 24 + byte_0[num];
		}
		num = (uint)int_5 >> 16;
		if (num != 0)
		{
			return 16 + byte_0[num];
		}
		num = (uint)int_5 >> 8;
		if (num != 0)
		{
			return 8 + byte_0[num];
		}
		return byte_0[int_5];
	}

	public int method_2(object object_0)
	{
		return method_3((Class117)object_0);
	}

	private static int smethod_4(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		while (int_5 != int_6.Length && int_6[int_5] == 0)
		{
			int_5++;
		}
		while (int_7 != int_8.Length && int_8[int_7] == 0)
		{
			int_7++;
		}
		return smethod_5(int_5, int_6, int_7, int_8);
	}

	private static int smethod_5(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length - int_8.Length - (int_5 - int_7);
		if (num != 0)
		{
			if (num >= 0)
			{
				return 1;
			}
			return -1;
		}
		uint num2;
		uint num3;
		do
		{
			if (int_5 < int_6.Length)
			{
				num2 = (uint)int_6[int_5++];
				num3 = (uint)int_8[int_7++];
				continue;
			}
			return 0;
		}
		while (num2 == num3);
		if (num2 >= num3)
		{
			return 1;
		}
		return -1;
	}

	public int method_3(Class117 class117_2)
	{
		if (int_2 >= class117_2.int_2)
		{
			if (int_2 <= class117_2.int_2)
			{
				if (int_2 != 0)
				{
					return int_2 * smethod_5(0, int_1, 0, class117_2.int_1);
				}
				return 0;
			}
			return 1;
		}
		return -1;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is Class117 @class))
		{
			return false;
		}
		if (int_2 == @class.int_2)
		{
			return method_4(@class);
		}
		return false;
	}

	public override int GetHashCode()
	{
		int num = int_1.Length;
		if (int_1.Length != 0)
		{
			num ^= int_1[0];
			if (int_1.Length > 1)
			{
				num ^= int_1[int_1.Length - 1];
			}
		}
		return num;
	}

	private bool method_4(Class117 class117_2)
	{
		if (int_1.Length != class117_2.int_1.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < int_1.Length)
			{
				if (int_1[num] != class117_2.int_1[num])
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

	public Class117 method_5(Class117 class117_2, Class117 class117_3)
	{
		if (class117_3.Equals(class117_1))
		{
			return class117_0;
		}
		if (class117_2.int_2 == 0)
		{
			return class117_1;
		}
		if (int_2 == 0)
		{
			return class117_0;
		}
		Class117 @class = this;
		if (!class117_2.Equals(class117_1))
		{
			@class = smethod_6(@class, class117_2.int_1[0], class117_3);
		}
		return @class;
	}

	private static Class117 smethod_6(Class117 class117_2, int int_5, Class117 class117_3)
	{
		int num = class117_3.int_1.Length;
		int num2 = 32 * num;
		bool bool_ = class117_3.method_1() + 2 <= num2;
		uint uint_ = (uint)class117_3.method_6();
		class117_2 = class117_2.method_7(num2).method_12(class117_3);
		int[] int_6 = new int[num + 1];
		int[] array = class117_2.int_1;
		if (array.Length < num)
		{
			int[] array2 = new int[num];
			Buffer.BlockCopy(array, 0, array2, num - array.Length, array.Length * 4);
			array = array2;
		}
		int[] array3 = smethod_20(array);
		smethod_10(int_6, array3, class117_3.int_1, uint_, bool_);
		int[] array4 = smethod_12(int_5);
		int num3 = array4[0];
		int num4 = num3 >> 8;
		num4--;
		int num5 = 1;
		while ((num3 = array4[num5++]) != -1)
		{
			int num6 = num4 + 1;
			for (int i = 0; i < num6; i++)
			{
				smethod_10(int_6, array3, class117_3.int_1, uint_, bool_);
			}
			smethod_9(int_6, array3, array, class117_3.int_1, uint_, bool_);
			num4 = num3 >> 8;
		}
		for (int j = 0; j < num4; j++)
		{
			smethod_10(int_6, array3, class117_3.int_1, uint_, bool_);
		}
		smethod_8(array3, class117_3.int_1, uint_);
		return new Class117(1, array3, bool_0: true);
	}

	private static int smethod_7(int int_5)
	{
		int num = int_5 + (((int_5 + 1) & 4) << 1);
		num *= 2 - int_5 * num;
		num *= 2 - int_5 * num;
		return num * (2 - int_5 * num);
	}

	private int method_6()
	{
		if (int_4 != 0)
		{
			return int_4;
		}
		int int_ = -int_1[int_1.Length - 1];
		return int_4 = smethod_7(int_);
	}

	private static void smethod_8(int[] int_5, int[] int_6, uint uint_0)
	{
		int num = int_6.Length;
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			uint num3 = (uint)int_5[num - 1];
			ulong num4 = num3 * uint_0;
			ulong num5 = num4 * (uint)int_6[num - 1] + num3;
			num5 >>= 32;
			for (int num6 = num - 2; num6 >= 0; num6--)
			{
				num5 += num4 * (uint)int_6[num6] + (uint)int_5[num6];
				int_5[num6 + 1] = (int)num5;
				num5 >>= 32;
			}
			int_5[0] = (int)num5;
		}
		if (smethod_4(0, int_5, 0, int_6) >= 0)
		{
			smethod_16(0, int_5, 0, int_6);
		}
	}

	private static void smethod_9(int[] int_5, int[] int_6, int[] int_7, int[] int_8, uint uint_0, bool bool_0)
	{
		int num = int_8.Length;
		if (num == 1)
		{
			int_6[0] = (int)smethod_11((uint)int_6[0], (uint)int_7[0], (uint)int_8[0], uint_0);
			return;
		}
		uint num2 = (uint)int_7[num - 1];
		ulong num3 = (uint)int_6[num - 1];
		ulong num4 = num3 * num2;
		ulong num5 = (uint)(int)num4 * uint_0;
		ulong num6 = num5 * (uint)int_8[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)int_7[num7];
			num6 = num5 * (uint)int_8[num7];
			num4 += (num8 & 0xFFFFFFFFL) + (uint)num6;
			int_5[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 32) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)int_5[num];
			ulong num12 = (uint)int_6[num10];
			ulong num13 = num12 * num2;
			ulong num14 = (num13 & 0xFFFFFFFFL) + num11;
			ulong num15 = (uint)(int)num14 * uint_0;
			ulong num16 = num15 * (uint)int_8[num - 1];
			num14 += (uint)num16;
			num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			for (int num17 = num - 2; num17 >= 0; num17--)
			{
				num13 = num12 * (uint)int_7[num17];
				num16 = num15 * (uint)int_8[num17];
				num14 += (num13 & 0xFFFFFFFFL) + (uint)num16 + (uint)int_5[num17 + 1];
				int_5[num17 + 2] = (int)num14;
				num14 = (num14 >> 32) + (num13 >> 32) + (num16 >> 32);
			}
			num14 += (uint)num9;
			int_5[1] = (int)num14;
			num9 = (int)(num14 >> 32);
		}
		int_5[0] = num9;
		if (!bool_0 && smethod_4(0, int_5, 0, int_8) >= 0)
		{
			smethod_16(0, int_5, 0, int_8);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	private static void smethod_10(int[] int_5, int[] int_6, int[] int_7, uint uint_0, bool bool_0)
	{
		int num = int_7.Length;
		if (num == 1)
		{
			uint num2 = (uint)int_6[0];
			int_6[0] = (int)smethod_11(num2, num2, (uint)int_7[0], uint_0);
			return;
		}
		ulong num3 = (uint)int_6[num - 1];
		ulong num4 = num3 * num3;
		ulong num5 = (uint)(int)num4 * uint_0;
		ulong num6 = num5 * (uint)int_7[num - 1];
		num4 += (uint)num6;
		num4 = (num4 >> 32) + (num6 >> 32);
		for (int num7 = num - 2; num7 >= 0; num7--)
		{
			ulong num8 = num3 * (uint)int_6[num7];
			num6 = num5 * (uint)int_7[num7];
			num4 += (num6 & 0xFFFFFFFFL) + (uint)((int)num8 << 1);
			int_5[num7 + 2] = (int)num4;
			num4 = (num4 >> 32) + (num8 >> 31) + (num6 >> 32);
		}
		int_5[1] = (int)num4;
		int num9 = (int)(num4 >> 32);
		for (int num10 = num - 2; num10 >= 0; num10--)
		{
			uint num11 = (uint)int_5[num];
			ulong num12 = num11 * uint_0;
			ulong num13 = num12 * (uint)int_7[num - 1] + num11;
			num13 >>= 32;
			for (int num14 = num - 2; num14 > num10; num14--)
			{
				num13 += num12 * (uint)int_7[num14] + (uint)int_5[num14 + 1];
				int_5[num14 + 2] = (int)num13;
				num13 >>= 32;
			}
			ulong num15 = (uint)int_6[num10];
			ulong num16 = num15 * num15;
			ulong num17 = num12 * (uint)int_7[num10];
			num13 += (num16 & 0xFFFFFFFFL) + (uint)num17 + (uint)int_5[num10 + 1];
			int_5[num10 + 2] = (int)num13;
			num13 = (num13 >> 32) + (num16 >> 32) + (num17 >> 32);
			for (int num18 = num10 - 1; num18 >= 0; num18--)
			{
				ulong num19 = num15 * (uint)int_6[num18];
				ulong num20 = num12 * (uint)int_7[num18];
				num13 += (num20 & 0xFFFFFFFFL) + (uint)((int)num19 << 1) + (uint)int_5[num18 + 1];
				int_5[num18 + 2] = (int)num13;
				num13 = (num13 >> 32) + (num19 >> 31) + (num20 >> 32);
			}
			num13 += (uint)num9;
			int_5[1] = (int)num13;
			num9 = (int)(num13 >> 32);
		}
		int_5[0] = num9;
		if (!bool_0 && smethod_4(0, int_5, 0, int_7) >= 0)
		{
			smethod_16(0, int_5, 0, int_7);
		}
		Array.Copy(int_5, 1, int_6, 0, num);
	}

	private static uint smethod_11(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		ulong num = (ulong)uint_0 * (ulong)uint_1;
		uint num2 = (uint)(int)num * uint_3;
		ulong num3 = uint_2;
		ulong num4 = num3 * num2;
		num += (uint)num4;
		num = (num >> 32) + (num4 >> 32);
		if (num > num3)
		{
			num -= num3;
		}
		return (uint)num;
	}

	private static int[] smethod_12(int int_5)
	{
		int num = smethod_3(int_5);
		int[] array = new int[num + 2];
		int num2 = 0;
		int i = 33 - num;
		int_5 <<= i;
		int num3 = 0;
		for (; i < 32; i++)
		{
			if (int_5 < 0)
			{
				array[num2++] = 1 | (num3 << 8);
				num3 = 0;
			}
			else
			{
				num3++;
			}
			int_5 <<= 1;
		}
		array[num2++] = 1 | (num3 << 8);
		array[num2] = -1;
		return array;
	}

	private static int[] smethod_13(int[] int_5, int int_6)
	{
		int num = int_6 >>> 5;
		int num2 = int_6 & 0x1F;
		int num3 = int_5.Length;
		int[] array;
		if (num2 == 0)
		{
			array = new int[num3 + num];
			int_5.CopyTo(array, 0);
		}
		else
		{
			int num4 = 0;
			int num5 = 32 - num2;
			int num6 = int_5[0] >>> num5;
			if (num6 != 0)
			{
				array = new int[num3 + num + 1];
				array[num4++] = num6;
			}
			else
			{
				array = new int[num3 + num];
			}
			int num7 = int_5[0];
			for (int i = 0; i < num3 - 1; i++)
			{
				int num8 = int_5[i + 1];
				array[num4++] = (num7 << num2) | (num8 >>> num5);
				num7 = num8;
			}
			array[num4] = int_5[num3 - 1] << num2;
		}
		return array;
	}

	private Class117 method_7(int int_5)
	{
		if (int_2 != 0 && int_1.Length != 0)
		{
			if (int_5 == 0)
			{
				return this;
			}
			Class117 @class = new Class117(int_2, smethod_13(int_1, int_5), bool_0: true);
			if (int_3 != -1)
			{
				@class.int_3 = int_3 + int_5;
			}
			return @class;
		}
		return class117_0;
	}

	private static void smethod_14(int int_5, int[] int_6, int int_7)
	{
		int num = (int_7 >>> 5) + int_5;
		int num2 = int_7 & 0x1F;
		int num3 = int_6.Length - 1;
		if (num != int_5)
		{
			int num4 = num - int_5;
			for (int num5 = num3; num5 >= num; num5--)
			{
				int_6[num5] = int_6[num5 - num4];
			}
			for (int num6 = num - 1; num6 >= int_5; num6--)
			{
				int_6[num6] = 0;
			}
		}
		if (num2 != 0)
		{
			int num7 = 32 - num2;
			int num8 = int_6[num3];
			for (int num9 = num3; num9 > num; num9--)
			{
				int num10 = int_6[num9 - 1];
				int_6[num9] = (num8 >>> num2) | (num10 << num7);
				num8 = num10;
			}
			int_6[num] >>>= num2;
		}
	}

	private static void smethod_15(int int_5, int[] int_6)
	{
		int num = int_6.Length;
		int num2 = int_6[num - 1];
		while (--num > int_5)
		{
			int num3 = int_6[num - 1];
			int_6[num] = (num2 >>> 1) | (num3 << 31);
			num2 = num3;
		}
		int_6[int_5] >>>= 1;
	}

	public int method_8()
	{
		return int_2;
	}

	private static int[] smethod_16(int int_5, int[] int_6, int int_7, int[] int_8)
	{
		int num = int_6.Length;
		int num2 = int_8.Length;
		int num3 = 0;
		do
		{
			long num4 = (int_6[--num] & 0xFFFFFFFFL) - (int_8[--num2] & 0xFFFFFFFFL) + num3;
			int_6[num] = (int)num4;
			num3 = (int)(num4 >> 63);
		}
		while (num2 > int_7);
		if (num3 != 0)
		{
			while (--int_6[--num] == -1)
			{
			}
		}
		return int_6;
	}

	public byte[] method_9()
	{
		if (int_2 == 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[smethod_0(method_1())];
		method_11(array, 0);
		return array;
	}

	public int method_10()
	{
		return method_11(null, 0);
	}

	public int method_11(byte[] byte_1, int int_5)
	{
		if (int_2 == 0)
		{
			return 0;
		}
		int num = smethod_0(method_1());
		if (byte_1 == null)
		{
			return num;
		}
		int num2 = int_1.Length;
		int num3 = int_5 + num;
		if (num3 > byte_1.Length)
		{
			throw new IndexOutOfRangeException();
		}
		while (num2 > 1)
		{
			uint num4 = (uint)int_1[--num2];
			byte_1[--num3] = (byte)num4;
			byte_1[--num3] = (byte)(num4 >> 8);
			byte_1[--num3] = (byte)(num4 >> 16);
			byte_1[--num3] = (byte)(num4 >> 24);
		}
		uint num5;
		for (num5 = (uint)int_1[0]; num5 > 255; num5 >>= 8)
		{
			byte_1[--num3] = (byte)num5;
		}
		byte_1[--num3] = (byte)num5;
		return num;
	}

	private static Class117 smethod_17(ulong ulong_0)
	{
		int num = (int)(ulong_0 >> 32);
		int num2 = (int)ulong_0;
		if (num != 0)
		{
			return new Class117(1, new int[2] { num, num2 }, bool_0: false);
		}
		if (num2 != 0)
		{
			return new Class117(1, new int[1] { num2 }, bool_0: false);
		}
		return class117_0;
	}

	public static Class117 smethod_18(ulong ulong_0)
	{
		return smethod_17(ulong_0);
	}

	private static int[] smethod_19(int[] int_5, int[] int_6)
	{
		int i;
		for (i = 0; i < int_5.Length && int_5[i] == 0; i++)
		{
		}
		int j;
		for (j = 0; j < int_6.Length && int_6[j] == 0; j++)
		{
		}
		int num = smethod_5(i, int_5, j, int_6);
		if (num > 0)
		{
			int num2 = smethod_2(1, j, int_6);
			int num3 = smethod_2(1, i, int_5);
			int num4 = num3 - num2;
			int k = 0;
			int num5 = num2;
			int[] array;
			if (num4 > 0)
			{
				array = smethod_13(int_6, num4);
				num5 += num4;
			}
			else
			{
				int num6 = int_6.Length - j;
				array = new int[num6];
				Array.Copy(int_6, j, array, 0, num6);
			}
			while (true)
			{
				if (num5 < num3 || smethod_5(i, int_5, k, array) >= 0)
				{
					smethod_16(i, int_5, k, array);
					while (int_5[i] == 0)
					{
						if (++i == int_5.Length)
						{
							return int_5;
						}
					}
					num3 = 32 * (int_5.Length - i - 1) + smethod_3(int_5[i]);
					if (num3 <= num2)
					{
						if (num3 < num2)
						{
							return int_5;
						}
						num = smethod_5(i, int_5, j, int_6);
						if (num <= 0)
						{
							break;
						}
					}
				}
				num4 = num5 - num3;
				if (num4 == 1)
				{
					int num7 = array[k] >>> 1;
					uint num8 = (uint)int_5[i];
					if ((uint)num7 > num8)
					{
						num4++;
					}
				}
				if (num4 < 2)
				{
					smethod_15(k, array);
					num5--;
				}
				else
				{
					smethod_14(k, array, num4);
					num5 -= num4;
				}
				for (; array[k] == 0; k++)
				{
				}
			}
		}
		if (num == 0)
		{
			Array.Clear(int_5, i, int_5.Length - i);
		}
		return int_5;
	}

	private Class117 method_12(Class117 class117_2)
	{
		if (int_2 == 0)
		{
			return class117_0;
		}
		if (smethod_5(0, int_1, 0, class117_2.int_1) < 0)
		{
			return this;
		}
		int[] int_ = (int[])int_1.Clone();
		int_ = smethod_19(int_, class117_2.int_1);
		return new Class117(int_2, int_, bool_0: true);
	}

	private static int[] smethod_20(int[] int_5)
	{
		int[] array = new int[int_5.Length];
		Buffer.BlockCopy(int_5, 0, array, 0, int_5.Length * 4);
		return array;
	}
}
