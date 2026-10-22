using System;
using System.Drawing;
using System.Drawing.Drawing2D;

internal sealed class Class149 : GClass14
{
	private static readonly int[] int_0;

	private static readonly int[] int_1;

	private static readonly CharacterRange[] characterRange_0;

	private static readonly StringFormat stringFormat_0;

	private static readonly StringFormat stringFormat_1;

	private readonly Graphics graphics_0;

	private readonly bool bool_0;

	private IntPtr intptr_0;

	private readonly bool bool_1;

	private bool bool_2;

	static Class149()
	{
		int_0 = new int[1];
		int_1 = new int[1000];
		characterRange_0 = new CharacterRange[1];
		stringFormat_0 = new StringFormat(StringFormat.GenericTypographic);
		stringFormat_0.FormatFlags = StringFormatFlags.MeasureTrailingSpaces | StringFormatFlags.NoClip;
		stringFormat_1 = new StringFormat(StringFormat.GenericTypographic);
	}

	public Class149(Graphics graphics_1, bool bool_3, bool bool_4 = false)
		: base(Class119.smethod_0(), Class237.smethod_7(graphics_1.ClipBounds))
	{
		GClass24.smethod_1(graphics_1, Class84.smethod_0(-994288345));
		graphics_0 = graphics_1;
		bool_1 = bool_4;
		bool_0 = bool_3;
	}

	public override void vmethod_0()
	{
		method_6();
		stack_0.Pop();
		graphics_0.SetClip(Class237.smethod_8(stack_0.Peek()), CombineMode.Replace);
	}

	public override void vmethod_1(GStruct1 gstruct1_0)
	{
		method_6();
		stack_0.Push(gstruct1_0);
		graphics_0.SetClip(Class237.smethod_8(gstruct1_0), CombineMode.Replace);
	}

	public override void vmethod_2(GStruct1 gstruct1_0)
	{
		method_6();
		stack_0.Push(stack_0.Peek());
		graphics_0.SetClip(Class237.smethod_8(gstruct1_0), CombineMode.Exclude);
	}

	public override object vmethod_3()
	{
		method_6();
		SmoothingMode smoothingMode = graphics_0.SmoothingMode;
		graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
		return smoothingMode;
	}

	public override void vmethod_4(object object_0)
	{
		if (object_0 != null)
		{
			method_6();
			graphics_0.SmoothingMode = (SmoothingMode)object_0;
		}
	}

	public override GStruct4 vmethod_7(string string_0, GClass62 gclass62_0)
	{
		if (bool_0)
		{
			method_6();
			Class339 @class = (Class339)gclass62_0;
			Font font = @class.method_0();
			characterRange_0[0] = new CharacterRange(0, string_0.Length);
			stringFormat_0.SetMeasurableCharacterRanges(characterRange_0);
			SizeF size = graphics_0.MeasureCharacterRanges(string_0, font, RectangleF.Empty, stringFormat_0)[0].GetBounds(graphics_0).Size;
			if (gclass62_0.vmethod_1() < 0.0)
			{
				int height = font.Height;
				float num = font.Size * (float)font.FontFamily.GetCellDescent(font.Style) / (float)font.FontFamily.GetEmHeight(font.Style);
				@class.method_2(height, (int)Math.Round((float)height - num + 0.5f));
			}
			return Class237.smethod_4(size);
		}
		method_8(gclass62_0);
		Size size_ = default;
		Class356.GetTextExtentPoint32W(intptr_0, string_0, string_0.Length, ref size_);
		if (gclass62_0.vmethod_1() < 0.0)
		{
			Class356.GetTextMetrics(intptr_0, out var struct34_);
			((Class339)gclass62_0).method_2(size_.Height, struct34_.int_0 - struct34_.int_2 + struct34_.byte_1 + 1);
		}
		return Class237.smethod_4(size_);
	}

