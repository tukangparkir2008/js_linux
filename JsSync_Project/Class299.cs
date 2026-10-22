using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

internal static class Class299
{
	private static readonly string[,] string_0 = new string[4, 10]
	{
		{
			string.Empty,
			Class84.smethod_0(-994284483),
			Class84.smethod_0(-994284491),
			Class84.smethod_0(-994284498),
			Class84.smethod_0(-994284456),
			Class84.smethod_0(-994284463),
			Class84.smethod_0(-994284471),
			Class84.smethod_0(-994284478),
			Class84.smethod_0(-994284420),
			Class84.smethod_0(-994284425)
		},
		{
			string.Empty,
			Class84.smethod_0(-994284448),
			Class84.smethod_0(-994284392),
			Class84.smethod_0(-994284399),
			Class84.smethod_0(-994284405),
			Class84.smethod_0(-994284412),
			Class84.smethod_0(-994284356),
			Class84.smethod_0(-994284363),
			Class84.smethod_0(-994284369),
			Class84.smethod_0(-994284326)
		},
		{
			string.Empty,
			Class84.smethod_0(-994284333),
			Class84.smethod_0(-994284341),
			Class84.smethod_0(-994284348),
			Class84.smethod_0(-994284290),
			Class84.smethod_0(-994284297),
			Class84.smethod_0(-994284305),
			Class84.smethod_0(-994284264),
			Class84.smethod_0(-994284270),
			Class84.smethod_0(-994284275)
		},
		{
			string.Empty,
			Class84.smethod_0(-994284282),
			Class84.smethod_0(-994284226),
			Class84.smethod_0(-994284233),
			Class84.smethod_0(-994284255),
			Class84.smethod_0(-994284196),
			Class84.smethod_0(-994284202),
			Class84.smethod_0(-994284223),
			Class84.smethod_0(-994284163),
			Class84.smethod_0(-994284182)
		}
	};

	private static readonly string[,] string_1 = new string[3, 9]
	{
		{
			Class84.smethod_0(-994284187),
			Class84.smethod_0(-994284130),
			Class84.smethod_0(-994284137),
			Class84.smethod_0(-994284160),
			Class84.smethod_0(-994284103),
			Class84.smethod_0(-994284110),
			Class84.smethod_0(-994284117),
			Class84.smethod_0(-994284124),
			Class84.smethod_0(-994284067)
		},
		{
			Class84.smethod_0(-994284074),
			Class84.smethod_0(-994284081),
			Class84.smethod_0(-994284040),
			Class84.smethod_0(-994284047),
			Class84.smethod_0(-994284054),
			Class84.smethod_0(-994284061),
			Class84.smethod_0(-994284004),
			Class84.smethod_0(-994284011),
			Class84.smethod_0(-994284018)
		},
		{
			Class84.smethod_0(-994284025),
			Class84.smethod_0(-994283984),
			Class84.smethod_0(-994283991),
			Class84.smethod_0(-994283998),
			Class84.smethod_0(-994283941),
			Class84.smethod_0(-994283946),
			Class84.smethod_0(-994283967),
			Class84.smethod_0(-994283908),
			Class84.smethod_0(-994283913)
		}
	};

	private static readonly string[,] string_2 = new string[3, 9]
	{
		{
			Class84.smethod_0(-994283932),
			Class84.smethod_0(-994283875),
			Class84.smethod_0(-994283882),
			Class84.smethod_0(-994283889),
			Class84.smethod_0(-994283848),
			Class84.smethod_0(-994283855),
			Class84.smethod_0(-994283862),
			Class84.smethod_0(-994283869),
			Class84.smethod_0(-994283812)
		},
		{
			Class84.smethod_0(-994283819),
			Class84.smethod_0(-994283826),
			Class84.smethod_0(-994283833),
			Class84.smethod_0(-994283792),
			Class84.smethod_0(-994283799),
			Class84.smethod_0(-994283806),
			Class84.smethod_0(-994283749),
			Class84.smethod_0(-994283826),
			Class84.smethod_0(-994283756)
		},
		{
			Class84.smethod_0(-994283763),
			Class84.smethod_0(-994283770),
			Class84.smethod_0(-994283713),
			Class84.smethod_0(-994283736),
			Class84.smethod_0(-994283743),
			Class84.smethod_0(-994283686),
			Class84.smethod_0(-994283693),
			Class84.smethod_0(-994283700),
			Class84.smethod_0(-994283707)
		}
	};

