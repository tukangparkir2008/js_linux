using System;
using System.Runtime.CompilerServices;

internal sealed class Class14 : Class6
{
	private ushort ushort_0;

	public Class14()
		: base(0)
	{
	}

	public ushort method_3()
	{
		return ushort_0;
	}

	public void method_4(ushort ushort_1)
	{
		ushort_0 = ushort_1;
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
			method_4((ushort)(short)object_0);
		}
		else if (object_0 is int)
		{
			method_4((ushort)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((ushort)(long)object_0);
		}
		else if (object_0 is uint)
		{
			method_4((ushort)(uint)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((ushort)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((ushort)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((ushort)(double)object_0);
		}
		else
		{
			method_4(Convert.ToUInt16(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class14 @class = new Class14();
		@class.method_4(ushort_0);
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
			method_4(Convert.ToUInt16(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((ushort)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((ushort)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((ushort)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((ushort)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((ushort)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((ushort)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((ushort)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((ushort)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((ushort)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((ushort)(uint)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToUInt16(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
