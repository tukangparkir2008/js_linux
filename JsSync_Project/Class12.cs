using System;
using System.Runtime.CompilerServices;

internal sealed class Class12 : Class6
{
	private byte byte_0;

	public Class12()
		: base(3)
	{
	}

	public byte method_3()
	{
		return byte_0;
	}

	public void method_4(byte byte_1)
	{
		byte_0 = byte_1;
	}

	public override Class6 vmethod_3()
	{
		Class12 @class = new Class12();
		@class.method_4(byte_0);
		@class.method_2(method_1());
		return @class;
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
			method_4((byte)(short)object_0);
		}
		else if (object_0 is int)
		{
			method_4((byte)(int)object_0);
		}
		else if (object_0 is long)
		{
			method_4((byte)(long)object_0);
		}
		else if (object_0 is ushort)
		{
			method_4((byte)(ushort)object_0);
		}
		else if (object_0 is uint)
		{
			method_4((byte)(uint)object_0);
		}
		else if (object_0 is ulong)
		{
			method_4((byte)(ulong)object_0);
		}
		else if (object_0 is float)
		{
			method_4((byte)(float)object_0);
		}
		else if (object_0 is double)
		{
			method_4((byte)(double)object_0);
		}
		else
		{
			method_4(Convert.ToByte(object_0));
		}
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4((byte)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(Convert.ToByte(((Class15)class6_0).method_3()));
			break;
		case 3:
			method_4(((Class12)class6_0).method_3());
			break;
		case 4:
			method_4(Convert.ToByte(((Class30)class6_0).method_3()));
			break;
		case 6:
			method_4((byte)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((byte)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((byte)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((byte)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((byte)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((byte)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4((byte)(int)((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((byte)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((byte)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 25:
			method_4((byte)(uint)((Class10)class6_0).method_3());
			break;
		case 26:
			method_4(Convert.ToByte(((Class8)class6_0).method_3()));
			break;
		}
		return this;
	}
}
