using System;

internal static class Class259
{
	private static readonly GStruct2[] gstruct2_0 = new GStruct2[4];

	public static void smethod_0(GClass14 gclass14_0, Class197 class197_0, GStruct1 gstruct1_0, bool bool_0, bool bool_1)
	{
		if (gstruct1_0.method_8() > 0.0 && gstruct1_0.method_10() > 0.0)
		{
			if (!string.IsNullOrEmpty(class197_0.method_14()) && !(class197_0.method_14() == Class84.smethod_0(-994289749)) && !(class197_0.method_14() == Class84.smethod_0(-994291909)) && class197_0.method_157() > 0.0)
			{
				smethod_2((Enum8)0, class197_0, gclass14_0, gstruct1_0, bool_0, bool_1);
			}
			if (bool_0 && !string.IsNullOrEmpty(class197_0.method_10()) && !(class197_0.method_10() == Class84.smethod_0(-994289749)) && !(class197_0.method_10() == Class84.smethod_0(-994291909)) && class197_0.method_158() > 0.0)
			{
				smethod_2((Enum8)3, class197_0, gclass14_0, gstruct1_0, bool_0: true, bool_1);
			}
			if (!string.IsNullOrEmpty(class197_0.method_8()) && !(class197_0.method_8() == Class84.smethod_0(-994289749)) && !(class197_0.method_8() == Class84.smethod_0(-994291909)) && class197_0.method_159() > 0.0)
			{
				smethod_2((Enum8)2, class197_0, gclass14_0, gstruct1_0, bool_0, bool_1);
			}
			if (bool_1 && !string.IsNullOrEmpty(class197_0.method_12()) && !(class197_0.method_12() == Class84.smethod_0(-994289749)) && !(class197_0.method_12() == Class84.smethod_0(-994291909)) && class197_0.method_160() > 0.0)
			{
				smethod_2((Enum8)1, class197_0, gclass14_0, gstruct1_0, bool_0, bool_1: true);
			}
		}
	}

	public static void smethod_1(Enum8 enum8_0, GClass14 gclass14_0, Class197 class197_0, GClass25 gclass25_0, GStruct1 gstruct1_0)
	{
		smethod_3(enum8_0, class197_0, gstruct1_0, bool_0: true, bool_1: true);
		gclass14_0.vmethod_17(gclass25_0, gstruct2_0);
	}

	private static void smethod_2(Enum8 enum8_0, Class197 class197_0, GClass14 gclass14_0, GStruct1 gstruct1_0, bool bool_0, bool bool_1)
	{
		string text = smethod_8(enum8_0, class197_0);
		GStruct3 gstruct3_ = smethod_6(enum8_0, class197_0, text);
		GClass30 gClass = smethod_4(gclass14_0, enum8_0, class197_0, gstruct1_0);
		if (gClass != null)
		{
			object object_ = null;
			if (class197_0.method_186() != null && !class197_0.method_186().method_17() && class197_0.method_169())
			{
				object_ = gclass14_0.vmethod_3();
			}
			GClass19 gclass19_ = smethod_5(gclass14_0, text, gstruct3_, smethod_7(enum8_0, class197_0));
			using (gClass)
			{
				gclass14_0.vmethod_15(gclass19_, gClass);
			}
			gclass14_0.vmethod_4(object_);
		}
		else if (!(text == Class84.smethod_0(-994295053)) && !(text == Class84.smethod_0(-994295057)))
		{
			GClass19 gclass19_2 = smethod_5(gclass14_0, text, gstruct3_, smethod_7(enum8_0, class197_0));
			switch (enum8_0)
			{
			case (Enum8)0:
				gclass14_0.vmethod_10(gclass19_2, Math.Ceiling(gstruct1_0.method_12()), gstruct1_0.method_13() + class197_0.method_157() / 2.0, gstruct1_0.method_14() - 1.0, gstruct1_0.method_13() + class197_0.method_157() / 2.0);
				break;
			case (Enum8)1:
				gclass14_0.vmethod_10(gclass19_2, gstruct1_0.method_14() - class197_0.method_160() / 2.0, Math.Ceiling(gstruct1_0.method_13()), gstruct1_0.method_14() - class197_0.method_160() / 2.0, Math.Floor(gstruct1_0.method_15()));
				break;
			case (Enum8)2:
				gclass14_0.vmethod_10(gclass19_2, Math.Ceiling(gstruct1_0.method_12()), gstruct1_0.method_15() - class197_0.method_159() / 2.0, gstruct1_0.method_14() - 1.0, gstruct1_0.method_15() - class197_0.method_159() / 2.0);
				break;
			case (Enum8)3:
				gclass14_0.vmethod_10(gclass19_2, gstruct1_0.method_12() + class197_0.method_158() / 2.0, Math.Ceiling(gstruct1_0.method_13()), gstruct1_0.method_12() + class197_0.method_158() / 2.0, Math.Floor(gstruct1_0.method_15()));
				break;
			}
		}
		else
		{
			smethod_3(enum8_0, class197_0, gstruct1_0, bool_0, bool_1);
			gclass14_0.vmethod_17(gclass14_0.method_1(gstruct3_), gstruct2_0);
		}
	}

