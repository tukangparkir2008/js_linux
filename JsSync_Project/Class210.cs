using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class210
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2201)
			{
				gClass = smethod_18(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2202)
			{
				gClass = smethod_17(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2203)
			{
				gClass = smethod_16(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2204)
			{
				gClass = smethod_15(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2205)
			{
				gClass = smethod_14(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2206)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2207)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2208)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2267)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2268)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2269)
			{
				gClass = smethod_10(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2270)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2325)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2326)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2327)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2328)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, gClass.Text);
				jsRequest_0.Data = string.Empty;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = -1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.UserRequest.Inflate();
			}
			else
			{
				jsRequest_0.Data = gClass.Data;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = gClass.Value;
				jsRequest_0.UserRequest.Inflate();
			}
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994183935));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.Data = string.Empty;
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = Class309.smethod_73() + ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	private static GClass70 smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand(Class84.smethod_0(-994216820) + text, mySqlConnection);
			mySqlCommand.ExecuteNonQuery();
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994240446)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268361)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994216676)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994188054)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994216691)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994216697)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994260111)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994277147)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268492)].ToString());
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994216651));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string commandText = Class84.smethod_0(-994216610) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994216565) + text2 + Class84.smethod_0(-994216434) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994216366));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string object_ = string.Empty;
			string commandText = Class84.smethod_0(-994216327) + text;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				object_ = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994216254));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string value = list[2];
			string value2 = list[3];
			string value3 = list[4];
			string text3 = list[5];
			string value4 = list[6];
			string value5 = list[7];
			string value6 = list[8];
			string value7 = list[9];
			string text4 = list[10];
			string text5 = list[11];
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string empty = string.Empty;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994216211);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994216016), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994216030), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215979), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215996), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215937), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = value;
				mySqlCommand.Parameters[Class84.smethod_0(-994216016)].Value = value2;
				mySqlCommand.Parameters[Class84.smethod_0(-994216030)].Value = value3;
				mySqlCommand.Parameters[Class84.smethod_0(-994215979)].Value = value4;
				mySqlCommand.Parameters[Class84.smethod_0(-994215996)].Value = text3;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = value7;
				mySqlCommand.Parameters[Class84.smethod_0(-994215937)].Value = value6;
				mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = value5;
				mySqlCommand.ExecuteNonQuery();
				mySqlCommand.CommandText = Class84.smethod_0(-994260596);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					text = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				string text6 = text3.Replace('\'', '`') + Class84.smethod_0(-994273716) + text5.Replace('\'', '`');
				empty = Class84.smethod_0(-994215956) + text2 + Class84.smethod_0(-994219947) + text4 + Class84.smethod_0(-994219854) + text + Class84.smethod_0(-994219780) + text6 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994219805);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215979), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215996), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994215937), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994259786), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994219592), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994215979)].Value = value4;
				mySqlCommand.Parameters[Class84.smethod_0(-994215996)].Value = text3;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = value7;
				mySqlCommand.Parameters[Class84.smethod_0(-994215937)].Value = value6;
				mySqlCommand.Parameters[Class84.smethod_0(-994259786)].Value = value5;
				mySqlCommand.Parameters[Class84.smethod_0(-994219592)].Value = text;
				mySqlCommand.ExecuteNonQuery();
				string text7 = text3.Replace('\'', '`') + Class84.smethod_0(-994273716) + text5.Replace('\'', '`');
				empty = Class84.smethod_0(-994219594) + text7 + Class84.smethod_0(-994219495) + text + Class84.smethod_0(-994219416) + text4 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994219344));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_5(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string string_ = list[3];
			string string_2 = list[4];
			string text4 = list[5];
			string text5 = list[6];
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			string commandText = Class84.smethod_0(-994219304) + text3 + Class84.smethod_0(-994219255) + text2 + Class84.smethod_0(-994219181) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994219120) + text4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994219069) + text4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994218960) + text4 + Class84.smethod_0(-994218897) + text2 + Class84.smethod_0(-994218827) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994218754) + text2 + Class84.smethod_0(-994218678);
			mySqlCommand.CommandText = commandText;
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				string string_3 = row[Class84.smethod_0(-994277136)].ToString();
				smethod_12(mySqlCommand, text, text2, text3, string_, string_2, string_3);
			}
			commandText = Class84.smethod_0(-994218596) + text4 + Class84.smethod_0(-994218547) + text5 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994218462));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_6(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string cmdText = Class84.smethod_0(-994218421) + text;
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				return new GClass70(0, Class84.smethod_0(-994221802), string.Empty);
			}
			string text2 = mySqlDataReader[Class84.smethod_0(-994268361)].ToString();
			string text3 = mySqlDataReader[Class84.smethod_0(-994188054)].ToString();
			mySqlDataReader[Class84.smethod_0(-994221769)].ToString();
			mySqlDataReader[Class84.smethod_0(-994221787)].ToString();
			string text4 = mySqlDataReader[Class84.smethod_0(-994216676)].ToString();
			List<string> value = new List<string>
			{
				mySqlDataReader[Class84.smethod_0(-994205248)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994273283)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994216676)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994240385)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994268361)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994264701)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994277103)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221742)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994239993)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221760)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221769)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221697)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221787)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221715)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221670)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994216697)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994216691)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221674)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221692)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994221646)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994268492)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994224892)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994187656)].ToString(),
				mySqlDataReader[Class84.smethod_0(-994187668)].ToString(),
				text
			};
			mySqlDataReader.Close();
			cmdText = Class84.smethod_0(-994221664) + text + Class84.smethod_0(-994221453);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188612)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			cmdText = Class84.smethod_0(-994221435) + text2 + Class84.smethod_0(-994218827) + text4 + Class84.smethod_0(-994221300) + text3 + Class84.smethod_0(-994221226);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<string> item2 = new List<string>
			{
				Class84.smethod_0(-994274584),
				Class84.smethod_0(-994221178)
			};
			list2.Add(item2);
			while (mySqlDataReader.Read())
			{
				List<string> item3 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994216691)].ToString()
				};
				list2.Add(item3);
			}
			mySqlDataReader.Close();
			List<string> value2 = new List<string>
			{
				JsonConvert.SerializeObject(value),
				JsonConvert.SerializeObject(list),
				JsonConvert.SerializeObject(list2)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994221130));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_7(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994221111) + text + Class84.smethod_0(-994220601) + text2, mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994220470)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994296808)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268492)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994186682)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994264701)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994273283)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994220423)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994239993)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994220427)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994220445));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994220403));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_8(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994220370), mySqlConnection).ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994142208));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994142168));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_9(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadUncommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			_ = list[1];
			string text2 = list[2];
			string text3 = list[3];
			string text4 = list[4];
			string text5 = list[5];
			string text6 = list[6];
			string text7 = list[7];
			string text8 = Class282.smethod_7(list[8]);
			string text9 = list[9];
			string text10 = Class282.smethod_7(list[10]);
			string value = list[11];
			string text11 = list[12].Replace('\'', '`');
			List<List<string>> list2 = JsonConvert.DeserializeObject<List<List<string>>>(value);
			string userId = jsRequest_0.UserRequest.UserId;
			string commandText = Class84.smethod_0(-994142121) + text3 + Class84.smethod_0(-994219181) + text2 + Class84.smethod_0(-994141997) + text6 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0)
			{
				commandText = Class84.smethod_0(-994141925) + text3 + Class84.smethod_0(-994219181) + text2 + Class84.smethod_0(-994141860) + text6 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
			}
			commandText = Class84.smethod_0(-994141848) + text4 + Class84.smethod_0(-994141734) + text3 + Class84.smethod_0(-994141727) + text2 + Class84.smethod_0(-994141646) + text7 + Class84.smethod_0(-994141575) + text10 + Class84.smethod_0(-994141566) + text9 + Class84.smethod_0(-994141495) + text6 + Class84.smethod_0(-994141423) + text8 + Class84.smethod_0(-994271698);
			if (!text5.Equals(string.Empty))
			{
				commandText = commandText + Class84.smethod_0(-994141403) + text5 + Class84.smethod_0(-994271698);
			}
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			int num = 0;
			commandText = Class84.smethod_0(-994260596);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			foreach (List<string> item in list2)
			{
				string text12 = item[0];
				string text13 = item[1];
				string text14 = item[2];
				text14 = text14.Trim().Replace('\'', '`');
				commandText = string.Format(Class84.smethod_0(-994141353), text13, text12, num, text14);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
				string text15 = Class84.smethod_0(-994274584);
				commandText = Class84.smethod_0(-994141206) + text3 + Class84.smethod_0(-994140998) + text2 + Class84.smethod_0(-994140936) + text6 + Class84.smethod_0(-994140924) + text12 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					double num2 = Convert.ToDouble(mySqlDataReader[0]);
					int num3 = Convert.ToInt32(mySqlDataReader[1]);
					text15 = Math.Round(num2 / (double)num3, 2).ToString(CultureInfo.InvariantCulture).Replace(',', '.');
				}
				mySqlDataReader.Close();
				int num4 = 0;
				commandText = Class84.smethod_0(-994140852) + text2 + Class84.smethod_0(-994219255) + text3 + Class84.smethod_0(-994140719) + text7 + Class84.smethod_0(-994140645) + text4 + Class84.smethod_0(-994140640) + text6 + Class84.smethod_0(-994140566) + text12 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num4 = Convert.ToInt32(mySqlDataReader[0]);
				}
				mySqlDataReader.Close();
				if (num4 == 0)
				{
					commandText = Class84.smethod_0(-994140496) + text2 + Class84.smethod_0(-994140390) + text3 + Class84.smethod_0(-994140327) + text7 + Class84.smethod_0(-994140264) + text4 + Class84.smethod_0(-994140241) + text6 + Class84.smethod_0(-994140177) + text12 + Class84.smethod_0(-994144214) + text15 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
				}
				else
				{
					commandText = string.Format(Class84.smethod_0(-994144152), text15, num4);
					mySqlCommand.CommandText = commandText;
					mySqlCommand.ExecuteNonQuery();
				}
			}
			string text16 = Class84.smethod_0(-994274584);
			commandText = string.Format(Class84.smethod_0(-994144012), num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				double num5 = Convert.ToDouble(mySqlDataReader[0]);
				int num6 = Convert.ToInt32(mySqlDataReader[1]);
				text16 = Math.Round(num5 / (double)num6, 2).ToString(CultureInfo.InvariantCulture).Replace(',', '.');
			}
			mySqlDataReader.Close();
			int num7 = 0;
			commandText = string.Format(Class84.smethod_0(-994143897), text2, text3, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num7 = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			if (num7 == 0)
			{
				commandText = string.Format(Class84.smethod_0(-994143685), text2, text3, num, text16);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				commandText = string.Format(Class84.smethod_0(-994143534), text16, text2, text3, num);
				mySqlCommand.CommandText = commandText;
				mySqlCommand.ExecuteNonQuery();
			}
			commandText = string.Format(Class84.smethod_0(-994143378), text, userId, num, text11);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994143198));
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994143153));
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994143133));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_10(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string empty = string.Empty;
			empty = ((!text2.Equals(Class84.smethod_0(-994221670)) || !text3.Equals(Class84.smethod_0(-994274584))) ? (Class84.smethod_0(-994142971) + text2 + Class84.smethod_0(-994200012) + text3 + Class84.smethod_0(-994142905) + text) : (Class84.smethod_0(-994143097) + text));
			new MySqlCommand(empty, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994142833));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string string_ = list[0];
			string string_2 = list[1];
			string string_3 = list[2];
			string string_4 = list[3];
			string string_5 = list[4];
			string string_6 = list[5];
			string string_7 = list[6];
			string text = list[7];
			string text2 = list[8];
			string text3 = list[9];
			text2 = text2.Replace(',', '.');
			string commandText = Class84.smethod_0(-994142803) + text2 + Class84.smethod_0(-994142702) + text3 + Class84.smethod_0(-994142640) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			smethod_12(mySqlCommand, string_, string_2, string_3, string_4, string_5, string_7);
			smethod_13(mySqlCommand, string_, string_2, string_6);
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994142833));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_12(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		try
		{
			string text = Class84.smethod_0(-994274584);
			string commandText = Class84.smethod_0(-994142617) + string_1 + Class84.smethod_0(-994142428) + string_0 + Class84.smethod_0(-994142359) + string_2 + Class84.smethod_0(-994142276) + string_5 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				double num = Convert.ToDouble(mySqlDataReader[0]);
				int num2 = Convert.ToInt32(mySqlDataReader[1]);
				if (num2 != 0)
				{
					text = Math.Round(num / (double)num2, 2).ToString().Replace(',', '.');
				}
			}
			mySqlDataReader.Close();
			commandText = Class84.smethod_0(-994142261) + text + Class84.smethod_0(-994146300) + string_0 + Class84.smethod_0(-994218897) + string_1 + Class84.smethod_0(-994146221) + string_3 + Class84.smethod_0(-994146151) + string_4 + Class84.smethod_0(-994146134) + string_2 + Class84.smethod_0(-994146064) + string_5 + Class84.smethod_0(-994271698);
			mySqlCommand_0.CommandText = commandText;
			mySqlCommand_0.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static void smethod_13(MySqlCommand mySqlCommand_0, string string_0, string string_1, string string_2)
	{
		string text = Class84.smethod_0(-994274584);
		string commandText = Class84.smethod_0(-994146046) + string_2 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			double num = Convert.ToDouble(mySqlDataReader[0]);
			int num2 = Convert.ToInt32(mySqlDataReader[1]);
			text = Math.Round(num / (double)num2, 2).ToString(CultureInfo.InvariantCulture).Replace(',', '.');
		}
		mySqlDataReader.Close();
		commandText = Class84.smethod_0(-994145871) + text + Class84.smethod_0(-994145801) + string_0 + Class84.smethod_0(-994145732) + string_1 + Class84.smethod_0(-994145714) + string_2 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		mySqlCommand_0.ExecuteNonQuery();
	}

	private static GClass70 smethod_14(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<string> list2 = new List<string>();
			string cmdText = Class84.smethod_0(-994145648) + text2;
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list2.Add(mySqlDataReader[0].ToString());
				list2.Add(mySqlDataReader[1].ToString());
			}
			mySqlDataReader.Close();
			cmdText = Class84.smethod_0(-994145484) + text + Class84.smethod_0(-994145364);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list2.Add(mySqlDataReader[0].ToString());
				list2.Add(mySqlDataReader[1].ToString());
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994145295));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_15(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994145260) + text + Class84.smethod_0(-994219181) + text2 + Class84.smethod_0(-994145093) + text3 + Class84.smethod_0(-994145031) + text4 + Class84.smethod_0(-994145022), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			List<string> item = new List<string>
			{
				string.Empty,
				Class84.smethod_0(-994144946),
				string.Empty,
				string.Empty,
				string.Empty
			};
			list2.Add(item);
			while (mySqlDataReader.Read())
			{
				item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString(),
					mySqlDataReader[4].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994144912));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_16(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994144873) + text2 + Class84.smethod_0(-994144722) + text3 + Class84.smethod_0(-994144651) + text + Class84.smethod_0(-994144565) + text4 + Class84.smethod_0(-994144485), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994144391));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_17(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994144370) + text2 + Class84.smethod_0(-994148318) + text + Class84.smethod_0(-994148178) + text3 + Class84.smethod_0(-994148120), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994148044));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_18(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			_ = list[1];
			string text2 = list[2];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994148019) + text2 + Class84.smethod_0(-994147815) + text + Class84.smethod_0(-994147801), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994147744));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_19(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994147709) + text3 + Class84.smethod_0(-994147548) + text + Class84.smethod_0(-994147416) + text2 + Class84.smethod_0(-994147342), mySqlConnection).ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994147744));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