	public override void vmethod_8(string string_0, GClass62 gclass62_0, double double_0, out int int_2, out double double_1)
	{
		int_2 = 0;
		double_1 = 0.0;
		if (bool_0)
		{
			method_6();
			GStruct4 gStruct = vmethod_7(string_0, gclass62_0);
			for (int i = 1; i <= string_0.Length; i++)
			{
				int_2 = i - 1;
				GStruct4 gStruct2 = vmethod_7(string_0.Substring(0, i), gclass62_0);
				if (gStruct2.method_3() <= gStruct.method_3() && gStruct2.method_1() < double_0)
				{
					double_1 = gStruct2.method_1();
					continue;
				}
				break;
			}
		}
		else
		{
			method_8(gclass62_0);
			Size size_ = default;
			Class356.GetTextExtentExPointW(intptr_0, string_0, string_0.Length, (int)Math.Round(double_0), int_0, int_1, ref size_);
			int_2 = int_0[0];
			double_1 = ((int_2 > 0) ? int_1[int_2 - 1] : 0);
		}
	}

	public override void vmethod_9(string string_0, GClass62 gclass62_0, GStruct3 gstruct3_0, GStruct2 gstruct2_0, GStruct4 gstruct4_0, bool bool_3)
	{
		if (bool_0)
		{
			method_6();
			method_11(bool_3);
			Brush brush = ((Class192)gclass0_0.method_3(gstruct3_0)).method_0();
			graphics_0.DrawString(string_0, ((Class339)gclass62_0).method_0(), brush, (int)(Math.Round(gstruct2_0.method_1()) + (bool_3 ? gstruct4_0.method_1() : 0.0)), (int)Math.Round(gstruct2_0.method_3()), stringFormat_1);
			return;
		}
		Point point_ = Class237.smethod_3(gstruct2_0);
		Color color_ = Class237.smethod_11(gstruct3_0);
		if (gstruct3_0.method_3() == byte.MaxValue)
		{
			method_8(gclass62_0);
			method_9(color_);
			method_10(bool_3);
			Class356.TextOutW(intptr_0, point_.X, point_.Y, string_0, string_0.Length);
		}
		else
		{
			method_7();
			method_10(bool_3);
			smethod_0(intptr_0, string_0, gclass62_0, point_, Class237.smethod_6(gstruct4_0), color_);
		}
	}

	public override GClass25 vmethod_5(GClass29 gclass29_0, GStruct1 gstruct1_0, GStruct2 gstruct2_0)
	{
		TextureBrush textureBrush = new TextureBrush(((Class209)gclass29_0).method_0(), Class237.smethod_8(gstruct1_0));
		textureBrush.TranslateTransform((float)gstruct2_0.method_1(), (float)gstruct2_0.method_3());
		return new Class192(textureBrush, bool_1: true);
	}

	public override GClass30 vmethod_6()
	{
		return new Class212();
	}

	public override void Dispose()
	{
		method_6();
		if (bool_1)
		{
			graphics_0.Dispose();
		}
		if (bool_0 && bool_2)
		{
			stringFormat_1.FormatFlags ^= StringFormatFlags.DirectionRightToLeft;
		}
	}

	public override void vmethod_10(GClass19 gclass19_0, double double_0, double double_1, double double_2, double double_3)
	{
		method_6();
		graphics_0.DrawLine(((Class171)gclass19_0).method_0(), (float)double_0, (float)double_1, (float)double_2, (float)double_3);
	}

	public override void vmethod_11(GClass19 gclass19_0, double double_0, double double_1, double double_2, double double_3)
	{
		method_6();
		graphics_0.DrawRectangle(((Class171)gclass19_0).method_0(), (float)double_0, (float)double_1, (float)double_2, (float)double_3);
	}

	public override void vmethod_12(GClass25 gclass25_0, double double_0, double double_1, double double_2, double double_3)
	{
		method_6();
		graphics_0.FillRectangle(((Class192)gclass25_0).method_0(), (float)double_0, (float)double_1, (float)double_2, (float)double_3);
	}

	public override void vmethod_13(GClass29 gclass29_0, GStruct1 gstruct1_0, GStruct1 gstruct1_1)
	{
		method_6();
		graphics_0.DrawImage(((Class209)gclass29_0).method_0(), Class237.smethod_8(gstruct1_0), Class237.smethod_8(gstruct1_1), GraphicsUnit.Pixel);
	}

