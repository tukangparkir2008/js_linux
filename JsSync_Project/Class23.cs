using System;
using System.Runtime.CompilerServices;

internal sealed class Class23 : Class22
{
	private Array array_0;

	private int[] int_1;

	public Class23()
		: base(2)
	{
	}

	public Array method_5()
	{
		return array_0;
	}

	public void method_6(Array array_1)
	{
		array_0 = array_1;
	}

	public int[] method_7()
	{
		return int_1;
	}

	public void method_8(int[] int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	public override object vmethod_4()
	{
		return method_5().GetValue(method_7());
	}

	[SpecialName]
	public override void vmethod_5(object object_0)
	{
		method_5().SetValue(object_0, method_7());
	}

	public override Class6 vmethod_3()
	{
		Class23 @class = new Class23();
		@class.method_6(method_5());
		@class.method_8(method_7());
		@class.method_4(method_3());
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		if (class6_0.method_0() != 2)
		{
			throw new ArgumentOutOfRangeException();
		}
		Class23 @class = (Class23)class6_0;
		method_6(@class.method_5());
		method_8(@class.method_7());
		method_4(@class.method_3());
		return this;
	}

	public override bool vmethod_6(Class22 class22_0)
	{
		Class23 @class = (Class23)class22_0;
		if (method_5() == @class.method_5())
		{
			return Class47.smethod_0(method_7(), @class.method_7());
		}
		return false;
	}
}
