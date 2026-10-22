using System;
using System.Runtime.CompilerServices;

internal sealed class Class25 : Class6
{
	private char char_0;

	public Class25()
		: base(13)
	{
	}

	public char method_3()
	{
		return char_0;
	}

	public void method_4(char char_1)
	{
		char_0 = char_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4(Convert.ToChar(object_0));
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4((char)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToChar(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4((char)((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToChar(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((char)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((char)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((char)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((char)((Class33)class6_0).method_3());
			break;
		case 13:
			method_4(((Class25)class6_0).method_3());
			break;
		case 18:
			method_4((char)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((char)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((char)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((char)(uint)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToChar(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class25 @class = new Class25();
		@class.method_4(char_0);
		@class.method_2(method_1());
		return @class;
	}
}
