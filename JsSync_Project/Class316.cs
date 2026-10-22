using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

internal sealed class Class316
{
	private static DataTable dataTable_0;

	public static DataTable smethod_0()
	{
		return dataTable_0;
	}

	public static void smethod_1(DataTable dataTable_1)
	{
		dataTable_0 = dataTable_1;
	}

	public static string smethod_2()
	{
		return Path.Combine(Class224.Class232.string_0, Class84.smethod_0(-994200913));
	}

	private static void smethod_3()
	{
		smethod_1(new DataTable(Class84.smethod_0(-994200879)));
		smethod_0().Columns.Add(Class84.smethod_0(-994200890), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254662), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254679), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254626), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254641), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254595), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254611), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254562), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994256547), Type.GetType(Class84.smethod_0(-994276505)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254591), Type.GetType(Class84.smethod_0(-994200846)));
		smethod_0().Columns.Add(Class84.smethod_0(-994254847), Type.GetType(Class84.smethod_0(-994276372)));
		smethod_0().Columns.Add(Class84.smethod_0(-994200808), Type.GetType(Class84.smethod_0(-994276505)));
	}

	private static void smethod_4()
	{
		Class324.smethod_0().method_57(Class324.smethod_2(), "D/>SWBkV9k", null);
	}

	public static void smethod_5()
	{
		smethod_4();
		smethod_3();
		if (!File.Exists(smethod_2()))
		{
			smethod_6();
		}
		if (!smethod_8())
		{
			smethod_6();
		}
	}

	private static void smethod_6()
	{
		DataTable dataTable = smethod_0().Clone();
		dataTable.Rows.Clear();
		smethod_7(dataTable);
	}

	private static void smethod_7(DataTable dataTable_1)
	{
		StringWriter stringWriter = new StringWriter();
		string value;
		try
		{
			dataTable_1.WriteXml((TextWriter)stringWriter, XmlWriteMode.WriteSchema);
			value = Class337.smethod_2(stringWriter.ToString(), Class224.Class234.string_0, Class224.Class234.string_1);
		}
		finally
		{
			((IDisposable)stringWriter).Dispose();
		}
		StreamWriter streamWriter = new StreamWriter(smethod_2(), append: false, Encoding.ASCII);
		try
		{
			streamWriter.WriteLine(value);
		}
		finally
		{
			((IDisposable)streamWriter).Dispose();
		}
	}

	private static bool smethod_8()
	{
		try
		{
			StreamReader streamReader = new StreamReader(smethod_2(), Encoding.ASCII);
			string string_;
			try
			{
				string_ = streamReader.ReadLine();
			}
			finally
			{
				((IDisposable)streamReader).Dispose();
			}
			StringReader stringReader = new StringReader(Class337.smethod_4(string_, Class224.Class234.string_0, Class224.Class234.string_1));
			try
			{
				smethod_0().ReadXml((TextReader)stringReader);
			}
			finally
			{
				((IDisposable)stringReader).Dispose();
			}
			if (smethod_0().Rows.Count == 0)
			{
				return false;
			}
			DataRow dataRow = smethod_0().Rows[0];
			Class348.Class352.bool_2 = true;
			Class348.Class352.string_3 = dataRow[Class84.smethod_0(-994254641)].ToString();
			Class348.Class352.string_4 = dataRow[Class84.smethod_0(-994254595)].ToString();
			Class348.Class352.string_0 = dataRow[Class84.smethod_0(-994254662)].ToString();
			Class348.Class352.string_1 = dataRow[Class84.smethod_0(-994254679)].ToString();
			Class348.Class352.string_2 = dataRow[Class84.smethod_0(-994254626)].ToString();
			Class348.Class352.string_5 = dataRow[Class84.smethod_0(-994254611)].ToString();
			Class348.Class352.string_6 = dataRow[Class84.smethod_0(-994200890)].ToString();
			Class348.Class352.int_0 = Convert.ToInt32(dataRow[Class84.smethod_0(-994254562)].ToString());
			Class348.Class352.int_1 = Class348.Class352.int_0;
			Class348.Class352.string_7 = dataRow[Class84.smethod_0(-994256547)].ToString();
			Class348.Class352.dateTime_0 = Convert.ToDateTime(dataRow[Class84.smethod_0(-994254591)]);
			Class348.Class352.int_2 = Convert.ToInt32(dataRow[Class84.smethod_0(-994254847)]);
			Class348.Class352.list_0 = smethod_9(dataRow[Class84.smethod_0(-994200808)].ToString());
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static List<List<string>> smethod_9(string string_0)
	{
		try
		{
			return JsonConvert.DeserializeObject<List<List<string>>>(string_0);
		}
		catch (Exception)
		{
			return new List<List<string>>();
		}
	}

	public static bool smethod_10(string string_0)
	{
		string text = string.Empty;
		StreamReader streamReader = new StreamReader(string_0, Encoding.ASCII);
		try
		{
			while (streamReader.Peek() >= 0)
			{
				string text2 = streamReader.ReadLine().Trim();
				if (text2.IndexOf(Class84.smethod_0(-994282651), StringComparison.Ordinal) != 0 && text2.Length != 0)
				{
					text += text2;
				}
			}
		}
		finally
		{
			((IDisposable)streamReader).Dispose();
		}
		string s = Class337.smethod_4(text, Class224.Class234.string_0, Class224.Class234.string_1);
		DataTable dataTable = new DataTable();
		StringReader stringReader = new StringReader(s);
		try
		{
			dataTable.ReadXml((TextReader)stringReader);
		}
		finally
		{
			((IDisposable)stringReader).Dispose();
		}
		if (dataTable.Rows.Count == 0)
		{
			throw new Exception(Class84.smethod_0(-994200809));
		}
		DataRow dataRow = dataTable.Rows[0];
		if (smethod_0().Rows.Count == 0)
		{
			string text3 = dataRow[Class84.smethod_0(-994254611)].ToString();
			if (text3 != Class348.Class350.string_0)
			{
				throw new Exception(Class84.smethod_0(-994200778) + text3 + Class84.smethod_0(-994271866));
			}
		}
		else
		{
			int num = Convert.ToInt32(dataRow[Class84.smethod_0(-994254847)]);
			if (num < Class348.Class352.int_2)
			{
				throw new Exception(Class84.smethod_0(-994200764));
			}
			if (num == Class348.Class352.int_2)
			{
				throw new Exception(Class84.smethod_0(-994200648));
			}
			string text4 = dataRow[Class84.smethod_0(-994254662)].ToString();
			if (!text4.Equals(Class348.Class352.string_0))
			{
				throw new Exception(Class84.smethod_0(-994200637) + text4 + Class84.smethod_0(-994271866));
			}
			string text5 = dataRow[Class84.smethod_0(-994254611)].ToString();
			if (text5 != Class348.Class350.string_0)
			{
				throw new Exception(Class84.smethod_0(-994200778) + text5 + Class84.smethod_0(-994200575));
			}
			if (DateTime.Compare(Convert.ToDateTime(dataRow[Class84.smethod_0(-994254591)]), Class348.Class350.dateTime_0) < 0)
			{
				throw new Exception(Class84.smethod_0(-994200518));
			}
			smethod_0().Rows.Clear();
		}
		Class348.Class352.bool_2 = true;
		Class348.Class352.string_3 = dataRow[Class84.smethod_0(-994254641)].ToString();
		Class348.Class352.string_4 = dataRow[Class84.smethod_0(-994254595)].ToString();
		Class348.Class352.string_0 = dataRow[Class84.smethod_0(-994254662)].ToString();
		Class348.Class352.string_1 = dataRow[Class84.smethod_0(-994254679)].ToString();
		Class348.Class352.string_2 = dataRow[Class84.smethod_0(-994254626)].ToString();
		Class348.Class352.string_5 = dataRow[Class84.smethod_0(-994254611)].ToString();
		Class348.Class352.string_6 = dataRow[Class84.smethod_0(-994200890)].ToString();
		Class348.Class352.int_0 = Convert.ToInt32(dataRow[Class84.smethod_0(-994254562)].ToString());
		Class348.Class352.int_1 = Class348.Class352.int_0;
		Class348.Class352.string_7 = dataRow[Class84.smethod_0(-994256547)].ToString();
		Class348.Class352.dateTime_0 = Convert.ToDateTime(dataRow[Class84.smethod_0(-994254591)]);
		Class348.Class352.int_2 = Convert.ToInt32(dataRow[Class84.smethod_0(-994254847)]);
		Class348.Class352.list_0 = smethod_9(dataRow[Class84.smethod_0(-994200808)].ToString());
		DataRow dataRow2 = smethod_0().NewRow();
		dataRow2[Class84.smethod_0(-994200890)] = dataRow[Class84.smethod_0(-994200890)];
		dataRow2[Class84.smethod_0(-994254662)] = dataRow[Class84.smethod_0(-994254662)];
		dataRow2[Class84.smethod_0(-994254679)] = dataRow[Class84.smethod_0(-994254679)];
		dataRow2[Class84.smethod_0(-994254626)] = dataRow[Class84.smethod_0(-994254626)];
		dataRow2[Class84.smethod_0(-994254641)] = dataRow[Class84.smethod_0(-994254641)];
		dataRow2[Class84.smethod_0(-994254595)] = dataRow[Class84.smethod_0(-994254595)];
		dataRow2[Class84.smethod_0(-994254611)] = dataRow[Class84.smethod_0(-994254611)];
		dataRow2[Class84.smethod_0(-994254562)] = dataRow[Class84.smethod_0(-994254562)];
		dataRow2[Class84.smethod_0(-994256547)] = dataRow[Class84.smethod_0(-994256547)];
		dataRow2[Class84.smethod_0(-994254591)] = dataRow[Class84.smethod_0(-994254591)];
		dataRow2[Class84.smethod_0(-994254847)] = dataRow[Class84.smethod_0(-994254847)];
		dataRow2[Class84.smethod_0(-994200808)] = dataRow[Class84.smethod_0(-994200808)];
		smethod_0().Rows.Add(dataRow2);
		smethod_7(smethod_0());
		return true;
	}

	public static void smethod_11()
	{
		try
		{
			smethod_0().Rows.Clear();
			Class348.Class352.smethod_5();
			smethod_6();
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	public static GClass70 smethod_12()
	{
		try
		{
			if (!Class348.Class352.bool_2)
			{
				return new GClass70(-1, Class84.smethod_0(-994200496));
			}
			if (!Class348.Class350.string_0.Equals(Class348.Class352.string_5))
			{
				return new GClass70(-1, Class84.smethod_0(-994200433) + Class348.Class350.string_0 + Class84.smethod_0(-994200398) + Class348.Class352.string_5 + Class84.smethod_0(-994200361));
			}
			return new GClass70(1, Class84.smethod_0(-994247224));
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class84.smethod_0(-994200330) + ex.Message);
		}
	}
}
