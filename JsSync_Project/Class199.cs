internal sealed class Class199 : Class197
{
	public Class199(Class197 class197_2, Class343 class343_1)
		: base(class197_2, class343_1)
	{
		method_83(Class84.smethod_0(-994289969));
	}

	protected override void vmethod_7(GClass14 gclass14_0)
	{
		if (!(method_82() == Class84.smethod_0(-994289749)))
		{
			method_234();
			Class197 @class = Class277.smethod_3(this);
			double num = method_194().method_130().method_1() + method_194().method_148() + method_154() + method_194().method_158();
			double double_ = ((@class == null && method_188() != null) ? method_188().method_141() : ((method_188() == null) ? method_130().method_3() : 0.0)) + method_224(@class) + ((@class != null) ? (@class.method_138() + @class.method_159()) : 0.0);
			method_131(new GStruct2(num, double_));
			method_139(double_);
			double num2 = method_219();
			double num3 = method_194().method_132().method_1() - method_194().method_148() - method_194().method_150() - method_194().method_158() - method_194().method_160() - method_154() - method_156() - method_158() - method_160();
			if (method_60() != Class84.smethod_0(-994293691) && !string.IsNullOrEmpty(method_60()))
			{
				num3 = Class172.smethod_4(method_60(), num3, this, bool_0: false);
			}
			if (num3 < num2 || num3 >= 9999.0)
			{
				num3 = num2;
			}
			double num4 = method_145();
			if (num4 < 1.0)
			{
				num4 = method_132().method_3() + method_157() + method_159();
			}
			if (num4 < 1.0)
			{
				num4 = 2.0;
			}
			if (num4 <= 2.0 && method_157() < 1.0 && method_159() < 1.0)
			{
				string string_;
				method_9(string_ = Class84.smethod_0(-994292460));
				method_15(string_);
				method_7(Class84.smethod_0(-994292442));
				method_1(Class84.smethod_0(-994292442));
			}
			method_133(new GStruct4(num3, num4));
			method_139(method_130().method_3() + method_147() + method_149() + num4);
		}
	}

	protected override void vmethod_9(GClass14 gclass14_0)
	{
		GStruct2 gStruct = ((method_186() == null || vmethod_5()) ? GStruct2.gstruct2_0 : method_186().method_27());
		GStruct1 gstruct1_ = new GStruct1(method_134().method_4() + gStruct.method_1(), method_134().method_6() + gStruct.method_3(), method_134().method_8(), method_134().method_10());
		if (gstruct1_.method_10() > 2.0 && Class328.smethod_0(method_172()))
		{
			gclass14_0.vmethod_12(gclass14_0.method_1(method_172()), gstruct1_.method_4(), gstruct1_.method_6(), gstruct1_.method_8(), gstruct1_.method_10());
		}
		GClass25 gclass25_ = gclass14_0.method_1(method_161());
		Class259.smethod_1((Enum8)0, gclass14_0, this, gclass25_, gstruct1_);
		if (gstruct1_.method_10() > 1.0)
		{
			GClass25 gclass25_2 = gclass14_0.method_1(method_162());
			Class259.smethod_1((Enum8)3, gclass14_0, this, gclass25_2, gstruct1_);
			GClass25 gclass25_3 = gclass14_0.method_1(method_164());
			Class259.smethod_1((Enum8)1, gclass14_0, this, gclass25_3, gstruct1_);
			GClass25 gclass25_4 = gclass14_0.method_1(method_163());
			Class259.smethod_1((Enum8)2, gclass14_0, this, gclass25_4, gstruct1_);
		}
	}
}
