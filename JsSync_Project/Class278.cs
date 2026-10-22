using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class278
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 135)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2135)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			if (gClass.Value < 0)
			{
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

	public static string smethod_1(MySqlCommand mySqlCommand_0)
	{
		List<List<string>> list = new List<List<string>>();
		string format = Class84.smethod_0(-994302385);
		foreach (string key in Class224.Class225.dictionary_0.Keys)
		{
			string item = Class84.smethod_0(-994248276);
			mySqlCommand_0.CommandText = string.Format(format, key);
			MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			list.Add(new List<string> { key, item });
		}
		return JsonConvert.SerializeObject(list);
	}

	public static string smethod_2()
	{
		List<string> list = new List<string>();
		Class348.Class352.smethod_4();
		if (Class348.Class352.smethod_2())
		{
			list.Add(Class84.smethod_0(-994274584));
			list.Add(Class84.smethod_0(-994200317));
		}
		else if (!Class348.Class352.smethod_0())
		{
			list.Add(Class84.smethod_0(-994274584));
			list.Add(Class84.smethod_0(-994200204));
		}
		else
		{
			list.Add(Class84.smethod_0(-994248276));
			list.Add(Class84.smethod_0(-994200137));
		}
		return JsonConvert.SerializeObject(list);
	}

	public static string smethod_3(string string_0, string string_1, string string_2, MySqlCommand mySqlCommand_0)
	{
		List<string> list = new List<string>();
		string commandText = Class84.smethod_0(-994217318) + string_1 + Class84.smethod_0(-994224672) + string_0 + Class84.smethod_0(-994271698);
		mySqlCommand_0.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			int num = Convert.ToInt32(mySqlDataReader[0]);
			string item = ((num == 1) ? Class84.smethod_0(-994217204) : string.Format(Class84.smethod_0(-994217220), string_2, mySqlDataReader[1]));
			list.Add(num.ToString());
			list.Add(item);
		}
		else
		{
			list.Add(Class84.smethod_0(-994274584));
			list.Add(Class84.smethod_0(-994217167) + string_2);
		}
		mySqlDataReader.Close();
		return JsonConvert.SerializeObject(list);
	}

	private static GClass70 smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand_ = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			string jibasId = jsRequest_0.UserRequest.JibasId;
			string userName = jsRequest_0.UserRequest.UserName;
			string item = smethod_1(mySqlCommand_);
			string item2 = smethod_3(deviceId, jibasId, userName, mySqlCommand_);
			string item3 = smethod_2();
			List<string> value = new List<string> { item, item2, item3 };
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994217143));
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
		try
		{
			mySqlConnection.Open();
			MySqlCommand mySqlCommand_ = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string userId = jsRequest_0.UserRequest.UserId;
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			string jibasId = jsRequest_0.UserRequest.JibasId;
			string userName = jsRequest_0.UserRequest.UserName;
			string item = smethod_1(mySqlCommand_);
			string item2 = smethod_3(deviceId, jibasId, userName, mySqlCommand_);
			string item3 = smethod_2();
			List<List<string>> list = new List<List<string>>();
			smethod_6(mySqlCommand_, userId, list);
			string item4 = JsonConvert.SerializeObject(list);
			List<string> value = new List<string> { item, item2, item3, item4 };
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994217143));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	public static void smethod_6(MySqlCommand mySqlCommand_0, string string_0, List<List<string>> list_0)
	{
		List<Tuple<int, int, string>> list = new List<Tuple<int, int, string>>();
		string format = Class84.smethod_0(-994217110);
		mySqlCommand_0.CommandText = string.Format(format, string_0);
		MySqlDataReader mySqlDataReader = mySqlCommand_0.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			list.Add(new Tuple<int, int, string>(Convert.ToInt32(mySqlDataReader[0]), Convert.ToInt32(mySqlDataReader[1]), mySqlDataReader[2].ToString()));
		}
		mySqlDataReader.Close();
		if (list.Count == 0)
		{
			return;
		}
		format = Class84.smethod_0(-994216977);
		foreach (Tuple<int, int, string> item3 in list)
		{
			int item = item3.Item2;
			string text = item3.Item3.Replace(Class84.smethod_0(-994267367), string.Empty);
			text = text.Replace(Class84.smethod_0(-994267375), string.Empty);
			string text2 = string.Empty;
			mySqlCommand_0.CommandText = string.Format(format, text);
			mySqlDataReader = mySqlCommand_0.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string text3 = string.Format(Class84.smethod_0(-994216862), mySqlDataReader[0], mySqlDataReader[1]);
				if (!text2.Equals(string.Empty))
				{
					text2 += Class84.smethod_0(-994216814);
				}
				text2 += text3;
			}
			mySqlDataReader.Close();
			if (!text2.Equals(string.Empty))
			{
				List<string> item2 = new List<string>
				{
					item.ToString(),
					text2
				};
				list_0.Add(item2);
			}
		}
	}
}
