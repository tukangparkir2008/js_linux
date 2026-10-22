using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

internal sealed class Class308
{
	private static readonly char[] char_0 = new char[2] { '}', ';' };

	private readonly GClass0 gclass0_0;

	private readonly Class172 class172_0;

	private static readonly char[] char_1 = new char[8] { '\r', '\n', '\t', ' ', '-', '!', '<', '>' };

	public Class308(GClass0 gclass0_1)
	{
		GClass24.smethod_1(gclass0_1, Class84.smethod_0(-994290092));
		class172_0 = new Class172(gclass0_1);
		gclass0_0 = gclass0_1;
	}

	public GClass55 method_0(string string_0, bool bool_0)
	{
		GClass55 gClass = (bool_0 ? gclass0_0.method_0().method_5() : new GClass55());
		if (!string.IsNullOrEmpty(string_0))
		{
			method_1(gClass, string_0);
		}
		return gClass;
	}

	public void method_1(GClass55 gclass55_0, string string_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string_0 = smethod_0(string_0);
			method_5(gclass55_0, string_0);
			method_6(gclass55_0, string_0);
		}
	}

	public CssBlock method_2(string string_0, string string_1)
	{
		return method_8(string_0, string_1);
	}

	public string method_3(string string_0)
	{
		return method_13(string_0);
	}

	public GStruct3 method_4(string string_0)
	{
		return class172_0.method_1(string_0);
	}

	private static string smethod_0(string string_0)
	{
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		while (num2 > -1 && num2 < string_0.Length)
		{
			num2 = string_0.IndexOf(Class84.smethod_0(-994282601), num2);
			if (num2 > -1)
			{
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(string_0.Length);
				}
				stringBuilder.Append(string_0, num, num2 - num);
				int num3 = string_0.IndexOf(Class84.smethod_0(-994282624), num2 + 2);
				if (num3 < 0)
				{
					num3 = string_0.Length;
				}
				num = (num2 = num3 + 2);
			}
			else if (stringBuilder != null)
			{
				Class86.smethod_0(stringBuilder, string_0, num);
			}
		}
		if (stringBuilder == null)
		{
			return string_0;
		}
		return stringBuilder.ToString();
	}

	private void method_5(GClass55 gclass55_0, string string_0)
	{
		int i = 0;
		int j = 0;
		while (i < string_0.Length && j > -1)
		{
			j = i;
			while (j + 1 < string_0.Length)
			{
				j++;
				if (string_0[j] == '}')
				{
					i = j + 1;
				}
				if (string_0[j] == '{')
				{
					break;
				}
			}
			int num = j + 1;
			if (j <= -1)
			{
				continue;
			}
			for (j++; j < string_0.Length; j++)
			{
				if (string_0[j] == '{')
				{
					i = num + 1;
				}
				if (string_0[j] == '}')
				{
					break;
				}
			}
			if (j < string_0.Length)
			{
				for (; char.IsWhiteSpace(string_0[i]); i++)
				{
				}
				string string_1 = string_0.Substring(i, j - i + 1);
				method_7(gclass55_0, string_1, Class84.smethod_0(-994290048));
			}
			i = j + 1;
		}
	}

	private void method_6(GClass55 gclass55_0, string string_0)
	{
		int int_ = 0;
		string text;
		while ((text = Class340.smethod_0(string_0, ref int_)) != null)
		{
			if (!text.StartsWith(Class84.smethod_0(-994282567), StringComparison.InvariantCultureIgnoreCase))
			{
				continue;
			}
			MatchCollection matchCollection = Class340.smethod_1(Class84.smethod_0(-994282570), text);
			if (matchCollection.Count != 1)
			{
				continue;
			}
			string value = matchCollection[0].Value;
			if (!value.StartsWith(Class84.smethod_0(-994282567), StringComparison.InvariantCultureIgnoreCase) || !value.EndsWith(Class84.smethod_0(-994282531)))
			{
				continue;
			}
			string[] array = value.Substring(6, value.Length - 7).Split(' ');
			foreach (string text2 in array)
			{
				if (string.IsNullOrEmpty(text2.Trim()))
				{
					continue;
				}
				foreach (Match item in Class340.smethod_1(Class84.smethod_0(-994282539), text))
				{
					method_7(gclass55_0, item.Value, text2.Trim());
				}
			}
		}
	}

	private void method_7(GClass55 gclass55_0, string string_0, string string_1)
	{
		int num = string_0.IndexOf(Class84.smethod_0(-994282531), StringComparison.Ordinal);
		int num2 = ((num > -1) ? string_0.IndexOf(Class84.smethod_0(-994288383), num) : (-1));
		if (num <= -1 || num2 <= -1)
		{
			return;
		}
		string string_2 = string_0.Substring(num + 1, num2 - num - 1);
		string[] array = string_0.Substring(0, num).Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].Trim(char_1);
			if (!string.IsNullOrEmpty(text))
			{
				CssBlock cssBlock = method_8(text, string_2);
				if (cssBlock != null)
				{
					gclass55_0.method_3(string_1, cssBlock);
				}
			}
		}
	}

	private CssBlock method_8(string string_0, string string_1)
	{
		string_0 = string_0.ToLower();
		string text = null;
		int num = string_0.IndexOf(Class84.smethod_0(-994263069), StringComparison.Ordinal);
		if (num > -1 && !string_0.StartsWith(Class84.smethod_0(-994282512)))
		{
			text = ((num < string_0.Length - 1) ? string_0.Substring(num + 1).Trim() : null);
			string_0 = string_0.Substring(0, num).Trim();
		}
		if (!string.IsNullOrEmpty(string_0) && (text == null || text == Class84.smethod_0(-994282519) || text == Class84.smethod_0(-994282524)))
		{
			List<GStruct0> selectors = smethod_1(string_0, out var string_2);
			Dictionary<string, string> properties = method_9(string_1);
			return new CssBlock(string_2, properties, selectors, text == Class84.smethod_0(-994282524));
		}
		return null;
	}

	private static List<GStruct0> smethod_1(string string_0, out string string_1)
	{
		List<GStruct0> list = null;
		string_1 = null;
		int num = string_0.Length - 1;
		while (num > -1)
		{
			bool flag = false;
			while (char.IsWhiteSpace(string_0[num]) || string_0[num] == '>')
			{
				flag = flag || string_0[num] == '>';
				num--;
			}
			int num2 = num;
			while (num2 > -1 && !char.IsWhiteSpace(string_0[num2]) && string_0[num2] != '>')
			{
				num2--;
			}
			if (num2 > -1)
			{
				if (list == null)
				{
					list = new List<GStruct0>();
				}
				string text = string_0.Substring(num2 + 1, num - num2);
				if (string_1 == null)
				{
					string_1 = text;
				}
				else
				{
					while (char.IsWhiteSpace(string_0[num2]) || string_0[num2] == '>')
					{
						num2--;
					}
					list.Add(new GStruct0(text, flag));
				}
			}
			else if (string_1 != null)
			{
				list.Add(new GStruct0(string_0.Substring(0, num + 1), flag));
			}
			num = num2;
		}
		string_1 = string_1 ?? string_0;
		return list;
	}

	private Dictionary<string, string> method_9(string string_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		int num = 0;
		while (num < string_0.Length)
		{
			int num2 = string_0.IndexOfAny(char_0, num);
			if (num >= 0 && num2 - num >= 10 && string_0.Length - num >= 10 && string_0.IndexOf(Class84.smethod_0(-994283409), num, num2 - num) >= 0)
			{
				num2 = string_0.IndexOfAny(char_0, num2 + 1);
			}
			if (num2 < 0)
			{
				num2 = string_0.Length - 1;
			}
			int num3 = string_0.IndexOf(':', num, num2 - num);
			if (num3 > -1)
			{
				num += ((string_0[num] == ' ') ? 1 : 0);
				int num4 = num2 - ((string_0[num2] == ' ' || string_0[num2] == ';') ? 1 : 0);
				string string_1 = string_0.Substring(num, num3 - num).Trim().ToLower();
				num3 += ((string_0[num3 + 1] != ' ') ? 1 : 2);
				if (num4 >= num3)
				{
					string text = string_0.Substring(num3, num4 - num3 + 1).Trim();
					if (!text.StartsWith(Class84.smethod_0(-994282480), StringComparison.InvariantCultureIgnoreCase))
					{
						text = text.ToLower();
					}
					method_10(string_1, text, dictionary);
				}
			}
			num = num2 + 1;
		}
		return dictionary;
	}

	private void method_10(string string_0, string string_1, Dictionary<string, string> dictionary_0)
	{
		string_1 = string_1.Replace(Class84.smethod_0(-994282486), string.Empty).Trim();
		if (!(string_0 == Class84.smethod_0(-994282437)) && !(string_0 == Class84.smethod_0(-994282441)) && !(string_0 == Class84.smethod_0(-994282460)))
		{
			if (!(string_0 == Class84.smethod_0(-994282411)) && !(string_0 == Class84.smethod_0(-994282431)) && !(string_0 == Class84.smethod_0(-994282377)) && !(string_0 == Class84.smethod_0(-994282340)) && !(string_0 == Class84.smethod_0(-994282364)) && !(string_0 == Class84.smethod_0(-994282326)))
			{
				if (string_0 == Class84.smethod_0(-994282287))
				{
					method_12(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282292))
				{
					method_14(string_1, null, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282247))
				{
					method_14(string_1, Class84.smethod_0(-994282261), dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282265))
				{
					method_14(string_1, Class84.smethod_0(-994282232), dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282237))
				{
					method_14(string_1, Class84.smethod_0(-994282186), dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282205))
				{
					method_14(string_1, Class84.smethod_0(-994282153), dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282171))
				{
					smethod_4(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282126))
				{
					smethod_5(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282139))
				{
					smethod_6(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282104))
				{
					smethod_7(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282053))
				{
					smethod_8(string_1, dictionary_0);
				}
				else if (string_0 == Class84.smethod_0(-994282071))
				{
					dictionary_0[Class84.smethod_0(-994282071)] = smethod_3(string_1);
				}
				else if (string_0 == Class84.smethod_0(-994282032))
				{
					dictionary_0[Class84.smethod_0(-994282032)] = smethod_3(string_1);
				}
				else if (string_0 == Class84.smethod_0(-994282034))
				{
					dictionary_0[Class84.smethod_0(-994282034)] = method_13(string_1);
				}
				else
				{
					dictionary_0[string_0] = string_1;
				}
			}
			else
			{
				method_11(string_0, string_1, dictionary_0);
			}
		}
		else
		{
			smethod_2(string_0, string_1, dictionary_0);
		}
	}

	private static void smethod_2(string string_0, string string_1, Dictionary<string, string> dictionary_0)
	{
		if (Class172.smethod_2(string_1) || string_1.Equals(Class84.smethod_0(-994293691), StringComparison.OrdinalIgnoreCase))
		{
			dictionary_0[string_0] = string_1;
		}
	}

	private void method_11(string string_0, string string_1, Dictionary<string, string> dictionary_0)
	{
		if (class172_0.method_0(string_1))
		{
			dictionary_0[string_0] = string_1;
		}
	}

	private void method_12(string string_0, Dictionary<string, string> dictionary_0)
	{
		string text = Class340.smethod_3(Class84.smethod_0(-994282000), string_0, out var int_);
		if (!string.IsNullOrEmpty(text))
		{
			text = text.Trim();
			string string_1 = string_0.Substring(0, int_);
			string value = Class340.smethod_2(Class84.smethod_0(-994281816), string_1);
			string value2 = Class340.smethod_2(Class84.smethod_0(-994281770), string_1);
			string value3 = Class340.smethod_2(Class84.smethod_0(-994281744), string_1);
			string text2 = string_0.Substring(int_ + text.Length).Trim();
			string value4 = text;
			string value5 = string.Empty;
			if (text.Contains(Class84.smethod_0(-994276891)) && text.Length > text.IndexOf(Class84.smethod_0(-994276891), StringComparison.Ordinal) + 1)
			{
				int num = text.IndexOf(Class84.smethod_0(-994276891), StringComparison.Ordinal);
				value4 = text.Substring(0, num);
				value5 = text.Substring(num + 1);
			}
			if (!string.IsNullOrEmpty(text2))
			{
				dictionary_0[Class84.smethod_0(-994282034)] = method_13(text2);
			}
			if (!string.IsNullOrEmpty(value))
			{
				dictionary_0[Class84.smethod_0(-994281673)] = value;
			}
			if (!string.IsNullOrEmpty(value2))
			{
				dictionary_0[Class84.smethod_0(-994281640)] = value2;
			}
			if (!string.IsNullOrEmpty(value3))
			{
				dictionary_0[Class84.smethod_0(-994281653)] = value3;
			}
			if (!string.IsNullOrEmpty(value4))
			{
				dictionary_0[Class84.smethod_0(-994281603)] = value4;
			}
			if (!string.IsNullOrEmpty(value5))
			{
				dictionary_0[Class84.smethod_0(-994281619)] = value5;
			}
		}
	}

	private static string smethod_3(string string_0)
	{
		int num = string_0.IndexOf(Class84.smethod_0(-994282977), StringComparison.InvariantCultureIgnoreCase);
		if (num > -1)
		{
			num += 4;
			int num2 = string_0.IndexOf(')', num);
			if (num2 > -1)
			{
				for (num2--; num < num2 && (char.IsWhiteSpace(string_0[num]) || string_0[num] == '\'' || string_0[num] == '"'); num++)
				{
				}
				while (num < num2 && (char.IsWhiteSpace(string_0[num2]) || string_0[num2] == '\'' || string_0[num2] == '"'))
				{
					num2--;
				}
				if (num <= num2)
				{
					return string_0.Substring(num, num2 - num + 1);
				}
			}
		}
		return string_0;
	}

	private string method_13(string string_0)
	{
		int i = 0;
		while (i > -1 && i < string_0.Length)
		{
			for (; char.IsWhiteSpace(string_0[i]) || string_0[i] == ',' || string_0[i] == '\'' || string_0[i] == '"'; i++)
			{
			}
			int num = string_0.IndexOf(',', i);
			if (num < 0)
			{
				num = string_0.Length;
			}
			int num2 = num - 1;
			while (char.IsWhiteSpace(string_0[num2]) || string_0[num2] == '\'' || string_0[num2] == '"')
			{
				num2--;
			}
			string text = string_0.Substring(i, num2 - i + 1);
			if (!gclass0_0.method_7(text))
			{
				i = num;
				continue;
			}
			return text;
		}
		return Class84.smethod_0(-994292120);
	}

	private void method_14(string string_0, string string_1, Dictionary<string, string> dictionary_0)
	{
		method_15(string_0, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			if (string_2 != null)
			{
				dictionary_0[Class84.smethod_0(-994282292) + string_1 + Class84.smethod_0(-994281569)] = string_2;
			}
			if (string_3 != null)
			{
				dictionary_0[Class84.smethod_0(-994282292) + string_1 + Class84.smethod_0(-994281588)] = string_3;
			}
			if (string_4 != null)
			{
				dictionary_0[Class84.smethod_0(-994282292) + string_1 + Class84.smethod_0(-994281543)] = string_4;
			}
		}
		else
		{
			if (string_2 != null)
			{
				smethod_6(string_2, dictionary_0);
			}
			if (string_3 != null)
			{
				smethod_5(string_3, dictionary_0);
			}
			if (string_4 != null)
			{
				smethod_7(string_4, dictionary_0);
			}
		}
	}

	private static void smethod_4(string string_0, Dictionary<string, string> dictionary_0)
	{
		smethod_9(string_0, out var string_1, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			dictionary_0[Class84.smethod_0(-994281546)] = string_1;
		}
		if (string_2 != null)
		{
			dictionary_0[Class84.smethod_0(-994281512)] = string_2;
		}
		if (string_3 != null)
		{
			dictionary_0[Class84.smethod_0(-994281527)] = string_3;
		}
		if (string_4 != null)
		{
			dictionary_0[Class84.smethod_0(-994281476)] = string_4;
		}
	}

	private static void smethod_5(string string_0, Dictionary<string, string> dictionary_0)
	{
		smethod_9(string_0, out var string_1, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			dictionary_0[Class84.smethod_0(-994281504)] = string_1;
		}
		if (string_2 != null)
		{
			dictionary_0[Class84.smethod_0(-994285560)] = string_2;
		}
		if (string_3 != null)
		{
			dictionary_0[Class84.smethod_0(-994285505)] = string_3;
		}
		if (string_4 != null)
		{
			dictionary_0[Class84.smethod_0(-994285480)] = string_4;
		}
	}

	private static void smethod_6(string string_0, Dictionary<string, string> dictionary_0)
	{
		smethod_9(string_0, out var string_1, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			dictionary_0[Class84.smethod_0(-994285502)] = string_1;
		}
		if (string_2 != null)
		{
			dictionary_0[Class84.smethod_0(-994285462)] = string_2;
		}
		if (string_3 != null)
		{
			dictionary_0[Class84.smethod_0(-994285423)] = string_3;
		}
		if (string_4 != null)
		{
			dictionary_0[Class84.smethod_0(-994285382)] = string_4;
		}
	}

	private static void smethod_7(string string_0, Dictionary<string, string> dictionary_0)
	{
		smethod_9(string_0, out var string_1, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			dictionary_0[Class84.smethod_0(-994285404)] = string_1;
		}
		if (string_2 != null)
		{
			dictionary_0[Class84.smethod_0(-994285364)] = string_2;
		}
		if (string_3 != null)
		{
			dictionary_0[Class84.smethod_0(-994285325)] = string_3;
		}
		if (string_4 != null)
		{
			dictionary_0[Class84.smethod_0(-994285284)] = string_4;
		}
	}

	private static void smethod_8(string string_0, Dictionary<string, string> dictionary_0)
	{
		smethod_9(string_0, out var string_1, out var string_2, out var string_3, out var string_4);
		if (string_1 != null)
		{
			dictionary_0[Class84.smethod_0(-994285306)] = string_1;
		}
		if (string_2 != null)
		{
			dictionary_0[Class84.smethod_0(-994285271)] = string_2;
		}
		if (string_3 != null)
		{
			dictionary_0[Class84.smethod_0(-994285221)] = string_3;
		}
		if (string_4 != null)
		{
			dictionary_0[Class84.smethod_0(-994285233)] = string_4;
		}
	}

	private static void smethod_9(string string_0, out string string_1, out string string_2, out string string_3, out string string_4)
	{
		string_2 = null;
		string_1 = null;
		string_3 = null;
		string_4 = null;
		string[] array = smethod_10(string_0, ' ');
		switch (array.Length)
		{
		case 1:
			string_2 = (string_1 = (string_3 = (string_4 = array[0])));
			break;
		case 2:
			string_2 = (string_4 = array[0]);
			string_1 = (string_3 = array[1]);
			break;
		case 3:
			string_2 = array[0];
			string_1 = (string_3 = array[1]);
			string_4 = array[2];
			break;
		case 4:
			string_2 = array[0];
			string_3 = array[1];
			string_4 = array[2];
			string_1 = array[3];
			break;
		}
	}

	private static string[] smethod_10(string string_0, char char_2)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string[] array = string_0.Split(char_2);
			List<string> list = new List<string>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i].Trim();
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			return list.ToArray();
		}
		return new string[0];
	}

	public void method_15(string string_0, out string string_1, out string string_2, out string string_3)
	{
		string_1 = (string_2 = (string_3 = null));
		if (string.IsNullOrEmpty(string_0))
		{
			return;
		}
		int int_ = 0;
		int int_2;
		while ((int_ = Class299.smethod_9(string_0, int_, out int_2)) > -1)
		{
			if (string_1 == null)
			{
				string_1 = smethod_11(string_0, int_, int_2);
			}
			if (string_2 == null)
			{
				string_2 = smethod_12(string_0, int_, int_2);
			}
			if (string_3 == null)
			{
				string_3 = method_16(string_0, int_, int_2);
			}
			int_ = int_ + int_2 + 1;
		}
	}

	private static string smethod_11(string string_0, int int_0, int int_1)
	{
		if ((int_1 > 2 && char.IsDigit(string_0[int_0])) || (int_1 > 3 && string_0[int_0] == '.'))
		{
			string text = null;
			if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295536)))
			{
				text = Class84.smethod_0(-994295536);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994292141)))
			{
				text = Class84.smethod_0(-994292141);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994292181)))
			{
				text = Class84.smethod_0(-994292181);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295577)))
			{
				text = Class84.smethod_0(-994295577);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295500)))
			{
				text = Class84.smethod_0(-994295500);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295493)))
			{
				text = Class84.smethod_0(-994295493);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295550)))
			{
				text = Class84.smethod_0(-994295550);
			}
			else if (Class299.smethod_10(string_0, int_0 + int_1 - 2, 2, Class84.smethod_0(-994295543)))
			{
				text = Class84.smethod_0(-994295543);
			}
			if (text != null && Class172.smethod_0(string_0, int_0, int_1 - 2))
			{
				return string_0.Substring(int_0, int_1);
			}
		}
		else
		{
			if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994285196)))
			{
				return Class84.smethod_0(-994285196);
			}
			if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994292335)))
			{
				return Class84.smethod_0(-994292335);
			}
			if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994285201)))
			{
				return Class84.smethod_0(-994285201);
			}
		}
		return null;
	}

	private static string smethod_12(string string_0, int int_0, int int_1)
	{
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994289749)))
		{
			return Class84.smethod_0(-994289749);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994292460)))
		{
			return Class84.smethod_0(-994292460);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994291909)))
		{
			return Class84.smethod_0(-994291909);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994295012)))
		{
			return Class84.smethod_0(-994295012);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994295031)))
		{
			return Class84.smethod_0(-994295031);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994285157)))
		{
			return Class84.smethod_0(-994285157);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994285176)))
		{
			return Class84.smethod_0(-994285176);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994285179)))
		{
			return Class84.smethod_0(-994285179);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994295053)))
		{
			return Class84.smethod_0(-994295053);
		}
		if (Class299.smethod_10(string_0, int_0, int_1, Class84.smethod_0(-994295057)))
		{
			return Class84.smethod_0(-994295057);
		}
		return null;
	}

	private string method_16(string string_0, int int_0, int int_1)
	{
		if (!class172_0.method_2(string_0, int_0, int_1, out var _))
		{
			return null;
		}
		return string_0.Substring(int_0, int_1);
	}
}