	private static readonly string[,] string_3 = new string[3, 9]
	{
		{
			Class84.smethod_0(-994283650),
			Class84.smethod_0(-994283657),
			Class84.smethod_0(-994283680),
			Class84.smethod_0(-994283623),
			Class84.smethod_0(-994283630),
			Class84.smethod_0(-994283637),
			Class84.smethod_0(-994283644),
			Class84.smethod_0(-994283587),
			Class84.smethod_0(-994283594)
		},
		{
			Class84.smethod_0(-994283601),
			Class84.smethod_0(-994283560),
			Class84.smethod_0(-994283567),
			Class84.smethod_0(-994283574),
			Class84.smethod_0(-994283581),
			Class84.smethod_0(-994283524),
			Class84.smethod_0(-994283531),
			Class84.smethod_0(-994283538),
			Class84.smethod_0(-994283545)
		},
		{
			Class84.smethod_0(-994287600),
			Class84.smethod_0(-994287607),
			Class84.smethod_0(-994287614),
			Class84.smethod_0(-994287557),
			Class84.smethod_0(-994287564),
			Class84.smethod_0(-994287571),
			Class84.smethod_0(-994287578),
			Class84.smethod_0(-994287521),
			Class84.smethod_0(-994287544)
		}
	};

	private static readonly string[] string_4 = new string[48]
	{
		Class84.smethod_0(-994287551),
		Class84.smethod_0(-994287494),
		Class84.smethod_0(-994287501),
		Class84.smethod_0(-994287508),
		Class84.smethod_0(-994287515),
		Class84.smethod_0(-994287458),
		Class84.smethod_0(-994287465),
		Class84.smethod_0(-994287488),
		Class84.smethod_0(-994287431),
		Class84.smethod_0(-994287438),
		Class84.smethod_0(-994287445),
		Class84.smethod_0(-994287452),
		Class84.smethod_0(-994287395),
		Class84.smethod_0(-994287402),
		Class84.smethod_0(-994287409),
		Class84.smethod_0(-994287368),
		Class84.smethod_0(-994287375),
		Class84.smethod_0(-994287382),
		Class84.smethod_0(-994287389),
		Class84.smethod_0(-994287332),
		Class84.smethod_0(-994287339),
		Class84.smethod_0(-994287346),
		Class84.smethod_0(-994287353),
		Class84.smethod_0(-994287312),
		Class84.smethod_0(-994287319),
		Class84.smethod_0(-994287326),
		Class84.smethod_0(-994287269),
		Class84.smethod_0(-994287276),
		Class84.smethod_0(-994287283),
		Class84.smethod_0(-994287290),
		Class84.smethod_0(-994287233),
		Class84.smethod_0(-994287256),
		Class84.smethod_0(-994287263),
		Class84.smethod_0(-994287206),
		Class84.smethod_0(-994287213),
		Class84.smethod_0(-994287220),
		Class84.smethod_0(-994287227),
		Class84.smethod_0(-994287170),
		Class84.smethod_0(-994287177),
		Class84.smethod_0(-994287200),
		Class84.smethod_0(-994287143),
		Class84.smethod_0(-994287150),
		Class84.smethod_0(-994287157),
		Class84.smethod_0(-994287164),
		Class84.smethod_0(-994287107),
		Class84.smethod_0(-994287114),
		Class84.smethod_0(-994287121),
		Class84.smethod_0(-994287080)
	};

