using System;

internal sealed class Class45
{
	private readonly bool bool_0;

	private readonly Class117 class117_0;

	private readonly Class117 class117_1;

	public Class45(bool bool_1, Class117 class117_2, Class117 class117_3)
	{
		if (class117_2 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273188));
		}
		if (class117_3 == null)
		{
			throw new ArgumentNullException(Class84.smethod_0(-994273206));
		}
		bool_0 = bool_1;
		class117_0 = class117_2;
		class117_1 = class117_3;
	}

	public bool method_0()
	{
		return bool_0;
	}

	public Class117 method_1()
	{
		return class117_0;
	}

	public Class117 method_2()
	{
		return class117_1;
	}
}
