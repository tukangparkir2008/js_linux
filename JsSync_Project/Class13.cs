using System;
using System.Runtime.CompilerServices;

internal sealed class Class13 : Class6
{
	private float float_0;

	public Class13()
		: base(14)
	{
	}

	public float method_3()
	{
		return float_0;
	}

	public void method_4(float float_1)
	{
		float_0 = float_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4(Convert.ToSingle(object_0));
	}

	public override Class6 vmethod_3()
	{
		Class13 @class = new Class13();
		@class.method_4(float_0);
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 22:
			method_4(((Class17)class6_0).method_3());
			break;
		case 23:
			method_4(((Class28)class6_0).method_3());
			break;
		case 26:
			method_4((float)((Class8)class6_0).method_3());
			break;
		case 0:
			method_4((int)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToSingle(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4((int)((Class12)class6_0).method_3());
			break;
		case 6:
			method_4(((Class31)class6_0).method_3());
			break;
		case 8:
			method_4(((Class7)class6_0).method_3());
			break;
		case 10:
			method_4(((Class27)class6_0).method_3());
			break;
		case 12:
			method_4(((Class33)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 14:
			method_4(((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((float)((Class11)class6_0).method_3());
			break;
		}
		return this;
	}
}
