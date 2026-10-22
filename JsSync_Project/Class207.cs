using System;
using System.Collections.Generic;

internal static class Class207
{
	public static Class197 smethod_0(string string_0)
	{
		Class197 @class = Class197.smethod_2();
		Class197 class197_ = @class;
		int num = 0;
		int num2 = 0;
		while (num2 >= 0)
		{
			int num3 = string_0.IndexOf('<', num2);
			if (num3 >= 0 && num3 < string_0.Length)
			{
				smethod_1(string_0, num2, num3, ref class197_);
				if (string_0[num3 + 1] == '!')
				{
					if (string_0[num3 + 2] == '-')
					{
						num2 = string_0.IndexOf(Class84.smethod_0(-994284641), num3 + 2);
						num = ((num2 > 0) ? (num2 + 3) : (num3 + 2));
					}
					else
					{
						num2 = string_0.IndexOf(Class84.smethod_0(-994284663), num3 + 2);
						num = ((num2 > 0) ? (num2 + 1) : (num3 + 2));
					}
				}
				else
				{
					num = smethod_2(string_0, num3, ref class197_) + 1;
					if (class197_.method_195() != null && class197_.method_195().method_0().Equals(Class84.smethod_0(-994285069), StringComparison.OrdinalIgnoreCase))
					{
						int int_ = num;
						num = string_0.IndexOf(Class84.smethod_0(-994284671), num, StringComparison.OrdinalIgnoreCase);
						if (num > -1)
						{
							smethod_1(string_0, int_, num, ref class197_);
						}
					}
				}
			}
			num2 = ((num3 <= -1 || num <= 0) ? (-1) : num);
		}
		if (num > -1 && num < string_0.Length)
		{
			Class289 class2 = new Class289(string_0, num, string_0.Length - num);
			if (!class2.method_4())
			{
				Class197.smethod_1(@class, null, null).method_199(class2);
			}
		}
		return @class;
	}

	private static void smethod_1(string string_0, int int_0, int int_1, ref Class197 class197_0)
	{
		Class289 @class = ((int_1 > int_0) ? new Class289(string_0, int_0, int_1 - int_0) : null);
		if (@class != null)
		{
			Class197.smethod_1(class197_0, null, null).method_199(@class);
		}
	}

	private static int smethod_2(string string_0, int int_0, ref Class197 class197_0)
	{
		int num = string_0.IndexOf('>', int_0 + 1);
		if (num > 0)
		{
			int int_1 = num - int_0 + 1 - ((string_0[num - 1] == '/') ? 1 : 0);
			if (smethod_3(string_0, int_0, int_1, out var string_1, out var dictionary_))
			{
				if (!Class273.smethod_0(string_1) && class197_0.method_188() != null)
				{
					class197_0 = Class277.smethod_2(class197_0.method_188(), string_1, class197_0);
				}
			}
			else if (!string.IsNullOrEmpty(string_1))
			{
				bool flag = Class273.smethod_0(string_1) || string_0[num - 1] == '/';
				Class343 class343_ = new Class343(string_1, flag, dictionary_);
				if (flag)
				{
					Class197.smethod_0(class343_, class197_0);
				}
				else
				{
					class197_0 = Class197.smethod_0(class343_, class197_0);
				}
			}
			else
			{
				num = int_0 + 1;
			}
		}
		return num;
	}

	private static bool smethod_3(string string_0, int int_0, int int_1, out string string_1, out Dictionary<string, string> dictionary_0)
	{
		int_0++;
		int_1 -= ((string_0[int_0 + int_1 - 3] == '/') ? 3 : 2);
		bool flag = false;
		if (string_0[int_0] == '/')
		{
			int_0++;
			int_1--;
			flag = true;
		}
		int i;
		for (i = int_0; i < int_0 + int_1 && !char.IsWhiteSpace(string_0, i); i++)
		{
		}
		string_1 = string_0.Substring(int_0, i - int_0).ToLower();
		dictionary_0 = null;
		if (!flag && int_0 + int_1 > i)
		{
			smethod_4(string_0, i, int_1 - (i - int_0), out dictionary_0);
		}
		return flag;
	}

	private static void smethod_4(string string_0, int int_0, int int_1, out Dictionary<string, string> dictionary_0)
	{
		dictionary_0 = null;
		int i = int_0;
		while (i < int_0 + int_1)
		{
			for (; i < int_0 + int_1 && char.IsWhiteSpace(string_0, i); i++)
			{
			}
			int j;
			for (j = i + 1; j < int_0 + int_1 && !char.IsWhiteSpace(string_0, j) && string_0[j] != '='; j++)
			{
			}
			if (i >= int_0 + int_1)
			{
				continue;
			}
			string text = string_0.Substring(i, j - i);
			string value = string.Empty;
			for (i = j + 1; i < int_0 + int_1 && (char.IsWhiteSpace(string_0, i) || string_0[i] == '='); i++)
			{
			}
			bool flag = false;
			if (i < int_0 + int_1)
			{
				char c = string_0[i];
				if (c == '"' || c == '\'')
				{
					flag = true;
					i++;
				}
				for (j = i + ((!flag) ? 1 : 0); j < int_0 + int_1 && (flag ? (string_0[j] != c) : (!char.IsWhiteSpace(string_0, j))); j++)
				{
				}
				value = string_0.Substring(i, j - i);
				value = Class273.smethod_1(value);
			}
			if (text.Length != 0)
			{
				if (dictionary_0 == null)
				{
					dictionary_0 = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
				}
				dictionary_0[text.ToLower()] = value;
			}
			i = j + ((!flag) ? 1 : 2);
		}
	}
}
