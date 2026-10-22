using System;
using System.Text;

public struct GStruct3
{
	public static readonly GStruct3 gstruct3_0;

	private readonly long long_0;

	private GStruct3(long long_1)
	{
		long_0 = long_1;
	}

	public static GStruct3 smethod_0()
	{
		return new GStruct3(0L);
	}

	public static GStruct3 smethod_1()
	{
		return smethod_6(0, 0, 0);
	}

	public static GStruct3 smethod_2()
	{
		return smethod_6(255, 255, 255);
	}

	public static GStruct3 smethod_3()
	{
		return smethod_6(245, 245, 245);
	}

	public static GStruct3 smethod_4()
	{
		return smethod_6(211, 211, 211);
	}

	public byte method_0()
	{
		return (byte)(long_0 >> 16);
	}

	public byte method_1()
	{
		return (byte)(long_0 >> 8);
	}

	public byte method_2()
	{
		return (byte)long_0;
	}

	public byte method_3()
	{
		return (byte)(long_0 >> 24);
	}

	public bool method_4()
	{
		return long_0 == 0L;
	}

	public static bool operator ==(GStruct3 gstruct3_1, GStruct3 gstruct3_2)
	{
		return gstruct3_1.long_0 == gstruct3_2.long_0;
	}

	public static bool operator !=(GStruct3 gstruct3_1, GStruct3 gstruct3_2)
	{
		return !(gstruct3_1 == gstruct3_2);
	}

	public static GStruct3 smethod_5(int int_0, int int_1, int int_2, int int_3)
	{
		smethod_7(int_0);
		smethod_7(int_1);
		smethod_7(int_2);
		smethod_7(int_3);
		return new GStruct3((long)(uint)((int_1 << 16) | (int_2 << 8) | int_3 | (int_0 << 24)) & 0xFFFFFFFFL);
	}

	public static GStruct3 smethod_6(int int_0, int int_1, int int_2)
	{
		return smethod_5(255, int_0, int_1, int_2);
	}

	public override bool Equals(object obj)
	{
		if (obj is GStruct3 gStruct)
		{
			return long_0 == gStruct.long_0;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return long_0.GetHashCode();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(32);
		stringBuilder.Append(GetType().Name);
		stringBuilder.Append(Class84.smethod_0(-994288532));
		if (long_0 != 0L)
		{
			stringBuilder.Append(Class84.smethod_0(-994288539));
			stringBuilder.Append(method_3());
			stringBuilder.Append(Class84.smethod_0(-994288482));
			stringBuilder.Append(method_0());
			stringBuilder.Append(Class84.smethod_0(-994288503));
			stringBuilder.Append(method_1());
			stringBuilder.Append(Class84.smethod_0(-994288508));
			stringBuilder.Append(method_2());
		}
		else
		{
			stringBuilder.Append(Class84.smethod_0(-994288449));
		}
		stringBuilder.Append(']');
		return stringBuilder.ToString();
	}

	private static void smethod_7(int int_0)
	{
		if (int_0 < 0 || int_0 > 255)
		{
			throw new ArgumentException(Class84.smethod_0(-994288469));
		}
	}
}
