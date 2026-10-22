using System.Drawing;

internal sealed class Class152 : Class151
{
	private readonly int int_0 = 10;

	private readonly GClass71 gclass71_0;

	public Class152(GClass71 gclass71_1)
	{
		gclass71_0 = gclass71_1;
	}

	public Class152(int int_1, GClass71 gclass71_1)
	{
		int_0 = int_1;
		gclass71_0 = gclass71_1;
	}

	public int method_0()
	{
		return int_0;
	}

	public Image method_1()
	{
		int num = GClass52.smethod_2(int_0, gclass71_0.method_3(), gclass71_0.method_1());
		Bitmap bitmap = new Bitmap(num, num);
		bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, num, num);
		return bitmap;
	}
}
