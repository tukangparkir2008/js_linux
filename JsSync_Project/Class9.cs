using System;
using System.Runtime.CompilerServices;

internal sealed class Class9 : Class6
{
	private string string_0;

	public Class9()
		: base(16)
	{
	}

	public string method_3()
	{
		return string_0;
	}

	public void method_4(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4((string)object_0);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		default:
			throw new ArgumentOutOfRangeException();
		case 26:
			method_4((string)((Class8)class6_0).method_3());
			break;
		case 16:
			method_4(((Class9)class6_0).method_3());
			break;
		}
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class9 @class = new Class9();
		@class.method_4(string_0);
		@class.method_2(method_1());
		return @class;
	}
}
