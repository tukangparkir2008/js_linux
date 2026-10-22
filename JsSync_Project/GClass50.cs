using System.Drawing;

public sealed class GClass50
{
	private readonly GClass49 gclass49_0;

	private readonly GClass9[,] gclass9_0;

	public GClass50(int int_0, int int_1, GClass49 gclass49_1)
	{
		gclass9_0 = new GClass9[int_0, int_1];
		gclass49_0 = gclass49_1;
	}

	public GClass9[,] method_0()
	{
		return gclass9_0;
	}

	public void method_1(int int_0, int int_1, string string_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(string_0, gclass49_0.method_0()[int_1].int_0, GClass1.font_0, GClass1.color_1, GClass1.color_0, GClass1.genum10_0);
	}

	public void method_2(int int_0, int int_1, string string_0, GEnum10 genum10_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(string_0, gclass49_0.method_0()[int_1].int_0, GClass1.font_0, GClass1.color_1, GClass1.color_0, genum10_0);
	}

	public void method_3(int int_0, int int_1, string string_0, Font font_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(string_0, gclass49_0.method_0()[int_1].int_0, font_0, GClass1.color_1, GClass1.color_0, GClass1.genum10_0);
	}

	public void method_4(int int_0, int int_1, string string_0, Font font_0, GEnum10 genum10_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(string_0, gclass49_0.method_0()[int_1].int_0, font_0, GClass1.color_1, GClass1.color_0, genum10_0);
	}

	public void method_5(int int_0, int int_1, string string_0, Font font_0, Color color_0, Color color_1, GEnum10 genum10_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(string_0, gclass49_0.method_0()[int_1].int_0, font_0, color_0, color_1, genum10_0);
	}

	public void method_6(int int_0, int int_1, Image image_0)
	{
		gclass9_0[int_0, int_1] = new GClass9(image_0, gclass49_0.method_0()[int_1].int_0);
	}
}
