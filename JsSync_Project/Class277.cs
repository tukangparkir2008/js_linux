using System;
using System.Collections.Generic;
using System.Text;
using Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

internal sealed class Class277
{
	public static bool smethod_0(Class197 class197_0, GStruct2 gstruct2_0)
	{
		foreach (KeyValuePair<Class301, GStruct1> item in class197_0.method_202())
		{
			if (item.Value.method_18(gstruct2_0))
			{
				return true;
			}
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			if (smethod_0(item2, gstruct2_0))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_1(Class197 class197_0)
	{
		foreach (Class197 item in class197_0.method_190())
		{
			if (!item.method_192())
			{
				return false;
			}
		}
		return true;
	}

	public static Class197 smethod_2(Class197 class197_0, string string_0, Class197 class197_1)
	{
		if (class197_1 == null)
		{
			return class197_0;
		}
		if (class197_1.method_195() != null && class197_1.method_195().method_0().Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
		{
			return class197_1.method_188() ?? class197_0;
		}
		return smethod_2(class197_0, string_0, class197_1.method_188());
	}

	public static Class197 smethod_3(Class197 class197_0)
	{
		if (class197_0.method_188() != null)
		{
			int num = class197_0.method_188().method_190().IndexOf(class197_0);
			if (num > 0)
			{
				int num2 = 1;
				Class197 @class = class197_0.method_188().method_190()[num - 1];
				while ((@class.method_82() == Class84.smethod_0(-994289749) || @class.method_90() == Class84.smethod_0(-994293484) || @class.method_90() == Class84.smethod_0(-994289933)) && num - num2 - 1 >= 0)
				{
					@class = class197_0.method_188().method_190()[num - ++num2];
				}
				if (!(@class.method_82() == Class84.smethod_0(-994289749)) && !(@class.method_90() == Class84.smethod_0(-994289933)))
				{
					return @class;
				}
				return null;
			}
		}
		return null;
	}

	public static Class197 smethod_4(Class197 class197_0)
	{
		Class197 @class = class197_0;
		int num = @class.method_188().method_190().IndexOf(@class);
		while (@class.method_188() != null && num < 1 && @class.method_82() != Class84.smethod_0(-994289969) && @class.method_82() != Class84.smethod_0(-994289910) && @class.method_82() != Class84.smethod_0(-994289914) && @class.method_82() != Class84.smethod_0(-994289894))
		{
			@class = @class.method_188();
			num = ((@class.method_188() != null) ? @class.method_188().method_190().IndexOf(@class) : (-1));
		}
		@class = @class.method_188();
		if (@class != null && num > 0)
		{
			int num2 = 1;
			Class197 class2 = @class.method_190()[num - 1];
			while ((class2.method_82() == Class84.smethod_0(-994289749) || class2.method_90() == Class84.smethod_0(-994293484) || class2.method_90() == Class84.smethod_0(-994289933)) && num - num2 - 1 >= 0)
			{
				class2 = @class.method_190()[num - ++num2];
			}
			if (!(class2.method_82() == Class84.smethod_0(-994289749)))
			{
				return class2;
			}
			return null;
		}
		return null;
	}

	public static bool smethod_5(Class197 class197_0)
	{
		if (!class197_0.method_203()[0].vmethod_4() && class197_0.method_203()[0].vmethod_0() && class197_0.method_192())
		{
			Class197 @class = smethod_4(class197_0);
			if (@class != null && @class.method_192())
			{
				return true;
			}
		}
		return false;
	}

	public static Class197 smethod_6(Class197 class197_0)
	{
		Class197 result = null;
		if (class197_0.method_188() != null)
		{
			for (int i = class197_0.method_188().method_190().IndexOf(class197_0) + 1; i <= class197_0.method_188().method_190().Count - 1; i++)
			{
				Class197 @class = class197_0.method_188().method_190()[i];
				if (@class.method_82() != Class84.smethod_0(-994289749) && @class.method_90() != Class84.smethod_0(-994293484) && @class.method_90() != Class84.smethod_0(-994289933))
				{
					result = @class;
					break;
				}
			}
		}
		return result;
	}

	public static string smethod_7(Class197 class197_0, string string_0)
	{
		string text = null;
		while (class197_0 != null && text == null)
		{
			text = class197_0.method_218(string_0, null);
			class197_0 = class197_0.method_188();
		}
		return text;
	}

	public static Class197 smethod_8(Class197 class197_0, GStruct2 gstruct2_0, bool bool_0)
	{
		if (class197_0 != null && (!bool_0 || class197_0.method_104() == Class84.smethod_0(-994289754)) && (class197_0.method_134().method_16() || class197_0.method_134().method_18(gstruct2_0)))
		{
			foreach (Class197 item in class197_0.method_190())
			{
				if (Class299.smethod_5(class197_0.method_202(), class197_0.method_134()).method_18(gstruct2_0))
				{
					return smethod_8(item, gstruct2_0, bool_0: true) ?? item;
				}
			}
		}
		return null;
	}

	public static void smethod_9(Class197 class197_0, List<Class197> list_0)
	{
		if (class197_0 == null)
		{
			return;
		}
		if (class197_0.vmethod_4() && class197_0.method_104() == Class84.smethod_0(-994289754))
		{
			list_0.Add(class197_0);
		}
		foreach (Class197 item in class197_0.method_190())
		{
			smethod_9(item, list_0);
		}
	}

	public static Class197 smethod_10(Class197 class197_0, GStruct2 gstruct2_0)
	{
		if (class197_0 != null)
		{
			if (class197_0.vmethod_4() && class197_0.method_104() == Class84.smethod_0(-994289754) && smethod_0(class197_0, gstruct2_0))
			{
				return class197_0;
			}
			if (class197_0.method_144().method_16() || class197_0.method_144().method_18(gstruct2_0))
			{
				foreach (Class197 item in class197_0.method_190())
				{
					Class197 @class = smethod_10(item, gstruct2_0);
					if (@class != null)
					{
						return @class;
					}
				}
			}
		}
		return null;
	}

	public static Class197 smethod_11(Class197 class197_0, string string_0)
	{
		if (class197_0 != null && !string.IsNullOrEmpty(string_0))
		{
			if (class197_0.method_195() != null && string_0.Equals(class197_0.method_195().method_5(Class84.smethod_0(-994264162), null), StringComparison.OrdinalIgnoreCase))
			{
				return class197_0;
			}
			foreach (Class197 item in class197_0.method_190())
			{
				Class197 @class = smethod_11(item, string_0);
				if (@class != null)
				{
					return @class;
				}
			}
		}
		return null;
	}

	public static Class301 smethod_12(Class197 class197_0, GStruct2 gstruct2_0)
	{
		Class301 @class = null;
		if (class197_0 != null)
		{
			if (class197_0.method_200().Count > 0 && (class197_0.method_195() == null || class197_0.method_195().method_0() != Class84.smethod_0(-994284929) || class197_0.method_134().method_18(gstruct2_0)))
			{
				foreach (Class301 item in class197_0.method_200())
				{
					foreach (KeyValuePair<Class197, GStruct1> item2 in item.method_3())
					{
						if (item2.Value.method_13() <= gstruct2_0.method_3())
						{
							@class = item;
						}
						if (!(item2.Value.method_13() <= gstruct2_0.method_3()))
						{
							return @class;
						}
					}
				}
			}
			foreach (Class197 item3 in class197_0.method_190())
			{
				@class = smethod_12(item3, gstruct2_0) ?? @class;
			}
		}
		return @class;
	}

	public static Class245 smethod_13(Class197 class197_0, GStruct2 gstruct2_0)
	{
		if (class197_0 != null && class197_0.method_104() == Class84.smethod_0(-994289754))
		{
			if (class197_0.method_200().Count > 0)
			{
				foreach (Class301 item in class197_0.method_200())
				{
					Class245 @class = smethod_14(item, gstruct2_0);
					if (@class != null)
					{
						return @class;
					}
				}
			}
			if (class197_0.method_144().method_16() || class197_0.method_144().method_18(gstruct2_0))
			{
				foreach (Class197 item2 in class197_0.method_190())
				{
					Class245 class2 = smethod_13(item2, gstruct2_0);
					if (class2 != null)
					{
						return class2;
					}
				}
			}
		}
		return null;
	}

	public static Class245 smethod_14(Class301 class301_0, GStruct2 gstruct2_0)
	{
		foreach (KeyValuePair<Class197, GStruct1> item in class301_0.method_3())
		{
			foreach (Class245 item2 in item.Key.method_203())
			{
				GStruct1 gStruct = item2.method_1();
				gStruct.method_9(gStruct.method_8() + item2.method_0().method_170());
				if (gStruct.method_18(gstruct2_0))
				{
					return item2;
				}
			}
		}
		return null;
	}

	public static Class301 smethod_15(Class245 class245_0)
	{
		Class197 @class = class245_0.method_0();
		while (@class.method_200().Count == 0)
		{
			@class = @class.method_188();
		}
		foreach (Class301 item in @class.method_200())
		{
			foreach (Class245 item2 in item.method_1())
			{
				if (item2 == class245_0)
				{
					return item;
				}
			}
		}
		return @class.method_200()[0];
	}

	public static string smethod_16(Class197 class197_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = smethod_19(stringBuilder, class197_0);
		return stringBuilder.ToString(0, num).Trim();
	}

	public static string smethod_17(Class197 class197_0, GEnum3 genum3_0, bool bool_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (class197_0 != null)
		{
			Dictionary<Class197, bool> dictionary_ = (bool_0 ? smethod_20(class197_0) : null);
			Class197 class197_1 = (bool_0 ? smethod_22(class197_0, dictionary_) : null);
			smethod_24(class197_0.method_186().method_1(), stringBuilder, class197_0, genum3_0, dictionary_, class197_1);
		}
		return stringBuilder.ToString();
	}

	public static string smethod_18(Class197 class197_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		smethod_29(class197_0, stringBuilder, 0);
		return stringBuilder.ToString();
	}

	private static int smethod_19(StringBuilder stringBuilder_0, Class197 class197_0)
	{
		int num = 0;
		foreach (Class245 item in class197_0.method_203())
		{
			if (item.method_19())
			{
				stringBuilder_0.Append(smethod_28(item, bool_0: true));
				num = stringBuilder_0.Length;
			}
		}
		if (class197_0.method_190().Count < 1 && class197_0.method_198() != null && class197_0.method_198().method_5())
		{
			stringBuilder_0.Append(' ');
		}
		if (class197_0.method_104() != Class84.smethod_0(-994291909) && class197_0.method_82() != Class84.smethod_0(-994289749))
		{
			foreach (Class197 item2 in class197_0.method_190())
			{
				int val = smethod_19(stringBuilder_0, item2);
				num = Math.Max(num, val);
			}
		}
		if (stringBuilder_0.Length > 0)
		{
			if (class197_0.method_195() != null && class197_0.method_195().method_0() == Class84.smethod_0(-994289817))
			{
				if (stringBuilder_0.Length > 1 && stringBuilder_0[stringBuilder_0.Length - 1] != '\n')
				{
					stringBuilder_0.AppendLine();
				}
				stringBuilder_0.AppendLine(new string('-', 80));
			}
			if ((class197_0.method_82() == Class84.smethod_0(-994289969) || class197_0.method_82() == Class84.smethod_0(-994289894) || class197_0.method_82() == Class84.smethod_0(-994291714)) && (!class197_0.method_191() || stringBuilder_0.Length <= 1 || stringBuilder_0[stringBuilder_0.Length - 1] != '\n'))
			{
				stringBuilder_0.AppendLine();
			}
			if (class197_0.method_82() == Class84.smethod_0(-994289914))
			{
				stringBuilder_0.Append(' ');
			}
			if (class197_0.method_195() != null && class197_0.method_195().method_0() == Class84.smethod_0(-994285819))
			{
				int num2 = 0;
				int num3 = stringBuilder_0.Length - 1;
				while (num3 >= 0 && char.IsWhiteSpace(stringBuilder_0[num3]))
				{
					num2 += ((stringBuilder_0[num3] == '\n') ? 1 : 0);
					num3--;
				}
				if (num2 < 2)
				{
					stringBuilder_0.AppendLine();
				}
			}
		}
		return num;
	}

	private static Dictionary<Class197, bool> smethod_20(Class197 class197_0)
	{
		Dictionary<Class197, bool> dictionary = new Dictionary<Class197, bool>();
		Dictionary<Class197, bool> dictionary_ = new Dictionary<Class197, bool>();
		smethod_21(class197_0, dictionary, dictionary_);
		return dictionary;
	}

	private static bool smethod_21(Class197 class197_0, Dictionary<Class197, bool> dictionary_0, Dictionary<Class197, bool> dictionary_1)
	{
		bool result = false;
		foreach (Class245 item in class197_0.method_203())
		{
			if (!item.method_19())
			{
				continue;
			}
			dictionary_0[class197_0] = true;
			foreach (KeyValuePair<Class197, bool> item2 in dictionary_1)
			{
				dictionary_0[item2.Key] = item2.Value;
			}
			dictionary_1.Clear();
			result = true;
		}
		foreach (Class197 item3 in class197_0.method_190())
		{
			if (smethod_21(item3, dictionary_0, dictionary_1))
			{
				dictionary_0[class197_0] = true;
				result = true;
			}
		}
		if (class197_0.method_195() != null && dictionary_0.Count > 0)
		{
			dictionary_1[class197_0] = true;
		}
		return result;
	}

	private static Class197 smethod_22(Class197 class197_0, Dictionary<Class197, bool> dictionary_0)
	{
		Class197 @class = class197_0;
		Class197 class2 = class197_0;
		while (true)
		{
			bool flag = false;
			Class197 class3 = null;
			foreach (Class197 item in class2.method_190())
			{
				if (dictionary_0.ContainsKey(item))
				{
					if (class3 != null)
					{
						flag = true;
						break;
					}
					class3 = item;
				}
			}
			if (flag || class3 == null)
			{
				break;
			}
			class2 = class3;
			if (class2.method_195() != null)
			{
				@class = class2;
			}
		}
		if (!smethod_23(@class))
		{
			class2 = @class.method_188();
			while (class2.method_188() != null && class2.method_195() == null)
			{
				class2 = class2.method_188();
			}
			if (class2.method_195() != null)
			{
				@class = class2;
			}
		}
		return @class;
	}

	private static bool smethod_23(Class197 class197_0)
	{
		foreach (Class197 item in class197_0.method_190())
		{
			if (item.method_195() != null || smethod_23(item))
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_24(Class308 class308_0, StringBuilder stringBuilder_0, Class197 class197_0, GEnum3 genum3_0, Dictionary<Class197, bool> dictionary_0, Class197 class197_1)
	{
		if (class197_0.method_195() != null && dictionary_0 != null && !dictionary_0.ContainsKey(class197_0))
		{
			return;
		}
		if (class197_0.method_195() != null)
		{
			if (class197_0.method_195().method_0() != Class84.smethod_0(-994282519) || !class197_0.method_195().method_1().ContainsKey(Class84.smethod_0(-994289937)) || (!class197_0.method_195().method_1()[Class84.smethod_0(-994289937)].StartsWith(Class84.smethod_0(-994285763)) && !class197_0.method_195().method_1()[Class84.smethod_0(-994289937)].StartsWith(Class84.smethod_0(-994285780))))
			{
				smethod_25(class308_0, stringBuilder_0, class197_0, genum3_0);
				if (class197_0 == class197_1)
				{
					stringBuilder_0.Append(Class84.smethod_0(-994285735));
				}
			}
			if (genum3_0 == (GEnum3)2 && class197_0.method_195().method_0() == Class84.smethod_0(-994285756) && class197_0.method_186().method_16() != null)
			{
				stringBuilder_0.AppendLine(Class84.smethod_0(-994285697));
				smethod_27(stringBuilder_0, class197_0.method_186().method_16());
				stringBuilder_0.AppendLine(Class84.smethod_0(-994285716));
			}
		}
		if (class197_0.method_203().Count > 0)
		{
			foreach (Class245 item in class197_0.method_203())
			{
				if (dictionary_0 == null || item.method_19())
				{
					string string_ = smethod_28(item, dictionary_0 != null);
					stringBuilder_0.Append(Class273.smethod_2(string_));
				}
			}
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			smethod_24(class308_0, stringBuilder_0, item2, genum3_0, dictionary_0, class197_1);
		}
		if (class197_0.method_195() != null && !class197_0.method_195().method_2())
		{
			if (class197_0 == class197_1)
			{
				stringBuilder_0.Append(Class84.smethod_0(-994285670));
			}
			stringBuilder_0.AppendFormat(Class84.smethod_0(-994285693), class197_0.method_195().method_0());
		}
	}

	private static void smethod_25(Class308 class308_0, StringBuilder stringBuilder_0, Class197 class197_0, GEnum3 genum3_0)
	{
		stringBuilder_0.AppendFormat(Class84.smethod_0(-994285648), class197_0.method_195().method_0());
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		IEnumerable<CssBlock> enumerable = class197_0.method_186().method_16().method_2(class197_0.method_195().method_0(), Class84.smethod_0(-994290048));
		if (enumerable != null)
		{
			foreach (CssBlock item in enumerable)
			{
				foreach (KeyValuePair<string, string> property in item.Properties)
				{
					dictionary[property.Key] = property.Value;
				}
			}
		}
		if (class197_0.method_195().method_3())
		{
			stringBuilder_0.Append(' ');
			foreach (KeyValuePair<string, string> item2 in class197_0.method_195().method_1())
			{
				if (genum3_0 == (GEnum3)1 && item2.Key == Class84.smethod_0(-994285069))
				{
					foreach (KeyValuePair<string, string> property2 in class308_0.method_2(class197_0.method_195().method_0(), class197_0.method_195().method_5(Class84.smethod_0(-994285069), null)).Properties)
					{
						dictionary[property2.Key] = property2.Value;
					}
				}
				else if (genum3_0 == (GEnum3)1 && item2.Key == Class84.smethod_0(-994285073))
				{
					IEnumerable<CssBlock> enumerable2 = class197_0.method_186().method_16().method_2(Class84.smethod_0(-994272055) + item2.Value, Class84.smethod_0(-994290048));
					if (enumerable2 == null)
					{
						continue;
					}
					foreach (CssBlock item3 in enumerable2)
					{
						foreach (KeyValuePair<string, string> property3 in item3.Properties)
						{
							dictionary[property3.Key] = property3.Value;
						}
					}
				}
				else
				{
					stringBuilder_0.AppendFormat(Class84.smethod_0(-994285653), item2.Key, item2.Value);
				}
			}
			stringBuilder_0.Remove(stringBuilder_0.Length - 1, 1);
		}
		if (genum3_0 == (GEnum3)1 && dictionary.Count > 0)
		{
			Dictionary<string, string> dictionary2 = smethod_26(class197_0, dictionary);
			if (dictionary2.Count > 0)
			{
				stringBuilder_0.Append(Class84.smethod_0(-994285604));
				foreach (KeyValuePair<string, string> item4 in dictionary2)
				{
					stringBuilder_0.AppendFormat(Class84.smethod_0(-994285621), item4.Key, item4.Value);
				}
				stringBuilder_0.Remove(stringBuilder_0.Length - 1, 1);
				stringBuilder_0.Append('"');
			}
		}
		stringBuilder_0.AppendFormat(Class84.smethod_0(-994285572), class197_0.method_195().method_2() ? Class84.smethod_0(-994276891) : string.Empty);
	}

	private static Dictionary<string, string> smethod_26(Class197 class197_0, Dictionary<string, string> dictionary_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		IEnumerable<CssBlock> enumerable = class197_0.method_186().method_0().method_0()
			.method_2(class197_0.method_195().method_0(), Class84.smethod_0(-994290048));
		foreach (KeyValuePair<string, string> item in dictionary_0)
		{
			bool flag = false;
			foreach (CssBlock item2 in enumerable)
			{
				if (item2.Properties.TryGetValue(item.Key, out var value) && value.Equals(item.Value, StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				dictionary[item.Key] = item.Value;
			}
		}
		return dictionary;
	}

	private static void smethod_27(StringBuilder stringBuilder_0, GClass55 gclass55_0)
	{
		stringBuilder_0.AppendLine(Class84.smethod_0(-994285577));
		foreach (KeyValuePair<string, List<CssBlock>> item in gclass55_0.method_0()[Class84.smethod_0(-994290048)])
		{
			stringBuilder_0.Append(item.Key);
			stringBuilder_0.Append(Class84.smethod_0(-994295319));
			foreach (CssBlock item2 in item.Value)
			{
				foreach (KeyValuePair<string, string> property in item2.Properties)
				{
					stringBuilder_0.AppendFormat(Class84.smethod_0(-994207723), property.Key, property.Value);
				}
			}
			stringBuilder_0.Append(Class84.smethod_0(-994295277));
			stringBuilder_0.AppendLine();
		}
		stringBuilder_0.AppendLine(Class84.smethod_0(-994284671));
	}

	private static string smethod_28(Class245 class245_0, bool bool_0)
	{
		if (bool_0 && class245_0.method_20() > -1 && class245_0.method_21() > -1)
		{
			return class245_0.vmethod_7().Substring(class245_0.method_20(), class245_0.method_21() - class245_0.method_20());
		}
		if (bool_0 && class245_0.method_20() > -1)
		{
			return class245_0.vmethod_7().Substring(class245_0.method_20()) + (class245_0.vmethod_1() ? Class84.smethod_0(-994263061) : string.Empty);
		}
		if (bool_0 && class245_0.method_21() > -1)
		{
			return class245_0.vmethod_7().Substring(0, class245_0.method_21());
		}
		return (((class245_0.method_0().method_203()[0] == class245_0) ? smethod_5(class245_0.method_0()) : class245_0.vmethod_0()) ? Class84.smethod_0(-994263061) : string.Empty) + class245_0.vmethod_7() + (class245_0.vmethod_1() ? Class84.smethod_0(-994263061) : string.Empty);
	}

	private static void smethod_29(Class197 class197_0, StringBuilder stringBuilder_0, int int_0)
	{
		stringBuilder_0.AppendFormat(Class84.smethod_0(-994207739), new string(' ', 2 * int_0), class197_0.method_82());
		if (class197_0.method_195() != null)
		{
			stringBuilder_0.AppendFormat(Class84.smethod_0(-994207693), (class197_0.method_195() != null) ? class197_0.method_195().method_0() : string.Empty);
		}
		if (class197_0.method_203().Count > 0)
		{
			stringBuilder_0.AppendFormat(Class84.smethod_0(-994207656), class197_0.method_203().Count);
		}
		stringBuilder_0.AppendFormat(Class84.smethod_0(-994207669), (class197_0.method_190().Count > 0) ? string.Empty : Class84.smethod_0(-994276891));
		if (class197_0.method_190().Count <= 0)
		{
			return;
		}
		foreach (Class197 item in class197_0.method_190())
		{
			smethod_29(item, stringBuilder_0, int_0 + 1);
		}
		stringBuilder_0.AppendFormat(Class84.smethod_0(-994207624), new string(' ', 2 * int_0), class197_0.method_82());
	}
}
