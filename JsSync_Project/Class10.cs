using System;
using System.Runtime.CompilerServices;

internal sealed class Class10 : Class6
{
	private UIntPtr uintptr_0;

	public Class10()
		: base(25)
	{
	}

	public UIntPtr method_3()
	{
		return uintptr_0;
	}

	public void method_4(UIntPtr uintptr_1)
	{
		uintptr_0 = uintptr_1;
	}

	public override Class6 vmethod_3()
	{
		Class10 @class = new Class10();
		@class.method_4(uintptr_0);
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
		method_4((UIntPtr)object_0);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		switch (class6_0.method_0())
		{
		case 23:
			method_4((UIntPtr)((Class28)class6_0).method_3());
			break;
		case 25:
			method_4(((Class10)class6_0).method_3());
			break;
		case 26:
			method_4((UIntPtr)((Class8)class6_0).method_3());
			break;
		case 10:
			method_4((UIntPtr)((Class27)class6_0).method_3());
			break;
		case 12:
			method_4((UIntPtr)(ulong)((Class33)class6_0).method_3());
			break;
		case 14:
			method_4((UIntPtr)(ulong)((Class13)class6_0).method_3());
			break;
		case 15:
			method_4((UIntPtr)(ulong)((Class11)class6_0).method_3());
			break;
		case 0:
			method_4((UIntPtr)((Class14)class6_0).method_3());
			break;
		case 1:
			method_4(new UIntPtr(Convert.ToUInt64(((Class15)class6_0).method_3())));
			break;
		case 3:
			method_4((UIntPtr)((Class12)class6_0).method_3());
			break;
		default:
			throw new ArgumentOutOfRangeException();
		case 6:
			method_4((UIntPtr)(ulong)((Class31)class6_0).method_3());
			break;
		}
		return this;
	}
}