	private static readonly string[] string_5 = new string[48]
	{
		Class84.smethod_0(-994287087),
		Class84.smethod_0(-994287094),
		Class84.smethod_0(-994287101),
		Class84.smethod_0(-994287044),
		Class84.smethod_0(-994287051),
		Class84.smethod_0(-994287058),
		Class84.smethod_0(-994287065),
		Class84.smethod_0(-994287024),
		Class84.smethod_0(-994287031),
		Class84.smethod_0(-994287038),
		Class84.smethod_0(-994286981),
		Class84.smethod_0(-994286988),
		Class84.smethod_0(-994286995),
		Class84.smethod_0(-994287002),
		Class84.smethod_0(-994286945),
		Class84.smethod_0(-994286968),
		Class84.smethod_0(-994286975),
		Class84.smethod_0(-994286918),
		Class84.smethod_0(-994286925),
		Class84.smethod_0(-994286932),
		Class84.smethod_0(-994286939),
		Class84.smethod_0(-994286882),
		Class84.smethod_0(-994286889),
		Class84.smethod_0(-994286912),
		Class84.smethod_0(-994286855),
		Class84.smethod_0(-994286862),
		Class84.smethod_0(-994286869),
		Class84.smethod_0(-994286876),
		Class84.smethod_0(-994286819),
		Class84.smethod_0(-994286826),
		Class84.smethod_0(-994286833),
		Class84.smethod_0(-994286792),
		Class84.smethod_0(-994286799),
		Class84.smethod_0(-994286806),
		Class84.smethod_0(-994286813),
		Class84.smethod_0(-994286756),
		Class84.smethod_0(-994286763),
		Class84.smethod_0(-994286770),
		Class84.smethod_0(-994286777),
		Class84.smethod_0(-994286736),
		Class84.smethod_0(-994286743),
		Class84.smethod_0(-994286750),
		Class84.smethod_0(-994286693),
		Class84.smethod_0(-994286700),
		Class84.smethod_0(-994286707),
		Class84.smethod_0(-994286714),
		Class84.smethod_0(-994286657),
		Class84.smethod_0(-994286680)
	};

	public static string string_6;

	public static bool smethod_0(char char_0)
	{
		if (char_0 >= '一')
		{
			return char_0 <= '鶴';
		}
		return false;
	}

	public static bool smethod_1(char char_0, bool bool_0)
	{
		if (char_0 >= '0' && char_0 <= '9')
		{
			return true;
		}
		if (bool_0)
		{
			if (char_0 >= 'a' && char_0 <= 'f')
			{
				return true;
			}
			if (char_0 >= 'A')
			{
				return char_0 <= 'F';
			}
			return false;
		}
		return false;
	}

	public static int smethod_2(char char_0, bool bool_0)
	{
		if (char_0 >= '0' && char_0 <= '9')
		{
			return char_0 - 48;
		}
		if (bool_0)
		{
			if (char_0 >= 'a' && char_0 <= 'f')
			{
				return char_0 - 97 + 10;
			}
			if (char_0 >= 'A' && char_0 <= 'F')
			{
				return char_0 - 65 + 10;
			}
		}
		return 0;
	}

	public static GStruct4 smethod_3(GStruct4 gstruct4_0, GStruct4 gstruct4_1)
	{
		return new GStruct4(Math.Max(gstruct4_0.method_1(), gstruct4_1.method_1()), Math.Max(gstruct4_0.method_3(), gstruct4_1.method_3()));
	}

	public static Uri smethod_4(string string_7)
	{
		try
		{
			if (Uri.IsWellFormedUriString(string_7, UriKind.RelativeOrAbsolute))
			{
				return new Uri(string_7);
			}
		}
		catch
		{
		}
		return null;
	}

