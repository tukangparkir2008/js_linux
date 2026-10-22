using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class285
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2279)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2280)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2281)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2282)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2283)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2284)
			{
				gClass = smethod_1(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), Class84.smethod_0(-994242818), gClass.Text);
				jsRequest_0.Data = string.Empty;
				jsRequest_0.Message = gClass.Text;
				jsRequest_0.ServerStatus = 1;
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994242837));
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
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			string commandText = string.Concat(str1: Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey), str0: Class84.smethod_0(-994064239));
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994064180));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994064135));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string empty = string.Empty;
			empty = ((!text.Equals(Class84.smethod_0(-994274584))) ? (Class84.smethod_0(-994063989) + text3 + Class84.smethod_0(-994063880) + text) : (Class84.smethod_0(-994064103) + text4 + Class84.smethod_0(-994064042) + text2 + Class84.smethod_0(-994064008) + text3 + Class84.smethod_0(-994063975)));
			mySqlCommand.CommandText = empty;
			mySqlCommand.ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994064180));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994063867));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			List<List<string>> list = new List<List<string>>();
			string commandText = Class84.smethod_0(-994063834) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			commandText = Class84.smethod_0(-994063706);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list2.Add(item2);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list),
				JsonConvert.SerializeObject(list2)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994063581));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1].Trim().Replace('\'', '`');
			string text3 = list[2].Trim().Replace('\'', '`');
			string text4 = list[3];
			string text5 = list[4];
			string text6 = list[5];
			string text7 = list[6];
			string empty = string.Empty;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994063548) + text2 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
				{
					return new GClass70(0, Class84.smethod_0(-994063424) + text2 + Class84.smethod_0(-994063365), string.Empty);
				}
				empty = Class84.smethod_0(-994063329) + text2 + Class84.smethod_0(-994126423) + text3 + Class84.smethod_0(-994063283) + text5 + Class84.smethod_0(-994063247) + text6 + Class84.smethod_0(-994063174) + text4 + Class84.smethod_0(-994063185);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994063154) + text2 + Class84.smethod_0(-994063043) + text7 + Class84.smethod_0(-994063065);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994063548) + text2 + Class84.smethod_0(-994062980) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
				{
					return new GClass70(0, Class84.smethod_0(-994063424) + text2 + Class84.smethod_0(-994063365), string.Empty);
				}
				empty = Class84.smethod_0(-994062971) + text2 + Class84.smethod_0(-994126423) + text3 + Class84.smethod_0(-994063283) + text5 + Class84.smethod_0(-994063247) + text6 + Class84.smethod_0(-994063174) + text4 + Class84.smethod_0(-994142640) + text;
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062850));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_5(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			string commandText = string.Concat(str1: Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey), str0: Class84.smethod_0(-994062822), str2: Class84.smethod_0(-994271698));
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (MySqlException ex)
		{
			if (ex.Number == 1451)
			{
				return new GClass70(0, Class84.smethod_0(-994062776), string.Empty);
			}
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062697));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		catch (Exception ex2)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062697));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex2.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			return new GClass70(-1, Class309.smethod_70() + ex2.Message, ex2);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string text2 = Class84.smethod_0(-994062670);
			if (!text.Equals(Class84.smethod_0(-994248828)))
			{
				text2 = text2 + Class84.smethod_0(-994062554) + text + Class84.smethod_0(-994271698);
			}
			text2 += Class84.smethod_0(-994062516);
			mySqlCommand.CommandText = text2;
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString(),
					mySqlDataReader[4].ToString(),
					mySqlDataReader[5].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062479));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
