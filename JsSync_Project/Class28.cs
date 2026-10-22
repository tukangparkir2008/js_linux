using System;
using System.Runtime.CompilerServices;

internal sealed class Class28 : Class6
{
	private uint uint_0;

	public Class28()
		: base(23)
	{
	}

	public uint method_3()
	{
		return uint_0;
	}

	public void method_4(uint uint_1)
	{
		uint_0 = uint_1;
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
			method_4((uint)(short)object_0);
		}
		else if (object_0 is int)
		{
			method_4((uint)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((uint)(long)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((uint)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((uint)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((uint)(double)object_0);
		}
		else
		{
			method_4(Convert.ToUInt32(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class28 @class = new Class28();
		@class.method_4(uint_0);
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
			method_4(Convert.ToUInt32(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((uint)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((uint)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((uint)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((uint)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((uint)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((uint)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((uint)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((uint)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4(((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((uint)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToUInt32(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
