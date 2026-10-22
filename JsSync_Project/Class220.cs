using System;
using System.Collections.Generic;
using System.Globalization;
using Yim.Jibas.JendelaSekolah.Client.Library.HtmlFactory.Core.Entities;

internal sealed class Class220
{
	private sealed class Class221
	{
		public string string_0;

		internal void method_0(Class197 class197_0)
		{
			string text;
			class197_0.method_9(text = Class84.smethod_0(-994292460));
			string text2;
			class197_0.method_13(text2 = text);
			string string_;
			class197_0.method_15(string_ = text2);
			class197_0.method_11(string_);
			class197_0.method_1(text = string_0);
			class197_0.method_5(text2 = text);
			class197_0.method_7(string_ = text2);
			class197_0.method_3(string_);
		}
	}

	private sealed class Class222
	{
		public string string_0;

		internal void method_0(Class197 class197_0)
		{
			string text;
			class197_0.method_47(text = string_0);
			string text2;
			class197_0.method_51(text2 = text);
			string string_;
			class197_0.method_53(string_ = text2);
			class197_0.method_49(string_);
		}
	}

	private readonly Class308 class308_0;

	public Class220(Class308 class308_1)
	{
		GClass24.smethod_1(class308_1, Class84.smethod_0(-994285096));
		class308_0 = class308_1;
	}

	public Class197 method_0(string string_0, GClass31 gclass31_0, ref GClass55 gclass55_0)
	{
		Class197 @class = Class207.smethod_0(string_0);
		if (@class != null)
		{
			@class.method_187(gclass31_0);
			bool bool_ = false;
			method_1(@class, gclass31_0, ref gclass55_0, ref bool_);
			method_2(@class, gclass55_0);
			method_3(gclass31_0, gclass55_0);
			smethod_11(@class);
			smethod_12(@class);
			bool bool_2 = true;
			smethod_13(@class, ref bool_2);
			smethod_17(@class);
			smethod_14(@class);
			smethod_17(@class);
		}
		return @class;
	}

	private void method_1(Class197 class197_0, GClass31 gclass31_0, ref GClass55 gclass55_0, ref bool bool_0)
	{
		if (class197_0.method_195() != null)
		{
			if (class197_0.method_195().method_0().Equals(Class84.smethod_0(-994282519), StringComparison.CurrentCultureIgnoreCase) && class197_0.method_218(Class84.smethod_0(-994285112), string.Empty).Equals(Class84.smethod_0(-994285118), StringComparison.CurrentCultureIgnoreCase))
			{
				smethod_6(ref gclass55_0, ref bool_0);
				Class279.smethod_0(gclass31_0, class197_0.method_218(Class84.smethod_0(-994289937), string.Empty), class197_0.method_195().method_1(), out var string_, out var gclass55_1);
				if (string_ != null)
				{
					class308_0.method_1(gclass55_0, string_);
				}
				else if (gclass55_1 != null)
				{
					gclass55_0.method_4(gclass55_1);
				}
			}
			if (class197_0.method_195().method_0().Equals(Class84.smethod_0(-994285069), StringComparison.CurrentCultureIgnoreCase) && class197_0.method_190().Count > 0)
			{
				smethod_6(ref gclass55_0, ref bool_0);
				foreach (Class197 item in class197_0.method_190())
				{
					class308_0.method_1(gclass55_0, item.method_198().method_6());
				}
			}
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			method_1(item2, gclass31_0, ref gclass55_0, ref bool_0);
		}
	}

	private void method_2(Class197 class197_0, GClass55 gclass55_0)
	{
		class197_0.method_223(null, bool_2: false);
		if (class197_0.method_195() != null)
		{
			smethod_1(class197_0, gclass55_0, Class84.smethod_0(-994274979));
			smethod_1(class197_0, gclass55_0, class197_0.method_195().method_0());
			if (class197_0.method_195().method_4(Class84.smethod_0(-994285073)))
			{
				smethod_0(class197_0, gclass55_0);
			}
			if (class197_0.method_195().method_4(Class84.smethod_0(-994264162)))
			{
				string text = class197_0.method_195().method_5(Class84.smethod_0(-994264162), null);
				smethod_1(class197_0, gclass55_0, Class84.smethod_0(-994282651) + text);
			}
			method_4(class197_0.method_195(), class197_0);
			if (class197_0.method_195().method_4(Class84.smethod_0(-994285069)))
			{
				CssBlock cssBlock = class308_0.method_2(class197_0.method_195().method_0(), class197_0.method_195().method_5(Class84.smethod_0(-994285069), null));
				if (cssBlock != null)
				{
					smethod_4(class197_0, cssBlock);
				}
			}
		}
		if (class197_0.method_100() != string.Empty && class197_0.method_198() == null)
		{
			foreach (Class197 item in class197_0.method_190())
			{
				item.method_101(class197_0.method_100());
			}
			class197_0.method_101(string.Empty);
		}
		foreach (Class197 item2 in class197_0.method_190())
		{
			method_2(item2, gclass55_0);
		}
	}

