using System;
using System.Globalization;

internal sealed class Class172
{
	private readonly GClass0 gclass0_0;

	public Class172(GClass0 gclass0_1)
	{
		GClass24.smethod_1(gclass0_1, Class84.smethod_0(-994290092));
		gclass0_0 = gclass0_1;
	}

	public static bool smethod_0(string string_0, int int_0, int int_1)
	{
		if (int_1 < 1)
		{
			return false;
		}
		bool flag = false;
		int num = 0;
		while (true)
		{
			if (num < int_1)
			{
				if (string_0[int_0 + num] == '.')
				{
					if (flag)
					{
						return false;
					}
					flag = true;
				}
				else if (!char.IsDigit(string_0[int_0 + num]))
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

	public static bool smethod_1(string string_0, int int_0, int int_1)
	{
		if (int_1 < 1)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < int_1)
			{
				if (!char.IsDigit(string_0[int_0 + num]))
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

	public static bool smethod_2(string string_0)
	{
		if (string_0.Length > 1)
		{
			string s = string.Empty;
			if (string_0.EndsWith(Class84.smethod_0(-994264352)))
			{
				s = string_0.Substring(0, string_0.Length - 1);
			}
			else if (string_0.Length > 2)
			{
				s = string_0.Substring(0, string_0.Length - 2);
			}
			double result;
			return double.TryParse(s, out result);
		}
		return false;
	}

	public static double smethod_3(string string_0, double double_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return 0.0;
		}
		string s = string_0;
		bool flag;
		if (flag = string_0.EndsWith(Class84.smethod_0(-994264352)))
		{
			s = string_0.Substring(0, string_0.Length - 1);
		}
		if (!double.TryParse(s, NumberStyles.Number, NumberFormatInfo.InvariantInfo, out var result))
		{
			return 0.0;
		}
		if (flag)
		{
			return result / 100.0 * double_0;
		}
		return result;
	}

	public static double smethod_4(string string_0, double double_0, Class196 class196_0, bool bool_0)
	{
		return smethod_6(string_0, double_0, class196_0.method_181(), null, bool_0, bool_1: false);
	}

	public static double smethod_5(string string_0, double double_0, Class196 class196_0, string string_1)
	{
		return smethod_6(string_0, double_0, class196_0.method_181(), string_1, bool_0: false, bool_1: false);
	}

	public static double smethod_6(string string_0, double double_0, double double_1, string string_1, bool bool_0, bool bool_1)
	{
		string string_2;
		double num;
		if (!string.IsNullOrEmpty(string_0) && !(string_0 == Class84.smethod_0(-994274584)))
		{
			if (string_0.EndsWith(Class84.smethod_0(-994264352)))
			{
				return smethod_3(string_0, double_0);
			}
			string text = smethod_7(string_0, string_1, out var bool_2);
			string_2 = (bool_2 ? string_0.Substring(0, string_0.Length - 2) : string_0);
			if (text != null)
			{
				int length = text.Length;
				if (length == 2)
				{
					char c = text[0];
					if ((uint)c <= 101u)
					{
						if (c != 'c')
						{
							if (c != 'e')
							{
								goto IL_01af;
							}
							if (!(text == Class84.smethod_0(-994292181)))
							{
								if (!(text == Class84.smethod_0(-994295577)))
								{
									goto IL_01af;
								}
								num = double_1 / 2.0;
							}
							else
							{
								num = double_1;
							}
						}
						else
						{
							if (!(text == Class84.smethod_0(-994295493)))
							{
								goto IL_01af;
							}
							num = 37.7952766418457;
						}
					}
					else if (c != 'i')
					{
						if (c != 'm')
						{
							if (c != 'p')
							{
								goto IL_01af;
							}
							if (!(text == Class84.smethod_0(-994295536)))
							{
								if (!(text == Class84.smethod_0(-994292141)))
								{
									if (!(text == Class84.smethod_0(-994295543)))
									{
										goto IL_01af;
									}
									num = 16.0;
								}
								else
								{
									num = 1.3333333730697632;
									if (bool_1)
									{
										return smethod_3(string_2, double_0);
									}
								}
							}
							else
							{
								num = (bool_0 ? 0.75f : 1f);
							}
						}
						else
						{
							if (!(text == Class84.smethod_0(-994295550)))
							{
								goto IL_01af;
							}
							num = 3.7795276641845703;
						}
					}
					else
					{
						if (!(text == Class84.smethod_0(-994295500)))
						{
							goto IL_01af;
						}
						num = 96.0;
					}
					goto IL_01b9;
				}
			}
			goto IL_01af;
		}
		return 0.0;
		IL_01b9:
		return num * smethod_3(string_2, double_0);
		IL_01af:
		num = 0.0;
		goto IL_01b9;
	}

	private static string smethod_7(string string_0, string string_1, out bool bool_0)
	{
		string text = ((string_0.Length >= 3) ? string_0.Substring(string_0.Length - 2, 2) : string.Empty);
		if (text != null)
		{
			int length = text.Length;
			if (length == 2)
			{
				char c = text[0];
				if ((uint)c <= 101u)
				{
					if (c != 'c')
					{
						if (c == 'e' && (text == Class84.smethod_0(-994292181) || text == Class84.smethod_0(-994295577)))
						{
							goto IL_0102;
						}
					}
					else if (text == Class84.smethod_0(-994295493))
					{
						goto IL_0102;
					}
				}
				else if (c != 'i')
				{
					if (c != 'm')
					{
						if (c == 'p' && (text == Class84.smethod_0(-994295536) || text == Class84.smethod_0(-994292141) || text == Class84.smethod_0(-994295543)))
						{
							goto IL_0102;
						}
					}
					else if (text == Class84.smethod_0(-994295550))
					{
						goto IL_0102;
					}
				}
				else if (text == Class84.smethod_0(-994295500))
				{
					goto IL_0102;
				}
			}
		}
		bool_0 = false;
		text = string_1 ?? string.Empty;
		goto IL_0115;
		IL_0115:
		return text;
		IL_0102:
		bool_0 = true;
		goto IL_0115;
	}

	public bool method_0(string string_0)
	{
		GStruct3 gstruct3_;
		return method_2(string_0, 0, string_0.Length, out gstruct3_);
	}

	public GStruct3 method_1(string string_0)
	{
		method_2(string_0, 0, string_0.Length, out var gstruct3_);
		return gstruct3_;
	}

	public bool method_2(string string_0, int int_0, int int_1, out GStruct3 gstruct3_0)
	{
		try
		{
			if (!string.IsNullOrEmpty(string_0))
			{
				if (int_1 > 1 && string_0[int_0] == '#')
				{
					return smethod_9(string_0, int_0, int_1, out gstruct3_0);
				}
				if (int_1 > 10 && Class299.smethod_10(string_0, int_0, 4, Class84.smethod_0(-994285135)) && string_0[int_1 - 1] == ')')
				{
					return smethod_10(string_0, int_0, int_1, out gstruct3_0);
				}
				if (int_1 > 13 && Class299.smethod_10(string_0, int_0, 5, Class84.smethod_0(-994285140)) && string_0[int_1 - 1] == ')')
				{
					return smethod_11(string_0, int_0, int_1, out gstruct3_0);
				}
				return method_3(string_0, int_0, int_1, out gstruct3_0);
			}
		}
		catch
		{
		}
		gstruct3_0 = GStruct3.smethod_1();
		return false;
	}

	public static double smethod_8(string string_0, Class196 class196_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return smethod_8(Class84.smethod_0(-994292335), class196_0);
		}
		if (!(string_0 == Class84.smethod_0(-994285196)))
		{
			if (!(string_0 == Class84.smethod_0(-994292335)))
			{
				if (!(string_0 == Class84.smethod_0(-994285201)))
				{
					return Math.Abs(smethod_4(string_0, 1.0, class196_0, bool_0: false));
				}
				return 4.0;
			}
			return 2.0;
		}
		return 1.0;
	}

	private static bool smethod_9(string string_0, int int_0, int int_1, out GStruct3 gstruct3_0)
	{
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		switch (int_1)
		{
		case 7:
			num = smethod_14(string_0, int_0 + 1, 2);
			num2 = smethod_14(string_0, int_0 + 3, 2);
			num3 = smethod_14(string_0, int_0 + 5, 2);
			break;
		case 4:
			num = smethod_14(string_0, int_0 + 1, 1);
			num = num * 16 + num;
			num2 = smethod_14(string_0, int_0 + 2, 1);
			num2 = num2 * 16 + num2;
			num3 = smethod_14(string_0, int_0 + 3, 1);
			num3 = num3 * 16 + num3;
			break;
		}
		if (num > -1 && num2 > -1 && num3 > -1)
		{
			gstruct3_0 = GStruct3.smethod_6(num, num2, num3);
			return true;
		}
		gstruct3_0 = GStruct3.gstruct3_0;
		return false;
	}

	private static bool smethod_10(string string_0, int int_0, int int_1, out GStruct3 gstruct3_0)
	{
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		if (int_1 > 10)
		{
			int int_2 = int_0 + 4;
			num = smethod_12(string_0, ref int_2);
			if (int_2 < int_0 + int_1)
			{
				num2 = smethod_12(string_0, ref int_2);
			}
			if (int_2 < int_0 + int_1)
			{
				num3 = smethod_12(string_0, ref int_2);
			}
		}
		if (num > -1 && num2 > -1 && num3 > -1)
		{
			gstruct3_0 = GStruct3.smethod_6(num, num2, num3);
			return true;
		}
		gstruct3_0 = GStruct3.gstruct3_0;
		return false;
	}

	private static bool smethod_11(string string_0, int int_0, int int_1, out GStruct3 gstruct3_0)
	{
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		int num4 = -1;
		if (int_1 > 13)
		{
			int int_2 = int_0 + 5;
			num = smethod_12(string_0, ref int_2);
			if (int_2 < int_0 + int_1)
			{
				num2 = smethod_12(string_0, ref int_2);
			}
			if (int_2 < int_0 + int_1)
			{
				num3 = smethod_12(string_0, ref int_2);
			}
			if (int_2 < int_0 + int_1)
			{
				num4 = smethod_12(string_0, ref int_2);
			}
		}
		if (num > -1 && num2 > -1 && num3 > -1 && num4 > -1)
		{
			gstruct3_0 = GStruct3.smethod_5(num4, num, num2, num3);
			return true;
		}
		gstruct3_0 = GStruct3.gstruct3_0;
		return false;
	}

	private bool method_3(string string_0, int int_0, int int_1, out GStruct3 gstruct3_0)
	{
		gstruct3_0 = gclass0_0.method_1(string_0.Substring(int_0, int_1));
		return gstruct3_0.method_3() > 0;
	}

	private static int smethod_12(string string_0, ref int int_0)
	{
		int i = 0;
		while (char.IsWhiteSpace(string_0, int_0))
		{
			int_0++;
		}
		for (; char.IsDigit(string_0, int_0 + i); i++)
		{
		}
		int result = smethod_13(string_0, int_0, i);
		int_0 = int_0 + i + 1;
		return result;
	}

	private static int smethod_13(string string_0, int int_0, int int_1)
	{
		if (int_1 < 1)
		{
			return -1;
		}
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < int_1)
			{
				int num3 = string_0[int_0 + num2];
				if (num3 < 48 || num3 > 57)
				{
					break;
				}
				num = num * 10 + num3 - 48;
				num2++;
				continue;
			}
			return num;
		}
		return -1;
	}

	private static int smethod_14(string string_0, int int_0, int int_1)
	{
		if (int_1 < 1)
		{
			return -1;
		}
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < int_1)
			{
				int num3 = string_0[int_0 + num2];
				if ((num3 < 48 || num3 > 57) && (num3 < 65 || num3 > 70) && (num3 < 97 || num3 > 102))
				{
					break;
				}
				num = num * 16 + ((num3 <= 57) ? (num3 - 48) : (10 + num3 - ((num3 <= 70) ? 65 : 97)));
				num2++;
				continue;
			}
			return num;
		}
		return -1;
	}
}
