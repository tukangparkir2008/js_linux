using System;

internal sealed class Class19 : Class18
{
	private int int_1;

	public Class19()
		: base(21)
	{
	}

	public int method_3()
	{
		return int_1;
	}

	public void method_4(int int_2)
	{
		int_1 = int_2;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		if (class6_0.method_0() != 21)
		{
			throw new ArgumentOutOfRangeException();
		}
		method_4(((Class19)class6_0).method_3());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class19 @class = new Class19();
		@class.method_4(int_1);
		@class.method_2(method_1());
		return @class;
	}
}