	private void method_3(GClass31 gclass31_0, GClass55 gclass55_0)
	{
		gclass31_0.method_50(GStruct3.gstruct3_0);
		gclass31_0.method_52(GStruct3.gstruct3_0);
		if (!gclass55_0.method_1(Class84.smethod_0(-994285029), Class84.smethod_0(-994290048)))
		{
			return;
		}
		foreach (CssBlock item in gclass55_0.method_2(Class84.smethod_0(-994285029), Class84.smethod_0(-994290048)))
		{
			if (item.Properties.ContainsKey(Class84.smethod_0(-994282411)))
			{
				gclass31_0.method_50(class308_0.method_4(item.Properties[Class84.smethod_0(-994282411)]));
			}
			if (item.Properties.ContainsKey(Class84.smethod_0(-994285043)))
			{
				gclass31_0.method_52(class308_0.method_4(item.Properties[Class84.smethod_0(-994285043)]));
			}
		}
	}

	private static void smethod_0(Class197 class197_0, GClass55 gclass55_0)
	{
		string text = class197_0.method_195().method_5(Class84.smethod_0(-994285073), null);
		int i = 0;
		while (i < text.Length)
		{
			for (; i < text.Length && text[i] == ' '; i++)
			{
			}
			if (i < text.Length)
			{
				int num = text.IndexOf(' ', i);
				if (num < 0)
				{
					num = text.Length;
				}
				string text2 = Class84.smethod_0(-994272055) + text.Substring(i, num - i);
				smethod_1(class197_0, gclass55_0, text2);
				smethod_1(class197_0, gclass55_0, class197_0.method_195().method_0() + text2);
				i = num + 1;
			}
		}
	}

	private static void smethod_1(Class197 class197_0, GClass55 gclass55_0, string string_0)
	{
		foreach (CssBlock item in gclass55_0.method_2(string_0, Class84.smethod_0(-994290048)))
		{
			if (smethod_2(class197_0, item))
			{
				smethod_4(class197_0, item);
			}
		}
	}

	private static bool smethod_2(Class197 class197_0, CssBlock cssBlock_0)
	{
		bool flag = true;
		if (cssBlock_0.Selectors != null)
		{
			flag = smethod_3(class197_0, cssBlock_0);
		}
		else if (class197_0.method_195().method_0().Equals(Class84.smethod_0(-994289925), StringComparison.OrdinalIgnoreCase) && cssBlock_0.Class.Equals(Class84.smethod_0(-994289925), StringComparison.OrdinalIgnoreCase) && !class197_0.method_195().method_4(Class84.smethod_0(-994289937)))
		{
			flag = false;
		}
		if (flag && cssBlock_0.Hover)
		{
			class197_0.method_186().method_74(class197_0, cssBlock_0);
			flag = false;
		}
		return flag;
	}

	private static bool smethod_3(Class197 class197_0, CssBlock cssBlock_0)
	{
		foreach (GStruct0 selector in cssBlock_0.Selectors)
		{
			bool flag = false;
			while (!flag)
			{
				class197_0 = class197_0.method_188();
				while (class197_0 != null && class197_0.method_195() == null)
				{
					class197_0 = class197_0.method_188();
				}
				if (class197_0 != null)
				{
					if (class197_0.method_195().method_0().Equals(selector.method_0(), StringComparison.InvariantCultureIgnoreCase))
					{
						flag = true;
					}
					if (!flag && class197_0.method_195().method_4(Class84.smethod_0(-994285073)))
					{
						string text = class197_0.method_195().method_5(Class84.smethod_0(-994285073), null);
						if (selector.method_0().Equals(Class84.smethod_0(-994272055) + text, StringComparison.InvariantCultureIgnoreCase) || selector.method_0().Equals(class197_0.method_195().method_0() + Class84.smethod_0(-994272055) + text, StringComparison.InvariantCultureIgnoreCase))
						{
							flag = true;
						}
					}
					if (!flag && class197_0.method_195().method_4(Class84.smethod_0(-994264162)))
					{
						string text2 = class197_0.method_195().method_5(Class84.smethod_0(-994264162), null);
						if (selector.method_0().Equals(Class84.smethod_0(-994282651) + text2, StringComparison.InvariantCultureIgnoreCase))
						{
							flag = true;
						}
					}
					if (!flag && selector.method_1())
					{
						return false;
					}
					continue;
				}
				return false;
			}
		}
		return true;
	}

