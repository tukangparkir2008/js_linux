using System;
using System.Drawing;
using System.Windows.Forms;

internal static class Class237
{
	public static GStruct2 smethod_0(PointF pointF_0)
	{
		return new GStruct2(pointF_0.X, pointF_0.Y);
	}

	public static PointF[] smethod_1(GStruct2[] gstruct2_0)
	{
		PointF[] array = new PointF[gstruct2_0.Length];
		for (int i = 0; i < gstruct2_0.Length; i++)
		{
			array[i] = smethod_2(gstruct2_0[i]);
		}
		return array;
	}

	public static PointF smethod_2(GStruct2 gstruct2_0)
	{
		return new PointF((float)gstruct2_0.method_1(), (float)gstruct2_0.method_3());
	}

	public static Point smethod_3(GStruct2 gstruct2_0)
	{
		return new Point((int)Math.Round(gstruct2_0.method_1()), (int)Math.Round(gstruct2_0.method_3()));
	}

	public static GStruct4 smethod_4(SizeF sizeF_0)
	{
		return new GStruct4(sizeF_0.Width, sizeF_0.Height);
	}

	public static SizeF smethod_5(GStruct4 gstruct4_0)
	{
		return new SizeF((float)gstruct4_0.method_1(), (float)gstruct4_0.method_3());
	}

	public static Size smethod_6(GStruct4 gstruct4_0)
	{
		return new Size((int)Math.Round(gstruct4_0.method_1()), (int)Math.Round(gstruct4_0.method_3()));
	}

	public static GStruct1 smethod_7(RectangleF rectangleF_0)
	{
		return new GStruct1(rectangleF_0.X, rectangleF_0.Y, rectangleF_0.Width, rectangleF_0.Height);
	}

	public static RectangleF smethod_8(GStruct1 gstruct1_0)
	{
		return new RectangleF((float)gstruct1_0.method_4(), (float)gstruct1_0.method_6(), (float)gstruct1_0.method_8(), (float)gstruct1_0.method_10());
	}

	public static Rectangle smethod_9(GStruct1 gstruct1_0)
	{
		return new Rectangle((int)Math.Round(gstruct1_0.method_4()), (int)Math.Round(gstruct1_0.method_6()), (int)Math.Round(gstruct1_0.method_8()), (int)Math.Round(gstruct1_0.method_10()));
	}

	public static GStruct3 smethod_10(Color color_0)
	{
		return GStruct3.smethod_5(color_0.A, color_0.R, color_0.G, color_0.B);
	}

	public static Color smethod_11(GStruct3 gstruct3_0)
	{
		return Color.FromArgb(gstruct3_0.method_3(), gstruct3_0.method_0(), gstruct3_0.method_1(), gstruct3_0.method_2());
	}

	public static Graphics smethod_12(Control control_0)
	{
		return control_0.CreateGraphics();
	}
}
