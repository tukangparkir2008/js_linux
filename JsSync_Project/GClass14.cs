using System;
using System.Collections.Generic;

public abstract class GClass14 : IDisposable
{
	protected readonly GClass0 gclass0_0;

	protected readonly Stack<GStruct1> stack_0 = new Stack<GStruct1>();

	private Stack<GStruct1> stack_1 = new Stack<GStruct1>();

	protected GClass14(GClass0 gclass0_1, GStruct1 gstruct1_0)
	{
		GClass24.smethod_1(gclass0_1, Class84.smethod_0(-994290092));
		gclass0_0 = gclass0_1;
		stack_0.Push(gstruct1_0);
	}

	public GClass19 method_0(GStruct3 gstruct3_0)
	{
		return gclass0_0.method_2(gstruct3_0);
	}

	public GClass25 method_1(GStruct3 gstruct3_0)
	{
		return gclass0_0.method_3(gstruct3_0);
	}

	public GClass25 method_2(GStruct1 gstruct1_0, GStruct3 gstruct3_0, GStruct3 gstruct3_1, double double_0)
	{
		return gclass0_0.method_4(gstruct1_0, gstruct3_0, gstruct3_1, double_0);
	}

	public GStruct1 method_3()
	{
		return stack_0.Peek();
	}

	public abstract void vmethod_0();

	public abstract void vmethod_1(GStruct1 gstruct1_0);

	public abstract void vmethod_2(GStruct1 gstruct1_0);

	public void method_4()
	{
		while (stack_0.Count > 1)
		{
			GStruct1 item = method_3();
			stack_1.Push(item);
			vmethod_0();
		}
	}

	public void method_5()
	{
		while (stack_1.Count > 0)
		{
			GStruct1 gstruct1_ = stack_1.Pop();
			vmethod_1(gstruct1_);
		}
	}

	public abstract object vmethod_3();

	public abstract void vmethod_4(object object_0);

	public abstract GClass25 vmethod_5(GClass29 gclass29_0, GStruct1 gstruct1_0, GStruct2 gstruct2_0);

	public abstract GClass30 vmethod_6();

	public abstract GStruct4 vmethod_7(string string_0, GClass62 gclass62_0);

	public abstract void vmethod_8(string string_0, GClass62 gclass62_0, double double_0, out int int_0, out double double_1);

	public abstract void vmethod_9(string string_0, GClass62 gclass62_0, GStruct3 gstruct3_0, GStruct2 gstruct2_0, GStruct4 gstruct4_0, bool bool_0);

	public abstract void vmethod_10(GClass19 gclass19_0, double double_0, double double_1, double double_2, double double_3);

	public abstract void vmethod_11(GClass19 gclass19_0, double double_0, double double_1, double double_2, double double_3);

	public abstract void vmethod_12(GClass25 gclass25_0, double double_0, double double_1, double double_2, double double_3);

	public abstract void vmethod_13(GClass29 gclass29_0, GStruct1 gstruct1_0, GStruct1 gstruct1_1);

	public abstract void vmethod_14(GClass29 gclass29_0, GStruct1 gstruct1_0);

	public abstract void vmethod_15(GClass19 gclass19_0, GClass30 gclass30_0);

	public abstract void vmethod_16(GClass25 gclass25_0, GClass30 gclass30_0);

	public abstract void vmethod_17(GClass25 gclass25_0, GStruct2[] gstruct2_0);

	public abstract void Dispose();
}
