using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class274
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 156)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 158)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 161)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994201677));
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
		return new GClass70(1, Class84.smethod_0(-994247224), jsRequest_0.UserRequest.RequestData);
	}

	private static GClass70 smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string string_ = list[0];
			string string_2 = list[1];
			string string_3 = list[2];
			string string_4 = list[3];
			string string_5 = list[4];
			Class243.smethod_0(new MySqlCommand
			{
				Connection = mySqlConnection
			}, string_, string_2, string_3, string_4, string_5, bool_0: true, bool_1: true, bool_2: true);
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 @class = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994201642), string.Empty, string.Empty);
			return new GClass70(-1, @class.method_1());
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_3(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlDataReader mySqlDataReader = null;
		try
		{
			string value = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(value);
			string text = list[0];
			string arg = list[1];
			_ = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string format = Class84.smethod_0(-994201662);
			format = string.Format(format, text, arg, Class348.Class352.string_0);
			mySqlCommand.CommandText = format;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (!mySqlDataReader.Read())
			{
				mySqlDataReader.Close();
				Class143 @class = Class143.smethod_0((Enum2)7008, text, Class84.smethod_0(-994205293), string.Empty);
				return new GClass70(-1, @class.method_1());
			}
			if (mySqlDataReader[Class84.smethod_0(-994205312)].ToString().Equals(string.Empty))
			{
				mySqlDataReader.Close();
				Class143 class2 = Class143.smethod_0((Enum2)7005, text, Class84.smethod_0(-994205293), string.Empty);
				return new GClass70(-1, class2.method_1());
			}
			if (Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994277147)]) == 0)
			{
				mySqlDataReader.Close();
				Class143 class3 = Class143.smethod_0((Enum2)7007, Class84.smethod_0(-994205252), string.Empty, string.Empty);
				return new GClass70(-1, class3.method_1());
			}
			if (Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994205271)]) == 0)
			{
				mySqlDataReader.Close();
				Class143 class4 = Class143.smethod_0((Enum2)7006, Class84.smethod_0(-994205224), string.Empty, string.Empty);
				return new GClass70(-1, class4.method_1());
			}
			string item = mySqlDataReader[Class84.smethod_0(-994264135)].ToString();
			string text2 = mySqlDataReader[Class84.smethod_0(-994277142)].ToString();
			string item2;
			if (!Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994205227)]))
			{
				byte[] array = (byte[])mySqlDataReader[Class84.smethod_0(-994205227)];
				item2 = ((array.Length == 0) ? GClass18.smethod_18(Class309.smethod_44()) : Convert.ToBase64String(array));
			}
			else
			{
				item2 = GClass18.smethod_18(Class309.smethod_44());
			}
			string item3 = mySqlDataReader[Class84.smethod_0(-994273283)].ToString();
			string item4 = mySqlDataReader[Class84.smethod_0(-994205248)].ToString();
			string item5 = mySqlDataReader[Class84.smethod_0(-994264701)].ToString();
			mySqlDataReader.Close();
			List<string> value2 = new List<string>
			{
				item,
				text2,
				item4,
				item3,
				item2,
				item5,
				Class84.smethod_0(-994205197),
				Class84.smethod_0(-994205213)
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), text2, Class84.smethod_0(-994205165));
			Class143 class5 = Class143.smethod_0((Enum2)7004, string.Empty, string.Empty, string.Empty);
			return new GClass70(1, class5.method_1(), JsonConvert.SerializeObject(value2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994205131));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			Class143 class6 = Class143.smethod_0((Enum2)6000, Class84.smethod_0(-994205106), string.Empty, string.Empty);
			return new GClass70(-1, class6.method_1());
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

	private static List<string> smethod_4(string string_0)
	{
		try
		{
			List<string> list = JsonConvert.DeserializeObject<List<string>>(string_0) ?? new List<string>
			{
				string.Empty,
				string.Empty,
				string.Empty,
				string.Empty
			};
			return (list.Count != 4) ? null : list;
		}
		catch (Exception ex)
		{
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return null;
		}
	}
}
