using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal sealed class Class29 : Class6
{
	private MethodBase methodBase_0;

	public Class29()
		: base(5)
	{
	}

	public MethodBase method_3()
	{
		return methodBase_0;
	}

	public void method_4(MethodBase methodBase_1)
	{
		methodBase_0 = methodBase_1;
	}

	public IntPtr method_5()
	{
		return method_3().MethodHandle.GetFunctionPointer();
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_0)
	{
		method_4((MethodBase)object_0);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		if (class6_0.method_0() != 5)
		{
			throw new ArgumentOutOfRangeException();
		}
		method_4(((Class29)class6_0).method_3());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class29 @class = new Class29();
		@class.method_4(methodBase_0);
		@class.method_2(method_1());
		return @class;
	}
}