	public override void vmethod_14(GClass29 gclass29_0, GStruct1 gstruct1_0)
	{
		method_6();
		graphics_0.DrawImage(((Class209)gclass29_0).method_0(), Class237.smethod_8(gstruct1_0));
	}

	public override void vmethod_15(GClass19 gclass19_0, GClass30 gclass30_0)
	{
		graphics_0.DrawPath(((Class171)gclass19_0).method_0(), ((Class212)gclass30_0).method_0());
	}

	public override void vmethod_16(GClass25 gclass25_0, GClass30 gclass30_0)
	{
		method_6();
		graphics_0.FillPath(((Class192)gclass25_0).method_0(), ((Class212)gclass30_0).method_0());
	}

	public override void vmethod_17(GClass25 gclass25_0, GStruct2[] gstruct2_0)
	{
		if (gstruct2_0 != null && gstruct2_0.Length != 0)
		{
			method_6();
			graphics_0.FillPolygon(((Class192)gclass25_0).method_0(), Class237.smethod_1(gstruct2_0));
		}
	}

	private void method_6()
	{
		if (intptr_0 != IntPtr.Zero)
		{
			Class356.SelectClipRgn(intptr_0, IntPtr.Zero);
			graphics_0.ReleaseHdc(intptr_0);
			intptr_0 = IntPtr.Zero;
		}
	}

	private void method_7()
	{
		if (intptr_0 == IntPtr.Zero)
		{
			IntPtr hrgn = graphics_0.Clip.GetHrgn(graphics_0);
			intptr_0 = graphics_0.GetHdc();
			bool_2 = false;
			Class356.SetBkMode(intptr_0, 1);
			Class356.SelectClipRgn(intptr_0, hrgn);
			Class356.DeleteObject(hrgn);
		}
	}

	private void method_8(GClass62 gclass62_0)
	{
		method_7();
		Class356.SelectObject(intptr_0, ((Class339)gclass62_0).method_1());
	}

	private void method_9(Color color_0)
	{
		method_7();
		int num = ((color_0.B & 0xFF) << 16) | ((color_0.G & 0xFF) << 8) | color_0.R;
		Class356.SetTextColor(intptr_0, num);
	}

	private void method_10(bool bool_3)
	{
		if (bool_2)
		{
			if (!bool_3)
			{
				Class356.SetTextAlign(intptr_0, 0u);
			}
		}
		else if (bool_3)
		{
			Class356.SetTextAlign(intptr_0, 256u);
		}
		bool_2 = bool_3;
	}

	private static void smethod_0(IntPtr intptr_1, string string_0, GClass62 gclass62_0, Point point_0, Size size_0, Color color_0)
	{
		IntPtr intptr_2 = Class356.smethod_0(intptr_1, size_0.Width, size_0.Height, out var intptr_3);
		try
		{
			Class356.BitBlt(intptr_2, 0, 0, size_0.Width, size_0.Height, intptr_1, point_0.X, point_0.Y, 13369376u);
			Class356.SelectObject(intptr_2, ((Class339)gclass62_0).method_1());
			Class356.SetTextColor(intptr_2, ((color_0.B & 0xFF) << 16) | ((color_0.G & 0xFF) << 8) | color_0.R);
			Class356.TextOutW(intptr_2, 0, 0, string_0, string_0.Length);
			Class356.GdiAlphaBlend(intptr_1, point_0.X, point_0.Y, size_0.Width, size_0.Height, intptr_2, 0, 0, size_0.Width, size_0.Height, new Struct33(color_0.A));
		}
		finally
		{
			Class356.smethod_1(intptr_2, intptr_3);
		}
	}

	private void method_11(bool bool_3)
	{
		if (bool_2)
		{
			if (!bool_3)
			{
				stringFormat_1.FormatFlags ^= StringFormatFlags.DirectionRightToLeft;
			}
		}
		else if (bool_3)
		{
			stringFormat_1.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
		}
		bool_2 = bool_3;
	}
}
