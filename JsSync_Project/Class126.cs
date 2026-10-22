using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class126
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2271)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2272)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2273)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2274)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2275)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2276)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2277)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2278)
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string text5 = list[4];
			string text6 = list[5];
			string text7 = list[6];
			string text8 = list[7];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			if (text6.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994147244) + text5 + Class84.smethod_0(-994147143) + text + Class84.smethod_0(-994147168) + text2 + Class84.smethod_0(-994147127) + text3 + Class84.smethod_0(-994147061) + text4 + Class84.smethod_0(-994147019) + text7 + Class84.smethod_0(-994146984) + text8 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994260596);
				mySqlCommand.CommandText = empty;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					text6 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
			}
			else
			{
				empty = Class84.smethod_0(-994146976) + text7 + Class84.smethod_0(-994146984) + text8 + Class84.smethod_0(-994142640) + text6;
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			return new GClass70(1, Class84.smethod_0(-994247224), text6);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994146850));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			List<List<string>> list2 = new List<List<string>>();
			string commandText = Class84.smethod_0(-994146828) + text + Class84.smethod_0(-994146710);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
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
			List<List<string>> list3 = new List<List<string>>();
			commandText = Class84.smethod_0(-994146608) + text3 + Class84.smethod_0(-994146484) + text2 + Class84.smethod_0(-994146424);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			List<List<string>> list4 = new List<List<string>>();
			commandText = Class84.smethod_0(-994146337) + text3 + Class84.smethod_0(-994146484) + text2 + Class84.smethod_0(-994133910) + text4 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item3 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString(),
					mySqlDataReader[4].ToString()
				};
				list4.Add(item3);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3),
				JsonConvert.SerializeObject(list4)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994133825));
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
			new MySqlCommand(Class84.smethod_0(-994133803) + text, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994133703));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string string_ = list[3];
			string_ = Class282.smethod_6(string_);
			string string_2 = list[4];
			string_2 = Class282.smethod_6(string_2);
			string empty = string.Empty;
			if (text3.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994133672) + text + Class84.smethod_0(-994133538) + text2 + Class84.smethod_0(-994133477) + string_ + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
				{
					return new GClass70(0, Class84.smethod_0(-994133465) + string_ + Class84.smethod_0(-994133430), string.Empty);
				}
				empty = Class84.smethod_0(-994133391) + string_ + Class84.smethod_0(-994147168) + text2 + Class84.smethod_0(-994133286) + text + Class84.smethod_0(-994133306) + string_2 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994133200) + text + Class84.smethod_0(-994133538) + text2 + Class84.smethod_0(-994133477) + string_ + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) > 0)
				{
					return new GClass70(0, Class84.smethod_0(-994133465) + string_ + Class84.smethod_0(-994133430), string.Empty);
				}
				empty = Class84.smethod_0(-994133065) + string_ + Class84.smethod_0(-994147168) + text2 + Class84.smethod_0(-994133286) + text + Class84.smethod_0(-994133306) + string_2 + Class84.smethod_0(-994142640) + text3;
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994132965));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			List<List<string>> list = new List<List<string>>();
			string cmdText = Class84.smethod_0(-994132933) + text + Class84.smethod_0(-994132741);
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
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
					Class84.smethod_0(-994274584)
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			cmdText = Class84.smethod_0(-994132729);
			for (int i = 0; i < list.Count; i++)
			{
				string arg = list[i][0];
				mySqlCommand.CommandText = string.Format(cmdText, arg);
				if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
				{
					list[i][5] = Class84.smethod_0(-994248276);
				}
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994132601));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string text5 = list[4];
			List<List<string>> list2 = new List<List<string>>();
			string commandText = Class84.smethod_0(-994132569) + text3 + Class84.smethod_0(-994132242) + text2 + Class84.smethod_0(-994132184) + text + Class84.smethod_0(-994132107);
			mySqlCommand.CommandText = commandText;
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
				list2.Add(item);
			}
			mySqlDataReader.Close();
			if (list2.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994132045), string.Empty);
			}
			List<List<string>> list3 = new List<List<string>>();
			commandText = Class84.smethod_0(-994132002) + text2 + Class84.smethod_0(-994136029);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			List<List<string>> list4 = new List<List<string>>();
			List<string> list5 = new List<string>();
			string format = Class84.smethod_0(-994135931);
			string text6 = Class84.smethod_0(-994135747) + text + Class84.smethod_0(-994135674) + text2 + Class84.smethod_0(-994135614) + text4 + Class84.smethod_0(-994135538) + text5 + Class84.smethod_0(-994135467) + text3 + Class84.smethod_0(-994271698);
			text6 += Class84.smethod_0(-994135406);
			for (int i = 0; i < list3.Count; i++)
			{
				string text7 = list3[i][0];
				List<string> list6 = new List<string>();
				for (int j = 0; j < list2.Count; j++)
				{
					string arg = list2[j][0];
					string item3 = Class84.smethod_0(-994278690);
					mySqlCommand.CommandText = string.Format(format, arg, text7);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						item3 = mySqlDataReader[0].ToString();
					}
					mySqlDataReader.Close();
					list6.Add(item3);
				}
				list4.Add(list6);
				string item4 = Class84.smethod_0(-994278690);
				mySqlCommand.CommandText = string.Format(text6, text7);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item4 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				list5.Add(item4);
			}
			List<string> list7 = new List<string>();
			string text8 = Class84.smethod_0(-994135367) + text + Class84.smethod_0(-994135674) + text2 + Class84.smethod_0(-994271698);
			text8 += Class84.smethod_0(-994135236);
			for (int k = 0; k < list2.Count; k++)
			{
				string arg2 = list2[k][0];
				string item5 = Class84.smethod_0(-994278690);
				mySqlCommand.CommandText = string.Format(text8, arg2);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item5 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				list7.Add(item5);
			}
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3),
				JsonConvert.SerializeObject(list4),
				JsonConvert.SerializeObject(list5),
				JsonConvert.SerializeObject(list7)
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994135257));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994135227));
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
			string text3 = list[2];
			string cmdText = Class84.smethod_0(-994144370) + text2 + Class84.smethod_0(-994135142) + text + Class84.smethod_0(-994135065) + text3 + Class84.smethod_0(-994135005);
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
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
			cmdText = Class84.smethod_0(-994134942) + text2 + Class84.smethod_0(-994134733) + text + Class84.smethod_0(-994134719) + text3 + Class84.smethod_0(-994134627);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list3 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString(),
					mySqlDataReader[3].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994134613));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string cmdText = Class84.smethod_0(-994134591) + text + Class84.smethod_0(-994134359) + text2 + Class84.smethod_0(-994134277);
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
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
			cmdText = Class84.smethod_0(-994134190) + text + Class84.smethod_0(-994134733) + text2 + Class84.smethod_0(-994138060);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list3 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list3.Add(item2);
			}
			mySqlDataReader.Close();
			List<string> value = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(list3)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994137924));
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
