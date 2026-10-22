using System.Drawing;
using System.Runtime.CompilerServices;

internal sealed class Class209 : GClass29
{
	private readonly Image image_0;

	public Class209(Image image_1)
	{
		image_0 = image_1;
	}

	public Image method_0()
	{
		return image_0;
	}

	[SpecialName]
	public override double vmethod_0()
	{
		return image_0.Width;
	}

	[SpecialName]
	public override double vmethod_1()
	{
		return image_0.Height;
	}

	public override void Dispose()
	{
		image_0.Dispose();
	}
}
