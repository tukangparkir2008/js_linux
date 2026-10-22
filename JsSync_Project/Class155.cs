using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

internal sealed class Class155 : Class151
{
	private GClass43 gclass43_0;

	private readonly GClass64 gclass64_0;

	private readonly GClass71 gclass71_0;

	public Class155(GClass43 gclass43_1, GClass71 gclass71_1)
	{
		method_1(gclass43_1);
		gclass64_0 = new GClass64();
		gclass71_0 = gclass71_1;
	}

	public Class155(GClass43 gclass43_1, GClass64 gclass64_1, GClass71 gclass71_1)
	{
		method_1(gclass43_1);
		gclass64_0 = gclass64_1;
		gclass71_0 = gclass71_1;
	}

	public GClass43 method_0()
	{
		return gclass43_0;
	}

	private void method_1(GClass43 gclass43_1)
	{
		gclass43_0 = gclass43_1;
	}

	private void method_2()
	{
		if (gclass71_0.method_2() == gclass71_0.method_0() && gclass71_0.method_3() == gclass71_0.method_1())
		{
			return;
		}
		gclass64_0.int_0 = GClass52.smethod_2(gclass64_0.int_0, gclass71_0.method_3(), gclass71_0.method_1());
		gclass64_0.int_1 = GClass52.smethod_2(gclass64_0.int_1, gclass71_0.method_3(), gclass71_0.method_1());
		foreach (GClass9 item in method_0().method_0().method_0())
		{
			item.int_0 = GClass52.smethod_2(item.int_0, gclass71_0.method_3(), gclass71_0.method_1());
		}
		int length = method_0().method_1().method_0().GetLength(0);
		int length2 = method_0().method_1().method_0().GetLength(1);
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < length2; j++)
			{
				GClass9 gClass = method_0().method_1().method_0()[i, j];
				gClass.int_0 = GClass52.smethod_2(gClass.int_0, gclass71_0.method_2(), gclass71_0.method_0());
				if (gClass.genum11_0 != (GEnum11)1 && gClass.image_0 != null)
				{
					int height = gClass.image_0.Height;
					height = GClass52.smethod_2(height, gclass71_0.method_3(), gclass71_0.method_1());
					int width = gClass.image_0.Width;
					width = GClass52.smethod_2(width, gclass71_0.method_2(), gclass71_0.method_0());
					if (gClass.int_0 < width)
					{
						float num = (float)gClass.int_0 / (float)width;
						height = Convert.ToInt32((float)height * num);
						width = gClass.int_0;
					}
					Bitmap bitmap = new Bitmap(width, height);
					bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
						graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
						graphics.CompositingQuality = CompositingQuality.HighQuality;
						graphics.DrawImage(gClass.image_0, 0, 0);
					}
					gClass.image_0 = bitmap;
				}
			}
		}
	}

	public Image method_3()
	{
		method_2();
		int length = method_0().method_1().method_0().GetLength(0);
		int length2 = method_0().method_1().method_0().GetLength(1);
		List<int> list = new List<int>();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (GClass9 item in method_0().method_0().method_0())
		{
			num += item.int_0 + 2 * gclass64_0.int_0;
			SizeF sizeF = method_4(item.string_0, item.font_0, item.int_0, item.genum10_0);
			if ((float)num3 < sizeF.Height + (float)(2 * gclass64_0.int_0))
			{
				num3 = (int)sizeF.Height + 2 * gclass64_0.int_0;
			}
		}
		list.Add(num3);
		num2 += num3;
		for (int i = 0; i < length; i++)
		{
			num3 = gclass64_0.int_1;
			for (int j = 0; j < length2; j++)
			{
				GClass9 gClass = method_0().method_1().method_0()[i, j];
				if (gClass.genum11_0 == (GEnum11)1)
				{
					SizeF sizeF2 = method_4(gClass.string_0, gClass.font_0, gClass.int_0, gClass.genum10_0);
					if ((float)num3 < sizeF2.Height + (float)(2 * gclass64_0.int_0))
					{
						num3 = (int)sizeF2.Height + 2 * gclass64_0.int_0;
					}
				}
				else if (gClass.image_0 != null)
				{
					if (gClass.image_0.Width > gClass.int_0)
					{
						gClass.image_0 = GClass18.smethod_5(gClass.image_0, gClass.int_0);
					}
					if (num3 < gClass.image_0.Height + 2 * gclass64_0.int_0)
					{
						num3 = gClass.image_0.Height + 2 * gclass64_0.int_0;
					}
				}
			}
			list.Add(num3);
			num2 += num3;
		}
		Bitmap bitmap = new Bitmap(num, num2);
		bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		foreach (GClass9 item2 in method_0().method_0().method_0())
		{
			StringFormat format = new StringFormat
			{
				Alignment = ((item2.genum10_0 != (GEnum10)1) ? ((item2.genum10_0 == (GEnum10)2) ? StringAlignment.Center : StringAlignment.Far) : StringAlignment.Near)
			};
			Bitmap bitmap2 = new Bitmap(item2.int_0 + 2 * gclass64_0.int_0, list[num6]);
			bitmap2.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
			using (Graphics graphics = Graphics.FromImage(bitmap2))
			{
				graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				Rectangle rect = new Rectangle(0, 0, bitmap2.Width, bitmap2.Height);
				graphics.FillRectangle(new SolidBrush(item2.color_0), rect);
				graphics.DrawString(layoutRectangle: new Rectangle(gclass64_0.int_0, gclass64_0.int_0, bitmap2.Width - gclass64_0.int_0, bitmap2.Height - gclass64_0.int_0), s: item2.string_0, font: item2.font_0, brush: new SolidBrush(item2.color_1), format: format);
				graphics.DrawRectangle(new Pen(Color.Black, 0.5f), rect);
			}
			using (Graphics graphics2 = Graphics.FromImage(bitmap))
			{
				graphics2.DrawImage(bitmap2, new Point(num4, num5));
			}
			num4 += bitmap2.Width;
		}
		num5 += list[num6];
		for (int k = 0; k < length; k++)
		{
			num4 = 0;
			num6++;
			for (int l = 0; l < length2; l++)
			{
				GClass9 gClass2 = method_0().method_1().method_0()[k, l];
				StringFormat format2 = new StringFormat
				{
					Alignment = ((gClass2.genum10_0 != (GEnum10)1) ? ((gClass2.genum10_0 == (GEnum10)2) ? StringAlignment.Center : StringAlignment.Far) : StringAlignment.Near)
				};
				Bitmap bitmap3 = new Bitmap(gClass2.int_0 + 2 * gclass64_0.int_0, list[num6]);
				bitmap3.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
				using (Graphics graphics3 = Graphics.FromImage(bitmap3))
				{
					graphics3.TextRenderingHint = TextRenderingHint.AntiAlias;
					graphics3.SmoothingMode = SmoothingMode.AntiAlias;
					graphics3.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics3.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics3.CompositingQuality = CompositingQuality.HighQuality;
					Rectangle rect2 = new Rectangle(0, 0, bitmap3.Width, bitmap3.Height);
					if (gClass2.genum11_0 == (GEnum11)1)
					{
						graphics3.FillRectangle(new SolidBrush(gClass2.color_0), rect2);
						graphics3.DrawString(layoutRectangle: new Rectangle(gclass64_0.int_0, gclass64_0.int_0, bitmap3.Width - gclass64_0.int_0, bitmap3.Height - gclass64_0.int_0), s: gClass2.string_0, font: gClass2.font_0, brush: new SolidBrush(gClass2.color_1), format: format2);
						graphics3.DrawRectangle(new Pen(Color.Black, 0.5f), rect2);
					}
					else
					{
						graphics3.FillRectangle(new SolidBrush(gClass2.color_0), rect2);
						graphics3.DrawImage(gClass2.image_0, gclass64_0.int_0, gclass64_0.int_0);
						graphics3.DrawRectangle(new Pen(Color.Black, 0.5f), rect2);
					}
				}
				using (Graphics graphics4 = Graphics.FromImage(bitmap))
				{
					graphics4.DrawImage(bitmap3, new Point(num4, num5));
				}
				num4 += bitmap3.Width;
			}
			num5 += list[num6];
		}
		return bitmap;
	}

	public SizeF method_4(string string_0, Font font_0, int int_0, GEnum10 genum10_0)
	{
		StringFormat format = new StringFormat
		{
			Alignment = genum10_0 switch
			{
				(GEnum10)2 => StringAlignment.Center, 
				(GEnum10)1 => StringAlignment.Near, 
				_ => StringAlignment.Far, 
			}
		};
		Bitmap bitmap = new Bitmap(int_0, 100);
		bitmap.SetResolution(gclass71_0.method_0(), gclass71_0.method_1());
		using Graphics graphics = Graphics.FromImage(bitmap);
		return graphics.MeasureString(string_0, font_0, int_0, format);
	}
}
