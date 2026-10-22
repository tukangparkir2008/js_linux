using System;
using System.Runtime.CompilerServices;

internal sealed class Class26 : Class6
{
	private IntPtr intptr_0;

	public Class26()
		: base(18)
	{
	}

	public IntPtr method_3()
	{
		return intptr_0;
	}

	public void method_4(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	public override Class6 vmethod_3()
	{
		Class26 @class = new Class26();
		@class.method_4(intptr_0);
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
		method_4((IntPtr)object_0);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 0:
			method_4((IntPtr)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(new IntPtr(Convert.ToInt64(((Class15)class6_0).method_3())));
			break;
		case 3:
			method_4((IntPtr)((Class12)class6_0).method_3());
			break;
		case 5:
		{
			Class29 @class = (Class29)class6_0;
			method_4(@class.method_5());
			break;
		}
		case 6:
			method_4((IntPtr)((Class31)class6_0).method_3());
			break;
		case 8:
			method_4((IntPtr)((Class7)class6_0).method_3());
			break;
		case 10:
			method_4((IntPtr)(long)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((IntPtr)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((IntPtr)(long)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((IntPtr)(long)((Class11)class6_0).method_3());
			break;
		case 18:
			method_4(((Class26)class6_0).method_3());
			break;
		case 22:
			method_4((IntPtr)((Class17)class6_0).method_3());
			break;
		case 23:
			method_4((IntPtr)((Class28)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 26:
			method_4((IntPtr)((Class8)class6_0).method_3());
			break;
		}
		return this;
	}
}
