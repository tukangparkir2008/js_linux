using System;

internal sealed class Class267
{
	public static string smethod_0(string string_0)
	{
		string_0 = Class282.smethod_0(7) + string_0 + Class282.smethod_0(7);
		return Class123.smethod_1(string_0);
	}

	public static string smethod_1(string string_0)
	{
		string_0 = Class123.smethod_4(string_0);
		if (string_0.IndexOf(Class84.smethod_0(-994267367), StringComparison.Ordinal) < 0)
		{
			return string_0.Substring(7, 1);
		}
		int length = string_0.Length;
		string_0 = string_0.Substring(0, length - 7);
		string_0 = string_0.Substring(7);
		return string_0;
	}
}
