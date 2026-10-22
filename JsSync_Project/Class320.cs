using System;
using System.Text;

internal sealed class Class320
{
	public static int int_0 = 77;

	public static int int_1 = 54;

	public static int int_2 = 17;

	public static int int_3 = 45;

	public static int int_4 = 34;

	public static int int_5 = 34;

	public static int int_6 = 57;

	public static string smethod_0(string string_0)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
	}

	public static string smethod_1(string string_0)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
	}

	public static string smethod_2(string string_0, int int_7)
	{
		string text = int_7.ToString();
		StringBuilder stringBuilder = new StringBuilder();
		int length = string_0.Length;
		int length2 = text.Length;
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append((char)(string_0[i] ^ text[i % length2]));
		}
		return smethod_1(stringBuilder.ToString());
	}

	public static string smethod_3(string string_0, string string_1)
	{
		return smethod_4(string_0, Convert.ToInt32(string_1));
	}

	public static string smethod_4(string string_0, int int_7)
	{
		string text = smethod_0(string_0);
		string text2 = int_7.ToString();
		StringBuilder stringBuilder = new StringBuilder();
		int length = text.Length;
		int length2 = text2.Length;
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append((char)(text[i] ^ text2[i % length2]));
		}
		return stringBuilder.ToString();
	}

	public static Tuple<string, string> smethod_5(string string_0, int int_7, int int_8)
	{
		int num = Class211.smethod_3(1000, 9800);
		num = int_8 + num;
		string item = smethod_2(string_0, num);
		return new Tuple<string, string>((num + int_7).ToString(), item);
	}
}
