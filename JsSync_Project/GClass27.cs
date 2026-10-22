using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public sealed class GClass27
{
	public static byte[] smethod_0(PictureBox pictureBox_0)
	{
		if (pictureBox_0.Image == null)
		{
			return null;
		}
		return GClass36.smethod_1((byte[])new ImageConverter().ConvertTo(pictureBox_0.Image, typeof(byte[])), Class224.Class234.string_0);
	}

	public static byte[] smethod_1(Image image_0)
	{
		if (image_0 == null)
		{
			return null;
		}
		return GClass36.smethod_1((byte[])new ImageConverter().ConvertTo(image_0, typeof(byte[])), Class224.Class234.string_0);
	}

	private static Image smethod_2()
	{
		Bitmap bitmap = new Bitmap(30, 30);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 30, 30);
			Pen pen = new Pen(Color.Red, 2f);
			graphics.DrawLine(pen, 0, 0, 30, 30);
			graphics.DrawLine(pen, 0, 30, 30, 0);
		}
		return GClass18.smethod_13(bitmap);
	}

	public static Image smethod_3(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return smethod_2();
		}
		byte_0 = GClass36.smethod_1(byte_0, Class224.Class234.string_0);
		MemoryStream memoryStream = new MemoryStream(byte_0);
		try
		{
			return GClass18.smethod_13(Image.FromStream(memoryStream));
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static byte[] smethod_4(string string_0)
	{
		if (string_0 != null)
		{
			return GClass36.smethod_1(GClass37.smethod_0(string_0), Class224.Class234.string_0);
		}
		return null;
	}

	public static string smethod_5(byte[] byte_0)
	{
		byte_0 = GClass36.smethod_1(byte_0, Class224.Class234.string_0);
		return GClass37.smethod_1(byte_0);
	}
}
