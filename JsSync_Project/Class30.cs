using System;
using System.Runtime.CompilerServices;

internal sealed class Class30 : Class6
{
	private bool bool_0;

	public Class30()
		: base(4)
	{
	}

	public bool method_3()
	{
		return bool_0;
	}

	public void method_4(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4(Convert.ToBoolean(object_0));
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 18:
			method_4(Convert.ToBoolean(((Class26)class6_0).method_3()));
			break;
		case 22:
			method_4(Convert.ToBoolean(((Class17)class6_0).method_3()));
			break;
		case 23:
			method_4(Convert.ToBoolean(((Class28)class6_0).method_3()));
			break;
		case 25:
			method_4(Convert.ToBoolean(((Class10)class6_0).method_3()));
			break;
		case 26:
			method_4(Convert.ToBoolean(((Class8)class6_0).method_3()));
			break;
		case 0:
			method_4(Convert.ToBoolean(((Class14)class6_0).method_3()));
			break;
		case 1:
			method_4(Convert.ToBoolean(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(Convert.ToBoolean(((Class12)class6_0).method_3()));
			break;
		case 4:
			method_4(((Class30)class6_0).method_3());
			break;
		case 6:
			method_4(Convert.ToBoolean(((Class31)class6_0).method_3()));
			break;
		case 8:
			method_4(Convert.ToBoolean(((Class7)class6_0).method_3()));
			break;
		case 10:
			method_4(Convert.ToBoolean(((Class27)class6_0).method_3()));
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 12:
			method_4(Convert.ToBoolean(((Class33)class6_0).method_3()));
			break;
		}
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class30 @class = new Class30();
		@class.method_4(bool_0);
		@class.method_2(method_1());
		return @class;
	}
}
