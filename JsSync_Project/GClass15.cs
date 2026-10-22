using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

public static class GClass15
{
	public static void smethod_0(FontFamily fontFamily_0)
	{
		GClass24.smethod_1(fontFamily_0, Class84.smethod_0(-994208648));
		Class119.smethod_0().method_8(new Class346(fontFamily_0));
	}

	public static void smethod_1(string string_0, string string_1)
	{
		GClass24.smethod_3(string_0, Class84.smethod_0(-994279561));
		GClass24.smethod_3(string_1, Class84.smethod_0(-994279528));
		Class119.smethod_0().method_9(string_0, string_1);
	}

	public static GClass55 smethod_2(string string_0, bool bool_0)
	{
		return GClass55.smethod_0(Class119.smethod_0(), string_0, bool_0);
	}

	public static SizeF smethod_3(Graphics graphics_0, string string_0, float float_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_18(graphics_0, string_0, float_0, gclass55_0, bool_0: false, eventHandler_0, eventHandler_1);
	}

	public static SizeF smethod_4(Graphics graphics_0, string string_0, float float_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_18(graphics_0, string_0, float_0, gclass55_0, bool_0: true, eventHandler_0, eventHandler_1);
	}

	public static SizeF smethod_5(Graphics graphics_0, string string_0, float float_0, float float_1, float float_2, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_20(graphics_0, string_0, new PointF(float_0, float_1), new SizeF(float_2, 0f), gclass55_0, bool_0: false, eventHandler_0, eventHandler_1);
	}

	public static SizeF smethod_6(Graphics graphics_0, string string_0, PointF pointF_0, SizeF sizeF_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_20(graphics_0, string_0, pointF_0, sizeF_0, gclass55_0, bool_0: false, eventHandler_0, eventHandler_1);
	}

	public static SizeF smethod_7(Graphics graphics_0, string string_0, float float_0, float float_1, float float_2, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_20(graphics_0, string_0, new PointF(float_0, float_1), new SizeF(float_2, 0f), gclass55_0, bool_0: true, eventHandler_0, eventHandler_1);
	}

	public static SizeF smethod_8(Graphics graphics_0, string string_0, PointF pointF_0, SizeF sizeF_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(graphics_0, Class84.smethod_0(-994288345));
		return smethod_20(graphics_0, string_0, pointF_0, sizeF_0, gclass55_0, bool_0: true, eventHandler_0, eventHandler_1);
	}

	public static Metafile smethod_9(string string_0, float float_0, float float_1, float float_2, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		IntPtr intPtr = Class356.smethod_0(IntPtr.Zero, 1, 1, out var intptr_);
		try
		{
			Metafile metafile = new Metafile(intPtr, EmfType.EmfPlusDual, Class84.smethod_0(-994208663));
			using Graphics graphics_ = Graphics.FromImage(metafile);
			smethod_5(graphics_, string_0, float_0, float_1, float_2, gclass55_0, eventHandler_0, eventHandler_1);
			return metafile;
		}
		finally
		{
			Class356.smethod_1(intPtr, intptr_);
		}
	}

	public static void smethod_10(Image image_0, string string_0, PointF pointF_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(image_0, Class84.smethod_0(-994295247));
		SizeF sizeF_ = new SizeF((float)image_0.Size.Width - pointF_0.X, (float)image_0.Size.Height - pointF_0.Y);
		smethod_11(image_0, string_0, pointF_0, sizeF_, gclass55_0, eventHandler_0, eventHandler_1);
	}

	public static void smethod_11(Image image_0, string string_0, PointF pointF_0, SizeF sizeF_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		GClass24.smethod_1(image_0, Class84.smethod_0(-994295247));
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		IntPtr intPtr = Class356.smethod_0(IntPtr.Zero, image_0.Width, image_0.Height, out var intptr_);
		try
		{
			using (Graphics graphics = Graphics.FromHdc(intPtr))
			{
				graphics.DrawImageUnscaled(image_0, 0, 0);
				smethod_21(graphics, string_0, pointF_0, sizeF_0, gclass55_0, bool_0: false, eventHandler_0, eventHandler_1);
			}
			smethod_22(intPtr, image_0);
		}
		finally
		{
			Class356.smethod_1(intPtr, intptr_);
		}
	}

