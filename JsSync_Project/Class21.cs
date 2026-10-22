using System;

internal sealed class Class21 : Class18
{
	private Class6 class6_0;

	public Class21()
		: base(7)
	{
	}

	public Class6 method_3()
	{
		return class6_0;
	}

	public void method_4(Class6 class6_1)
	{
		class6_0 = class6_1;
	}

	public override Class6 vmethod_2(Class6 class6_1)
	{
		method_2(class6_1.method_1());
		if (class6_1.method_0() != 7)
		{
			throw new ArgumentOutOfRangeException();
		}
		method_4(((Class21)class6_1).method_3());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class21 @class = new Class21();
		@class.method_4(method_3());
		@class.method_2(method_1());
		return @class;
	}
}
