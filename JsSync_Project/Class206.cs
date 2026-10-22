using System;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;

internal sealed class Class206
{
	private static string string_0 = Class84.smethod_0(-994274987);

	public static void smethod_0()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			smethod_1(new MySqlCommand
			{
				Connection = mySqlConnection
			});
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_1(MySqlCommand mySqlCommand_0)
	{
		smethod_2(mySqlCommand_0);
		smethod_5(mySqlCommand_0);
		smethod_3(mySqlCommand_0);
		smethod_6(mySqlCommand_0);
		smethod_4(mySqlCommand_0);
	}

	private static void smethod_2(MySqlCommand mySqlCommand_0)
	{
		mySqlCommand_0.CommandText = Class84.smethod_0(-994557562);
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			string_0 = Class84.smethod_0(-994267367) + mySqlDataReader[Class84.smethod_0(-994557373)]?.ToString() + Class84.smethod_0(-994267375);
		}
		mySqlDataReader.Close();
	}

	private static void smethod_3(MySqlCommand mySqlCommand_0)
	{
		mySqlCommand_0.CommandText = Class84.smethod_0(-994557326);
		DataTable dataTable = new DataTable();
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		mySqlDataAdapter.Fill(dataTable);
		string format = Class84.smethod_0(-994557055);
		string format2 = Class84.smethod_0(-994556927);
		foreach (DataRow row in dataTable.Rows)
		{
			string arg = row[Class84.smethod_0(-994253701)].ToString();
			int num = Convert.ToInt32(row[Class84.smethod_0(-994264701)]);
			string arg2 = Class84.smethod_0(-994267367) + row[Class84.smethod_0(-994249543)]?.ToString() + Class84.smethod_0(-994267375);
			mySqlCommand_0.CommandText = string.Format(format, arg);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
			{
				if (num == 1)
				{
					mySqlCommand_0.CommandText = string.Format(format2, arg, string_0);
				}
				else
				{
					mySqlCommand_0.CommandText = string.Format(format2, arg, arg2);
				}
			}
			mySqlCommand_0.ExecuteNonQuery();
		}
	}

	private static void smethod_4(MySqlCommand mySqlCommand_0)
	{
		mySqlCommand_0.CommandText = Class84.smethod_0(-994556720);
		DataTable dataTable = new DataTable();
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		mySqlDataAdapter.Fill(dataTable);
		string format = Class84.smethod_0(-994556447);
		string format2 = Class84.smethod_0(-994556319);
		foreach (DataRow row in dataTable.Rows)
		{
			string arg = row[Class84.smethod_0(-994253701)].ToString();
			int num = Convert.ToInt32(row[Class84.smethod_0(-994264701)]);
			string arg2 = Class84.smethod_0(-994267367) + row[Class84.smethod_0(-994249543)]?.ToString() + Class84.smethod_0(-994267375);
			mySqlCommand_0.CommandText = string.Format(format, arg);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
			{
				if (num == 1)
				{
					mySqlCommand_0.CommandText = string.Format(format2, arg, string_0);
				}
				else
				{
					mySqlCommand_0.CommandText = string.Format(format2, arg, arg2);
				}
			}
			mySqlCommand_0.ExecuteNonQuery();
		}
	}

	private static void smethod_5(MySqlCommand mySqlCommand_0)
	{
		string commandText = Class84.smethod_0(-994557562);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		string arg = Class84.smethod_0(-994274987);
		if (mySqlDataReader.Read())
		{
			arg = Class84.smethod_0(-994267367) + mySqlDataReader[Class84.smethod_0(-994557373)]?.ToString() + Class84.smethod_0(-994267375);
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994556112);
		mySqlCommand_0.CommandText = commandText;
		DataTable dataTable = new DataTable();
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		mySqlDataAdapter.Fill(dataTable);
		string format = Class84.smethod_0(-994555953);
		string format2 = Class84.smethod_0(-994543537);
		foreach (DataRow row in dataTable.Rows)
		{
			string arg2 = row[Class84.smethod_0(-994253701)].ToString();
			mySqlCommand_0.CommandText = string.Format(format, arg2);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
			{
				mySqlCommand_0.CommandText = string.Format(format2, arg2, arg);
				mySqlCommand_0.ExecuteNonQuery();
			}
		}
	}

	private static void smethod_6(MySqlCommand mySqlCommand_0)
	{
		mySqlCommand_0.CommandText = Class84.smethod_0(-994543330);
		DataTable dataTable = new DataTable();
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
		mySqlDataAdapter.SelectCommand = mySqlCommand_0;
		mySqlDataAdapter.Fill(dataTable);
		string format = Class84.smethod_0(-994543104);
		string format2 = Class84.smethod_0(-994542976);
		foreach (DataRow row in dataTable.Rows)
		{
			string arg = row[Class84.smethod_0(-994266832)].ToString();
			string arg2 = Class84.smethod_0(-994267367) + row[Class84.smethod_0(-994557373)]?.ToString() + Class84.smethod_0(-994267375);
			mySqlCommand_0.CommandText = string.Format(format, arg);
			if (Convert.ToInt32(mySqlCommand_0.ExecuteScalar()) == 0)
			{
				mySqlCommand_0.CommandText = string.Format(format2, arg, arg2);
				mySqlCommand_0.ExecuteNonQuery();
			}
		}
	}
}
