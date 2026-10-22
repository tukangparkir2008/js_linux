using System;

public struct GStruct2
{
	public static readonly GStruct2 gstruct2_0;

	private double double_0;

	private double double_1;

	static GStruct2()
	{
	}

	public GStruct2(double double_2, double double_3)
	{
		double_0 = double_2;
		double_1 = double_3;
	}

	public bool method_0()
	{
		if (Math.Abs(double_0) < 0.001)
		{
			return Math.Abs(double_1) < 0.001;
		}
		return false;
	}

	public double method_1()
	{
		return double_0;
	}

	public void method_2(double double_2)
	{
		double_0 = double_2;
	}

	public double method_3()
	{
		return double_1;
	}

	public void method_4(double double_2)
	{
		double_1 = double_2;
	}

	public static GStruct2 operator +(GStruct2 gstruct2_1, GStruct4 gstruct4_0)
	{
		return smethod_0(gstruct2_1, gstruct4_0);
	}

	public static GStruct2 operator -(GStruct2 gstruct2_1, GStruct4 gstruct4_0)
	{
		return smethod_1(gstruct2_1, gstruct4_0);
	}

	public static bool operator ==(GStruct2 gstruct2_1, GStruct2 gstruct2_2)
	{
		if (gstruct2_1.method_1() == gstruct2_2.method_1())
		{
			return gstruct2_1.method_3() == gstruct2_2.method_3();
		}
		return false;
	}

	public static bool operator !=(GStruct2 gstruct2_1, GStruct2 gstruct2_2)
	{
		return !(gstruct2_1 == gstruct2_2);
	}

	public static GStruct2 smethod_0(GStruct2 gstruct2_1, GStruct4 gstruct4_0)
	{
		return new GStruct2(gstruct2_1.method_1() + gstruct4_0.method_1(), gstruct2_1.method_3() + gstruct4_0.method_3());
	}

	public static GStruct2 smethod_1(GStruct2 gstruct2_1, GStruct4 gstruct4_0)
	{
		return new GStruct2(gstruct2_1.method_1() - gstruct4_0.method_1(), gstruct2_1.method_3() - gstruct4_0.method_3());
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GStruct2 gStruct))
		{
			return false;
		}
		if (gStruct.method_1() == method_1() && gStruct.method_3() == method_3())
		{
			return gStruct.GetType().Equals(GetType());
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994288439), new object[2] { double_0, double_1 });
	}
}
