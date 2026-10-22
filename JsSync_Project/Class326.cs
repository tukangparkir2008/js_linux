using System.Collections.Generic;
using MySql.Data.MySqlClient;

internal sealed class Class326
{
	public string string_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public static Class326 smethod_0(string string_4)
	{
		string[] array = string_4.Split('.');
		if (array.Length != 4)
		{
			return null;
		}
		return new Class326
		{
			string_0 = array[0],
			string_1 = array[1],
			string_2 = array[2],
			string_3 = array[3]
		};
	}

	public bool method_0(MySqlConnection mySqlConnection_0, ref string string_4)
	{
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = string.Format(Class84.smethod_0(-994273635), string_2, string_3)
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string_4 = mySqlDataReader[0].ToString();
			mySqlDataReader.Close();
			return true;
		}
		string_4 = string.Empty;
		mySqlDataReader.Close();
		return false;
	}

	public bool method_1(MySqlConnection mySqlConnection_0, ref string string_4)
	{
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = string.Format(Class84.smethod_0(-994273579), string_2, string_3)
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string_4 = mySqlDataReader[0].ToString();
			mySqlDataReader.Close();
			return true;
		}
		string_4 = string.Empty;
		mySqlDataReader.Close();
		return false;
	}

	public bool method_2(MySqlConnection mySqlConnection_0, ref string string_4)
	{
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = string.Format(Class84.smethod_0(-994273524), string_2, string_3)
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string_4 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			mySqlDataReader.Close();
			return true;
		}
		mySqlDataReader.Close();
		return false;
	}

	public bool method_3(MySqlConnection mySqlConnection_0, ref List<string> list_0)
	{
		list_0.Clear();
		MySqlDataReader mySqlDataReader = new MySqlCommand
		{
			Connection = mySqlConnection_0,
			CommandText = string.Format(Class84.smethod_0(-994273298), string_2, string_3)
		}.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994277136)].ToString());
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994277142)].ToString());
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994277147)].ToString());
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994273283)].ToString());
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994277103)].ToString());
			list_0.Add(mySqlDataReader[Class84.smethod_0(-994277105)].ToString());
			mySqlDataReader.Close();
			return true;
		}
		mySqlDataReader.Close();
		return false;
	}
}
