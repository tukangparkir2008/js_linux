using System;
using System.IO;

internal sealed class Class205
{
	public static void smethod_0()
	{
		string path = Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994094709));
		if (!File.Exists(path))
		{
			throw new Exception(Class84.smethod_0(-994094660));
		}
		StreamReader streamReader = new StreamReader(path);
		while (streamReader.Peek() >= 0)
		{
			string text = streamReader.ReadLine().Trim();
			if (text.Length == 0 || text.Substring(0, 1) == Class84.smethod_0(-994282651) || text.IndexOf(Class84.smethod_0(-994207831), StringComparison.Ordinal) < 0)
			{
				continue;
			}
			int num = text.IndexOf(Class84.smethod_0(-994207831), StringComparison.Ordinal);
			if (num < 0)
			{
				continue;
			}
			string text2 = text.Substring(0, num).Trim();
			string text3 = text.Substring(num + 1).Trim();
			if (text2.Equals(Class84.smethod_0(-994094643)))
			{
				Class224.Class228.string_0 = text3;
			}
			else if (text2.Equals(Class84.smethod_0(-994094596)))
			{
				Class224.Class228.string_1 = text3;
			}
			else if (text2.Equals(Class84.smethod_0(-994094615)))
			{
				Class224.Class228.string_2 = text3;
			}
			else if (text2.Equals(Class84.smethod_0(-994094618)))
			{
				Class224.Class228.string_3 = smethod_2(text3);
			}
			else if (text2.Equals(Class84.smethod_0(-994094569)))
			{
				Class224.Class226.bool_0 = Class159.smethod_3(text3, bool_0: false);
			}
			else if (text2.Equals(Class84.smethod_0(-994094585)))
			{
				Class224.Class226.string_2 = smethod_2(text3);
			}
			else if (text2.Equals(Class84.smethod_0(-994094549)))
			{
				Class224.Class229.string_0 = text3;
			}
			else if (text2.Equals(Class84.smethod_0(-994094501)))
			{
				int num2 = Class159.smethod_0(text3, 2000);
				if (num2 != 1000 && num2 != 2000 && num2 != 3000 && num2 != 4000 && num2 != 5000)
				{
					num2 = 2000;
				}
				Class224.Class226.int_11 = num2;
			}
		}
		streamReader.Close();
	}

	public static void smethod_1()
	{
		StreamWriter streamWriter = new StreamWriter(Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994094709)), append: false);
		streamWriter.WriteLine(Class84.smethod_0(-994094528));
		streamWriter.WriteLine(Class84.smethod_0(-994094451));
		streamWriter.WriteLine(Class84.smethod_0(-994094528));
		streamWriter.WriteLine(string.Empty);
		streamWriter.WriteLine(Class84.smethod_0(-994094390) + Class224.Class228.string_0);
		streamWriter.WriteLine(Class84.smethod_0(-994094340) + Class224.Class228.string_1);
		streamWriter.WriteLine(Class84.smethod_0(-994094356) + Class224.Class228.string_2);
		streamWriter.WriteLine(Class84.smethod_0(-994094308) + smethod_3(Class224.Class228.string_3));
		streamWriter.WriteLine(string.Empty);
		streamWriter.WriteLine(Class84.smethod_0(-994094336) + Class224.Class229.string_0);
		streamWriter.WriteLine(string.Empty);
		streamWriter.WriteLine(Class84.smethod_0(-994094285) + Class224.Class226.bool_0);
		streamWriter.WriteLine(Class84.smethod_0(-994094298) + smethod_3(Class224.Class226.string_2));
		streamWriter.WriteLine(string.Empty);
		streamWriter.WriteLine(Class84.smethod_0(-994094259) + Class224.Class226.int_11);
		streamWriter.Close();
	}

	private static string smethod_2(string string_0)
	{
		try
		{
			return (string_0.Length == 0) ? string.Empty : Class123.smethod_4(string_0);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094219), ex.Message, ex);
			return string.Empty;
		}
	}

	private static string smethod_3(string string_0)
	{
		try
		{
			return Class123.smethod_1(string_0);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(Class84.smethod_0(-994094188), ex.Message, ex);
			return string.Empty;
		}
	}
}