	public static TValue smethod_5<TKey, TValue>(IDictionary<TKey, TValue> idictionary_0, TValue gparam_0)
	{
		if (idictionary_0 != null)
		{
			using IEnumerator<KeyValuePair<TKey, TValue>> enumerator = idictionary_0.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Value;
			}
		}
		return gparam_0;
	}

	public static FileInfo smethod_6(string string_7)
	{
		try
		{
			return new FileInfo(string_7);
		}
		catch
		{
		}
		return null;
	}

	public static string smethod_7(WebClient webClient_0)
	{
		foreach (string responseHeader in webClient_0.ResponseHeaders)
		{
			if (responseHeader.Equals(Class84.smethod_0(-994286687), StringComparison.InvariantCultureIgnoreCase))
			{
				return webClient_0.ResponseHeaders[responseHeader];
			}
		}
		return null;
	}

	public static FileInfo smethod_8(Uri uri_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string absoluteUri = uri_0.AbsoluteUri;
		int num = absoluteUri.LastIndexOf('/');
		if (num == -1)
		{
			return null;
		}
		string text = absoluteUri.Substring(0, num);
		stringBuilder.Append(text.GetHashCode().ToString());
		stringBuilder.Append('_');
		string text2 = absoluteUri.Substring(num + 1);
		int num2 = text2.IndexOf('?');
		if (num2 == -1)
		{
			string value = Class84.smethod_0(-994274274);
			int num3 = text2.IndexOf('.');
			if (num3 > -1)
			{
				value = text2.Substring(num3);
				text2 = text2.Substring(0, num3);
			}
			stringBuilder.Append(text2);
			stringBuilder.Append(value);
		}
		else
		{
			int num4 = text2.IndexOf('.');
			if (num4 != -1 && num4 <= num2)
			{
				if (num2 > num4)
				{
					stringBuilder.Append(text2, 0, num4);
					stringBuilder.Append(text2, num2, text2.Length - num2);
					stringBuilder.Append(text2, num4, num2 - num4);
				}
			}
			else
			{
				stringBuilder.Append(text2);
				stringBuilder.Append(Class84.smethod_0(-994274274));
			}
		}
		string text3 = smethod_11(stringBuilder.ToString());
		if (text3.Length > 25)
		{
			text3 = text3.Substring(0, 24) + text3.Substring(24).GetHashCode() + Path.GetExtension(text3);
		}
		if (string_6 == null)
		{
			string_6 = Path.Combine(Path.GetTempPath(), Class84.smethod_0(-994286636));
			if (!Directory.Exists(string_6))
			{
				Directory.CreateDirectory(string_6);
			}
		}
		return new FileInfo(Path.Combine(string_6, text3));
	}

	public static int smethod_9(string string_7, int int_0, out int int_1)
	{
		while (int_0 < string_7.Length && char.IsWhiteSpace(string_7[int_0]))
		{
			int_0++;
		}
		if (int_0 < string_7.Length)
		{
			int i;
			for (i = int_0 + 1; i < string_7.Length && !char.IsWhiteSpace(string_7[i]); i++)
			{
			}
			int_1 = i - int_0;
			return int_0;
		}
		int_1 = 0;
		return -1;
	}

	public static bool smethod_10(string string_7, int int_0, int int_1, string string_8)
	{
		if (int_1 == string_8.Length && int_0 + int_1 <= string_7.Length)
		{
			int num = 0;
			while (true)
			{
				if (num < int_1)
				{
					if (char.ToLowerInvariant(string_7[int_0 + num]) != char.ToLowerInvariant(string_8[num]))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static string smethod_11(string string_7)
	{
		string text = string_7;
		char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
		foreach (char oldChar in invalidFileNameChars)
		{
			text = text.Replace(oldChar, '_');
		}
		return text;
	}

	public static string smethod_12(int int_0, string string_7)
	{
		if (int_0 == 0)
		{
			return string.Empty;
		}
		if (string_7.Equals(Class84.smethod_0(-994286649), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_14(int_0);
		}
		if (string_7.Equals(Class84.smethod_0(-994286615), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_15(int_0, bool_0: true);
		}
		if (string_7.Equals(Class84.smethod_0(-994286565), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_15(int_0, bool_0: false);
		}
		if (string_7.Equals(Class84.smethod_0(-994286579), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_16(int_0, string_3);
		}
		if (string_7.Equals(Class84.smethod_0(-994286532), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_16(int_0, string_2);
		}
		if (string_7.Equals(Class84.smethod_0(-994286549), StringComparison.InvariantCultureIgnoreCase))
		{
			return smethod_16(int_0, string_1);
		}
		if (!string_7.Equals(Class84.smethod_0(-994286504), StringComparison.InvariantCultureIgnoreCase) && !string_7.Equals(Class84.smethod_0(-994286505), StringComparison.InvariantCultureIgnoreCase))
		{
			if (!string_7.Equals(Class84.smethod_0(-994286468), StringComparison.InvariantCultureIgnoreCase) && !string_7.Equals(Class84.smethod_0(-994286485), StringComparison.InvariantCultureIgnoreCase))
			{
				bool bool_ = string_7.Equals(Class84.smethod_0(-994286448), StringComparison.InvariantCultureIgnoreCase) || string_7.Equals(Class84.smethod_0(-994286462), StringComparison.InvariantCultureIgnoreCase);
				return smethod_13(int_0, bool_);
			}
			return smethod_17(int_0, string_5);
		}
		return smethod_17(int_0, string_4);
	}

	private static string smethod_13(int int_0, bool bool_0)
	{
		string text = string.Empty;
		int num = (bool_0 ? 97 : 65);
		while (int_0 > 0)
		{
			int num2 = int_0 % 26 - 1;
			if (num2 >= 0)
			{
				text = (char)(num + num2) + text;
				int_0 /= 26;
			}
			else
			{
				text = (char)(num + 25) + text;
				int_0 = (int_0 - 1) / 26;
			}
		}
		return text;
	}

	private static string smethod_14(int int_0)
	{
		string text = string.Empty;
		while (int_0 > 0)
		{
			int num = int_0 % 24 - 1;
			if (num > 16)
			{
				num++;
			}
			if (num >= 0)
			{
				text = (char)(945 + num) + text;
				int_0 /= 24;
			}
			else
			{
				text = Class84.smethod_0(-994286412) + text;
				int_0 = (int_0 - 1) / 25;
			}
		}
		return text;
	}

	private static string smethod_15(int int_0, bool bool_0)
	{
		string text = string.Empty;
		int num = 1000;
		int num2 = 3;
		while (num > 0)
		{
			int num3 = int_0 / num;
			text += string.Format(string_0[num2, num3]);
			int_0 -= num3 * num;
			num /= 10;
			num2--;
		}
		if (!bool_0)
		{
			return text;
		}
		return text.ToLower();
	}

	private static string smethod_16(int int_0, string[,] string_7)
	{
		int num = 0;
		string text = string.Empty;
		while (int_0 > 0 && num < string_7.GetLength(0))
		{
			if (int_0 % 10 > 0)
			{
				text = string_7[num, int_0 % 10 - 1].ToString(CultureInfo.InvariantCulture) + text;
			}
			int_0 /= 10;
			num++;
		}
		return text;
	}

	private static string smethod_17(int int_0, string[] string_7)
	{
		for (int num = 20; num > 0; num--)
		{
			if (int_0 > 49 * num - num + 1)
			{
				int_0++;
			}
		}
		string text = string.Empty;
		while (int_0 > 0)
		{
			text = string_7[Math.Max(0, int_0 % 49 - 1)].ToString(CultureInfo.InvariantCulture) + text;
			int_0 /= 49;
		}
		return text;
	}
}
