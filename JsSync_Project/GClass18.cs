using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

public sealed class GClass18
{
	public enum GEnum1
	{

	}

	public static Image smethod_0(string string_0)
	{
		return smethod_1(string_0, new Font(Class84.smethod_0(-994273712), 11f), Color.White, Color.Black);
	}

	public static Image smethod_1(string string_0, Font font_0, Color color_0, Color color_1)
	{
		SolidBrush brush = new SolidBrush(color_0);
		SolidBrush brush2 = new SolidBrush(color_1);
		SizeF sizeF = Graphics.FromImage(new Bitmap(10, 10)).MeasureString(string_0, font_0);
		int num = (int)sizeF.Width + 80;
		int num2 = (int)sizeF.Height + 50;
		Bitmap bitmap = new Bitmap(num, num2);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.FillRectangle(brush, 0, 0, num, num2);
			float x = ((float)num - sizeF.Width) / 2f;
			float y = ((float)num2 - sizeF.Height) / 2f;
			graphics.DrawString(string_0, font_0, brush2, x, y);
		}
		return smethod_13(bitmap);
	}

	public static Image smethod_2(Image image_0, Color color_0, int int_0, int int_1, int int_2, int int_3)
	{
		if (image_0.Width > int_0 && image_0.Height > int_1)
		{
			return smethod_13(image_0);
		}
		if (image_0.Width > int_0 + int_3)
		{
			int_0 = image_0.Width + int_3;
		}
		if (image_0.Height > int_1 + int_2)
		{
			int_1 = image_0.Height + int_2;
		}
		Bitmap bitmap = new Bitmap(int_0, int_1);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.FillRectangle(new SolidBrush(color_0), 0, 0, int_0, int_1);
			graphics.DrawImage(image_0, new Point(int_2, int_3));
		}
		return smethod_13(bitmap);
	}

	public static Image smethod_3(Image image_0, float float_0, float float_1)
	{
		int width = image_0.Width;
		int height = image_0.Height;
		double num = 1.0;
		if (float_0 < (float)width || float_1 < (float)height)
		{
			float num2 = float_0 / (float)width;
			float num3 = float_1 / (float)height;
			num = ((num2 < num3) ? num2 : num3);
		}
		int width2 = Convert.ToInt32((double)width * num);
		int height2 = Convert.ToInt32((double)height * num);
		Bitmap bitmap = new Bitmap(width2, height2);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		graphics.DrawImage(image_0, new Rectangle(0, 0, width2, height2), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
		graphics.Dispose();
		return bitmap;
	}

	public static Image smethod_4(Image image_0, float float_0)
	{
		Graphics graphics = null;
		try
		{
			int height = image_0.Height;
			int width = image_0.Width;
			float num = float_0 / (float)height;
			int width2 = Convert.ToInt32((float)width * num);
			int height2 = Convert.ToInt32(float_0);
			Bitmap bitmap = new Bitmap(width2, height2);
			graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(image_0, new Rectangle(0, 0, width2, height2), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
			return bitmap;
		}
		finally
		{
			graphics?.Dispose();
		}
	}

	public static Image smethod_5(Image image_0, float float_0)
	{
		Graphics graphics = null;
		try
		{
			int height = image_0.Height;
			int width = image_0.Width;
			float num = float_0 / (float)width;
			int width2 = Convert.ToInt32(float_0);
			int height2 = Convert.ToInt32((float)height * num);
			Bitmap bitmap = new Bitmap(width2, height2);
			graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(image_0, new Rectangle(0, 0, width2, height2), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
			return bitmap;
		}
		finally
		{
			graphics?.Dispose();
		}
	}

	public static Image smethod_6(Image image_0, float float_0, float float_1)
	{
		Graphics graphics = null;
		try
		{
			int width = image_0.Width;
			int height = image_0.Height;
			int width2 = Convert.ToInt32(float_0);
			int height2 = Convert.ToInt32(float_1);
			Bitmap bitmap = new Bitmap(width2, height2);
			graphics = Graphics.FromImage(bitmap);
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.DrawImage(image_0, new Rectangle(0, 0, width2, height2), new Rectangle(0, 0, width, height), GraphicsUnit.Pixel);
			return bitmap;
		}
		finally
		{
			graphics?.Dispose();
		}
	}

	public static Image smethod_7(Image image_0, int int_0, int int_1, int int_2, int int_3)
	{
		Graphics graphics = null;
		try
		{
			Bitmap bitmap = new Bitmap(int_0, int_1, PixelFormat.Format24bppRgb);
			bitmap.SetResolution(96f, 96f);
			graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.DrawImage(image_0, new Rectangle(0, 0, int_0, int_1), new Rectangle(int_2, int_3, int_0, int_1), GraphicsUnit.Pixel);
			return bitmap;
		}
		finally
		{
			graphics?.Dispose();
		}
	}

	public static Image smethod_8(Image image_0, string string_0, Font font_0)
	{
		Graphics graphics = null;
		try
		{
			Bitmap bitmap = new Bitmap(image_0.Width, image_0.Height, PixelFormat.Format24bppRgb);
			bitmap.SetResolution(96f, 96f);
			graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.DrawImage(image_0, new Rectangle(0, 0, image_0.Width, image_0.Height), new Rectangle(0, 0, image_0.Width, image_0.Height), GraphicsUnit.Pixel);
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 5, image_0.Height));
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, image_0.Width, 5));
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(image_0.Width - 5, 0, 5, image_0.Height));
			graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, image_0.Height - 25, image_0.Width, 25));
			graphics.DrawRectangle(new Pen(Color.Black), 0, 0, image_0.Width, image_0.Height);
			SizeF sizeF = graphics.MeasureString(string_0, font_0);
			graphics.DrawString(x: ((float)image_0.Width - sizeF.Width) / 2f, y: (float)(image_0.Height - 25) + (25f - sizeF.Height) / 2f, s: string_0, font: font_0, brush: new SolidBrush(Color.Black));
			return bitmap;
		}
		finally
		{
			graphics?.Dispose();
		}
	}

	public static byte[] smethod_9(Image image_0)
	{
		return (byte[])new ImageConverter().ConvertTo(image_0, typeof(byte[]));
	}

	public static Image smethod_10(DataRow dataRow_0, int int_0)
	{
		if (dataRow_0[int_0] == null)
		{
			return null;
		}
		byte[] array = (byte[])dataRow_0[int_0];
		if (array.Length == 0)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream(array);
		try
		{
			memoryStream.Write(array, 0, array.Length);
			memoryStream.Position = 0L;
			return Image.FromStream(memoryStream);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static Image smethod_11(IDataRecord idataRecord_0, int int_0)
	{
		MemoryStream memoryStream = null;
		BinaryWriter binaryWriter = null;
		Image result = null;
		try
		{
			byte[] buffer = new byte[1024];
			long num = 0L;
			long bytes = idataRecord_0.GetBytes(int_0, 0L, buffer, 0, 1024);
			if (bytes == 0L)
			{
				return result;
			}
			memoryStream = new MemoryStream();
			binaryWriter = new BinaryWriter(memoryStream);
			while (bytes == 1024L)
			{
				binaryWriter.Write(buffer);
				binaryWriter.Flush();
				num += 1024L;
				bytes = idataRecord_0.GetBytes(int_0, num, buffer, 0, 1024);
			}
			if ((int)bytes > 1)
			{
				binaryWriter.Write(buffer, 0, (int)bytes - 1);
				binaryWriter.Flush();
			}
			return Image.FromStream(memoryStream);
		}
		finally
		{
			if (memoryStream != null)
			{
				memoryStream.Flush();
				memoryStream.Close();
			}
			if (binaryWriter != null)
			{
				binaryWriter.Flush();
				binaryWriter.Close();
			}
		}
	}

	public static Image smethod_12(IDataRecord idataRecord_0, int int_0)
	{
		try
		{
			byte[] array = (byte[])idataRecord_0[int_0];
			if (array != null)
			{
				MemoryStream memoryStream = new MemoryStream(array);
				try
				{
					return Image.FromStream(memoryStream);
				}
				finally
				{
					((IDisposable)memoryStream).Dispose();
				}
			}
			return null;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Image smethod_13(Image image_0)
	{
		if (image_0 == null)
		{
			return null;
		}
		byte[] array = smethod_9(image_0);
		byte[] array2 = new byte[array.Length];
		Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		return smethod_24(array2);
	}

	public static Image smethod_14(Image image_0)
	{
		if (image_0 == null)
		{
			return null;
		}
		return new Bitmap(image_0);
	}

	public static Image smethod_15(Image image_0)
	{
		if (image_0 == null)
		{
			return null;
		}
		return new Bitmap(image_0);
	}

	public static Image smethod_16(string string_0)
	{
		byte[] array = Convert.FromBase64String(string_0);
		MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
		try
		{
			return Image.FromStream(memoryStream, useEmbeddedColorManagement: true);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static string smethod_17(Image image_0, ImageFormat imageFormat_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			image_0.Save(memoryStream, imageFormat_0);
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static string smethod_18(Image image_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			image_0.Save(memoryStream, image_0.RawFormat);
			return Convert.ToBase64String(memoryStream.ToArray());
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static string smethod_19(Image image_0)
	{
		return Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(image_0, typeof(byte[])));
	}

	public static Bitmap smethod_20(Bitmap bitmap_0)
	{
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(Point.Empty, bitmap_0.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
		int[] array = new int[bitmap_0.Height * bitmap_0.Width];
		Marshal.Copy(bitmapData.Scan0, array, 0, array.Length);
		bitmap_0.UnlockBits(bitmapData);
		int num = bitmapData.Width;
		int num2 = bitmapData.Height;
		int num3 = 0;
		int num4 = 0;
		for (int i = 0; i < array.Length; i++)
		{
			if ((array[i] & 0xFFFFFF) != 16777215)
			{
				int num5 = i / bitmapData.Width;
				int num6 = i % bitmapData.Width;
				if (num > num6)
				{
					num = num6;
				}
				if (num3 < num6)
				{
					num3 = num6;
				}
				num4 = num5;
				num2 = num5;
				break;
			}
		}
		int num7 = array.Length - 1;
		while (num7 >= 0)
		{
			if ((array[num7] & 0xFFFFFF) == 16777215)
			{
				num7--;
				continue;
			}
			int num8 = num7 / bitmapData.Width;
			int num9 = num7 % bitmapData.Width;
			if (num > num9)
			{
				num = num9;
			}
			if (num3 < num9)
			{
				num3 = num9;
			}
			num4 = num8;
			break;
		}
		if (num4 > num2)
		{
			for (int j = num2 + 1; j < num4; j++)
			{
				for (int k = 0; k < num; k++)
				{
					if ((array[j * bitmapData.Width + k] & 0xFFFFFF) != 16777215 && num > k)
					{
						num = k;
						break;
					}
				}
				int num10 = bitmapData.Width - 1;
				while (num10 > num3)
				{
					if ((array[j * bitmapData.Width + num10] & 0xFFFFFF) == 16777215 || num3 >= num10)
					{
						num10--;
						continue;
					}
					num3 = num10;
					break;
				}
			}
		}
		int num11 = num3 - num + 1;
		int num12 = num4 - num2 + 1;
		int[] array2 = new int[num11 * num12];
		for (int l = num2; l <= num4; l++)
		{
			Array.Copy(array, l * bitmapData.Width + num, array2, (l - num2) * num11, num11);
		}
		Bitmap bitmap = new Bitmap(num11, num12, PixelFormat.Format32bppArgb);
		BitmapData bitmapData2 = bitmap.LockBits(new Rectangle(0, 0, num11, num12), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
		Marshal.Copy(array2, 0, bitmapData2.Scan0, array2.Length);
		bitmap.UnlockBits(bitmapData2);
		return bitmap;
	}

	public static ImageFormat smethod_21(Image image_0)
	{
		if (ImageFormat.Jpeg.Equals(image_0.RawFormat))
		{
			return ImageFormat.Jpeg;
		}
		if (ImageFormat.Bmp.Equals(image_0.RawFormat))
		{
			return ImageFormat.Bmp;
		}
		if (ImageFormat.Emf.Equals(image_0.RawFormat))
		{
			return ImageFormat.Emf;
		}
		if (ImageFormat.Exif.Equals(image_0.RawFormat))
		{
			return ImageFormat.Exif;
		}
		if (ImageFormat.Gif.Equals(image_0.RawFormat))
		{
			return ImageFormat.Gif;
		}
		if (ImageFormat.Png.Equals(image_0.RawFormat))
		{
			return ImageFormat.Png;
		}
		if (ImageFormat.Tiff.Equals(image_0.RawFormat))
		{
			return ImageFormat.Tiff;
		}
		if (ImageFormat.Wmf.Equals(image_0.RawFormat))
		{
			return ImageFormat.Wmf;
		}
		if (ImageFormat.Icon.Equals(image_0.RawFormat))
		{
			return ImageFormat.Icon;
		}
		return ImageFormat.Bmp;
	}

	public static Image smethod_22(Image image_0, ImageFormat imageFormat_0)
	{
		if (imageFormat_0.Equals(smethod_21(image_0)))
		{
			return image_0;
		}
		MemoryStream memoryStream = new MemoryStream();
		image_0.Save(memoryStream, imageFormat_0);
		memoryStream.Position = 0L;
		return Image.FromStream(memoryStream);
	}

	public static ImageCodecInfo smethod_23(ImageFormat imageFormat_0)
	{
		ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
		int num = 0;
		ImageCodecInfo imageCodecInfo;
		while (true)
		{
			if (num < imageDecoders.Length)
			{
				imageCodecInfo = imageDecoders[num];
				if (imageCodecInfo.FormatID == imageFormat_0.Guid)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return imageCodecInfo;
	}

	public static Image smethod_24(byte[] byte_0)
	{
		return Image.FromStream(new MemoryStream(byte_0));
	}

	public static bool smethod_25(byte[] byte_0)
	{
		try
		{
			Image.FromStream(new MemoryStream(byte_0));
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static Image smethod_26(byte[] byte_0, string string_0)
	{
		try
		{
			return Image.FromStream(new MemoryStream(byte_0));
		}
		catch (Exception)
		{
			return smethod_0(string_0);
		}
	}

	public static Image smethod_27(byte[] byte_0, Image image_0)
	{
		try
		{
			return Image.FromStream(new MemoryStream(byte_0));
		}
		catch (Exception)
		{
			return image_0;
		}
	}

	public static Image smethod_28(Image image_0, ImageFormat imageFormat_0, long long_0)
	{
		if (imageFormat_0.Equals(smethod_21(image_0)))
		{
			return image_0;
		}
		ImageCodecInfo encoder = smethod_23(imageFormat_0);
		Encoder quality = Encoder.Quality;
		EncoderParameters encoderParameters = new EncoderParameters(1);
		EncoderParameter encoderParameter = new EncoderParameter(quality, long_0);
		encoderParameters.Param[0] = encoderParameter;
		MemoryStream memoryStream = new MemoryStream();
		byte[] byte_;
		try
		{
			image_0.Save(memoryStream, encoder, encoderParameters);
			byte_ = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return smethod_24(byte_);
	}

	public static Bitmap smethod_29(string string_0, Font font_0, Brush brush_0, Brush brush_1, GEnum1 genum1_0, float float_0, float float_1, int int_0, int int_1)
	{
		string_0 = string_0.Trim();
		string text = string.Empty;
		List<string> list = new List<string>();
		Bitmap bitmap = new Bitmap(int_0, int_1);
		try
		{
			using Graphics graphics = Graphics.FromImage(bitmap);
			for (int num = string_0.IndexOf(Class84.smethod_0(-994263061)); num >= 0; num = string_0.IndexOf(Class84.smethod_0(-994263061)))
			{
				string text2 = string_0.Substring(0, num) + Class84.smethod_0(-994263061);
				string text3 = text + text2;
				if (graphics.MeasureString(text3, font_0).Width <= (float)int_0)
				{
					text = text3;
				}
				else
				{
					string text4 = text;
					text = text2;
					if (graphics.MeasureString(text4, font_0).Width > (float)int_0)
					{
						int startIndex = 0;
						text3 = text4;
						int num2 = text4.Length - 1;
						while (num2 >= 1)
						{
							text3 = text4.Substring(0, num2);
							if (graphics.MeasureString(text3, font_0).Width >= (float)int_0)
							{
								num2--;
								continue;
							}
							startIndex = num2;
							break;
						}
						text = text4.Substring(startIndex) + text2;
						text4 = text3;
					}
					list.Add(text4);
				}
				if (string_0.Length >= num + 1)
				{
					string_0 = string_0.Substring(num + 1);
				}
			}
			if (text.Length > 0)
			{
				string_0 = text + string_0;
			}
			if (string_0.Length > 0)
			{
				list.Add(string_0);
			}
		}
		finally
		{
			((IDisposable)bitmap).Dispose();
		}
		float num3 = 0f;
		float num4 = 0f;
		Bitmap bitmap2 = new Bitmap(int_0, int_1);
		try
		{
			using Graphics graphics2 = Graphics.FromImage(bitmap2);
			foreach (string item in list)
			{
				float num5 = float_0 + graphics2.MeasureString(item, font_0).Width;
				float height = graphics2.MeasureString(item, font_0).Height;
				if (num3 < num5)
				{
					num3 = num5;
				}
				num4 += height;
			}
		}
		finally
		{
			((IDisposable)bitmap2).Dispose();
		}
		int_0 = (int)num3 + 10;
		int_1 = (int)num4 + 10;
		float x = 0f;
		float num6 = float_1;
		Bitmap bitmap3 = new Bitmap(int_0, int_1);
		try
		{
			using (Graphics graphics3 = Graphics.FromImage(bitmap3))
			{
				graphics3.FillRectangle(brush_1, 0, 0, int_0, int_1);
				foreach (string item2 in list)
				{
					float width = graphics3.MeasureString(item2, font_0).Width;
					switch (genum1_0)
					{
					case (GEnum1)1:
						x = float_0;
						break;
					case (GEnum1)2:
						x = float_0 + (float)Convert.ToInt32((float)(int_0 / 2) - width / 2f);
						break;
					default:
						if (genum1_0 == (GEnum1)2)
						{
							x = float_0 + (float)Convert.ToInt32((float)int_0 - width);
						}
						break;
					}
					float height2 = graphics3.MeasureString(item2, font_0).Height;
					graphics3.DrawString(item2, font_0, brush_0, x, num6);
					num6 += height2;
				}
			}
			return bitmap3.Clone(new Rectangle(0, 0, int_0, int_1), PixelFormat.Undefined);
		}
		finally
		{
			((IDisposable)bitmap3).Dispose();
		}
	}

	public static Color smethod_30(Bitmap bitmap_0)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		for (int i = 0; i < bitmap_0.Size.Width; i++)
		{
			for (int j = 0; j < bitmap_0.Size.Height; j++)
			{
				int key = bitmap_0.GetPixel(i, j).ToArgb();
				if (dictionary.ContainsKey(key))
				{
					dictionary[key]++;
				}
				else
				{
					dictionary.Add(key, 1);
				}
			}
		}
		int num = 0;
		foreach (int key2 in dictionary.Keys)
		{
			if (num < dictionary[key2])
			{
				num = dictionary[key2];
			}
		}
		return Color.FromArgb(num);
	}

	public static Image smethod_31(List<Image> list_0, int int_0, int int_1)
	{
		Bitmap bitmap = new Bitmap(int_0, int_1);
		int num = 0;
		using Graphics graphics = Graphics.FromImage(bitmap);
		for (int i = 0; i < list_0.Count; i++)
		{
			string s = Class84.smethod_0(-994271858) + (i + 1).ToString().PadLeft(2, '0') + Class84.smethod_0(-994271866);
			graphics.DrawImage(list_0[i], new Point(0, num));
			graphics.DrawString(s, new Font(Class84.smethod_0(-994273712), 11f), new SolidBrush(Color.DarkGray), new PointF(9f, num));
			num += list_0[i].Height + 15;
		}
		return bitmap;
	}

	public static Image smethod_32(Image image_0, int int_0)
	{
		try
		{
			return smethod_33((Bitmap)image_0, int_0);
		}
		catch (Exception)
		{
			return image_0;
		}
	}

	public static Bitmap smethod_33(Bitmap bitmap_0, int int_0)
	{
		int num = int_0;
		if (num % 2 == 0)
		{
			num++;
		}
		Bitmap bitmap = (Bitmap)bitmap_0.Clone();
		float num2 = 1f / (float)num;
		for (int i = 0; i < bitmap_0.Height; i++)
		{
			float[] array = new float[4];
			float[] array2 = new float[4];
			for (int j = 0; j < num; j++)
			{
				Color pixel = bitmap_0.GetPixel(j, i);
				array[0] += (int)pixel.A;
				array[1] += (int)pixel.R;
				array[2] += (int)pixel.G;
				array[3] += (int)pixel.B;
			}
			array2[0] = array[0] * num2;
			array2[1] = array[1] * num2;
			array2[2] = array[2] * num2;
			array2[3] = array[3] * num2;
			for (int k = 0; k < bitmap_0.Width; k++)
			{
				if (k - num / 2 >= 0 && k + 1 + num / 2 < bitmap_0.Width)
				{
					Color pixel2 = bitmap_0.GetPixel(k - num / 2, i);
					array[0] -= (int)pixel2.A;
					array[1] -= (int)pixel2.R;
					array[2] -= (int)pixel2.G;
					array[3] -= (int)pixel2.B;
					Color pixel3 = bitmap_0.GetPixel(k + 1 + num / 2, i);
					array[0] += (int)pixel3.A;
					array[1] += (int)pixel3.R;
					array[2] += (int)pixel3.G;
					array[3] += (int)pixel3.B;
					array2[0] = array[0] * num2;
					array2[1] = array[1] * num2;
					array2[2] = array[2] * num2;
					array2[3] = array[3] * num2;
				}
				bitmap.SetPixel(k, i, Color.FromArgb((int)array2[0], (int)array2[1], (int)array2[2], (int)array2[3]));
			}
		}
		Bitmap bitmap2 = (Bitmap)bitmap.Clone();
		for (int l = 0; l < bitmap.Width; l++)
		{
			float[] array3 = new float[4];
			float[] array4 = new float[4];
			for (int m = 0; m < num; m++)
			{
				Color pixel4 = bitmap.GetPixel(l, m);
				array3[0] += (int)pixel4.A;
				array3[1] += (int)pixel4.R;
				array3[2] += (int)pixel4.G;
				array3[3] += (int)pixel4.B;
			}
			array4[0] = array3[0] * num2;
			array4[1] = array3[1] * num2;
			array4[2] = array3[2] * num2;
			array4[3] = array3[3] * num2;
			for (int n = 0; n < bitmap.Height; n++)
			{
				if (n - num / 2 >= 0 && n + 1 + num / 2 < bitmap.Height)
				{
					Color pixel5 = bitmap.GetPixel(l, n - num / 2);
					array3[0] -= (int)pixel5.A;
					array3[1] -= (int)pixel5.R;
					array3[2] -= (int)pixel5.G;
					array3[3] -= (int)pixel5.B;
					Color pixel6 = bitmap.GetPixel(l, n + 1 + num / 2);
					array3[0] += (int)pixel6.A;
					array3[1] += (int)pixel6.R;
					array3[2] += (int)pixel6.G;
					array3[3] += (int)pixel6.B;
					array4[0] = array3[0] * num2;
					array4[1] = array3[1] * num2;
					array4[2] = array3[2] * num2;
					array4[3] = array3[3] * num2;
				}
				bitmap2.SetPixel(l, n, Color.FromArgb((int)array4[0], (int)array4[1], (int)array4[2], (int)array4[3]));
			}
		}
		return bitmap2;
	}
}
