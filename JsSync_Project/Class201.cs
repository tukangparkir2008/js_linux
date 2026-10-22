using System.Collections.Generic;

internal sealed class Class201 : Class197
{
	private readonly Class197 class197_2;

	private readonly int int_0;

	private readonly int int_1;

	public Class201(Class197 class197_3, ref Class197 class197_4, int int_2)
		: base(class197_3, new Class343(Class84.smethod_0(-994289749), bool_1: false, new Dictionary<string, string> { 
		{
			Class84.smethod_0(-994295662),
			Class84.smethod_0(-994248276)
		} }))
	{
		class197_2 = class197_4;
		method_83(Class84.smethod_0(-994289749));
		int_0 = int_2;
		int_1 = int_2 + int.Parse(class197_4.method_218(Class84.smethod_0(-994295680), Class84.smethod_0(-994248276))) - 1;
	}

	public Class197 method_238()
	{
		return class197_2;
	}

	public int method_239()
	{
		return int_0;
	}

	public int method_240()
	{
		return int_1;
	}
}
