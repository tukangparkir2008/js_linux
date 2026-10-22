using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

internal sealed class Class280
{
	private static readonly List<string> list_0 = new List<string>();

	public static MySqlConnection smethod_0(string string_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(string_0);
		mySqlConnection.Open();
		return mySqlConnection;
	}

	public static void smethod_1(MySqlConnection mySqlConnection_0, string string_0)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection_0;
			mySqlCommand.CommandText = string_0;
			mySqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542476), ex.Message, ex);
			throw;
		}
	}

	public static void smethod_2(string string_0)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.CommandText = string_0;
			mySqlCommand.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542476), ex.Message, ex);
			throw;
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	public static object smethod_3(MySqlConnection mySqlConnection_0, string string_0, object object_0)
	{
		try
		{
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection_0,
				CommandText = string_0
			}.ExecuteReader();
			object result = (mySqlDataReader.Read() ? mySqlDataReader[0] : object_0);
			mySqlDataReader.Close();
			return result;
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542456), ex.Message, ex);
			throw;
		}
	}

	public static object smethod_4(MySqlConnection mySqlConnection_0, string string_0)
	{
		try
		{
			return new MySqlCommand
			{
				Connection = mySqlConnection_0,
				CommandText = string_0
			}.ExecuteScalar();
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542456), ex.Message, ex);
			throw;
		}
	}

	public static object smethod_5(string string_0)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			return new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = string_0
			}.ExecuteScalar();
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542456), ex.Message, ex);
			throw;
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	public static DataTable smethod_6(MySqlConnection mySqlConnection_0, string string_0)
	{
		try
		{
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(string_0, mySqlConnection_0);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542422), ex.Message, ex);
			throw;
		}
	}

	public static DataTable smethod_7(string string_0)
	{
		MySqlConnection mySqlConnection = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(string_0, mySqlConnection);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			return dataTable;
		}
		catch (Exception ex)
		{
			Class162.smethod_2(Class84.smethod_0(-994542422), ex.Message, ex);
			throw;
		}
		finally
		{
			mySqlConnection?.Close();
		}
	}

	public static void smethod_8()
	{
		list_0.Clear();
	}

	public static void smethod_9(string string_0)
	{
		list_0.Add(string_0);
	}

	public static void smethod_10()
	{
		MySqlConnection mySqlConnection = null;
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			foreach (string item in list_0)
			{
				mySqlCommand.CommandText = item;
				mySqlCommand.ExecuteNonQuery();
			}
			mySqlTransaction.Commit();
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			Class162.smethod_2(Class84.smethod_0(-994542389), ex.Message, ex);
			throw;
		}
		finally
		{
			mySqlConnection?.Close();
			list_0.Clear();
		}
	}
}
