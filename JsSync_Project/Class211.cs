using System;

internal sealed class Class211
{
	private static readonly Random random_0 = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0));

	public static string smethod_0(int int_0)
	{
		string text = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			int startIndex = random_0.Next(0, 36);
			text += Class84.smethod_0(-994091877).Substring(startIndex, 1);
		}
		return text;
	}

	public static string smethod_1(int int_0)
	{
		string text = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			int startIndex = random_0.Next(0, 10);
			text += Class84.smethod_0(-994091850).Substring(startIndex, 1);
		}
		return text;
	}

	public static string smethod_2(string string_0, int int_0)
	{
		string text = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			int startIndex = random_0.Next(0, string_0.Length);
			text += string_0.Substring(startIndex, 1);
		}
		return text;
	}

	public static int smethod_3(int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}
}
