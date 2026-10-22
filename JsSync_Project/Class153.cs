using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

internal sealed class Class153 : Class151
{
	private readonly GClass71 gclass71_0;

	private Image image_0;

	public Class153(Image image_1, GClass71 gclass71_1)
	{
		method_1(image_1);
		gclass71_0 = gclass71_1;
	}

	public Image method_0()
	{
		return image_0;
	}

	private void method_1(Image image_1)
	{
		image_0 = image_1;
	}

	public Image method_2()
	{
		int height = method_0().Height;
		height = GClass52.smethod_2(height, gclass71_0.method_3(), gclass71_0.method_1());
		Bitmap bitmap = new Bitmap(gclass71_0.method_10(), height);
		bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
		graphics.SmoothingMode = SmoothingMode.AntiAlias;
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, bitmap.Width, bitmap.Height));
		graphics.DrawImage(method_0(), 0, 0);
		return bitmap;
	}
}
