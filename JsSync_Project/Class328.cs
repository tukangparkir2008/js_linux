internal static class Class328
{
	public static bool smethod_0(GStruct3 gstruct3_0)
	{
		return gstruct3_0.method_3() > 0;
	}

	public static bool smethod_1(GClass14 gclass14_0, Class197 class197_0)
	{
		Class197 @class = class197_0.method_194();
		while (true)
		{
			if (!(@class.method_122() == Class84.smethod_0(-994291909)))
			{
				Class197 class2 = @class.method_194();
				if (class2 == @class)
				{
					break;
				}
				@class = class2;
				continue;
			}
			GStruct1 gstruct1_ = gclass14_0.method_3();
			GStruct1 gstruct1_2 = class197_0.method_194().method_144();
			gstruct1_2.method_5(gstruct1_2.method_4() - 2.0);
			gstruct1_2.method_9(gstruct1_2.method_8() + 2.0);
			if (!class197_0.vmethod_5())
			{
				gstruct1_2.method_24(class197_0.method_186().method_27());
			}
			gstruct1_2.method_22(gstruct1_);
			gclass14_0.vmethod_1(gstruct1_2);
			return true;
		}
		return false;
	}

	public static void smethod_2(GClass14 gclass14_0, GClass31 gclass31_0, GStruct1 gstruct1_0)
	{
		gclass14_0.vmethod_11(gclass14_0.method_0(GStruct3.smethod_4()), gstruct1_0.method_12() + 3.0, gstruct1_0.method_13() + 3.0, 13.0, 14.0);
		GClass29 gClass = gclass31_0.method_0().method_11();
		gclass14_0.vmethod_14(gClass, new GStruct1(gstruct1_0.method_12() + 4.0, gstruct1_0.method_13() + 4.0, gClass.vmethod_0(), gClass.vmethod_1()));
	}

	public static void smethod_3(GClass14 gclass14_0, GClass31 gclass31_0, GStruct1 gstruct1_0)
	{
		gclass14_0.vmethod_11(gclass14_0.method_0(GStruct3.smethod_4()), gstruct1_0.method_12() + 2.0, gstruct1_0.method_13() + 2.0, 15.0, 15.0);
		GClass29 gClass = gclass31_0.method_0().method_12();
		gclass14_0.vmethod_14(gClass, new GStruct1(gstruct1_0.method_12() + 3.0, gstruct1_0.method_13() + 3.0, gClass.vmethod_0(), gClass.vmethod_1()));
	}

	public static GClass30 smethod_4(GClass14 gclass14_0, GStruct1 gstruct1_0, double double_0, double double_1, double double_2, double double_3)
	{
		GClass30 gClass = gclass14_0.vmethod_6();
		gClass.vmethod_0(gstruct1_0.method_12() + double_0, gstruct1_0.method_13());
		gClass.vmethod_1(gstruct1_0.method_14() - double_1, gstruct1_0.method_6());
		if (double_1 > 0.0)
		{
			gClass.vmethod_2(gstruct1_0.method_14(), gstruct1_0.method_13() + double_1, double_1, (GClass30.GEnum8)1);
		}
		gClass.vmethod_1(gstruct1_0.method_14(), gstruct1_0.method_15() - double_2);
		if (double_2 > 0.0)
		{
			gClass.vmethod_2(gstruct1_0.method_14() - double_2, gstruct1_0.method_15(), double_2, (GClass30.GEnum8)3);
		}
		gClass.vmethod_1(gstruct1_0.method_12() + double_3, gstruct1_0.method_15());
		if (double_3 > 0.0)
		{
			gClass.vmethod_2(gstruct1_0.method_12(), gstruct1_0.method_15() - double_3, double_3, (GClass30.GEnum8)2);
		}
		gClass.vmethod_1(gstruct1_0.method_12(), gstruct1_0.method_13() + double_0);
		if (double_0 > 0.0)
		{
			gClass.vmethod_2(gstruct1_0.method_12() + double_0, gstruct1_0.method_13(), double_0, (GClass30.GEnum8)0);
		}
		return gClass;
	}
}
