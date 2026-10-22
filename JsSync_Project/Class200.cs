using System;

internal sealed class Class200 : Class197
{
	private readonly Class246 class246_0;

	private Class214 class214_1;

	private bool bool_2;

	public Class200(Class197 class197_2, Class343 class343_1)
		: base(class197_2, class343_1)
	{
		class246_0 = new Class246(this);
		method_203().Add(class246_0);
	}

	public GClass29 method_238()
	{
		return class246_0.vmethod_2();
	}

	protected override void vmethod_9(GClass14 gclass14_0)
	{
		if (class214_1 == null)
		{
			class214_1 = new Class214(method_186(), method_240);
			class214_1.method_2(method_217(Class84.smethod_0(-994293138)), (method_195() != null) ? method_195().method_1() : null);
		}
		GStruct1 gstruct1_ = Class299.smethod_5(method_202(), default);
		GStruct2 gStruct = GStruct2.gstruct2_0;
		if (!vmethod_5())
		{
			gStruct = method_186().method_27();
		}
		gstruct1_.method_24(gStruct);
		bool flag = Class328.smethod_1(gclass14_0, this);
		method_230(gclass14_0, gstruct1_, bool_2: true, bool_3: true);
		Class259.smethod_0(gclass14_0, this, gstruct1_, bool_0: true, bool_1: true);
		GStruct1 gstruct1_2 = class246_0.method_1();
		gstruct1_2.method_24(gStruct);
		gstruct1_2.method_11(gstruct1_2.method_10() - (method_157() + method_159() + method_147() + method_149()));
		gstruct1_2.method_7(gstruct1_2.method_6() + (method_157() + method_147()));
		gstruct1_2.method_5(Math.Floor(gstruct1_2.method_4()));
		gstruct1_2.method_7(Math.Floor(gstruct1_2.method_6()));
		if (class246_0.vmethod_2() != null)
		{
			if (gstruct1_2.method_8() > 0.0 && gstruct1_2.method_10() > 0.0)
			{
				if (class246_0.method_26() == GStruct1.gstruct1_0)
				{
					gclass14_0.vmethod_14(class246_0.vmethod_2(), gstruct1_2);
				}
				else
				{
					gclass14_0.vmethod_13(class246_0.vmethod_2(), gstruct1_2, class246_0.method_26());
				}
				if (class246_0.method_19())
				{
					gclass14_0.vmethod_12(method_237(gclass14_0, bool_2: true), class246_0.method_3() + gStruct.method_1(), class246_0.method_5() + gStruct.method_3(), class246_0.method_7() + 2.0, Class277.smethod_15(class246_0).method_4());
				}
			}
		}
		else if (bool_2)
		{
			if (bool_2 && gstruct1_2.method_8() > 19.0 && gstruct1_2.method_10() > 19.0)
			{
				Class328.smethod_3(gclass14_0, method_186(), gstruct1_2);
			}
		}
		else
		{
			Class328.smethod_2(gclass14_0, method_186(), gstruct1_2);
			if (gstruct1_2.method_8() > 19.0 && gstruct1_2.method_10() > 19.0)
			{
				gclass14_0.vmethod_11(gclass14_0.method_0(GStruct3.smethod_4()), gstruct1_2.method_4(), gstruct1_2.method_6(), gstruct1_2.method_8(), gstruct1_2.method_10());
			}
		}
		if (flag)
		{
			gclass14_0.vmethod_0();
		}
	}

	internal override void vmethod_8(GClass14 gclass14_0)
	{
		if (!bool_1)
		{
			if (class214_1 == null && (method_186().method_19() || method_186().method_21()))
			{
				class214_1 = new Class214(method_186(), method_240);
				if (method_80() != null && method_80() != Class84.smethod_0(-994292400))
				{
					class214_1.method_2(method_80(), (method_195() != null) ? method_195().method_1() : null);
				}
				else
				{
					class214_1.method_2(method_217(Class84.smethod_0(-994293138)), (method_195() != null) ? method_195().method_1() : null);
				}
			}
			method_184(gclass14_0);
			bool_1 = true;
		}
		Class281.smethod_0(class246_0);
	}

	public override void Dispose()
	{
		if (class214_1 != null)
		{
			class214_1.Dispose();
		}
		base.Dispose();
	}

	private void method_239()
	{
		method_183(Class84.smethod_0(-994292460), Class84.smethod_0(-994292480), Class84.smethod_0(-994292422));
		string string_;
		method_17(string_ = Class84.smethod_0(-994292440));
		method_21(string_);
	}

	private void method_240(GClass29 gclass29_0, GStruct1 gstruct1_0, bool bool_3)
	{
		class246_0.vmethod_3(gclass29_0);
		class246_0.method_27(gstruct1_0);
		bool_2 = true;
		bool_1 = false;
		if (bool_2 && gclass29_0 == null)
		{
			method_239();
		}
		if (!method_186().method_21() | bool_3)
		{
			Class239 @class = new Class239(method_60());
			Class239 class2 = new Class239(method_64());
			bool bool_4 = @class.method_0() <= 0.0 || @class.method_4() != (Enum4)2 || class2.method_0() <= 0.0 || class2.method_4() != (Enum4)2;
			method_186().method_71(bool_4);
		}
	}
}
