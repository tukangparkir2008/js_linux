using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public sealed class GClass32
{
	private sealed class Class217
	{
		public readonly Image image_0;

		public readonly string string_0;

		public Class217(Image image_1, string string_1)
		{
			image_0 = image_1;
			string_0 = string_1;
		}
	}

	private readonly List<Class151> list_0 = new List<Class151>();

	private readonly List<Image> list_1 = new List<Image>();

	private readonly List<Class217> list_2 = new List<Class217>();

	private readonly List<Image> list_3 = new List<Image>();

	private GClass71 gclass71_0;

	public GClass32(Control control_0, int int_0, int int_1, int int_2, float float_0)
	{
		method_1(new GClass71(control_0, int_0, int_1, int_2, float_0));
	}

	public GClass71 method_0()
	{
		return gclass71_0;
	}

	private void method_1(GClass71 gclass71_1)
	{
		gclass71_0 = gclass71_1;
	}

	public List<Image> method_2()
	{
		return list_3;
	}

	public void method_3(Image image_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class153(image_0, method_0()));
		}
	}

	public void method_4(string string_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class154(string_0, method_0()));
		}
	}

	public void method_5(string string_0, Font font_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class154(string_0, font_0, method_0()));
		}
	}

	public void method_6(string string_0, Font font_0, GEnum10 genum10_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class154(string_0, font_0, genum10_0, method_0()));
		}
	}

	public void method_7(string string_0, Font font_0, Color color_0, Color color_1, GEnum10 genum10_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class154(string_0, font_0, color_0, color_1, genum10_0, method_0()));
		}
	}

	public void method_8(GClass43 gclass43_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class155(gclass43_0, method_0()));
		}
	}

	public void method_9(GClass43 gclass43_0, GClass64 gclass64_0)
	{
		lock (list_0)
		{
			list_0.Add(new Class155(gclass43_0, gclass64_0, method_0()));
		}
	}

	public void method_10()
	{
		lock (list_0)
		{
			list_0.Add(new Class152(method_0()));
		}
	}

	private void method_11()
	{
		list_1.Clear();
		lock (list_0)
		{
			foreach (Class151 item in list_0)
			{
				if (item != null)
				{
					if (item is Class153)
					{
						method_15((Class153)item);
					}
					else if (item is Class152)
					{
						method_14((Class152)item);
					}
					else if (item is Class154)
					{
						method_13((Class154)item);
					}
					else if (item is Class155)
					{
						method_12((Class155)item);
					}
				}
			}
		}
	}

	private void method_12(Class155 class155_0)
	{
		Image item = class155_0.method_3();
		list_1.Add(item);
	}

	private void method_13(Class154 class154_0)
	{
		Image item = class154_0.method_10();
		list_1.Add(item);
	}

	private void method_14(Class152 class152_0)
	{
		Image item = class152_0.method_1();
		list_1.Add(item);
	}

	private void method_15(Class153 class153_0)
	{
		Image item = class153_0.method_2();
		list_1.Add(item);
	}

	private Image method_16()
	{
		int num = 0;
		int num2 = 0;
		foreach (Image item in list_1)
		{
			if (num2 < item.Width)
			{
				num2 = item.Width;
			}
			num += item.Height;
		}
		Bitmap bitmap = new Bitmap(num2, num);
		bitmap.SetResolution(method_0().method_0(), method_0().method_1());
		using Graphics graphics = Graphics.FromImage(bitmap);
		graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, bitmap.Width, bitmap.Height));
		int num3 = 0;
		foreach (Image item2 in list_1)
		{
			graphics.DrawImage(item2, new Point(0, num3));
			num3 += item2.Height;
		}
		return bitmap;
	}

	public void method_17(string string_0)
	{
		if (list_0.Count != 0)
		{
			method_11();
			method_16().Save(string_0);
		}
	}

	public void method_18()
	{
		if (list_0.Count != 0)
		{
			method_11();
			Image image_ = method_16();
			method_21(image_);
			method_19();
		}
	}

	private void method_19()
	{
		list_3.Clear();
		foreach (Class217 item in list_2)
		{
			Bitmap bitmap = new Bitmap(method_0().method_5(), method_0().method_4());
			bitmap.SetResolution(method_0().method_0(), method_0().method_1());
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, bitmap.Width, bitmap.Height);
				graphics.DrawImage(item.image_0, new Point(method_0().method_6(), method_0().method_8()));
				SizeF sizeF = graphics.MeasureString(item.string_0, GClass1.font_0);
				float x = ((float)method_0().method_5() - sizeF.Width) / 2f;
				float y = (float)(method_0().method_8() + method_0().method_11()) + ((float)method_0().method_9() - sizeF.Height) / 2f;
				graphics.DrawString(item.string_0, GClass1.font_0, new SolidBrush(Color.Black), x, y);
				string s = smethod_0() + Class84.smethod_0(-994271851) + DateTime.Now.ToString(Class84.smethod_0(-994212511));
				Font font = new Font(GClass1.font_0.Name, GClass1.font_0.Size, FontStyle.Italic);
				graphics.DrawString(s, font, new SolidBrush(Color.Black), method_0().method_6(), y);
			}
			list_3.Add(bitmap);
		}
	}

	private static string smethod_0()
	{
		return DateTime.Now.DayOfWeek switch
		{
			DayOfWeek.Sunday => Class84.smethod_0(-994212469), 
			DayOfWeek.Monday => Class84.smethod_0(-994212424), 
			DayOfWeek.Tuesday => Class84.smethod_0(-994212428), 
			DayOfWeek.Wednesday => Class84.smethod_0(-994212447), 
			DayOfWeek.Thursday => Class84.smethod_0(-994212388), 
			DayOfWeek.Friday => Class84.smethod_0(-994212408), 
			_ => Class84.smethod_0(-994212411), 
		};
	}

	private void method_20(Image image_0, int int_0)
	{
		Bitmap bitmap = new Bitmap(image_0);
		bitmap.SetResolution(method_0().method_0(), method_0().method_1());
		int num = 0;
		while (bitmap != null && method_0().method_10() <= bitmap.Width)
		{
			num++;
			Bitmap bitmap2 = new Bitmap(method_0().method_10(), image_0.Height);
			bitmap2.SetResolution(method_0().method_0(), method_0().method_1());
			using (Graphics graphics = Graphics.FromImage(bitmap2))
			{
				graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), GraphicsUnit.Pixel);
			}
			string string_ = int_0 + Class84.smethod_0(-994278690) + num;
			list_2.Add(new Class217(bitmap2, string_));
			if (bitmap.Width == method_0().method_10())
			{
				bitmap = null;
				continue;
			}
			int x = method_0().method_10() - 10;
			int width = bitmap.Width - method_0().method_10() + 10;
			Bitmap bitmap3 = new Bitmap(width, image_0.Height);
			bitmap3.SetResolution(method_0().method_0(), method_0().method_1());
			using (Graphics graphics2 = Graphics.FromImage(bitmap3))
			{
				graphics2.DrawImage(bitmap, new Rectangle(0, 0, bitmap3.Width, bitmap3.Height), new Rectangle(x, 0, width, bitmap3.Height), GraphicsUnit.Pixel);
			}
			bitmap = new Bitmap(bitmap3);
			bitmap.SetResolution(method_0().method_0(), method_0().method_1());
		}
		if (bitmap != null && bitmap.Width > 0)
		{
			num++;
			string string_2 = int_0 + Class84.smethod_0(-994278690) + num;
			list_2.Add(new Class217(bitmap, string_2));
		}
	}

	private void method_21(Image image_0)
	{
		list_2.Clear();
		Bitmap bitmap = new Bitmap(image_0);
		bitmap.SetResolution(method_0().method_0(), method_0().method_1());
		int num = 0;
		while (bitmap != null && method_0().method_11() <= bitmap.Height)
		{
			num++;
			Bitmap bitmap2 = new Bitmap(image_0.Width, method_0().method_11());
			bitmap2.SetResolution(method_0().method_0(), method_0().method_1());
			using (Graphics graphics = Graphics.FromImage(bitmap2))
			{
				graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), GraphicsUnit.Pixel);
			}
			if (bitmap2.Width <= method_0().method_10())
			{
				list_2.Add(new Class217(bitmap2, num.ToString()));
			}
			else
			{
				method_20(bitmap2, num);
			}
			if (bitmap.Height == method_0().method_11())
			{
				bitmap = null;
				continue;
			}
			int y = method_0().method_11() - 10;
			int height = bitmap.Height - method_0().method_11() + 10;
			Bitmap bitmap3 = new Bitmap(image_0.Width, height);
			bitmap3.SetResolution(method_0().method_0(), method_0().method_1());
			using (Graphics graphics2 = Graphics.FromImage(bitmap3))
			{
				graphics2.DrawImage(bitmap, new Rectangle(0, 0, bitmap3.Width, bitmap3.Height), new Rectangle(0, y, bitmap3.Width, height), GraphicsUnit.Pixel);
			}
			bitmap = new Bitmap(bitmap3);
			bitmap.SetResolution(method_0().method_0(), method_0().method_1());
		}
		if (bitmap != null && bitmap.Height > 0)
		{
			num++;
			if (bitmap.Width <= method_0().method_10())
			{
				list_2.Add(new Class217(bitmap, num.ToString()));
			}
			else
			{
				method_20(bitmap, num);
			}
		}
	}
}
