using System;
using System.Drawing.Drawing2D;

internal sealed class Class212 : GClass30
{
	private readonly GraphicsPath graphicsPath_0 = new GraphicsPath();

	private GStruct2 gstruct2_0;

	public GraphicsPath method_0()
	{
		return graphicsPath_0;
	}

	public override void vmethod_0(double double_0, double double_1)
	{
		gstruct2_0 = new GStruct2(double_0, double_1);
	}

	public override void vmethod_1(double double_0, double double_1)
	{
		graphicsPath_0.AddLine((float)gstruct2_0.method_1(), (float)gstruct2_0.method_3(), (float)double_0, (float)double_1);
		gstruct2_0 = new GStruct2(double_0, double_1);
	}

	public override void vmethod_2(double double_0, double double_1, double double_2, GEnum8 genum8_0)
	{
		float x = (float)(Math.Min(double_0, gstruct2_0.method_1()) - ((genum8_0 == (GEnum8)1 || genum8_0 == (GEnum8)3) ? double_2 : 0.0));
		float y = (float)(Math.Min(double_1, gstruct2_0.method_3()) - ((genum8_0 == (GEnum8)2 || genum8_0 == (GEnum8)3) ? double_2 : 0.0));
		graphicsPath_0.AddArc(x, y, (float)double_2 * 2f, (float)double_2 * 2f, smethod_0(genum8_0), 90f);
		gstruct2_0 = new GStruct2(double_0, double_1);
	}

	public override void Dispose()
	{
		graphicsPath_0.Dispose();
	}

	private static int smethod_0(GEnum8 genum8_0)
	{
		return genum8_0 switch
		{
			(GEnum8)0 => 180, 
			(GEnum8)1 => 270, 
			(GEnum8)2 => 90, 
			(GEnum8)3 => 0, 
			_ => throw new ArgumentOutOfRangeException(Class84.smethod_0(-994288289)), 
		};
	}
}
