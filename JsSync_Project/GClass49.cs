using System.Collections.Generic;
using System.Drawing;

public sealed class GClass49
{
	private readonly List<GClass9> list_0 = new List<GClass9>();

	public List<GClass9> method_0()
	{
		return list_0;
	}

	public void method_1(string string_0, int int_0)
	{
		list_0.Add(new GClass9(string_0, int_0, GClass1.font_0, Color.SteelBlue, Color.White, (GEnum10)1));
	}

	public void method_2(string string_0, int int_0, GEnum10 genum10_0)
	{
		list_0.Add(new GClass9(string_0, int_0, GClass1.font_0, Color.SteelBlue, Color.White, genum10_0));
	}

	public void method_3(string string_0, int int_0, Font font_0, Color color_0, Color color_1, GEnum10 genum10_0)
	{
		list_0.Add(new GClass9(string_0, int_0, font_0, color_0, color_1, genum10_0));
	}
}
