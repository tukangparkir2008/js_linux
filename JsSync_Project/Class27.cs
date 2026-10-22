using System;
using System.Runtime.CompilerServices;

internal sealed class Class27 : Class6
{
	private ulong ulong_0;

	public Class27()
		: base(10)
	{
	}

	public ulong method_3()
	{
		return ulong_0;
	}

	public void method_4(ulong ulong_1)
	{
		ulong_0 = ulong_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		if (object_0 is short)
		{
			method_4((ulong)(short)object_0);
		}
		else if (object_0 is int)
		{
			method_4((ulong)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((ulong)(long)object_0);
		}
		else if (object_0 is float)
		{
			method_4((ulong)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((ulong)(double)object_0);
		}
		else
		{
			method_4(Convert.ToUInt64(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class27 @class = new Class27();
		@class.method_4(ulong_0);
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4(((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToUInt64(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((ulong)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((ulong)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4(((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((ulong)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((ulong)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((ulong)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((ulong)(long)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((ulong)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4(((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((ulong)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToUInt64(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
