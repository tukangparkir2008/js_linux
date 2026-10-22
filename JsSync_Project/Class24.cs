using System;
using System.Runtime.CompilerServices;

internal sealed class Class24 : Class22
{
	private Array array_0;

	private long long_0;

	public Class24()
		: base(17)
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

	public long method_7()
	{
		return long_0;
	}

	public void method_8(long long_1)
	{
		long_0 = long_1;
	}

	[SpecialName]
	public override object vmethod_4()
	{
		return array_0.GetValue(long_0);
	}

	[SpecialName]
	public override void vmethod_5(object object_0)
	{
		array_0.SetValue(object_0, long_0);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		if (class6_0.method_0() != 17)
		{
			throw new ArgumentOutOfRangeException();
		}
		Class24 @class = (Class24)class6_0;
		method_6(@class.method_5());
		method_8(@class.method_7());
		method_4(@class.method_3());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class24 @class = new Class24();
		@class.method_6(array_0);
		@class.method_8(long_0);
		@class.method_4(method_3());
		@class.method_2(method_1());
		return @class;
	}

	public override bool vmethod_6(Class22 class22_0)
	{
		Class24 @class = (Class24)class22_0;
		if (method_7() == @class.method_7())
		{
			return method_5() == @class.method_5();
		}
		return false;
	}
}
