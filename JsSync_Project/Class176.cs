using System;

internal sealed class Class176
{
	public static string smethod_0(string string_0)
	{
		string_0 = string_0.Trim();
		bool flag = string_0.IndexOf(Class84.smethod_0(-994278690), StringComparison.Ordinal) < 0;
		string_0 = string_0.Replace(Class84.smethod_0(-994278690), string.Empty);
		int length = string_0.Length;
		int num = length / 3;
		if (length % 3 == 0)
		{
			num--;
		}
		string text = string.Empty;
		for (int i = 0; i < num; i++)
		{
			int num2 = 0;
			string text2 = string.Empty;
			while (string_0.Length >= 0 && num2++ < 3)
			{
				text2 = string_0.Substring(string_0.Length - 1, 1) + text2;
				string_0 = ((string_0.Length < 2) ? string.Empty : string_0.Substring(0, string_0.Length - 1));
			}
			text = ((text.Length <= 0) ? text2 : (text2 + Class84.smethod_0(-994272055) + text));
		}
		if (string_0.Length > 0)
		{
			text = string_0 + Class84.smethod_0(-994272055) + text;
		}
		if (!flag)
		{
			return Class84.smethod_0(-994092495) + text + Class84.smethod_0(-994271866);
		}
		return Class84.smethod_0(-994092500) + text;
	}

	public static string smethod_1(string string_0)
	{
		bool flag = string_0.IndexOf(Class84.smethod_0(-994271858), StringComparison.Ordinal) != 0;
		string text = string_0.Replace(Class84.smethod_0(-994092506), string.Empty).Replace(Class84.smethod_0(-994272055), string.Empty).Replace(Class84.smethod_0(-994263061), string.Empty)
			.Replace(Class84.smethod_0(-994271858), string.Empty)
			.Replace(Class84.smethod_0(-994271866), string.Empty);
		if (!flag)
		{
			text = Class84.smethod_0(-994278690) + text;
		}
		return text;
	}
}
