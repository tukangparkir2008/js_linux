using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class261
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		if (jsRequest_0.UserRequest.Protocol == 2102)
		{
			smethod_4(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 2131)
		{
			smethod_6(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 2105)
		{
			smethod_3(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 2106)
		{
			smethod_2(gclass4_0, gclass41_0, jsRequest_0);
		}
		else if (jsRequest_0.UserRequest.Protocol == 2107)
		{
			smethod_1(gclass4_0, gclass41_0, jsRequest_0);
		}
	}

	private static void smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			List<string> list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			if (list == null)
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.Message = Class84.smethod_0(-994224482);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text = list[0];
			string text2 = list[1].Replace('\'', '`');
			string text3 = list[2].Replace('\'', '`');
			string jibasId = jsRequest_0.UserRequest.JibasId;
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			mySqlConnection.Open();
			string commandText = Class84.smethod_0(-994227887) + text + Class84.smethod_0(-994227818) + deviceId + Class84.smethod_0(-994227778);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			};
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0)
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = 1;
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227802));
				return;
			}
			commandText = Class84.smethod_0(-994227722) + jibasId + Class84.smethod_0(-994227677) + text + Class84.smethod_0(-994227626) + text2 + Class84.smethod_0(-994227642) + text3 + Class84.smethod_0(-994227606) + deviceId + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227802));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227553));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			string jibasId = jsRequest_0.UserRequest.JibasId;
			mySqlConnection.Open();
			string commandText = Class84.smethod_0(-994227546) + jibasId + Class84.smethod_0(-994227419);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = 0;
				jsRequest_0.Message = Class84.smethod_0(-994227378) + jsRequest_0.UserRequest.UserName;
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list = new List<List<string>>();
			do
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994227311)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994265628)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276954)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276501)].ToString()
				};
				list.Add(item);
			}
			while (mySqlDataReader.Read());
			mySqlDataReader.Close();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = 1;
			jsRequest_0.Message = Class84.smethod_0(-994247224);
			jsRequest_0.Data = JsonConvert.SerializeObject(list);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227314));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227292));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			mySqlConnection.Open();
			string commandText = Class84.smethod_0(-994227215) + text + Class84.smethod_0(-994224672) + deviceId + Class84.smethod_0(-994271698);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			};
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994227194) + text + Class84.smethod_0(-994224672) + deviceId + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227126));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227082));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static void smethod_4(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlDataReader mySqlDataReader = null;
		try
		{
			string value = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(value);
			string text = list[0];
			string text2 = list[1];
			string string_ = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994062435);
			format = string.Format(format, text, text2, Class348.Class352.string_0);
			mySqlCommand.CommandText = format;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				Class143 @class = Class143.smethod_0((Enum2)7008, text, Class84.smethod_0(-994205293), string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)@class.method_0();
				jsRequest_0.Message = @class.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string text3 = mySqlDataReader[Class84.smethod_0(-994264135)].ToString();
			string text4 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
			string text5;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				text5 = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				text5 = GClass18.smethod_18(Class309.smethod_44());
			}
			string item = Class208.smethod_0(text5);
			string item2 = mySqlDataReader[Class84.smethod_0(-994226615)].ToString();
			int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994226617)]);
			string item3 = mySqlDataReader[Class84.smethod_0(-994277103)].ToString();
			string item4 = mySqlDataReader[Class84.smethod_0(-994277105)].ToString();
			string item5 = mySqlDataReader[Class84.smethod_0(-994268361)].ToString();
			string item6 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			string item7 = mySqlDataReader[Class84.smethod_0(-994187348)].ToString();
			string item8 = mySqlDataReader[Class84.smethod_0(-994187299)].ToString();
			string item9 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			string item10 = mySqlDataReader[Class84.smethod_0(-994205248)].ToString();
			int num2 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277147)]);
			int num3 = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994205271)]);
			string item11 = mySqlDataReader[Class84.smethod_0(-994226570)].ToString();
			mySqlDataReader.Close();
			if (num2 == 0)
			{
				Class143 class2 = Class143.smethod_0((Enum2)7007, Class84.smethod_0(-994205252), string.Empty, string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class2.method_0();
				jsRequest_0.Message = class2.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			if (num3 == 0)
			{
				Class143 class3 = Class143.smethod_0((Enum2)7006, Class84.smethod_0(-994205224), string.Empty, string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class3.method_0();
				jsRequest_0.Message = class3.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			List<List<string>> list2 = new List<List<string>>();
			Class278.smethod_6(mySqlCommand, text, list2);
			if (list2.Count == 0)
			{
				Class143 class4 = Class143.smethod_0((Enum2)7009, Class84.smethod_0(-994229643), string.Empty, string.Empty);
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.MessageCode = (int)class4.method_0();
				jsRequest_0.Message = class4.method_1();
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			string item12 = JsonConvert.SerializeObject(list2);
			string item13 = JsonConvert.SerializeObject(new List<string>
			{
				Class224.Class227.string_6,
				Class224.Class227.string_1,
				Class224.Class227.string_3
			});
			string item14 = Class278.smethod_1(mySqlCommand);
			string item15 = Class278.smethod_3(jsRequest_0.UserRequest.DeviceId, text3, text4, mySqlCommand);
			string item16 = Class278.smethod_2();
			string item17 = JsonConvert.SerializeObject(new List<string> { item14, item15, item16 });
			smethod_5(mySqlConnection, jsRequest_0, text3, text, string_);
			List<string> value2 = new List<string>
			{
				text3,
				text,
				text2,
				text4,
				item2,
				num.ToString(),
				text5,
				item3,
				item4,
				item5,
				item6,
				item7,
				item8,
				item10,
				item9,
				item,
				num2.ToString(),
				item11,
				item13,
				item17,
				item12,
				Class84.smethod_0(-994229662),
				Class84.smethod_0(-994205197),
				Class84.smethod_0(-994205213)
			};
			Class143 class5 = Class143.smethod_0((Enum2)7004, string.Empty, string.Empty, string.Empty);
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.MessageCode = (int)class5.method_0();
			jsRequest_0.Message = class5.method_1();
			jsRequest_0.Data = JsonConvert.SerializeObject(value2);
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), text4, Class84.smethod_0(-994226590));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994226552));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 class6 = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.MessageCode = (int)class6.method_0();
			jsRequest_0.Message = class6.method_1();
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

	public static void smethod_5(MySqlConnection mySqlConnection_0, JsRequest jsRequest_0, string string_0, string string_1, string string_2)
	{
		try
		{
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection_0
			};
			string appName = jsRequest_0.UserRequest.AppName;
			string appVer = jsRequest_0.UserRequest.AppVer;
			string compatibilityVer = jsRequest_0.UserRequest.CompatibilityVer;
			string text = jsRequest_0.UserRequest.DeviceName.Replace('\'', '`');
			string text2 = jsRequest_0.UserRequest.DeviceAddr.Replace('\'', '`');
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			string format = Class84.smethod_0(-994226526);
			mySqlCommand.CommandText = string.Format(format, string_0, deviceId);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				format = Class84.smethod_0(-994066132);
				format = string.Format(format, string_0, string_1, appVer, compatibilityVer, text, text2, appName, deviceId);
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				format = Class84.smethod_0(-994226184);
				format = string.Format(format, string_0, deviceId);
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
			}
			format = Class84.smethod_0(-994224183);
			mySqlCommand.CommandText = string.Format(format, string_0, deviceId);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				format = Class84.smethod_0(-994065891);
				mySqlCommand.CommandText = string.Format(format, string_0, string_1, deviceId, string_2);
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				format = Class84.smethod_0(-994230153);
				format = string.Format(format, string_0, deviceId);
				mySqlCommand.CommandText = format;
				mySqlCommand.ExecuteNonQuery();
			}
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
		}
	}

	private static void smethod_6(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			List<string> list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			if (list == null)
			{
				jsRequest_0.ServerStatus = 1;
				jsRequest_0.ExecCode = -1;
				jsRequest_0.Message = Class84.smethod_0(-994224482);
				jsRequest_0.UserRequest.Inflate();
				gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
				return;
			}
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string deviceId = jsRequest_0.UserRequest.DeviceId;
			string format = Class84.smethod_0(-994224183);
			mySqlCommand.CommandText = string.Format(format, text2, deviceId);
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				format = Class84.smethod_0(-994228163);
				format = string.Format(format, text2, text, deviceId, text3);
			}
			else
			{
				format = Class84.smethod_0(-994228005);
				format = string.Format(format, text3, text2, deviceId);
			}
			mySqlCommand.CommandText = format;
			mySqlCommand.ExecuteNonQuery();
			jsRequest_0.ServerStatus = 1;
			jsRequest_0.ExecCode = 1;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994227917));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			jsRequest_0.ServerStatus = -1;
			jsRequest_0.ExecCode = -1;
			jsRequest_0.Message = ex.Message;
			jsRequest_0.UserRequest.Inflate();
			gclass41_0.vmethod_10(BinSerializer.ToByteArray(jsRequest_0));
		}
		finally
		{
			mySqlConnection.Close();
		}
	}
}
