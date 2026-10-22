using System;
using System.Runtime.CompilerServices;

internal sealed class Class31 : Class6
{
	private int int_1;

	public Class31()
		: base(6)
	{
	}

	public Class31(int int_2)
		: this()
	{
		int_1 = int_2;
	}

	public int method_3()
	{
		return int_1;
	}

	public void method_4(int int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		if (object_0 is long)
		{
			method_4((int)(long)object_0);
		}
		else if (object_0 is ushort)
		{
			method_4((ushort)object_0);
		}
		else if (object_0 is uint)
		{
			method_4((int)(uint)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((int)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((int)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((int)(double)object_0);
		}
		else
		{
			method_4(Convert.ToInt32(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class31 @class = new Class31();
		@class.method_4(int_1);
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
			method_4(Convert.ToInt32(((Class15)class6_0).method_3()));
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
			method_4((int)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4(Convert.ToInt32(((Class33)class6_0).method_3()));
			break;
		case 14:
			method_4((int)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((int)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4(((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((int)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((int)(uint)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToInt32(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
