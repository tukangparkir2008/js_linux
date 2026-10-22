using System;
using System.Runtime.CompilerServices;

internal sealed class Class33 : Class6
{
	private long long_0;

	public Class33()
		: base(12)
	{
	}

	public Class33(long long_1)
		: this()
	{
		long_0 = long_1;
	}

	public long method_3()
	{
		return long_0;
	}

	public void method_4(long long_1)
	{
		long_0 = long_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		if (object_0 is ulong)
		{
			method_4((long)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((long)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((long)(double)object_0);
		}
		else
		{
			method_4(Convert.ToInt64(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class33 @class = new Class33();
		@class.method_4(long_0);
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
			method_4(Convert.ToInt64(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4(((Class31)class6_0).method_3());
			break;
		case 8:
			method_4(((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((long)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4(((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((long)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((long)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((long)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4(((Class17)class6_0).method_3());
			break;
		case 23:
			method_4(((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((long)(ulong)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToInt64(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
