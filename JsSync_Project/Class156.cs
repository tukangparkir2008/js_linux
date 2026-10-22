using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;

internal sealed class Class156
{
	private readonly MySqlCommand mySqlCommand_0;

	public Class156(MySqlCommand mySqlCommand_1)
	{
		mySqlCommand_0 = mySqlCommand_1;
	}

	public bool method_0(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		return method_1(new List<string> { string_0 }, string_1, string_2, string_3, string_4);
	}

	public bool method_1(List<string> list_0, string string_0, string string_1, string string_2, string string_3)
	{
		try
		{
			foreach (string item in list_0)
			{
				mySqlCommand_0.CommandText = Class84.smethod_0(-994099910);
				mySqlCommand_0.Parameters.Clear();
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099749), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099766), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099717), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099734), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099686), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099703), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099749)].Value = string_3;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099766)].Value = string.Empty;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099717)].Value = item;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099734)].Value = string_0;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099686)].Value = string_1;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099703)].Value = string_2;
				mySqlCommand_0.ExecuteNonQuery();
			}
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	public bool method_2(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		return method_3(new List<string> { string_0 }, string_1, string_2, string_3, string_4);
	}

	public bool method_3(List<string> list_0, string string_0, string string_1, string string_2, string string_3)
	{
		try
		{
			foreach (string item in list_0)
			{
				mySqlCommand_0.CommandText = Class84.smethod_0(-994099910);
				mySqlCommand_0.Parameters.Clear();
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099749), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099766), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099717), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099734), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099686), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099703), MySqlDbType.VarChar);
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099749)].Value = string_3;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099766)].Value = item;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099717)].Value = string.Empty;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099734)].Value = string_0;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099686)].Value = string_1;
				mySqlCommand_0.Parameters[Class84.smethod_0(-994099703)].Value = string_2;
				mySqlCommand_0.ExecuteNonQuery();
			}
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}

	public bool method_4(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
	{
		try
		{
			string commandText = Class84.smethod_0(-994099654);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.Parameters.Clear();
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994130413), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994130418), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099512), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099717), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099517), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099472), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099473), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters.Add(Class84.smethod_0(-994099427), MySqlDbType.VarChar);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994130413)].Value = (string_0.Equals(string.Empty) ? null : string_0);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994130418)].Value = (string_1.Equals(string.Empty) ? null : string_1);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099512)].Value = (string_2.Equals(string.Empty) ? null : string_2);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099717)].Value = (string_3.Equals(string.Empty) ? null : string_3);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099517)].Value = string_4;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099472)].Value = string_5;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099473)].Value = string_6;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099427)].Value = string_7;
			mySqlCommand_0.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994099442);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994130413)].Value = (string_0.Equals(string.Empty) ? null : string_0);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994130418)].Value = (string_1.Equals(string.Empty) ? null : string_1);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099512)].Value = (string_2.Equals(string.Empty) ? null : string_2);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099717)].Value = (string_3.Equals(string.Empty) ? null : string_3);
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099517)].Value = string_4;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099472)].Value = string_5;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099473)].Value = string_6;
			mySqlCommand_0.Parameters[Class84.smethod_0(-994099427)].Value = string_7;
			mySqlCommand_0.ExecuteNonQuery();
			return true;
		}
		catch (Exception ex)
		{
			Class125.smethod_0(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return false;
		}
	}
}
