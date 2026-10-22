using System;
using System.Text;
using System.Windows.Forms;

internal static class Class189
{
	private static readonly char[] char_0 = new char[1];

	public static DataObject smethod_0(string string_0, string string_1)
	{
		string_0 = string_0 ?? string.Empty;
		string text = smethod_3(string_0);
		if (Environment.Version.Major < 4 && string_0.Length != Encoding.UTF8.GetByteCount(string_0))
		{
			text = Encoding.Default.GetString(Encoding.UTF8.GetBytes(text));
		}
		DataObject dataObject = new DataObject();
		dataObject.SetData(DataFormats.Html, text);
		dataObject.SetData(DataFormats.Text, string_1);
		dataObject.SetData(DataFormats.UnicodeText, string_1);
		return dataObject;
	}

	public static void smethod_1(string string_0, string string_1)
	{
		Clipboard.SetDataObject(smethod_0(string_0, string_1), copy: true);
	}

	public static void smethod_2(string string_0)
	{
		DataObject dataObject = new DataObject();
		dataObject.SetData(DataFormats.Text, string_0);
		dataObject.SetData(DataFormats.UnicodeText, string_0);
		Clipboard.SetDataObject(dataObject, copy: true);
	}

	private static string smethod_3(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Class84.smethod_0(-994208473));
		stringBuilder.AppendLine();
		stringBuilder.AppendLine(Class84.smethod_0(-994208351));
		int num = string_0.IndexOf(Class84.smethod_0(-994285735), StringComparison.OrdinalIgnoreCase);
		int num2 = string_0.LastIndexOf(Class84.smethod_0(-994285670), StringComparison.OrdinalIgnoreCase);
		int num3 = string_0.IndexOf(Class84.smethod_0(-994208282), StringComparison.OrdinalIgnoreCase);
		int num4 = ((num3 > -1) ? (string_0.IndexOf('>', num3) + 1) : (-1));
		int num5 = string_0.LastIndexOf(Class84.smethod_0(-994208238), StringComparison.OrdinalIgnoreCase);
		int num8;
		int num9;
		if (num < 0 && num2 < 0)
		{
			int num6 = string_0.IndexOf(Class84.smethod_0(-994208241), StringComparison.OrdinalIgnoreCase);
			int num7 = ((num6 > -1) ? (string_0.IndexOf('>', num6) + 1) : (-1));
			if (num4 < 0 && num7 < 0)
			{
				stringBuilder.Append(Class84.smethod_0(-994208197));
				stringBuilder.Append(Class84.smethod_0(-994285735));
				num8 = smethod_4(stringBuilder, 0, -1);
				stringBuilder.Append(string_0);
				num9 = smethod_4(stringBuilder, 0, -1);
				stringBuilder.Append(Class84.smethod_0(-994285670));
				stringBuilder.Append(Class84.smethod_0(-994208210));
			}
			else
			{
				int num10 = string_0.LastIndexOf(Class84.smethod_0(-994208173), StringComparison.OrdinalIgnoreCase);
				if (num4 < 0)
				{
					stringBuilder.Append(Class84.smethod_0(-994208192));
				}
				else
				{
					stringBuilder.Append(string_0, 0, num4);
				}
				if (num7 > -1)
				{
					stringBuilder.Append(string_0, (num4 > -1) ? num4 : 0, num7 - ((num4 > -1) ? num4 : 0));
				}
				stringBuilder.Append(Class84.smethod_0(-994285735));
				num8 = smethod_4(stringBuilder, 0, -1);
				int num11 = ((num7 > -1) ? num7 : ((num4 > -1) ? num4 : 0));
				int num12;
				if (num10 > -1)
				{
					num12 = num10;
				}
				else
				{
					num12 = ((num5 > -1) ? num5 : string_0.Length);
				}
				stringBuilder.Append(string_0, num11, num12 - num11);
				num9 = smethod_4(stringBuilder, 0, -1);
				stringBuilder.Append(Class84.smethod_0(-994285670));
				if (num12 < string_0.Length)
				{
					stringBuilder.Append(string_0, num12, string_0.Length - num12);
				}
				if (num5 < 0)
				{
					stringBuilder.Append(Class84.smethod_0(-994208131));
				}
			}
		}
		else
		{
			if (num4 < 0)
			{
				stringBuilder.Append(Class84.smethod_0(-994208192));
			}
			int num13 = smethod_4(stringBuilder, 0, -1);
			stringBuilder.Append(string_0);
			num8 = num13 + smethod_4(stringBuilder, num13, num13 + num) + 20;
			num9 = num13 + smethod_4(stringBuilder, num13, num13 + num2);
			if (num5 < 0)
			{
				stringBuilder.Append(Class84.smethod_0(-994208131));
			}
		}
		stringBuilder.Replace(Class84.smethod_0(-994208149), 143.ToString(Class84.smethod_0(-994208101)), 0, 143);
		stringBuilder.Replace(Class84.smethod_0(-994208108), smethod_4(stringBuilder, 0, -1).ToString(Class84.smethod_0(-994208101)), 0, 143);
		stringBuilder.Replace(Class84.smethod_0(-994208124), num8.ToString(Class84.smethod_0(-994208101)), 0, 143);
		stringBuilder.Replace(Class84.smethod_0(-994208076), num9.ToString(Class84.smethod_0(-994208101)), 0, 143);
		return stringBuilder.ToString();
	}

	private static int smethod_4(StringBuilder stringBuilder_0, int int_0, int int_1)
	{
		int num = 0;
		int_1 = ((int_1 > -1) ? int_1 : stringBuilder_0.Length);
		for (int i = int_0; i < int_1; i++)
		{
			char_0[0] = stringBuilder_0[i];
			num += Encoding.UTF8.GetByteCount(char_0);
		}
		return num;
	}
}
