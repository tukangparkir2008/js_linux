using System;
using System.Runtime.CompilerServices;

internal sealed class Class16 : Class6
{
	private Array array_0;

	public Class16()
		: base(24)
	{
	}

	public Array method_3()
	{
		return array_0;
	}

	public void method_4(Array array_1)
	{
		array_0 = array_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4((Array)object_0);
	}

	public override Class6 vmethod_3()
	{
		Class16 @class = new Class16();
		@class.method_4(array_0);
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 26:
			method_4((Array)((Class8)class6_0).method_3());
			break;
		case 24:
			method_4(((Class16)class6_0).method_3());
			break;
		}
		return this;
	}
}
