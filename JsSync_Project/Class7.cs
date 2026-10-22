using System;
using System.Runtime.CompilerServices;

internal sealed class Class7 : Class6
{
	private sbyte sbyte_0;

	public Class7()
		: base(8)
	{
	}

	public sbyte method_3()
	{
		return sbyte_0;
	}

	public void method_4(sbyte sbyte_1)
	{
		sbyte_0 = sbyte_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		if (object_0 is byte)
		{
			method_4((sbyte)(byte)object_0);
		}
		else if (object_0 is short)
		{
			method_4((sbyte)(short)object_0);
		}
		else if (object_0 is int)
		{
			method_4((sbyte)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((sbyte)(long)object_0);
		}
		else if (object_0 is ushort)
		{
			method_4((sbyte)(ushort)object_0);
		}
		else if (object_0 is uint)
		{
			method_4((sbyte)(uint)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((sbyte)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((sbyte)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((sbyte)(double)object_0);
		}
		else
		{
			method_4(Convert.ToSByte(object_0));
		}
	}

	public override Class6 vmethod_3()
	{
		Class7 @class = new Class7();
		@class.method_4(sbyte_0);
		@class.method_2(method_1());
		return @class;
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4((sbyte)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToSByte(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4((sbyte)((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToSByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((sbyte)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4(((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((sbyte)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((sbyte)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((sbyte)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((sbyte)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((sbyte)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((sbyte)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((sbyte)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 26:
			method_4(Convert.ToSByte(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
