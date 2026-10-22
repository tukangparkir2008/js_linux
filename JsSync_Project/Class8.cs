using System.Runtime.CompilerServices;

internal sealed class Class8 : Class6
{
	private object object_0;

	public Class8()
		: base(26)
	{
	}

	public object method_3()
	{
		return object_0;
	}

	public void method_4(object object_1)
	{
		object_0 = object_1;
	}

	[SpecialName]
	public override object vmethod_0()
	{
		return method_3();
	}

	[SpecialName]
	public override void vmethod_1(object object_1)
	{
		method_4(object_1);
	}

	public override Class6 vmethod_2(Class6 class6_0)
	{
		method_2(class6_0.method_1());
		method_4(class6_0.vmethod_0());
		return this;
	}

	public override Class6 vmethod_3()
	{
		Class8 @class = new Class8();
		@class.method_4(object_0);
		@class.method_2(method_1());
		return @class;
	}
}
