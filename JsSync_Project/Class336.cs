using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using MySql.Data.MySqlClient;

internal sealed class Class336
{
	private static MySqlCommand mySqlCommand_0;

	private static MySqlCommand mySqlCommand_1;

	public static void smethod_0()
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
		}
		catch (Exception)
		{
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_1(string string_0, string string_1, string string_2, string string_3)
	{
		smethod_2(string_0, string_1, string_2, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string_3);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_2(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8)
	{
	}

	private static string smethod_3(Exception exception_0)
	{
		if (exception_0 == null)
		{
			return string.Empty;
		}
		StackFrame[] frames = new StackTrace(exception_0, fNeedFileInfo: true).GetFrames();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(exception_0.Message);
		StackFrame[] array = frames;
		foreach (StackFrame stackFrame in array)
		{
			if (stackFrame.GetFileLineNumber() >= 1)
			{
				stringBuilder.Append(Class84.smethod_0(-994542353) + stackFrame.GetFileName());
				stringBuilder.Append(Class84.smethod_0(-994542308) + stackFrame.GetMethod().Name);
				stringBuilder.AppendLine(Class84.smethod_0(-994542323) + stackFrame.GetFileLineNumber());
			}
		}
		return stringBuilder.ToString();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_4(string string_0, Exception exception_0)
	{
		smethod_5(string.Empty, string.Empty, string.Empty, string.Empty, string_0, exception_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void smethod_5(string string_0, string string_1, string string_2, string string_3, string string_4, Exception exception_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			if (mySqlCommand_1 == null)
			{
				string commandText = Class84.smethod_0(-994542286);
				mySqlCommand_1 = new MySqlCommand
				{
					Connection = mySqlConnection,
					CommandText = commandText
				};
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542121), MySqlDbType.VarChar);
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542088), MySqlDbType.VarChar);
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542104), MySqlDbType.VarChar);
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542106), MySqlDbType.VarChar);
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542060), MySqlDbType.VarChar);
				mySqlCommand_1.Parameters.Add(Class84.smethod_0(-994542080), MySqlDbType.VarChar);
			}
			mySqlCommand_1.Connection = mySqlConnection;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542121)].Value = string_0 ?? string.Empty;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542088)].Value = string_1 ?? string.Empty;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542104)].Value = string_2 ?? string.Empty;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542106)].Value = string_3 ?? string.Empty;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542060)].Value = string_4 ?? string.Empty;
			mySqlCommand_1.Parameters[Class84.smethod_0(-994542080)].Value = smethod_3(exception_0);
			mySqlCommand_1.ExecuteNonQuery();
		}
		catch (Exception)
		{
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
