using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

internal sealed class Class154 : Class151
{
	private readonly GClass71 gclass71_0;

	private string string_0;

	private Font font_0;

	private Color color_0;

	private Color color_1;

	private GEnum10 genum10_0;

	public Class154(string string_1, GClass71 gclass71_1)
	{
		method_1(string_1);
		method_3(GClass1.font_0);
		method_5(GClass1.color_0);
		method_7(GClass1.color_1);
		method_9(GClass1.genum10_0);
		gclass71_0 = gclass71_1;
	}

	public Class154(string string_1, Font font_1, GClass71 gclass71_1)
	{
		method_1(string_1);
		method_3(font_1);
		method_5(GClass1.color_0);
		method_7(GClass1.color_1);
		method_9(GClass1.genum10_0);
		gclass71_0 = gclass71_1;
	}

	public Class154(string string_1, Font font_1, GEnum10 genum10_1, GClass71 gclass71_1)
	{
		method_1(string_1);
		method_3(font_1);
		method_5(GClass1.color_0);
		method_7(GClass1.color_1);
		method_9(genum10_1);
		gclass71_0 = gclass71_1;
	}

	public Class154(string string_1, Font font_1, Color color_2, Color color_3, GEnum10 genum10_1, GClass71 gclass71_1)
	{
		method_1(string_1);
		method_3(font_1);
		method_5(color_2);
		method_7(color_3);
		method_9(genum10_1);
		gclass71_0 = gclass71_1;
	}

	public string method_0()
	{
		return string_0;
	}

	private void method_1(string string_1)
	{
		string_0 = string_1;
	}

	public Font method_2()
	{
		return font_0;
	}

	private void method_3(Font font_1)
	{
		font_0 = font_1;
	}

	public Color method_4()
	{
		return color_0;
	}

	private void method_5(Color color_2)
	{
		color_0 = color_2;
	}

	public Color method_6()
	{
		return color_1;
	}

	private void method_7(Color color_2)
	{
		color_1 = color_2;
	}

	public GEnum10 method_8()
	{
		return genum10_0;
	}

	private void method_9(GEnum10 genum10_1)
	{
		genum10_0 = genum10_1;
	}

	public Image method_10()
	{
		StringFormat format = new StringFormat
		{
			Alignment = ((method_8() != (GEnum10)1) ? ((method_8() == (GEnum10)2) ? StringAlignment.Center : StringAlignment.Far) : StringAlignment.Near)
		};
		Bitmap bitmap = new Bitmap(gclass71_0.method_10(), 100);
		bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		SizeF sizeF;
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			sizeF = graphics.MeasureString(method_0(), method_2(), gclass71_0.method_10(), format);
		}
		RectangleF rectangleF = new RectangleF(0f, 0f, sizeF.Width, sizeF.Height);
		Bitmap bitmap2 = new Bitmap((int)sizeF.Width, (int)sizeF.Height);
		bitmap2.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		using Graphics graphics2 = Graphics.FromImage(bitmap2);
		graphics2.TextRenderingHint = TextRenderingHint.AntiAlias;
		graphics2.SmoothingMode = SmoothingMode.AntiAlias;
		graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics2.CompositingQuality = CompositingQuality.HighQuality;
		graphics2.FillRectangle(new SolidBrush(method_6()), rectangleF);
		graphics2.DrawString(method_0(), method_2(), new SolidBrush(method_4()), rectangleF, format);
		return bitmap2;
	}
}