	private static void smethod_4(Class197 class197_0, CssBlock cssBlock_0)
	{
		foreach (KeyValuePair<string, string> property in cssBlock_0.Properties)
		{
			string string_ = property.Value;
			if (property.Value == Class84.smethod_0(-994292120) && class197_0.method_188() != null)
			{
				string_ = Class204.smethod_2(class197_0.method_188(), property.Key);
			}
			if (smethod_5(class197_0, property.Key, string_))
			{
				Class204.smethod_3(class197_0, property.Key, string_);
			}
		}
	}

	private static bool smethod_5(Class197 class197_0, string string_0, string string_1)
	{
		if (class197_0.method_195() != null && string_0 == Class84.smethod_0(-994285004))
		{
			string text = class197_0.method_195().method_0();
			if (text != null)
			{
				switch (text.Length)
				{
				case 2:
				{
					char c = text[1];
					if (c != 'd')
					{
						if (c != 'h')
						{
							if (c != 'r' || !(text == Class84.smethod_0(-994284986)))
							{
								break;
							}
							return string_1 == Class84.smethod_0(-994291714);
						}
						if (!(text == Class84.smethod_0(-994284952)))
						{
							break;
						}
					}
					else if (!(text == Class84.smethod_0(-994284929)))
					{
						break;
					}
					return string_1 == Class84.smethod_0(-994289914);
				}
				case 3:
					if (text == Class84.smethod_0(-994284959))
					{
						return string_1 == Class84.smethod_0(-994291803);
					}
					break;
				case 5:
					switch (text[1])
					{
					case 'b':
						if (text == Class84.smethod_0(-994285022))
						{
							return string_1 == Class84.smethod_0(-994291768);
						}
						break;
					case 'a':
						if (text == Class84.smethod_0(-994289910))
						{
							return string_1 == Class84.smethod_0(-994289910);
						}
						break;
					case 'h':
						if (text == Class84.smethod_0(-994284962))
						{
							return string_1 == Class84.smethod_0(-994295765);
						}
						break;
					case 'f':
						if (text == Class84.smethod_0(-994284982))
						{
							return string_1 == Class84.smethod_0(-994295724);
						}
						break;
					}
					break;
				case 7:
					if (text == Class84.smethod_0(-994284918))
					{
						return string_1 == Class84.smethod_0(-994295801);
					}
					break;
				case 8:
					if (text == Class84.smethod_0(-994284901))
					{
						return string_1 == Class84.smethod_0(-994295683);
					}
					break;
				}
			}
		}
		return true;
	}

	private static void smethod_6(ref GClass55 gclass55_0, ref bool bool_0)
	{
		if (!bool_0)
		{
			bool_0 = true;
			gclass55_0 = gclass55_0.method_5();
		}
	}

