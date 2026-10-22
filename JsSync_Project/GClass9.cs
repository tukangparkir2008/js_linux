using System.Drawing;

public sealed class GClass9
{
	public GEnum11 genum11_0;

	public int int_0;

	public string string_0;

	public Image image_0;

	public GEnum10 genum10_0;

	public Font font_0;

	public Color color_0;

	public Color color_1;

	public GClass9(string string_1, int int_1, Font font_1, Color color_2, Color color_3, GEnum10 genum10_1)
	{
		genum11_0 = (GEnum11)1;
		int_0 = int_1;
		string_0 = string_1;
		genum10_0 = genum10_1;
		font_0 = font_1;
		color_0 = color_2;
		color_1 = color_3;
	}

	public GClass9(Image image_1, int int_1)
	{
		genum11_0 = (GEnum11)2;
		image_0 = image_1;
		int_0 = int_1;
	}
}
