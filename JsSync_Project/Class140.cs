using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Text;

internal sealed class Class140
{
	public static string smethod_0(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class84.smethod_0(-994091865));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(string_0);
		stringBuilder.AppendLine(Class84.smethod_0(-994091693));
		PointF pointF_ = new PointF(0f, 0f);
		SizeF sizeF_ = new SizeF(800f, 800f);
		Bitmap bitmap = new Bitmap(800, 800);
		try
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.TextRenderingHint = TextRenderingHint.SystemDefault;
				graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, 800, 800);
				GClass15.smethod_8(graphics, stringBuilder.ToString(), pointF_, sizeF_, null, null, null);
			}
			Bitmap bitmap2 = GClass18.smethod_20(bitmap);
			string filename = Path.Combine(path2: Class282.smethod_0(20) + Class84.smethod_0(-994274268), path1: Class224.Class232.string_1);
			bitmap2.Save(filename);
			return GClass18.smethod_18(Image.FromFile(filename));
		}
		finally
		{
			((IDisposable)bitmap).Dispose();
		}
	}
}
