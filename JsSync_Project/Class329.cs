using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class329
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2127)
			{
				gClass = smethod_15(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2128)
			{
				gClass = smethod_14(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2129)
			{
				gClass = smethod_13(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2140)
			{
				gClass = smethod_12(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2143)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2144)
			{
				gClass = smethod_10(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2145)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2209)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2210)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2139)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2302)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2303)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2304)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2316)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2317)
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994070724));
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
			string cmdText = Class84.smethod_0(-994070702) + text + Class84.smethod_0(-994070559);
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224863)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224832)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074584));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074559));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string cmdText = Class84.smethod_0(-994074479) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994074265) + text + Class84.smethod_0(-994174494);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074196)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074149)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074165)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074113)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276441)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994310831)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994173866)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074139));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074053));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<List<string>> list2 = new List<List<string>>();
			string text3 = Class84.smethod_0(-994074040) + text + Class84.smethod_0(-994271698);
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				text3 = text3 + Class84.smethod_0(-994073791) + text2;
			}
			text3 += Class84.smethod_0(-994073748);
			MySqlDataReader mySqlDataReader = new MySqlCommand(text3, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994222931)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994237662)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994237616)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994073728)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994073668));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994073656));
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
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994073573), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994222931)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994073385));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994073375));
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
			string cmdText = Class84.smethod_0(-994073294) + text + Class84.smethod_0(-994073072);
			string text2 = string.Empty;
			List<List<string>> list = new List<List<string>>();
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994237662)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994237616)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994073728)].ToString()
				};
				list.Add(item);
				if (!text2.Equals(string.Empty))
				{
					text2 += Class84.smethod_0(-994279022);
				}
				text2 = text2 + Class84.smethod_0(-994271698) + mySqlDataReader[Class84.smethod_0(-994266832)]?.ToString() + Class84.smethod_0(-994271698);
			}
			mySqlDataReader.Close();
			if (text2.Equals(string.Empty))
			{
				gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074139));
				return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
			}
			cmdText = Class84.smethod_0(-994073000) + text2 + Class84.smethod_0(-994072915);
			mySqlCommand.CommandText = cmdText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					Class84.smethod_0(-994237583),
					Class84.smethod_0(-994237583),
					string.Empty
				};
				list.Add(item2);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074139));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074053));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			List<string> list2 = new List<string>
			{
				Class84.smethod_0(-994278690),
				Class84.smethod_0(-994278690),
				Class84.smethod_0(-994278690),
				Class84.smethod_0(-994278690),
				Class84.smethod_0(-994278690),
				Class84.smethod_0(-994278690)
			};
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994072804) + text + Class84.smethod_0(-994072687) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994072609), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				int index = Convert.ToInt32(mySqlDataReader[0]) - 1;
				string value = mySqlDataReader[1].ToString();
				list2[index] = value;
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994072603));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060230));
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
			string text3 = list[3];
			string text4 = list[4];
			List<List<string>> list2 = new List<List<string>>();
			string empty = string.Empty;
			empty = ((!text4.Equals(Class84.smethod_0(-994060202))) ? (Class84.smethod_0(-994059887) + text + Class84.smethod_0(-994224932) + text2 + Class84.smethod_0(-994059612) + text3 + Class84.smethod_0(-994059541)) : (Class84.smethod_0(-994060221) + text3 + Class84.smethod_0(-994073072)));
			MySqlDataReader mySqlDataReader = new MySqlCommand(empty, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276441)]);
				string item = string.Empty;
				string item2 = Class84.smethod_0(-994059478);
				switch (num)
				{
				case 1:
					item2 = Class84.smethod_0(-994059432);
					item = Class84.smethod_0(-994127565);
					break;
				case 2:
					item2 = Class84.smethod_0(-994059434);
					item = Class84.smethod_0(-994127525);
					break;
				case 3:
					item2 = Class84.smethod_0(-994059434);
					item = Class84.smethod_0(-994127569);
					break;
				case 4:
					item2 = Class84.smethod_0(-994059434);
					item = Class84.smethod_0(-994127550);
					break;
				case 5:
					item2 = Class84.smethod_0(-994059452);
					item = Class84.smethod_0(-994059406);
					break;
				case 6:
					item2 = Class84.smethod_0(-994059411);
					item = Class84.smethod_0(-994059365);
					break;
				}
				List<string> item3 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994059369)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074196)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074149)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074165)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994074113)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276441)].ToString(),
					item,
					item2,
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994310831)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994173866)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString()
				};
				list2.Add(item3);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994072603));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060230));
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
			string text3 = list[2];
			List<List<string>> list2 = new List<List<string>>();
			if (text3.Equals(Class84.smethod_0(-994060202)))
			{
				string cmdText = Class84.smethod_0(-994059335) + text + Class84.smethod_0(-994224932) + text2 + Class84.smethod_0(-994059177);
				MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				List<Tuple<string, string>> list3 = new List<Tuple<string, string>>();
				while (mySqlDataReader.Read())
				{
					list3.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
				}
				mySqlDataReader.Close();
				cmdText = Class84.smethod_0(-994059128);
				foreach (Tuple<string, string> item in list3)
				{
					List<string> list4 = new List<string>
					{
						item.Item2,
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						item.Item1
					};
					mySqlCommand.CommandText = string.Format(cmdText, item.Item1);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					while (mySqlDataReader.Read())
					{
						int index = Convert.ToInt32(mySqlDataReader[0]);
						string value = mySqlDataReader[1].ToString();
						list4[index] = value;
					}
					mySqlDataReader.Close();
					list2.Add(list4);
				}
			}
			else
			{
				List<Tuple<string, string>> list5 = new List<Tuple<string, string>>();
				string cmdText2 = Class84.smethod_0(-994058948) + text + Class84.smethod_0(-994224932) + text2 + Class84.smethod_0(-994168706);
				MySqlCommand mySqlCommand2 = new MySqlCommand(cmdText2, mySqlConnection);
				MySqlDataReader mySqlDataReader2 = mySqlCommand2.ExecuteReader();
				while (mySqlDataReader2.Read())
				{
					list5.Add(new Tuple<string, string>(mySqlDataReader2[0].ToString(), mySqlDataReader2[1].ToString()));
				}
				mySqlDataReader2.Close();
				cmdText2 = Class84.smethod_0(-994058806);
				foreach (Tuple<string, string> item2 in list5)
				{
					List<string> list6 = new List<string>
					{
						item2.Item2,
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						Class84.smethod_0(-994278690),
						item2.Item1
					};
					mySqlCommand2.CommandText = string.Format(cmdText2, item2.Item1, text, text2);
					mySqlDataReader2 = mySqlCommand2.ExecuteReader();
					while (mySqlDataReader2.Read())
					{
						int index2 = Convert.ToInt32(mySqlDataReader2[0]);
						string value2 = mySqlDataReader2[1].ToString();
						list6[index2] = value2;
					}
					mySqlDataReader2.Close();
					list2.Add(list6);
				}
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994072603));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060230));
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
		try
		{
			mySqlConnection.Open();
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			string commandText = Class84.smethod_0(-994237934) + text2 + Class84.smethod_0(-994237801) + text + Class84.smethod_0(-994237774) + text3;
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item2 in list2)
			{
				commandText = Class84.smethod_0(-994058602) + string_ + Class84.smethod_0(-994237636) + item2.Item1 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				List<string> list4 = new List<string>();
				if (mySqlDataReader.Read())
				{
					string item = ((Convert.IsDBNull(mySqlDataReader[Class84.smethod_0(-994203637)]) || Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (mySqlDataReader[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
					list4.Add(item2.Item2);
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237662)].ToString());
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237616)].ToString());
					list4.Add(item);
					list4.Add(mySqlDataReader[Class84.smethod_0(-994237617)].ToString());
					mySqlDataReader.Close();
				}
				else
				{
					mySqlDataReader.Close();
					list4.Add(item2.Item2);
					list4.Add(Class84.smethod_0(-994237583));
					list4.Add(Class84.smethod_0(-994237583));
					list4.Add(string.Empty);
					list4.Add(string.Empty);
				}
				list3.Add(list4);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994058500));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994058490));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string> list = new List<string>();
			string commandText = Class84.smethod_0(-994237453);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[0].ToString());
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994058425));
			}
			int num = 0;
			List<List<string>> list2 = new List<List<string>>();
			foreach (string item2 in list)
			{
				List<string>? list3 = JsonConvert.DeserializeObject<List<string>>(item2);
				int num2 = Convert.ToInt32(list3[0]);
				int num3 = Convert.ToInt32(list3[1]);
				List<string> list4 = new List<string>();
				commandText = string.Format(Class84.smethod_0(-994237227), num2, num3);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					list4.Add(mySqlDataReader[0].ToString());
				}
				mySqlDataReader.Close();
				int num4 = 0;
				int num5 = 0;
				foreach (string item3 in list4)
				{
					commandText = Class84.smethod_0(-994058328) + string_ + Class84.smethod_0(-994237038) + item3 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = commandText;
					if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
					{
						num5++;
					}
					else
					{
						num4++;
					}
				}
				num += num4;
				List<string> item = new List<string>
				{
					Class120.smethod_18(num3) + Class84.smethod_0(-994263061) + num2,
					num4.ToString(),
					num5.ToString(),
					num2.ToString(),
					num3.ToString()
				};
				list2.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994058264));
			if (num == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994247224), Class84.smethod_0(-994058425));
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062288));
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
		try
		{
			mySqlConnection.Open();
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			empty = Class84.smethod_0(-994222168);
			mySqlCommand.CommandText = string.Format(empty, text, text2, text3, text4);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			empty = Class84.smethod_0(-994062209);
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item4 in list2)
			{
				mySqlCommand.CommandText = string.Format(empty, string_, text, item4.Item1);
				MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
				if (mySqlDataReader2.Read())
				{
					string item = ((Convert.IsDBNull(mySqlDataReader2[Class84.smethod_0(-994203637)]) || Convert.ToInt32(mySqlDataReader2[Class84.smethod_0(-994203637)]) == 0) ? Class84.smethod_0(-994263061) : (mySqlDataReader2[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
					List<string> item2 = new List<string>
					{
						item4.Item2,
						mySqlDataReader2[Class84.smethod_0(-994237662)].ToString(),
						mySqlDataReader2[Class84.smethod_0(-994237616)].ToString(),
						item,
						mySqlDataReader2[Class84.smethod_0(-994237617)].ToString()
					};
					list3.Add(item2);
				}
				else
				{
					List<string> item3 = new List<string>
					{
						item4.Item2,
						Class84.smethod_0(-994237583),
						Class84.smethod_0(-994237583),
						string.Empty,
						string.Empty
					};
					list3.Add(item3);
				}
				mySqlDataReader2.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994062035));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994061968));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_12(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<Tuple<int, string>> list2 = new List<Tuple<int, string>>();
			string format = Class84.smethod_0(-994061894);
			mySqlCommand.CommandText = string.Format(format, string_, text, text2);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			if (list2.Count == 0)
			{
				return new GClass70(1, Class84.smethod_0(-994236700), JsonConvert.SerializeObject(list3));
			}
			foreach (Tuple<int, string> item4 in list2)
			{
				int item = item4.Item1;
				string item2 = item4.Item2;
				format = Class84.smethod_0(-994236652);
				mySqlCommand.CommandText = string.Format(format, item, text, text2);
				int num = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				format = Class84.smethod_0(-994061679);
				mySqlCommand.CommandText = string.Format(format, string_, item, text, text2);
				int num2 = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				double num3 = ((num == 0) ? 0.0 : (100.0 * Math.Round((float)num2 / (float)num, 2)));
				List<string> item3 = new List<string>
				{
					item.ToString(),
					item2,
					num.ToString(),
					num2.ToString(),
					num3.ToString()
				};
				list3.Add(item3);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994061502));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994061424));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_13(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string empty = string.Empty;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994061403);
				empty = string.Format(empty, string_);
			}
			else
			{
				empty = Class84.smethod_0(-994061144);
				empty = string.Format(empty, string_, text);
			}
			empty = empty + Class84.smethod_0(-994222281) + text2;
			mySqlCommand.CommandText = empty;
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list3 = new List<string>();
				string item = ((Convert.IsDBNull(row[Class84.smethod_0(-994203637)]) || Convert.ToInt32(row[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (row[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
				list3.Add(row[Class84.smethod_0(-994239992)].ToString());
				list3.Add(row[Class84.smethod_0(-994222931)].ToString());
				list3.Add(row[Class84.smethod_0(-994237662)].ToString());
				list3.Add(row[Class84.smethod_0(-994237616)].ToString());
				list3.Add(item);
				list3.Add(row[Class84.smethod_0(-994237617)].ToString());
				list2.Add(list3);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060889));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060813));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_14(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994060794), string_);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list = new List<List<string>>();
			List<string> item = new List<string>
			{
				Class84.smethod_0(-994274584),
				Class84.smethod_0(-994222955)
			};
			list.Add(item);
			foreach (DataRow row in dataTable.Rows)
			{
				item = new List<string>
				{
					row[Class84.smethod_0(-994222916)].ToString(),
					row[Class84.smethod_0(-994222931)].ToString()
				};
				list.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060602));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994060535));
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
			Class326 @class = Class326.smethod_0(jsRequest_0.UserRequest.JibasId);
			if (@class == null)
			{
				return new GClass70(-1, Class309.smethod_68() + jsRequest_0.UserRequest.JibasId);
			}
			string string_ = string.Empty;
			if (!@class.method_0(mySqlConnection, ref string_))
			{
				return new GClass70(-1, Class309.smethod_69() + jsRequest_0.UserRequest.JibasId);
			}
			string arg = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994060461), string_, arg);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				List<string> list2 = new List<string>();
				string item = ((Convert.IsDBNull(row[Class84.smethod_0(-994203637)]) || Convert.ToInt32(row[Class84.smethod_0(-994203637)]) == 0) ? string.Empty : (row[Class84.smethod_0(-994203637)]?.ToString() + Class84.smethod_0(-994240938)));
				list2.Add(row[Class84.smethod_0(-994239992)].ToString());
				list2.Add(row[Class84.smethod_0(-994237662)].ToString());
				list2.Add(row[Class84.smethod_0(-994237616)].ToString());
				list2.Add(item);
				list2.Add(row[Class84.smethod_0(-994237617)].ToString());
				list.Add(list2);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994064330));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994064320));
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
