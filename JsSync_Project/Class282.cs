using System;
using System.Text;
using System.Text.RegularExpressions;

internal sealed class Class282
{
	private static readonly Random random_0 = new Random();

	public static string smethod_0(int int_0)
	{
		string text = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			int startIndex = random_0.Next(0, 62);
			text += Class84.smethod_0(-994091651).Substring(startIndex, 1);
		}
		return text;
	}

	public static string smethod_1(string string_0, int int_0)
	{
		if (string_0.Length >= int_0)
		{
			return string_0.Substring(0, int_0);
		}
		return string_0;
	}

	public static string smethod_2(string string_0)
	{
		return Regex.Replace(string_0, Class84.smethod_0(-994091598), string.Empty);
	}

	public static string smethod_3(string string_0)
	{
		return Regex.Replace(string_0, Class84.smethod_0(-994091609), Class84.smethod_0(-994263511));
	}

	public static string smethod_4(string string_0)
	{
		string text = string.Empty;
		char[] array = string_0.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			int num = Convert.ToInt32(array[i]);
			string text2 = string.Format(Class84.smethod_0(-994091572), num);
			text += text2;
		}
		return text;
	}

	public static string smethod_5(string string_0)
	{
		int length = string_0.Length;
		if (length % 2 != 0)
		{
			throw new Exception(Class84.smethod_0(-994091528));
		}
		string text = string.Empty;
		int num = length / 2;
		for (int i = 0; i < num; i++)
		{
			int num2 = Convert.ToInt32(string_0.Substring(i * 2, 2), 16);
			text += (char)num2;
		}
		return text;
	}

	public static string smethod_6(string string_0)
	{
		return string_0.Trim().Replace('\'', '`');
	}

	public static string smethod_7(string string_0)
	{
		return string_0.Trim().Replace('\'', '`').Replace(Class84.smethod_0(-994207545), Class84.smethod_0(-994091546))
			.Replace(Class84.smethod_0(-994284663), Class84.smethod_0(-994091504));
	}

	public static string smethod_8(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string smethod_9(string string_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
	}
}