	public static Image smethod_12(string string_0, Size size_0, Color color_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		if (color_0 == Color.Transparent)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208670), Class84.smethod_0(-994208611));
		}
		Bitmap bitmap = new Bitmap(size_0.Width, size_0.Height, PixelFormat.Format32bppArgb);
		if (!string.IsNullOrEmpty(string_0))
		{
			IntPtr intPtr = Class356.smethod_0(IntPtr.Zero, bitmap.Width, bitmap.Height, out var intptr_);
			try
			{
				using (Graphics graphics = Graphics.FromHdc(intPtr))
				{
					graphics.Clear((color_0 != Color.Empty) ? color_0 : Color.White);
					smethod_21(graphics, string_0, PointF.Empty, size_0, gclass55_0, bool_0: true, eventHandler_0, eventHandler_1);
				}
				smethod_22(intPtr, bitmap);
			}
			finally
			{
				Class356.smethod_1(intPtr, intptr_);
			}
		}
		return bitmap;
	}

	public static Image smethod_13(string string_0, int int_0, int int_1, Color color_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		return smethod_14(string_0, Size.Empty, new Size(int_0, int_1), color_0, gclass55_0, eventHandler_0, eventHandler_1);
	}

	public static Image smethod_14(string string_0, Size size_0, Size size_1, Color color_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		if (color_0 == Color.Transparent)
		{
			throw new ArgumentOutOfRangeException(Class84.smethod_0(-994208597), Class84.smethod_0(-994208611));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return new Bitmap(0, 0, PixelFormat.Format32bppArgb);
		}
		using GClass63 gClass = new GClass63();
		gClass.method_21(bool_1: true);
		gClass.method_23(bool_1: true);
		if (eventHandler_0 != null)
		{
			gClass.method_10(eventHandler_0);
		}
		if (eventHandler_1 != null)
		{
			gClass.method_12(eventHandler_1);
		}
		gClass.method_39(string_0, gclass55_0);
		Size size = smethod_19(gClass, size_0, size_1);
		gClass.method_33(size);
		Bitmap bitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
		IntPtr intPtr = Class356.smethod_0(IntPtr.Zero, bitmap.Width, bitmap.Height, out var intptr_);
		try
		{
			using (Graphics graphics = Graphics.FromHdc(intPtr))
			{
				graphics.Clear((color_0 != Color.Empty) ? color_0 : Color.White);
				gClass.method_46(graphics);
			}
			smethod_22(intPtr, bitmap);
		}
		finally
		{
			Class356.smethod_1(intPtr, intptr_);
		}
		return bitmap;
	}

	public static Image smethod_15(string string_0, Size size_0, TextRenderingHint textRenderingHint_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		Bitmap bitmap = new Bitmap(size_0.Width, size_0.Height, PixelFormat.Format32bppArgb);
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.TextRenderingHint = textRenderingHint_0;
		smethod_21(graphics, string_0, PointF.Empty, size_0, gclass55_0, bool_0: true, eventHandler_0, eventHandler_1);
		return bitmap;
	}

	public static Image smethod_16(string string_0, int int_0, int int_1, TextRenderingHint textRenderingHint_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		return smethod_17(string_0, Size.Empty, new Size(int_0, int_1), textRenderingHint_0, gclass55_0, eventHandler_0, eventHandler_1);
	}

	public static Image smethod_17(string string_0, Size size_0, Size size_1, TextRenderingHint textRenderingHint_0, GClass55 gclass55_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return new Bitmap(0, 0, PixelFormat.Format32bppArgb);
		}
		using GClass63 gClass = new GClass63();
		gClass.method_21(bool_1: true);
		gClass.method_23(bool_1: true);
		gClass.method_16(bool_1: true);
		if (eventHandler_0 != null)
		{
			gClass.method_10(eventHandler_0);
		}
		if (eventHandler_1 != null)
		{
			gClass.method_12(eventHandler_1);
		}
		gClass.method_39(string_0, gclass55_0);
		Size size = smethod_19(gClass, size_0, size_1);
		gClass.method_33(size);
		Bitmap bitmap = new Bitmap(size.Width, size.Height, PixelFormat.Format32bppArgb);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.TextRenderingHint = textRenderingHint_0;
			gClass.method_46(graphics);
		}
		return bitmap;
	}

	private static SizeF smethod_18(Graphics graphics_0, string string_0, float float_0, GClass55 gclass55_0, bool bool_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		SizeF result = SizeF.Empty;
		if (!string.IsNullOrEmpty(string_0))
		{
			GClass63 gClass = new GClass63();
			try
			{
				gClass.method_33(new SizeF(float_0, 0f));
				gClass.method_21(bool_1: true);
				gClass.method_23(bool_1: true);
				gClass.method_16(bool_0);
				if (eventHandler_0 != null)
				{
					gClass.method_10(eventHandler_0);
				}
				if (eventHandler_1 != null)
				{
					gClass.method_12(eventHandler_1);
				}
				gClass.method_39(string_0, gclass55_0);
				gClass.method_45(graphics_0);
				result = gClass.method_34();
			}
			finally
			{
				((IDisposable)gClass).Dispose();
			}
		}
		return result;
	}

	private static Size smethod_19(GClass63 gclass63_0, Size size_0, Size size_1)
	{
		using Graphics graphics_ = Graphics.FromHwnd(IntPtr.Zero);
		Class149 @class = new Class149(graphics_, gclass63_0.method_15());
		try
		{
			GStruct4 gstruct4_ = GClass7.smethod_0(@class, gclass63_0.method_14(), Class237.smethod_4(size_0), Class237.smethod_4(size_1));
			if (size_1.Width < 1 && gstruct4_.method_1() > 4096.0)
			{
				gstruct4_.method_2(4096.0);
			}
			return Class237.smethod_6(gstruct4_);
		}
		finally
		{
			((IDisposable)@class).Dispose();
		}
	}

	private static SizeF smethod_20(Graphics graphics_0, string string_0, PointF pointF_0, SizeF sizeF_0, GClass55 gclass55_0, bool bool_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		Region region = null;
		if (sizeF_0.Height > 0f)
		{
			region = graphics_0.Clip;
			graphics_0.SetClip(new RectangleF(pointF_0, sizeF_0));
		}
		SizeF result = smethod_21(graphics_0, string_0, pointF_0, sizeF_0, gclass55_0, bool_0, eventHandler_0, eventHandler_1);
		if (region != null)
		{
			graphics_0.SetClip(region, CombineMode.Replace);
		}
		return result;
	}

	private static SizeF smethod_21(Graphics graphics_0, string string_0, PointF pointF_0, SizeF sizeF_0, GClass55 gclass55_0, bool bool_0, EventHandler<GEventArgs0> eventHandler_0, EventHandler<GEventArgs5> eventHandler_1)
	{
		SizeF result = SizeF.Empty;
		if (!string.IsNullOrEmpty(string_0))
		{
			GClass63 gClass = new GClass63();
			try
			{
				gClass.method_31(pointF_0);
				gClass.method_33(sizeF_0);
				gClass.method_21(bool_1: true);
				gClass.method_23(bool_1: true);
				gClass.method_16(bool_0);
				if (eventHandler_0 != null)
				{
					gClass.method_10(eventHandler_0);
				}
				if (eventHandler_1 != null)
				{
					gClass.method_12(eventHandler_1);
				}
				gClass.method_39(string_0, gclass55_0);
				gClass.method_45(graphics_0);
				gClass.method_46(graphics_0);
				result = gClass.method_34();
			}
			finally
			{
				((IDisposable)gClass).Dispose();
			}
		}
		return result;
	}

	private static void smethod_22(IntPtr intptr_0, Image image_0)
	{
		using Graphics graphics = Graphics.FromImage(image_0);
		IntPtr hdc = graphics.GetHdc();
		Class356.BitBlt(hdc, 0, 0, image_0.Width, image_0.Height, intptr_0, 0, 0, 13369376u);
		graphics.ReleaseHdc(hdc);
	}
}
