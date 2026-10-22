using System.Runtime.CompilerServices;

internal sealed class Class247 : Class245
{
	private readonly string string_0;

	private readonly bool bool_0;

	private readonly bool bool_1;

	public Class247(Class197 class197_1, string string_1, bool bool_2, bool bool_3)
		: base(class197_1)
	{
		string_0 = string_1;
		bool_0 = bool_2;
		bool_1 = bool_3;
	}

	[SpecialName]
	public override bool vmethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public override bool vmethod_1()
	{
		return bool_1;
	}

	[SpecialName]
	public override bool vmethod_5()
	{
		string text = vmethod_7();
		int num = 0;
		while (true)
		{
			if (num < text.Length)
			{
				if (!char.IsWhiteSpace(text[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public override bool vmethod_6()
	{
		return vmethod_7() == Class84.smethod_0(-994263511);
	}

	[SpecialName]
	public override string vmethod_7()
	{
		return string_0;
	}

	public override string ToString()
	{
		return string.Format(Class84.smethod_0(-994295413), vmethod_7().Replace(' ', '-').Replace(Class84.smethod_0(-994263511), Class84.smethod_0(-994295373)), vmethod_7().Length, (vmethod_7().Length != 1) ? Class84.smethod_0(-994295380) : string.Empty);
	}
}
