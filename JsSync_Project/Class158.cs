using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class158
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		if (jsRequest_0.UserRequest.Protocol == 136)
		{
			smethod_4(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 101)
		{
			smethod_3(gclass4_0, gclass41_0, jsRequest_0, bool_0: false);
		}
		else if (jsRequest_0.UserRequest.Protocol == 148)
		{
			smethod_3(gclass4_0, gclass41_0, jsRequest_0, bool_0: true);
		}
		else if (jsRequest_0.UserRequest.Protocol == 2136)
		{
			smethod_2(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 165)
		{
			smethod_1(gclass4_0, gclass41_0, jsRequest_0);
		}
	}

	private static void smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			string data = JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_6,
				Class224.Class227.string_1,
				Class224.Class227.string_3,
				Class224.Class227.string_4,
				Class224.Class227.string_7
			});
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = data;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229994));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 @class = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.MessageCode = (int)@class.method_0();
			jsRequest_0.Message = @class.method_1();
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	private static void smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlDataReader mySqlDataReader = null;
		try
		{
			mySqlConnection.Open();
			string text = jsRequest_0.UserRequest.UserId;
			string jibasId = jsRequest_0.UserRequest.JibasId;
			Class326 @class = Class326.smethod_0(jibasId);
			if (@class != null)
			{
				string string_ = string.Empty;
				if (@class.method_0(mySqlConnection, ref string_))
				{
					text = string_;
				}
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994229983);
			format = string.Format(format, text, Class348.Class352.string_0);
			mySqlCommand.CommandText = format;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				Class143 class2 = Class143.smethod_0((Enum2)7008, text, Class84.smethod_0(-994229639), string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class2.method_0();
				jsRequest_0.Message = class2.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text2 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
			string item = mySqlDataReader[Class84.smethod_0(-994247193)].ToString();
			string text3;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text3 = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text3 = GClass18.smethod_18(Class309.smethod_44());
			}
			string item2 = Class208.smethod_0(text3);
			string item3 = mySqlDataReader[Class84.smethod_0(-994277103)].ToString();
			string item4 = mySqlDataReader[Class84.smethod_0(-994277105)].ToString();
			string item5 = mySqlDataReader[Class84.smethod_0(-994268361)].ToString();
			string item6 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			string item7 = mySqlDataReader[Class84.smethod_0(-994187348)].ToString();
			string item8 = mySqlDataReader[Class84.smethod_0(-994187299)].ToString();
			string item9 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			string item10 = mySqlDataReader[Class84.smethod_0(-994205248)].ToString();
			int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277147)]);
			mySqlDataReader.Close();
			List<List<string>> list = new List<List<string>>();
			Class278.smethod_6(mySqlCommand, text, list);
			if (list.Count == 0)
			{
				Class143 class3 = Class143.smethod_0((Enum2)7009, Class84.smethod_0(-994229643), string.Empty, string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class3.method_0();
				jsRequest_0.Message = class3.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string item11 = JsonConvert.SerializeObject(list);
			string item12 = JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_6,
				Class224.Class227.string_1,
				Class224.Class227.string_3
			});
			string item13 = Class278.smethod_1(mySqlCommand);
			string item14 = Class278.smethod_3(jsRequest_0.UserRequest.DeviceId, jibasId, text2, mySqlCommand);
			string item15 = Class278.smethod_2();
			List<string> value = new List<string>
			{
				text,
				text2,
				item,
				text3,
				item2,
				num.ToString(),
				item3,
				item4,
				item5,
				item6,
				item7,
				item8,
				item10,
				item9,
				item13,
				item14,
				item15,
				item12,
				item11,
				Class84.smethod_0(-994229662),
				Class84.smethod_0(-994205197),
				Class84.smethod_0(-994205213)
			};
			Class143 class4 = Class143.smethod_0((Enum2)7004, string.Empty, string.Empty, string.Empty);
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = (int)class4.method_0();
			jsRequest_0.Message = class4.method_1();
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), text2, Class84.smethod_0(-994229614));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229589));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 class5 = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.MessageCode = (int)class5.method_0();
			jsRequest_0.Message = class5.method_1();
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
			if (mySqlDataReader != null && !mySqlDataReader.IsClosed)
			{
				mySqlDataReader.Close();
			}
		}
	}

	public static void smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0, bool bool_0)
	{
		try
		{
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.Data = string.Empty;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			if (!bool_0)
			{
				gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229509));
			}
		}
		catch (Exception ex)
		{
			if (!bool_0)
			{
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229493));
				gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			}
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
	}

	public static void smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = jsRequest_0.UserRequest.UserId;
			string schoolId = jsRequest_0.UserRequest.SchoolId;
			string jibasId = jsRequest_0.UserRequest.JibasId;
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			Class326 @class = Class326.smethod_0(jibasId);
			if (@class != null)
			{
				string string_ = string.Empty;
				if (@class.method_1(mySqlConnection, ref string_))
				{
					text = string_;
				}
			}
			string format = Class84.smethod_0(-994229422);
			format = string.Format(format, text, schoolId);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			mySqlCommand.ExecuteNonQuery();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				Class143 class2 = Class143.smethod_0((Enum2)7001, text, Class84.smethod_0(-994229063), string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class2.method_0();
				jsRequest_0.Message = class2.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text2 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
			string item = mySqlDataReader[Class84.smethod_0(-994229066)].ToString();
			string text3;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text3 = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text3 = GClass18.smethod_18(Class309.smethod_44());
			}
			string item2 = Class208.smethod_0(text3);
			string item3 = mySqlDataReader[Class84.smethod_0(-994277103)].ToString();
			string item4 = mySqlDataReader[Class84.smethod_0(-994277105)].ToString();
			string item5 = mySqlDataReader[Class84.smethod_0(-994268361)].ToString();
			string item6 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			string item7 = mySqlDataReader[Class84.smethod_0(-994187348)].ToString();
			string item8 = mySqlDataReader[Class84.smethod_0(-994187299)].ToString();
			string item9 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			string item10 = mySqlDataReader[Class84.smethod_0(-994205248)].ToString();
			string item11 = mySqlDataReader[Class84.smethod_0(-994277147)].ToString();
			mySqlDataReader.Close();
			string item12 = Class278.smethod_1(mySqlCommand);
			string item13 = Class278.smethod_3(deviceId, jibasId, text2, mySqlCommand);
			string item14 = Class278.smethod_2();
			string item15 = JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_6,
				Class224.Class227.string_1,
				Class224.Class227.string_3
			});
			List<string> value = new List<string>
			{
				text,
				text2,
				item,
				text3,
				item2,
				item11,
				item3,
				item4,
				item5,
				item6,
				item7,
				item8,
				item10,
				item9,
				item12,
				item13,
				item14,
				item15,
				Class84.smethod_0(-994205197),
				Class84.smethod_0(-994205213)
			};
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.Data = JsonConvert.SerializeObject(value);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229614));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994229589));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