	private void method_4(Class343 class343_0, Class197 class197_0)
	{
		if (!class343_0.method_3())
		{
			return;
		}
		foreach (string key in class343_0.method_1().Keys)
		{
			string text = class343_0.method_1()[key];
			if (key == null)
			{
				continue;
			}
			switch (key.Length)
			{
			case 3:
				if (key == Class84.smethod_0(-994284752))
				{
					class197_0.method_85(text.ToLower());
				}
				break;
			case 4:
				switch (key[0])
				{
				case 's':
					if (key == Class84.smethod_0(-994284763))
					{
						if (class343_0.method_0().Equals(Class84.smethod_0(-994289817), StringComparison.OrdinalIgnoreCase))
						{
							class197_0.method_65(smethod_7(text));
						}
						else if (class343_0.method_0().Equals(Class84.smethod_0(-994282287), StringComparison.OrdinalIgnoreCase))
						{
							class197_0.method_113(text);
						}
					}
					break;
				case 'f':
					if (key == Class84.smethod_0(-994284758))
					{
						class197_0.method_111(class308_0.method_3(text));
					}
					break;
				}
				break;
			case 5:
				switch (key[0])
				{
				case 'w':
					if (key == Class84.smethod_0(-994282437))
					{
						class197_0.method_61(smethod_7(text));
					}
					break;
				case 'c':
					if (key == Class84.smethod_0(-994282411))
					{
						class197_0.method_79(text.ToLower());
					}
					break;
				case 'a':
					if (key == Class84.smethod_0(-994284872))
					{
						if (!(text == Class84.smethod_0(-994295048)) && !(text == Class84.smethod_0(-994291853)) && !(text == Class84.smethod_0(-994291897)) && !(text == Class84.smethod_0(-994291872)))
						{
							class197_0.method_95(text.ToLower());
						}
						else
						{
							class197_0.method_99(text.ToLower());
						}
					}
					break;
				}
				break;
			case 6:
				switch (key[2])
				{
				case 'l':
					if (key == Class84.smethod_0(-994284803))
					{
						class197_0.method_95(text.ToLower());
					}
					break;
				case 'i':
					if (key == Class84.smethod_0(-994282441))
					{
						class197_0.method_65(smethod_7(text));
					}
					break;
				case 'w':
					if (key == Class84.smethod_0(-994293524))
					{
						class197_0.method_103(Class84.smethod_0(-994293524));
					}
					break;
				case 'r':
				{
					if (!(key == Class84.smethod_0(-994282292)))
					{
						break;
					}
					string text2;
					string text3;
					string string_;
					if (!string.IsNullOrEmpty(text) && text != Class84.smethod_0(-994274584))
					{
						class197_0.method_9(text2 = Class84.smethod_0(-994292460));
						class197_0.method_13(text3 = text2);
						class197_0.method_15(string_ = text3);
						class197_0.method_11(string_);
					}
					class197_0.method_1(text2 = smethod_7(text));
					class197_0.method_5(text3 = text2);
					class197_0.method_7(string_ = text3);
					class197_0.method_3(string_);
					if (class343_0.method_0() == Class84.smethod_0(-994289910))
					{
						if (text != Class84.smethod_0(-994274584))
						{
							smethod_8(class197_0, Class84.smethod_0(-994292442));
						}
					}
					else
					{
						class197_0.method_9(text2 = Class84.smethod_0(-994292460));
						class197_0.method_13(text3 = text2);
						class197_0.method_11(string_ = text3);
						class197_0.method_15(string_);
					}
					break;
				}
				case 'p':
					if (!(key == Class84.smethod_0(-994284845)))
					{
						if (key == Class84.smethod_0(-994284864))
						{
							string string_;
							class197_0.method_39(string_ = smethod_7(text));
							class197_0.method_45(string_);
						}
					}
					else
					{
						string string_;
						class197_0.method_41(string_ = smethod_7(text));
						class197_0.method_43(string_);
					}
					break;
				}
				break;
			case 7:
				if (key == Class84.smethod_0(-994284891))
				{
					class197_0.method_67(text.ToLower());
				}
				break;
			case 10:
				if (key == Class84.smethod_0(-994284876))
				{
					class197_0.method_69(text.ToLower());
				}
				break;
			case 11:
				switch (key[4])
				{
				case 's':
					if (key == Class84.smethod_0(-994284772))
					{
						class197_0.method_25(smethod_7(text));
					}
					break;
				case 'p':
					if (key == Class84.smethod_0(-994284786))
					{
						smethod_9(class197_0, text);
					}
					break;
				case 'e':
					if (key == Class84.smethod_0(-994284822))
					{
						string text2;
						class197_0.method_17(text2 = text.ToLower());
						string text3;
						class197_0.method_21(text3 = text2);
						string string_;
						class197_0.method_23(string_ = text3);
						class197_0.method_19(string_);
					}
					break;
				}
				break;
			}
		}
	}

	private static string smethod_7(string string_0)
	{
		if (new Class239(string_0).method_1())
		{
			return string.Format(NumberFormatInfo.InvariantInfo, Class84.smethod_0(-994292161), string_0);
		}
		return string_0;
	}

	private static void smethod_8(Class197 class197_0, string string_0)
	{
		Class221 @class = new Class221();
		@class.string_0 = string_0;
		smethod_10(class197_0, @class.method_0);
	}

