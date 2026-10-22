using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public sealed class GClass23
{
	public static int smethod_0(int int_0, float float_0)
	{
		return Convert.ToInt32((float)int_0 / 100f * float_0);
	}

	public static float smethod_1(float float_0, float float_1)
	{
		return Convert.ToInt32(float_0 / 100f * float_1);
	}

	public static int smethod_2(int int_0, float float_0)
	{
		return Convert.ToInt32((float)int_0 / float_0 * 100f);
	}

	public static float smethod_3(float float_0, float float_1)
	{
		return Convert.ToInt32(float_0 / float_1 * 100f);
	}

	public static int smethod_4(int int_0, float float_0, float float_1)
	{
		if (float_0 == float_1)
		{
			return int_0;
		}
		return smethod_0(smethod_2(int_0, float_0), float_1);
	}

	public static float smethod_5(float float_0, float float_1, float float_2)
	{
		if (float_1 == float_2)
		{
			return float_0;
		}
		return smethod_1(smethod_3(float_0, float_1), float_2);
	}

	public static Image smethod_6(Image image_0, float float_0, float float_1, float float_2, float float_3)
	{
		if (image_0 == null)
		{
			return null;
		}
		if ((int)float_0 == (int)float_2 && (int)float_1 == (int)float_3)
		{
			return GClass18.smethod_14(image_0);
		}
		int height = image_0.Height;
		height = smethod_4(height, float_1, float_3);
		Bitmap bitmap = new Bitmap(smethod_4(image_0.Width, float_0, float_2), height);
		bitmap.SetResolution(float_2, float_3);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		graphics.CompositingQuality = CompositingQuality.HighQuality;
		graphics.DrawImage(image_0, 0, 0);
		return bitmap;
	}
}
