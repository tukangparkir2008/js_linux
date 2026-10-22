using System;
using System.Data;
using System.Diagnostics;
using System.IO;

public sealed class GClass20
{
	private static readonly Random random_0 = new Random();

	private static string smethod_0()
	{
		string text2;
		do
		{
			string text = string.Empty;
			for (int i = 0; i < 12; i++)
			{
				int startIndex = random_0.Next(0, 36);
				text += Class84.smethod_0(-994212604).Substring(startIndex, 1);
			}
			text += Class84.smethod_0(-994213407);
			text2 = Path.Combine(Class224.Class232.string_1, text);
		}
		while (File.Exists(text2));
		return text2;
	}

	private static string smethod_1(string string_0)
	{
		return Class84.smethod_0(-994293038) + string_0.Trim().Replace(Class84.smethod_0(-994293038), Class84.smethod_0(-994212489)) + Class84.smethod_0(-994293038);
	}

	public static void smethod_2(string[] string_0, DataTable dataTable_0)
	{
		string text = smethod_0();
		StreamWriter streamWriter = new StreamWriter(text, append: false);
		string text2 = string.Empty;
		foreach (string string_1 in string_0)
		{
			if (text2 != string.Empty)
			{
				text2 += Class84.smethod_0(-994279022);
			}
			text2 += smethod_1(string_1);
		}
		streamWriter.WriteLine(text2);
		foreach (DataRow row in dataTable_0.Rows)
		{
			text2 = string.Empty;
			foreach (DataColumn column in dataTable_0.Columns)
			{
				if (text2 != string.Empty)
				{
					text2 += Class84.smethod_0(-994279022);
				}
				text2 += smethod_1(Convert.ToString(row[column]));
			}
			streamWriter.WriteLine(text2);
		}
		streamWriter.Close();
		Process.Start(text);
	}
}
