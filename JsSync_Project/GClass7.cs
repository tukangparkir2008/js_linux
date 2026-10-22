using System;

public static class GClass7
{
	public static GStruct4 smethod_0(GClass14 gclass14_0, GClass31 gclass31_0, GStruct4 gstruct4_0, GStruct4 gstruct4_1)
	{
		gclass31_0.method_61(gclass14_0);
		if (gstruct4_1.method_1() > 0.0 && gstruct4_1.method_1() < gclass31_0.method_33().method_1())
		{
			gclass31_0.method_32(new GStruct4(gstruct4_1.method_1(), 0.0));
			gclass31_0.method_61(gclass14_0);
		}
		double num = Math.Max((gstruct4_1.method_1() > 0.0) ? Math.Min(gstruct4_1.method_1(), (int)gclass31_0.method_33().method_1()) : ((double)(int)gclass31_0.method_33().method_1()), gstruct4_0.method_1());
		if (num > gclass31_0.method_33().method_1())
		{
			gclass31_0.method_32(new GStruct4(num, 0.0));
			gclass31_0.method_61(gclass14_0);
		}
		double double_ = Math.Max((gstruct4_1.method_3() > 0.0) ? Math.Min(gstruct4_1.method_3(), (int)gclass31_0.method_33().method_3()) : ((double)(int)gclass31_0.method_33().method_3()), gstruct4_0.method_3());
		return new GStruct4(num, double_);
	}

	public static GStruct4 smethod_1(GClass14 gclass14_0, GClass31 gclass31_0, GStruct4 gstruct4_0, GStruct4 gstruct4_1, GStruct4 gstruct4_2, bool bool_0, bool bool_1)
	{
		if (bool_0)
		{
			gclass31_0.method_32(new GStruct4(0.0, 0.0));
		}
		else if (bool_1)
		{
			gclass31_0.method_32(new GStruct4(gstruct4_0.method_1(), 0.0));
		}
		else
		{
			gclass31_0.method_32(gstruct4_0);
		}
		gclass31_0.method_61(gclass14_0);
		GStruct4 result = gstruct4_0;
		if (bool_0 | bool_1)
		{
			if (bool_0)
			{
				if (gstruct4_2.method_1() > 0.0 && gstruct4_2.method_1() < gclass31_0.method_33().method_1())
				{
					gclass31_0.method_32(gstruct4_2);
					gclass31_0.method_61(gclass14_0);
				}
				else if (gstruct4_1.method_1() > 0.0 && gstruct4_1.method_1() > gclass31_0.method_33().method_1())
				{
					gclass31_0.method_32(new GStruct4(gstruct4_1.method_1(), 0.0));
					gclass31_0.method_61(gclass14_0);
				}
				result = gclass31_0.method_33();
			}
			else if (Math.Abs(gstruct4_0.method_3() - gclass31_0.method_33().method_3()) > 0.01)
			{
				double num = gstruct4_0.method_1();
				result.method_4((!(gstruct4_1.method_3() > 0.0) || gstruct4_1.method_3() <= gclass31_0.method_33().method_3()) ? gclass31_0.method_33().method_3() : gstruct4_1.method_3());
				if (Math.Abs(num - gstruct4_0.method_1()) > 0.01)
				{
					return smethod_1(gclass14_0, gclass31_0, gstruct4_0, gstruct4_1, gstruct4_2, bool_0: false, bool_1: true);
				}
			}
		}
		return result;
	}
}
