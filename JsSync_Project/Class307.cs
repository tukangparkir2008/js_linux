using System;

internal static class Class307
{
	public static void smethod_0(GClass14 gclass14_0, Class197 class197_0, Class214 class214_0, GStruct1 gstruct1_0)
	{
		GStruct4 gstruct4_ = new GStruct4((class214_0.method_1() == GStruct1.gstruct1_0) ? class214_0.method_0().vmethod_0() : class214_0.method_1().method_8(), (class214_0.method_1() == GStruct1.gstruct1_0) ? class214_0.method_0().vmethod_1() : class214_0.method_1().method_10());
		GStruct2 gstruct2_ = smethod_1(class197_0.method_70(), gstruct1_0, gstruct4_);
		GStruct1 gstruct1_1 = ((class214_0.method_1() == GStruct1.gstruct1_0) ? new GStruct1(0.0, 0.0, gstruct4_.method_1(), gstruct4_.method_3()) : new GStruct1(class214_0.method_1().method_12(), class214_0.method_1().method_13(), gstruct4_.method_1(), gstruct4_.method_3()));
		GStruct1 gStruct = new GStruct1(gstruct2_, gstruct4_);
		GStruct1 gstruct1_2 = gstruct1_0;
		gstruct1_2.method_22(gclass14_0.method_3());
		gclass14_0.vmethod_1(gstruct1_2);
		string text = class197_0.method_72();
		if (!(text == Class84.smethod_0(-994295126)))
		{
			if (!(text == Class84.smethod_0(-994295078)))
			{
				if (!(text == Class84.smethod_0(-994295095)))
				{
					smethod_4(gclass14_0, class214_0, gstruct1_0, gstruct1_1, gStruct, gstruct4_);
				}
				else
				{
					smethod_3(gclass14_0, class214_0, gstruct1_0, gstruct1_1, gStruct, gstruct4_);
				}
			}
			else
			{
				smethod_2(gclass14_0, class214_0, gstruct1_0, gstruct1_1, gStruct, gstruct4_);
			}
		}
		else
		{
			gclass14_0.vmethod_13(class214_0.method_0(), gStruct, gstruct1_1);
		}
		gclass14_0.vmethod_0();
	}

	private static GStruct2 smethod_1(string string_0, GStruct1 gstruct1_0, GStruct4 gstruct4_0)
	{
		double double_ = gstruct1_0.method_12();
		if (string_0.IndexOf(Class84.smethod_0(-994295048), StringComparison.OrdinalIgnoreCase) > -1)
		{
			double_ = gstruct1_0.method_12() + 0.5;
		}
		else if (string_0.IndexOf(Class84.smethod_0(-994291897), StringComparison.OrdinalIgnoreCase) > -1)
		{
			double_ = gstruct1_0.method_14() - gstruct4_0.method_1();
		}
		else if (string_0.IndexOf(Class84.smethod_0(-994274584), StringComparison.OrdinalIgnoreCase) < 0)
		{
			double_ = gstruct1_0.method_12() + (gstruct1_0.method_8() - gstruct4_0.method_1()) / 2.0 + 0.5;
		}
		double double_2 = gstruct1_0.method_13();
		if (string_0.IndexOf(Class84.smethod_0(-994291933), StringComparison.OrdinalIgnoreCase) > -1)
		{
			double_2 = gstruct1_0.method_13();
		}
		else if (string_0.IndexOf(Class84.smethod_0(-994291875), StringComparison.OrdinalIgnoreCase) > -1)
		{
			double_2 = gstruct1_0.method_15() - gstruct4_0.method_3();
		}
		else if (string_0.IndexOf(Class84.smethod_0(-994274584), StringComparison.OrdinalIgnoreCase) < 0)
		{
			double_2 = gstruct1_0.method_13() + (gstruct1_0.method_10() - gstruct4_0.method_3()) / 2.0 + 0.5;
		}
		return new GStruct2(double_, double_2);
	}

	private static void smethod_2(GClass14 gclass14_0, Class214 class214_0, GStruct1 gstruct1_0, GStruct1 gstruct1_1, GStruct1 gstruct1_2, GStruct4 gstruct4_0)
	{
		while (gstruct1_2.method_4() > gstruct1_0.method_4())
		{
			gstruct1_2.method_5(gstruct1_2.method_4() - gstruct4_0.method_1());
		}
		using GClass25 gclass25_ = gclass14_0.vmethod_5(class214_0.method_0(), gstruct1_1, gstruct1_2.method_0());
		gclass14_0.vmethod_12(gclass25_, gstruct1_0.method_4(), gstruct1_2.method_6(), gstruct1_0.method_8(), gstruct1_1.method_10());
	}

	private static void smethod_3(GClass14 gclass14_0, Class214 class214_0, GStruct1 gstruct1_0, GStruct1 gstruct1_1, GStruct1 gstruct1_2, GStruct4 gstruct4_0)
	{
		while (gstruct1_2.method_6() > gstruct1_0.method_6())
		{
			gstruct1_2.method_7(gstruct1_2.method_6() - gstruct4_0.method_3());
		}
		using GClass25 gclass25_ = gclass14_0.vmethod_5(class214_0.method_0(), gstruct1_1, gstruct1_2.method_0());
		gclass14_0.vmethod_12(gclass25_, gstruct1_2.method_4(), gstruct1_0.method_6(), gstruct1_1.method_8(), gstruct1_0.method_10());
	}

	private static void smethod_4(GClass14 gclass14_0, Class214 class214_0, GStruct1 gstruct1_0, GStruct1 gstruct1_1, GStruct1 gstruct1_2, GStruct4 gstruct4_0)
	{
		while (gstruct1_2.method_4() > gstruct1_0.method_4())
		{
			gstruct1_2.method_5(gstruct1_2.method_4() - gstruct4_0.method_1());
		}
		while (gstruct1_2.method_6() > gstruct1_0.method_6())
		{
			gstruct1_2.method_7(gstruct1_2.method_6() - gstruct4_0.method_3());
		}
		using GClass25 gclass25_ = gclass14_0.vmethod_5(class214_0.method_0(), gstruct1_1, gstruct1_2.method_0());
		gclass14_0.vmethod_12(gclass25_, gstruct1_0.method_4(), gstruct1_0.method_6(), gstruct1_0.method_8(), gstruct1_0.method_10());
	}
}
