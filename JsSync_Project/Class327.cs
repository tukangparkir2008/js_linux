using System.Collections.Generic;
using System.Text.RegularExpressions;

internal static class Class327
{
	private static readonly Dictionary<string, Regex> dictionary_0 = new Dictionary<string, Regex>();

	public static string smethod_0(string string_0, ref int int_0)
	{
		int_0 = string_0.IndexOf('@', int_0);
		if (int_0 > -1)
		{
			int num = 1;
			int num2 = string_0.IndexOf('{', int_0);
			if (num2 > -1)
			{
				while (num > 0 && num2 < string_0.Length)
				{
					num2++;
					if (string_0[num2] == '{')
					{
						num++;
					}
					else if (string_0[num2] == '}')
					{
						num--;
					}
				}
				if (num2 < string_0.Length)
				{
					string result = string_0.Substring(int_0, num2 - int_0 + 1);
					int_0 = num2;
					return result;
				}
			}
		}
		return null;
	}

	public static MatchCollection smethod_1(string string_0, string string_1)
	{
		return smethod_4(string_0).Matches(string_1);
	}

	public static string smethod_2(string string_0, string string_1)
	{
		int int_;
		return smethod_3(string_0, string_1, out int_);
	}

	public static string smethod_3(string string_0, string string_1, out int int_0)
	{
		MatchCollection matchCollection = smethod_1(string_0, string_1);
		if (matchCollection.Count > 0)
		{
			int_0 = matchCollection[0].Index;
			return matchCollection[0].Value;
		}
		int_0 = -1;
		return null;
	}

	private static Regex smethod_4(string string_0)
	{
		if (!dictionary_0.TryGetValue(string_0, out var value))
		{
			value = new Regex(string_0, RegexOptions.IgnoreCase | RegexOptions.Singleline);
			dictionary_0[string_0] = value;
		}
		return value;
	}
}
