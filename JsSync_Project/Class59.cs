using System.Runtime.CompilerServices;

internal sealed class Class59 : Class55
{
	private byte byte_0;

	private Class70 class70_0;

	private string string_0;

	private Class70[] class70_1;

	private Class70[] class70_2;

	private Class70 class70_3;

	public byte method_0()
	{
		return byte_0;
	}

	public void method_1(byte byte_1)
	{
		byte_0 = byte_1;
	}

	public bool method_2()
	{
		return (method_0() & 1) != 0;
	}

	public bool method_3()
	{
		return (method_0() & 2) != 0;
	}

	public Class70 method_4()
	{
		return class70_0;
	}

	public void method_5(Class70 class70_4)
	{
		class70_0 = class70_4;
	}

	public string method_6()
	{
		return string_0;
	}

	public void method_7(string string_1)
	{
		string_0 = string_1;
	}

	public Class70[] method_8()
	{
		return class70_1;
	}

	public void method_9(Class70[] class70_4)
	{
		class70_1 = class70_4;
	}

	public Class70[] method_10()
	{
		return class70_2;
	}

	public void method_11(Class70[] class70_4)
	{
		class70_2 = class70_4;
	}

	public Class70 method_12()
	{
		return class70_3;
	}

	public void method_13(Class70 class70_4)
	{
		class70_3 = class70_4;
	}

	[SpecialName]
	public override byte vmethod_0()
	{
		return 2;
	}
}
