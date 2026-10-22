using System;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

public static class GClass60
{
	public static void smethod_0(Metafile metafile_0, string string_0)
	{
		int int_ = metafile_0.GetHenhmetafile().ToInt32();
		int enhMetaFileBits = GetEnhMetaFileBits(int_, 0, null);
		byte[] array = new byte[enhMetaFileBits];
		if (GetEnhMetaFileBits(int_, enhMetaFileBits, array) <= 0)
		{
			throw new SystemException(Class84.smethod_0(-994208452));
		}
		FileStream fileStream = File.Open(string_0, FileMode.Create);
		fileStream.Write(array, 0, enhMetaFileBits);
		fileStream.Close();
		fileStream.Dispose();
		if (!DeleteEnhMetaFile(int_))
		{
			throw new SystemException(Class84.smethod_0(-994208457));
		}
	}

	[DllImport("gdi32")]
	public static extern int GetEnhMetaFileBits(int int_0, int int_1, byte[] byte_0);

	[DllImport("gdi32")]
	public static extern bool DeleteEnhMetaFile(int int_0);
}