	private static void smethod_3(Enum8 enum8_0, Class197 class197_0, GStruct1 gstruct1_0, bool bool_0, bool bool_1)
	{
		switch (enum8_0)
		{
		case (Enum8)0:
			gstruct2_0[0] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_13());
			gstruct2_0[1] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_13());
			gstruct2_0[2] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_13() + class197_0.method_157());
			gstruct2_0[3] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_13() + class197_0.method_157());
			if (bool_1)
			{
				ref GStruct2 reference3 = ref gstruct2_0[2];
				reference3.method_2(reference3.method_1() - class197_0.method_160());
			}
			if (bool_0)
			{
				ref GStruct2 reference4 = ref gstruct2_0[3];
				reference4.method_2(reference4.method_1() + class197_0.method_158());
			}
			break;
		case (Enum8)1:
			gstruct2_0[0] = new GStruct2(gstruct1_0.method_14() - class197_0.method_160(), gstruct1_0.method_13() + class197_0.method_157());
			gstruct2_0[1] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_13());
			gstruct2_0[2] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_15());
			gstruct2_0[3] = new GStruct2(gstruct1_0.method_14() - class197_0.method_160(), gstruct1_0.method_15() - class197_0.method_159());
			break;
		case (Enum8)2:
			gstruct2_0[0] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_15() - class197_0.method_159());
			gstruct2_0[1] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_15() - class197_0.method_159());
			gstruct2_0[2] = new GStruct2(gstruct1_0.method_14(), gstruct1_0.method_15());
			gstruct2_0[3] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_15());
			if (bool_0)
			{
				ref GStruct2 reference = ref gstruct2_0[0];
				reference.method_2(reference.method_1() + class197_0.method_158());
			}
			if (bool_1)
			{
				ref GStruct2 reference2 = ref gstruct2_0[1];
				reference2.method_2(reference2.method_1() - class197_0.method_160());
			}
			break;
		case (Enum8)3:
			gstruct2_0[0] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_13());
			gstruct2_0[1] = new GStruct2(gstruct1_0.method_12() + class197_0.method_158(), gstruct1_0.method_13() + class197_0.method_157());
			gstruct2_0[2] = new GStruct2(gstruct1_0.method_12() + class197_0.method_158(), gstruct1_0.method_15() - class197_0.method_159());
			gstruct2_0[3] = new GStruct2(gstruct1_0.method_12(), gstruct1_0.method_15());
			break;
		}
	}

	private static GClass30 smethod_4(GClass14 gclass14_0, Enum8 enum8_0, Class197 class197_0, GStruct1 gstruct1_0)
	{
		GClass30 gClass = null;
		switch (enum8_0)
		{
		case (Enum8)0:
			if (class197_0.method_165() > 0.0 || class197_0.method_166() > 0.0)
			{
				gClass = gclass14_0.vmethod_6();
				gClass.vmethod_0(gstruct1_0.method_12() + class197_0.method_158() / 2.0, gstruct1_0.method_13() + class197_0.method_157() / 2.0 + class197_0.method_165());
				if (class197_0.method_165() > 0.0)
				{
					gClass.vmethod_2(gstruct1_0.method_12() + class197_0.method_158() / 2.0 + class197_0.method_165(), gstruct1_0.method_13() + class197_0.method_157() / 2.0, class197_0.method_165(), (GClass30.GEnum8)0);
				}
				gClass.vmethod_1(gstruct1_0.method_14() - class197_0.method_160() / 2.0 - class197_0.method_166(), gstruct1_0.method_13() + class197_0.method_157() / 2.0);
				if (class197_0.method_166() > 0.0)
				{
					gClass.vmethod_2(gstruct1_0.method_14() - class197_0.method_160() / 2.0, gstruct1_0.method_13() + class197_0.method_157() / 2.0 + class197_0.method_166(), class197_0.method_166(), (GClass30.GEnum8)1);
				}
			}
			break;
		case (Enum8)1:
			if (class197_0.method_166() > 0.0 || class197_0.method_167() > 0.0)
			{
				gClass = gclass14_0.vmethod_6();
				bool flag3 = class197_0.method_14() == Class84.smethod_0(-994289749) || class197_0.method_14() == Class84.smethod_0(-994291909);
				bool flag4 = class197_0.method_8() == Class84.smethod_0(-994289749) || class197_0.method_8() == Class84.smethod_0(-994291909);
				gClass.vmethod_0(gstruct1_0.method_14() - class197_0.method_160() / 2.0 - (flag3 ? class197_0.method_166() : 0.0), gstruct1_0.method_13() + class197_0.method_157() / 2.0 + (flag3 ? 0.0 : class197_0.method_166()));
				if ((class197_0.method_166() > 0.0) & flag3)
				{
					gClass.vmethod_2(gstruct1_0.method_14() - class197_0.method_158() / 2.0, gstruct1_0.method_13() + class197_0.method_157() / 2.0 + class197_0.method_166(), class197_0.method_166(), (GClass30.GEnum8)1);
				}
				gClass.vmethod_1(gstruct1_0.method_14() - class197_0.method_160() / 2.0, gstruct1_0.method_15() - class197_0.method_159() / 2.0 - class197_0.method_167());
				if ((class197_0.method_167() > 0.0) & flag4)
				{
					gClass.vmethod_2(gstruct1_0.method_14() - class197_0.method_160() / 2.0 - class197_0.method_167(), gstruct1_0.method_15() - class197_0.method_159() / 2.0, class197_0.method_167(), (GClass30.GEnum8)3);
				}
			}
			break;
		case (Enum8)2:
			if (class197_0.method_168() > 0.0 || class197_0.method_167() > 0.0)
			{
				gClass = gclass14_0.vmethod_6();
				gClass.vmethod_0(gstruct1_0.method_14() - class197_0.method_160() / 2.0, gstruct1_0.method_15() - class197_0.method_159() / 2.0 - class197_0.method_167());
				if (class197_0.method_167() > 0.0)
				{
					gClass.vmethod_2(gstruct1_0.method_14() - class197_0.method_160() / 2.0 - class197_0.method_167(), gstruct1_0.method_15() - class197_0.method_159() / 2.0, class197_0.method_167(), (GClass30.GEnum8)3);
				}
				gClass.vmethod_1(gstruct1_0.method_12() + class197_0.method_158() / 2.0 + class197_0.method_168(), gstruct1_0.method_15() - class197_0.method_159() / 2.0);
				if (class197_0.method_168() > 0.0)
				{
					gClass.vmethod_2(gstruct1_0.method_12() + class197_0.method_158() / 2.0, gstruct1_0.method_15() - class197_0.method_159() / 2.0 - class197_0.method_168(), class197_0.method_168(), (GClass30.GEnum8)2);
				}
			}
			break;
		case (Enum8)3:
			if (class197_0.method_165() > 0.0 || class197_0.method_168() > 0.0)
			{
				gClass = gclass14_0.vmethod_6();
				bool flag = class197_0.method_14() == Class84.smethod_0(-994289749) || class197_0.method_14() == Class84.smethod_0(-994291909);
				bool flag2 = class197_0.method_8() == Class84.smethod_0(-994289749) || class197_0.method_8() == Class84.smethod_0(-994291909);
				gClass.vmethod_0(gstruct1_0.method_12() + class197_0.method_158() / 2.0 + (flag2 ? class197_0.method_168() : 0.0), gstruct1_0.method_15() - class197_0.method_159() / 2.0 - (flag2 ? 0.0 : class197_0.method_168()));
				if ((class197_0.method_168() > 0.0) & flag2)
				{
					gClass.vmethod_2(gstruct1_0.method_12() + class197_0.method_158() / 2.0, gstruct1_0.method_15() - class197_0.method_159() / 2.0 - class197_0.method_168(), class197_0.method_168(), (GClass30.GEnum8)2);
				}
				gClass.vmethod_1(gstruct1_0.method_12() + class197_0.method_158() / 2.0, gstruct1_0.method_13() + class197_0.method_157() / 2.0 + class197_0.method_165());
				if ((class197_0.method_165() > 0.0) & flag)
				{
					gClass.vmethod_2(gstruct1_0.method_12() + class197_0.method_158() / 2.0 + class197_0.method_165(), gstruct1_0.method_13() + class197_0.method_157() / 2.0, class197_0.method_165(), (GClass30.GEnum8)0);
				}
			}
			break;
		}
		return gClass;
	}

	private static GClass19 smethod_5(GClass14 gclass14_0, string string_0, GStruct3 gstruct3_0, double double_0)
	{
		GClass19 gClass = gclass14_0.method_0(gstruct3_0);
		gClass.vmethod_1(double_0);
		if (!(string_0 == Class84.smethod_0(-994292460)))
		{
			if (!(string_0 == Class84.smethod_0(-994295012)))
			{
				if (string_0 == Class84.smethod_0(-994295031))
				{
					gClass.vmethod_2((GEnum4)1);
				}
			}
			else
			{
				gClass.vmethod_2((GEnum4)2);
			}
		}
		else
		{
			gClass.vmethod_2((GEnum4)0);
		}
		return gClass;
	}

	private static GStruct3 smethod_6(Enum8 enum8_0, Class196 class196_0, string string_0)
	{
		switch (enum8_0)
		{
		default:
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994295034));
		case (Enum8)0:
			if (!(string_0 == Class84.smethod_0(-994295053)))
			{
				return class196_0.method_161();
			}
			return smethod_9(class196_0.method_161());
		case (Enum8)1:
			if (!(string_0 == Class84.smethod_0(-994295057)))
			{
				return class196_0.method_164();
			}
			return smethod_9(class196_0.method_164());
		case (Enum8)2:
			if (!(string_0 == Class84.smethod_0(-994295057)))
			{
				return class196_0.method_163();
			}
			return smethod_9(class196_0.method_163());
		case (Enum8)3:
			if (!(string_0 == Class84.smethod_0(-994295053)))
			{
				return class196_0.method_162();
			}
			return smethod_9(class196_0.method_162());
		}
	}

	private static double smethod_7(Enum8 enum8_0, Class196 class196_0)
	{
		return enum8_0 switch
		{
			(Enum8)0 => class196_0.method_157(), 
			(Enum8)1 => class196_0.method_160(), 
			(Enum8)2 => class196_0.method_159(), 
			(Enum8)3 => class196_0.method_158(), 
			_ => throw new ArgumentOutOfRangeException(Class84.smethod_0(-994294991)), 
		};
	}

	private static string smethod_8(Enum8 enum8_0, Class196 class196_0)
	{
		return enum8_0 switch
		{
			(Enum8)0 => class196_0.method_14(), 
			(Enum8)1 => class196_0.method_12(), 
			(Enum8)2 => class196_0.method_8(), 
			(Enum8)3 => class196_0.method_10(), 
			_ => throw new ArgumentOutOfRangeException(Class84.smethod_0(-994294996)), 
		};
	}

	private static GStruct3 smethod_9(GStruct3 gstruct3_0)
	{
		return GStruct3.smethod_6(gstruct3_0.method_0() / 2, gstruct3_0.method_1() / 2, gstruct3_0.method_2() / 2);
	}
}
