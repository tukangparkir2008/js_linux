using System.Runtime.CompilerServices;

internal sealed class Class103 : Interface4
{
	private Class115 class115_0;

	private readonly int int_0;

	private readonly int int_1;

	public Class103(bool bool_0, Class45 class45_0)
	{
		class115_0 = new Class115();
		class115_0.method_0(bool_0, class45_0);
		int_0 = class115_0.method_1();
		int_1 = class115_0.method_3();
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int imethod_1()
	{
		return int_1;
	}

	public int imethod_2(byte[] byte_0, int int_2, int int_3, byte[] byte_1, int int_4)
	{
		Class117 class117_ = class115_0.method_5(byte_0, int_2, int_3);
		Class117 class117_2 = class115_0.method_7(class117_);
		return class115_0.method_6(class117_2, byte_1, int_4);
	}
}