	private static void smethod_9(Class197 class197_0, string string_0)
	{
		Class222 @class = new Class222();
		@class.string_0 = smethod_7(string_0);
		smethod_10(class197_0, @class.method_0);
	}

	private static void smethod_10(Class197 class197_0, Delegate25<Class197> delegate25_0)
	{
		foreach (Class197 item in class197_0.method_190())
		{
			foreach (Class197 item2 in item.method_190())
			{
				if (item2.method_195() != null && item2.method_195().method_0() == Class84.smethod_0(-994284929))
				{
					delegate25_0(item2);
					continue;
				}
				foreach (Class197 item3 in item2.method_190())
				{
					delegate25_0(item3);
				}
			}
		}
	}

	private static void smethod_11(Class197 class197_0)
	{
		for (int num = class197_0.method_190().Count - 1; num >= 0; num--)
		{
			Class197 @class = class197_0.method_190()[num];
			if (@class.method_198() != null)
			{
				if (!@class.method_198().method_4() || @class.method_102() == Class84.smethod_0(-994293750) || @class.method_102() == Class84.smethod_0(-994293756) || class197_0.method_190().Count == 1 || (num > 0 && num < class197_0.method_190().Count - 1 && class197_0.method_190()[num - 1].method_192() && class197_0.method_190()[num + 1].method_192()) || (num == 0 && class197_0.method_190().Count > 1 && class197_0.method_190()[1].method_192() && class197_0.method_192()) || (num == class197_0.method_190().Count - 1 && class197_0.method_190().Count > 1 && class197_0.method_190()[num - 1].method_192() && class197_0.method_192()))
				{
					@class.method_213();
				}
				else
				{
					@class.method_188().method_190().RemoveAt(num);
				}
			}
			else
			{
				smethod_11(@class);
			}
		}
	}

	private static void smethod_12(Class197 class197_0)
	{
		for (int num = class197_0.method_190().Count - 1; num >= 0; num--)
		{
			Class197 @class = class197_0.method_190()[num];
			if (@class is Class200 && @class.method_82() == Class84.smethod_0(-994289969))
			{
				Class197 class197_1 = Class197.smethod_3(@class.method_188(), null, @class);
				@class.method_189(class197_1);
				@class.method_83(Class84.smethod_0(-994290001));
			}
			else
			{
				smethod_12(@class);
			}
		}
	}

	private static void smethod_13(Class197 class197_0, ref bool bool_0)
	{
		bool_0 = bool_0 || class197_0.method_193();
		foreach (Class197 item in class197_0.method_190())
		{
			smethod_13(item, ref bool_0);
			bool_0 = item.method_203().Count == 0 && (bool_0 || item.method_193());
		}
		int num = -1;
		Class197 @class;
		do
		{
			@class = null;
			for (int i = 0; i < class197_0.method_190().Count; i++)
			{
				if (@class != null)
				{
					break;
				}
				if (i > num && class197_0.method_190()[i].method_191())
				{
					@class = class197_0.method_190()[i];
					num = i;
				}
				else if (class197_0.method_190()[i].method_203().Count > 0)
				{
					bool_0 = false;
				}
				else if (class197_0.method_190()[i].method_193())
				{
					bool_0 = true;
				}
			}
			if (@class != null)
			{
				@class.method_83(Class84.smethod_0(-994289969));
				if (bool_0)
				{
					@class.method_65(Class84.smethod_0(-994284720));
				}
			}
		}
		while (@class != null);
	}

	private static void smethod_14(Class197 class197_0)
	{
		try
		{
			if (Class277.smethod_1(class197_0) && !smethod_18(class197_0))
			{
				Class197 @class = smethod_15(class197_0);
				while (@class != null)
				{
					Class197 class2 = null;
					if (Class277.smethod_1(@class) && !smethod_18(@class))
					{
						class2 = smethod_15(@class);
					}
					@class.method_188().method_212(@class);
					@class.method_189(null);
					@class = class2;
				}
			}
			if (Class277.smethod_1(class197_0))
			{
				return;
			}
			foreach (Class197 item in class197_0.method_190())
			{
				smethod_14(item);
			}
		}
		catch (Exception exception_)
		{
			class197_0.method_186().method_72(GEnum7.HtmlParsing, Class84.smethod_0(-994284724), exception_);
		}
	}

