using System;
using System.Runtime.CompilerServices;

internal sealed class Class17 : Class6
{
	private short short_0;

	public Class17()
		: base(22)
	{
	}

	public short method_3()
	{
		return short_0;
	}

	public void method_4(short short_1)
	{
		short_0 = short_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		if (object_0 is int)
		{
			method_4((short)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((short)(long)object_0);
		}
		else if (object_0 is ushort)
		{
			method_4((short)(ushort)object_0);
		}
		else if (object_0 is uint)
		{
			method_4((short)(uint)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((short)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((short)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((short)(double)object_0);
		}
		else
		{
			method_4(Convert.ToInt16(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class17 @class = new Class17();
		@class.method_4(short_0);
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4((short)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToInt16(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((short)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4(((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((short)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((short)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((short)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((short)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((short)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4(((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((short)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 26:
			method_4(Convert.ToInt16(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
