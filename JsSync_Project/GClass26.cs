using System;
using System.Collections.Generic;
using System.Drawing;

public sealed class GClass26
{
	private readonly int int_0;

	private readonly int int_1;

	private readonly int int_2;

	private readonly Color color_0;

	private readonly Color color_1;

	private readonly Color color_2;

	private readonly List<int> list_0;

	private readonly List<int> list_1;

	public GClass26(int int_3, int int_4, int int_5, Color color_3, Color color_4, Color color_5)
	{
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
		color_0 = color_3;
		color_1 = color_4;
		color_2 = color_5;
		list_0 = smethod_2(color_0);
		list_1 = smethod_2(color_1);
	}

	public GClass26(int int_3, int int_4, int int_5)
	{
		int_0 = int_3;
		int_1 = int_4;
		int_2 = int_5;
		color_0 = Color.FromArgb(183, 13, 13);
		color_1 = Color.FromArgb(35, 166, 46);
		color_2 = Color.FromArgb(198, 198, 198);
		list_0 = smethod_2(color_0);
		list_1 = smethod_2(color_1);
	}

	private static byte smethod_0(byte byte_0, byte byte_1, byte byte_2)
	{
		if (byte_0 <= byte_1)
		{
			if (byte_1 <= byte_2)
			{
				return byte_2;
			}
			return byte_1;
		}
		return byte_0;
	}

	private static byte smethod_1(byte byte_0, byte byte_1, byte byte_2)
	{
		if (byte_0 >= byte_1)
		{
			if (byte_1 >= byte_2)
			{
				return byte_2;
			}
			return byte_1;
		}
		return byte_0;
	}

	private static List<int> smethod_2(Color color_3)
	{
		byte b = smethod_1(color_3.R, color_3.G, color_3.B);
		byte b2 = smethod_0(color_3.R, color_3.G, color_3.B);
		double value = (int)b2;
		double num = Convert.ToDouble(b2 - b);
		double value2;
		double num2;
		if (b2 != 0)
		{
			value2 = num / (double)(int)b2;
			if (color_3.R == b2)
			{
				num2 = (double)(color_3.G - color_3.B) / num;
			}
			else
			{
				num2 = ((color_3.G != b2) ? (4.0 + (double)(color_3.R - color_3.G) / num) : (2.0 + (double)(color_3.B - color_3.R) / num));
			}
			num2 *= 60.0;
			if (num2 < 0.0)
			{
				num2 += 360.0;
			}
			return new List<int>
			{
				Convert.ToInt32(num2),
				Convert.ToInt32(value2),
				Convert.ToInt32(value)
			};
		}
		value2 = 0.0;
		num2 = -1.0;
		return new List<int>
		{
			Convert.ToInt32(num2),
			Convert.ToInt32(value2),
			Convert.ToInt32(value)
		};
	}

	private static List<int> smethod_3(List<int> list_2)
	{
		int num = list_2[0];
		int num2 = list_2[1];
		int num3 = list_2[2];
		if (num2 == 0)
		{
			int item = Convert.ToInt32(num3);
			return new List<int> { item, item, item };
		}
		double num4 = (float)num / 60f;
		int num5 = (int)Math.Floor(num4);
		double num6 = num4 - (double)num5;
		double num7 = num3 * (1 - num2);
		double num8 = (double)num3 * (1.0 - (double)num2 * num6);
		double num9 = (double)num3 * (1.0 - (double)num2 * (1.0 - num6));
		double double_;
		double double_2;
		double double_3;
		switch (num5)
		{
		default:
			double_ = num3;
			double_2 = num7;
			double_3 = num8;
			break;
		case 0:
			double_ = num3;
			double_2 = num9;
			double_3 = num7;
			break;
		case 1:
			double_ = num8;
			double_2 = num3;
			double_3 = num7;
			break;
		case 2:
			double_ = num7;
			double_2 = num3;
			double_3 = num9;
			break;
		case 3:
			double_ = num7;
			double_2 = num8;
			double_3 = num3;
			break;
		case 4:
			double_ = num9;
			double_2 = num7;
			double_3 = num3;
			break;
		}
		int item2 = smethod_4(double_);
		int item3 = smethod_4(double_2);
		int item4 = smethod_4(double_3);
		return new List<int> { item2, item3, item4 };
	}

	private static int smethod_4(double double_0)
	{
		double value;
		if (double_0 > 255.0)
		{
			value = 255.0;
		}
		else
		{
			value = ((double_0 < 0.0) ? 0.0 : double_0);
		}
		return Convert.ToInt32(value);
	}

	private int method_0(int int_3, int int_4, int int_5)
	{
		if (int_3 < int_0)
		{
			int_3 = int_0;
		}
		else if (int_3 > int_1)
		{
			int_3 = int_1;
		}
		int_3 -= int_0;
		int num = int_1 - int_0;
		return int_4 + (int_5 - int_4) * int_3 / num;
	}

	private List<int> method_1(int int_3)
	{
		int item = method_0(int_3, list_0[0], list_1[0]);
		int item2 = method_0(int_3, list_0[1], list_1[1]);
		int item3 = method_0(int_3, list_0[2], list_1[2]);
		return new List<int> { item, item2, item3 };
	}

	public Color method_2(int int_3)
	{
		if (int_3 == int_2)
		{
			return color_2;
		}
		if (int_3 <= int_0)
		{
			return color_0;
		}
		if (int_3 >= int_1)
		{
			return color_1;
		}
		List<int> list = smethod_3(method_1(int_3));
		return Color.FromArgb(list[0], list[1], list[2]);
	}
}
