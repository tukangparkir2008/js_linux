using System;
using System.IO;
using System.Runtime.CompilerServices;

internal sealed class Class162
{
	private static bool bool_0;

	private static readonly string string_0 = Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994542019));

	private static string smethod_0()
	{
		return DateTime.Now.ToString(Class84.smethod_0(-994254559));
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_1(string string_1, string string_2)
	{
		smethod_4(string_1, string_2, null);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_2(string string_1, string string_2, Exception exception_0)
	{
		smethod_4(string_1, string_2, exception_0);
	}

	private static void smethod_3()
	{
		FileInfo fileInfo = new FileInfo(string_0);
		if (fileInfo.Exists)
		{
			if (fileInfo.Length > 5000000L)
			{
				fileInfo.Delete();
				fileInfo.Create();
			}
		}
		else
		{
			fileInfo.Create();
		}
		bool_0 = true;
	}

	private static void smethod_4(string string_1, string string_2, Exception exception_0)
	{
		try
		{
			if (!bool_0)
			{
				smethod_3();
			}
			StreamWriter streamWriter = new StreamWriter(string_0, append: true);
			if (exception_0 != null)
			{
				string format = Class84.smethod_0(-994542045);
				format = string.Format(format, string_1, smethod_0(), string_2);
				streamWriter.WriteLine(format);
				streamWriter.WriteLine(exception_0.Message);
				streamWriter.WriteLine(exception_0.StackTrace);
				streamWriter.WriteLine();
			}
			else
			{
				string format2 = Class84.smethod_0(-994541958);
				format2 = string.Format(format2, smethod_0(), string_1, string_2);
				streamWriter.WriteLine(format2);
				streamWriter.WriteLine();
			}
			streamWriter.Close();
		}
		catch (Exception)
		{
		}
	}
}
