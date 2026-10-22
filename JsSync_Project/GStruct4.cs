using System;

public struct GStruct4
{
	public static readonly GStruct4 gstruct4_0;

	private double double_0;

	private double double_1;

	public GStruct4(GStruct4 gstruct4_1)
	{
		double_1 = gstruct4_1.double_1;
		double_0 = gstruct4_1.double_0;
	}

	public GStruct4(GStruct2 gstruct2_0)
	{
		double_1 = gstruct2_0.method_1();
		double_0 = gstruct2_0.method_3();
	}

	public GStruct4(double double_2, double double_3)
	{
		double_1 = double_2;
		double_0 = double_3;
	}

	public bool method_0()
	{
		if (Math.Abs(double_1) < 0.0001)
		{
			return Math.Abs(double_0) < 0.0001;
		}
		return false;
	}

	public double method_1()
	{
		return double_1;
	}

	public void method_2(double double_2)
	{
		double_1 = double_2;
	}

	public double method_3()
	{
		return double_0;
	}

	public void method_4(double double_2)
	{
		double_0 = double_2;
	}

	public static explicit operator GStruct2(GStruct4 gstruct4_1)
	{
		return new GStruct2(gstruct4_1.method_1(), gstruct4_1.method_3());
	}

	public static GStruct4 operator +(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		return smethod_0(gstruct4_1, gstruct4_2);
	}

	public static GStruct4 operator -(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		return smethod_1(gstruct4_1, gstruct4_2);
	}

	public static bool operator ==(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		if (Math.Abs(gstruct4_1.method_1() - gstruct4_2.method_1()) < 0.001)
		{
			return Math.Abs(gstruct4_1.method_3() - gstruct4_2.method_3()) < 0.001;
		}
		return false;
	}

	public static bool operator !=(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		return !(gstruct4_1 == gstruct4_2);
	}

	public static GStruct4 smethod_0(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		return new GStruct4(gstruct4_1.method_1() + gstruct4_2.method_1(), gstruct4_1.method_3() + gstruct4_2.method_3());
	}

	public static GStruct4 smethod_1(GStruct4 gstruct4_1, GStruct4 gstruct4_2)
	{
		return new GStruct4(gstruct4_1.method_1() - gstruct4_2.method_1(), gstruct4_1.method_3() - gstruct4_2.method_3());
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GStruct4 gStruct))
		{
			return false;
		}
		if (Math.Abs(gStruct.method_1() - method_1()) < 0.001 && Math.Abs(gStruct.method_3() - method_3()) < 0.001)
		{
			return gStruct.GetType() == GetType();
		}
		return false;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public GStruct2 method_5()
	{
		return (GStruct2)this;
	}

	public override string ToString()
	{
		return Class84.smethod_0(-994288327) + double_1 + Class84.smethod_0(-994288329) + double_0 + Class84.smethod_0(-994288383);
	}
}
