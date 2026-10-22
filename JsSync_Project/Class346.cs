using System.Drawing;
using System.Runtime.CompilerServices;

internal sealed class Class346 : GClass68
{
	private readonly FontFamily fontFamily_0;

	public Class346(FontFamily fontFamily_1)
	{
		fontFamily_0 = fontFamily_1;
	}

	public FontFamily method_0()
	{
		return fontFamily_0;
	}

	[SpecialName]
	public override string vmethod_0()
	{
		return fontFamily_0.Name;
	}
}