	private static Class197 smethod_15(Class197 class197_0)
	{
		if (class197_0.method_82() == Class84.smethod_0(-994290001))
		{
			class197_0.method_83(Class84.smethod_0(-994289969));
		}
		if (class197_0.method_190().Count <= 1 && class197_0.method_190()[0].method_190().Count <= 1)
		{
			if (class197_0.method_190()[0].method_82() == Class84.smethod_0(-994290001))
			{
				class197_0.method_190()[0].method_83(Class84.smethod_0(-994289969));
			}
		}
		else
		{
			Class197 @class = Class197.smethod_3(class197_0, null, null);
			while (smethod_18(class197_0.method_190()[0]))
			{
				class197_0.method_190()[0].method_189(@class);
			}
			@class.method_211(class197_0.method_190()[0]);
			Class197 class2 = class197_0.method_190()[1];
			class2.method_189(null);
			smethod_16(class197_0, class2, @class);
			if (@class.method_190().Count < 1)
			{
				@class.method_189(null);
			}
			int num = ((@class.method_188() == null) ? 1 : 2);
			if (class197_0.method_190().Count > num)
			{
				Class197 class3 = Class197.smethod_1(class197_0, null, class197_0.method_190()[num]);
				while (class197_0.method_190().Count > num + 1)
				{
					class197_0.method_190()[num + 1].method_189(class3);
				}
				return class3;
			}
		}
		return null;
	}

	private static void smethod_16(Class197 class197_0, Class197 class197_1, Class197 class197_2)
	{
		Class197 @class = null;
		while (class197_1.method_190()[0].method_192() && smethod_18(class197_1.method_190()[0]))
		{
			if (@class == null)
			{
				@class = Class197.smethod_1(class197_2, class197_1.method_195(), null);
				@class.method_223(class197_1, bool_2: true);
			}
			class197_1.method_190()[0].method_189(@class);
		}
		Class197 class2 = class197_1.method_190()[0];
		if (!smethod_18(class2))
		{
			smethod_16(class197_0, class2, class197_2);
			class2.method_189(null);
		}
		else
		{
			class2.method_189(class197_0);
		}
		if (class197_1.method_190().Count > 0)
		{
			Class197 class3;
			if (class2.method_188() == null && class197_0.method_190().Count >= 3)
			{
				class3 = class197_0.method_190()[2];
			}
			else
			{
				class3 = Class197.smethod_1(class197_0, class197_1.method_195(), null);
				class3.method_223(class197_1, bool_2: true);
				if (class197_0.method_190().Count > 2)
				{
					class3.method_211(class197_0.method_190()[1]);
				}
				if (class2.method_188() != null)
				{
					class2.method_211(class3);
				}
			}
			class3.method_212(class197_1);
		}
		else if (class2.method_188() != null && class197_0.method_190().Count > 1)
		{
			class2.method_211(class197_0.method_190()[1]);
			if (class2.method_195() != null && class2.method_195().method_0() == Class84.smethod_0(-994289994) && (@class != null || class197_2.method_190().Count > 1))
			{
				class2.method_83(Class84.smethod_0(-994290001));
			}
		}
	}

	private static void smethod_17(Class197 class197_0)
	{
		if (smethod_19(class197_0))
		{
			for (int i = 0; i < class197_0.method_190().Count; i++)
			{
				if (class197_0.method_190()[i].method_192())
				{
					Class197 class197_1 = Class197.smethod_3(class197_0, null, class197_0.method_190()[i++]);
					while (i < class197_0.method_190().Count && class197_0.method_190()[i].method_192())
					{
						class197_0.method_190()[i].method_189(class197_1);
					}
				}
			}
		}
		if (Class277.smethod_1(class197_0))
		{
			return;
		}
		foreach (Class197 item in class197_0.method_190())
		{
			smethod_17(item);
		}
	}

	private static bool smethod_18(Class197 class197_0)
	{
		foreach (Class197 item in class197_0.method_190())
		{
			if (!item.method_192() || !smethod_18(item))
			{
				return false;
			}
		}
		return true;
	}

	private static bool smethod_19(Class197 class197_0)
	{
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < class197_0.method_190().Count; i++)
		{
			if (flag && flag2)
			{
				break;
			}
			bool flag3 = !class197_0.method_190()[i].method_192();
			flag |= flag3;
			flag2 = flag2 || !flag3;
		}
		return flag & flag2;
	}
}
