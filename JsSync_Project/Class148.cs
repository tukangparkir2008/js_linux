using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class148
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 130)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 149)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 150)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 152)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 151)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994235982));
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
			List<string> list = Class300.smethod_0(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey), Class84.smethod_0(-994274987));
			if (list.Count != 2)
			{
				return new GClass70(-1, Class84.smethod_0(-994235957), string.Empty);
			}
			string text = list[0];
			string arg = list[1];
			string arg2 = string.Empty;
			if (!text.Equals(Class84.smethod_0(-994274584)))
			{
				arg2 = Class84.smethod_0(-994235919) + text + Class84.smethod_0(-994263061);
			}
			string format = Class84.smethod_0(-994235873);
			format = string.Format(format, arg, arg2);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			}.ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994297386)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994235638));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994235614));
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
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string arg = string.Empty;
			if (!text.Equals(Class84.smethod_0(-994274584)))
			{
				arg = Class84.smethod_0(-994235535) + text;
			}
			string format = Class84.smethod_0(-994235490);
			format = string.Format(format, arg);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994235153)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276368)].ToString(),
					string.Empty,
					mySqlDataReader[Class84.smethod_0(-994235105)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			string text2 = Class84.smethod_0(-994235127);
			string text3 = Class84.smethod_0(-994235056);
			foreach (List<string> item2 in list)
			{
				string arg2 = item2[0];
				string text4 = item2[1];
				mySqlCommand.CommandText = string.Format(text4.Equals(Class84.smethod_0(-994257743)) ? text2 : text3, arg2);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item2[2] = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234984));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234954));
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
			string text2 = Class84.smethod_0(-994234885);
			if (!text.Equals(Class84.smethod_0(-994274584)))
			{
				text2 = text2 + Class84.smethod_0(-994235535) + text;
			}
			text2 += Class84.smethod_0(-994234645);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = text2
			}.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994235105)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234558));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994234467));
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
		try
		{
			mySqlConnection.Open();
			List<List<string>> list = new List<List<string>>();
			List<string> item = new List<string>
			{
				Class84.smethod_0(-994274584),
				Class84.smethod_0(-994234449)
			};
			list.Add(item);
			string commandText = Class84.smethod_0(-994234403);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = commandText
			}.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238447));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_1(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlDataReader mySqlDataReader = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = string.Format(Class84.smethod_0(-994238409), string_, arg)
			}.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994238122)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994238088)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994238103)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238053));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994238039));
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
