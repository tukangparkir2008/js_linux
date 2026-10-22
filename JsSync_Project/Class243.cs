using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

internal sealed class Class243
{
	public static int smethod_0(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2, string string_3, string string_4, bool bool_0, bool bool_1, bool bool_2)
	{
		try
		{
			int num = 0;
			if (bool_2)
			{
				List<string> list = new List<string>();
				string commandText = Class84.smethod_0(-994200112) + string_1 + Class84.smethod_0(-994200012) + string_0 + Class84.smethod_0(-994200017);
				mySqlCommand_0.CommandText = commandText;
				MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					list.Add(mySqlDataReader[0].ToString());
				}
				mySqlDataReader.Close();
				if (list.Count > 0)
				{
					smethod_1(mySqlCommand_0, string_0, string_1, string_2, string_3, string_4, list);
					num += list.Count;
				}
			}
			if (bool_1)
			{
				List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
				string commandText2 = Class84.smethod_0(-994199924) + string_1 + Class84.smethod_0(-994200012) + string_0 + Class84.smethod_0(-994199794);
				mySqlCommand_0.CommandText = commandText2;
				MySqlDataReader mySqlDataReader2 = mySqlCommand_0.ExecuteReader();
				while (mySqlDataReader2.Read())
				{
					list2.Add(new Tuple<string, string>(mySqlDataReader2[0].ToString(), mySqlDataReader2[1].ToString()));
				}
				mySqlDataReader2.Close();
				if (list2.Count > 0)
				{
					smethod_2(mySqlCommand_0, string_3, string_4, list2);
					num += list2.Count;
				}
			}
			int result = 0;
			if (bool_0)
			{
				List<string> list3 = new List<string>();
				string format = Class84.smethod_0(-994199735);
				format = string.Format(format, string_0);
				mySqlCommand_0.CommandText = format;
				MySqlDataReader mySqlDataReader3 = mySqlCommand_0.ExecuteReader();
				if (mySqlDataReader3.Read())
				{
					string text = Convert.ToString(mySqlDataReader3[Class84.smethod_0(-994203618)]);
					if (text.Length >= 7 && text.IndexOf(Class84.smethod_0(-994282651), StringComparison.Ordinal) < 0)
					{
						list3.Add(text);
					}
					text = Convert.ToString(mySqlDataReader3[Class84.smethod_0(-994203637)]);
					if (text.Length >= 7 && text.IndexOf(Class84.smethod_0(-994282651), StringComparison.Ordinal) < 0)
					{
						list3.Add(text);
					}
					text = Convert.ToString(mySqlDataReader3[Class84.smethod_0(-994203641)]);
					if (text.Length >= 7 && text.IndexOf(Class84.smethod_0(-994282651), StringComparison.Ordinal) < 0)
					{
						list3.Add(text);
					}
				}
				mySqlDataReader3.Close();
				if (list3.Count == 0)
				{
					return 0;
				}
				smethod_3(mySqlCommand_0, string_3, string_4, list3);
				result = list3.Count;
			}
			return result;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return 0;
		}
	}

	private static void smethod_1(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2, string string_3, string string_4, List<string> list_0)
	{
		string text = JsonConvert.SerializeObject(list_0);
		string format = Class84.smethod_0(-994203597);
		format = string.Format(format, text, string_2, string_3, string_4);
		mySqlCommand_0.CommandText = format;
		mySqlCommand_0.ExecuteNonQuery();
		format = Class84.smethod_0(-994203440);
		format = string.Format(format, string_1, string_0, string_3, string_4, string_2);
		mySqlCommand_0.CommandText = format;
		mySqlCommand_0.ExecuteNonQuery();
		format = Class84.smethod_0(-994203269);
		format = string.Format(format, string_1, string_0, string_3, string_4, string_2);
		mySqlCommand_0.CommandText = format;
		mySqlCommand_0.ExecuteNonQuery();
	}

	private static void smethod_2(MySqlCommand mySqlCommand_0, string string_0, string string_1, List<Tuple<string, string>> list_0)
	{
		string empty = string.Empty;
		foreach (Tuple<string, string> item2 in list_0)
		{
			string text = item2.Item1.Replace('\'', '`');
			string item = item2.Item2;
			empty = Class84.smethod_0(-994203107);
			empty = string.Format(empty, item, text, string_0, string_1);
			mySqlCommand_0.CommandText = empty;
			mySqlCommand_0.ExecuteNonQuery();
			empty = Class84.smethod_0(-994260596);
			mySqlCommand_0.CommandText = empty;
			int num = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
			empty = Class84.smethod_0(-994202932);
			empty = string.Format(empty, num, item, text, string_0, string_1);
			mySqlCommand_0.CommandText = empty;
			mySqlCommand_0.ExecuteNonQuery();
		}
	}

	private static void smethod_3(MySqlCommand mySqlCommand_0, string string_0, string string_1, List<string> list_0)
	{
		int num = 0;
		string commandText = Class84.smethod_0(-994202720);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		if (num == 0)
		{
			commandText = Class84.smethod_0(-994202504);
			mySqlCommand_0.CommandText = string.Format(commandText, string_1);
			mySqlCommand_0.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994260596);
			mySqlCommand_0.CommandText = commandText;
			num = Convert.ToInt32(mySqlCommand_0.ExecuteScalar());
		}
		foreach (string item in list_0)
		{
			commandText = Class84.smethod_0(-994202321);
			commandText = string.Format(commandText, string_0, item, num);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994201891);
			commandText = string.Format(commandText, string_0, item, num);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
		}
	}
}
