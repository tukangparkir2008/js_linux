using System;

public struct GStruct1
{
	public static readonly GStruct1 gstruct1_0;

	private double double_0;

	private double double_1;

	private double double_2;

	private double double_3;

	public GStruct1(double double_4, double double_5, double double_6, double double_7)
	{
		double_2 = double_4;
		double_3 = double_5;
		double_1 = double_6;
		double_0 = double_7;
	}

	public GStruct1(GStruct2 gstruct2_0, GStruct4 gstruct4_0)
	{
		double_2 = gstruct2_0.method_1();
		double_3 = gstruct2_0.method_3();
		double_1 = gstruct4_0.method_1();
		double_0 = gstruct4_0.method_3();
	}

	public GStruct2 method_0()
	{
		return new GStruct2(method_4(), method_6());
	}

	public void method_1(GStruct2 gstruct2_0)
	{
		method_5(gstruct2_0.method_1());
		method_7(gstruct2_0.method_3());
	}

	public GStruct4 method_2()
	{
		return new GStruct4(method_8(), method_10());
	}

	public void method_3(GStruct4 gstruct4_0)
	{
		method_9(gstruct4_0.method_1());
		method_11(gstruct4_0.method_3());
	}

	public double method_4()
	{
		return double_2;
	}

	public void method_5(double double_4)
	{
		double_2 = double_4;
	}

	public double method_6()
	{
		return double_3;
	}

	public void method_7(double double_4)
	{
		double_3 = double_4;
	}

	public double method_8()
	{
		return double_1;
	}

	public void method_9(double double_4)
	{
		double_1 = double_4;
	}

	public double method_10()
	{
		return double_0;
	}

	public void method_11(double double_4)
	{
		double_0 = double_4;
	}

	public double method_12()
	{
		return method_4();
	}

	public double method_13()
	{
		return method_6();
	}

	public double method_14()
	{
		return method_4() + method_8();
	}

	public double method_15()
	{
		return method_6() + method_10();
	}

	public bool method_16()
	{
		if (method_8() > 0.0)
		{
			return method_10() <= 0.0;
		}
		return true;
	}

	public static bool operator ==(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		if (Math.Abs(gstruct1_1.method_4() - gstruct1_2.method_4()) < 0.001 && Math.Abs(gstruct1_1.method_6() - gstruct1_2.method_6()) < 0.001 && Math.Abs(gstruct1_1.method_8() - gstruct1_2.method_8()) < 0.001)
		{
			return Math.Abs(gstruct1_1.method_10() - gstruct1_2.method_10()) < 0.001;
		}
		return false;
	}

	public static bool operator !=(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		return !(gstruct1_1 == gstruct1_2);
	}

	public static GStruct1 smethod_0(double double_4, double double_5, double double_6, double double_7)
	{
		return new GStruct1(double_4, double_5, double_6 - double_4, double_7 - double_5);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is GStruct1 gStruct))
		{
			return false;
		}
		if (Math.Abs(gStruct.method_4() - method_4()) < 0.001 && Math.Abs(gStruct.method_6() - method_6()) < 0.001 && Math.Abs(gStruct.method_8() - method_8()) < 0.001)
		{
			return Math.Abs(gStruct.method_10() - method_10()) < 0.001;
		}
		return false;
	}

	public bool method_17(double double_4, double double_5)
	{
		if (method_4() <= double_4 && double_4 < method_4() + method_8() && method_6() <= double_5)
		{
			return double_5 < method_6() + method_10();
		}
		return false;
	}

	public bool method_18(GStruct2 gstruct2_0)
	{
		return method_17(gstruct2_0.method_1(), gstruct2_0.method_3());
	}

	public bool method_19(GStruct1 gstruct1_1)
	{
		if (method_4() <= gstruct1_1.method_4() && gstruct1_1.method_4() + gstruct1_1.method_8() <= method_4() + method_8() && method_6() <= gstruct1_1.method_6())
		{
			return gstruct1_1.method_6() + gstruct1_1.method_10() <= method_6() + method_10();
		}
		return false;
	}

	public void method_20(double double_4, double double_5)
	{
		method_5(method_4() - double_4);
		method_7(method_6() - double_5);
		method_9(method_8() + 2.0 * double_4);
		method_11(method_10() + 2.0 * double_5);
	}

	public void method_21(GStruct4 gstruct4_0)
	{
		method_20(gstruct4_0.method_1(), gstruct4_0.method_3());
	}

	public static GStruct1 smethod_1(GStruct1 gstruct1_1, double double_4, double double_5)
	{
		GStruct1 result = gstruct1_1;
		result.method_20(double_4, double_5);
		return result;
	}

	public void method_22(GStruct1 gstruct1_1)
	{
		GStruct1 gStruct = smethod_2(gstruct1_1, this);
		method_5(gStruct.method_4());
		method_7(gStruct.method_6());
		method_9(gStruct.method_8());
		method_11(gStruct.method_10());
	}

	public static GStruct1 smethod_2(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		double num = Math.Max(gstruct1_1.method_4(), gstruct1_2.method_4());
		double num2 = Math.Min(gstruct1_1.method_4() + gstruct1_1.method_8(), gstruct1_2.method_4() + gstruct1_2.method_8());
		double num3 = Math.Max(gstruct1_1.method_6(), gstruct1_2.method_6());
		double num4 = Math.Min(gstruct1_1.method_6() + gstruct1_1.method_10(), gstruct1_2.method_6() + gstruct1_2.method_10());
		if (num2 >= num && num4 >= num3)
		{
			return new GStruct1(num, num3, num2 - num, num4 - num3);
		}
		return gstruct1_0;
	}

	public bool method_23(GStruct1 gstruct1_1)
	{
		if (gstruct1_1.method_4() < method_4() + method_8() && method_4() < gstruct1_1.method_4() + gstruct1_1.method_8() && gstruct1_1.method_6() < method_6() + method_10())
		{
			return method_6() < gstruct1_1.method_6() + gstruct1_1.method_10();
		}
		return false;
	}

	public static GStruct1 smethod_3(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		double num = Math.Min(gstruct1_1.method_4(), gstruct1_2.method_4());
		double num2 = Math.Max(gstruct1_1.method_4() + gstruct1_1.method_8(), gstruct1_2.method_4() + gstruct1_2.method_8());
		double num3 = Math.Min(gstruct1_1.method_6(), gstruct1_2.method_6());
		double num4 = Math.Max(gstruct1_1.method_6() + gstruct1_1.method_10(), gstruct1_2.method_6() + gstruct1_2.method_10());
		return new GStruct1(num, num3, num2 - num, num4 - num3);
	}

	public void method_24(GStruct2 gstruct2_0)
	{
		method_25(gstruct2_0.method_1(), gstruct2_0.method_3());
	}

	public void method_25(double double_4, double double_5)
	{
		method_5(method_4() + double_4);
		method_7(method_6() + double_5);
	}

	public override int GetHashCode()
	{
		return (int)((uint)method_4() ^ (((uint)method_6() << 13) | ((uint)method_6() >> 19)) ^ (((uint)method_8() << 26) | ((uint)method_8() >> 6)) ^ (((uint)method_10() << 7) | ((uint)method_10() >> 25)));
	}

	public override string ToString()
	{
		return Class84.smethod_0(-994288400) + method_4() + Class84.smethod_0(-994288406) + method_6() + Class84.smethod_0(-994288412) + method_8() + Class84.smethod_0(-994288366) + method_10() + Class84.smethod_0(-994288383);
	}
}
