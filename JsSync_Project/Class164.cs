using System;
using System.Collections.Generic;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class164
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2111)
			{
				gClass = smethod_15(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2113)
			{
				gClass = smethod_16(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2114)
			{
				gClass = smethod_17(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2147)
			{
				gClass = smethod_18(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2211)
			{
				gClass = smethod_14(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2212)
			{
				gClass = smethod_13(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2213)
			{
				gClass = smethod_12(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2214)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2215)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2216)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2217)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2218)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2219)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2220)
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994157662));
			}
			int num = 0;
			string item = string.Empty;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
				item = mySqlDataReader[1].ToString();
			}
			mySqlDataReader.Close();
			int num2 = 0;
			commandText = Class84.smethod_0(-994157431) + text2 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num2 = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			commandText = string.Format(Class84.smethod_0(-994157292), num, num2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item8 in list2)
			{
				string item2 = item8.Item1;
				string item3 = item8.Item2;
				string item4 = string.Empty;
				commandText = string.Format(Class84.smethod_0(-994157046), item2, num2);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item4 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				string item5 = string.Empty;
				string item6 = string.Empty;
				commandText = string.Format(Class84.smethod_0(-994156888), item2, num2);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item5 = mySqlDataReader[0].ToString();
					item6 = mySqlDataReader[1].ToString();
				}
				mySqlDataReader.Close();
				List<string> item7 = new List<string>
				{
					num.ToString(),
					item,
					item2,
					item3,
					item4,
					item5,
					item6
				};
				list3.Add(item7);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994156642));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994156584));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			List<Tuple<string, string, string, string, string, string, string>> list = new List<Tuple<string, string, string, string, string, string, string>>();
			string commandText = Class84.smethod_0(-994160615) + text + Class84.smethod_0(-994160350);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string, string, string, string, string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString(), mySqlDataReader[2].ToString(), mySqlDataReader[3].ToString(), mySqlDataReader[4].ToString(), mySqlDataReader[5].ToString(), mySqlDataReader[6].ToString()));
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994160195));
			}
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<string, string, string, string, string, string, string> item12 in list)
			{
				string item = item12.Item1;
				long num = Convert.ToInt64(item12.Item2);
				string item2 = item12.Item3;
				string item3 = item12.Item4;
				string item4 = item12.Item5;
				string item5 = item12.Item6;
				string item6 = item12.Item7;
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				commandText = Class84.smethod_0(-994160131) + item + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = Convert.ToInt64(mySqlDataReader[0]) + Convert.ToInt64(mySqlDataReader[1]);
					num3 = Convert.ToInt64(mySqlDataReader[1]);
					num4 = num - num2;
				}
				mySqlDataReader.Close();
				string item7 = string.Empty;
				string item8 = string.Empty;
				string item9 = string.Empty;
				string item10 = string.Empty;
				commandText = Class84.smethod_0(-994159997) + item + Class84.smethod_0(-994159686);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item7 = mySqlDataReader[0].ToString();
					item9 = mySqlDataReader[1].ToString();
					item8 = mySqlDataReader[2].ToString();
					item10 = mySqlDataReader[3].ToString();
				}
				mySqlDataReader.Close();
				List<string> item11 = new List<string>
				{
					item3,
					item4,
					item5,
					item6,
					num.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					item2,
					item7,
					item9,
					item8,
					item10
				};
				list2.Add(item11);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994159633));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994159562));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string string_ = list[0];
			string string_2 = list[1];
			string text = list[2];
			string string_3 = list[3];
			GClass70 gClass = null;
			gClass = ((!text.Equals(Class84.smethod_0(-994159500))) ? smethod_4(mySqlConnection, string_, string_2, string_3) : smethod_5(mySqlConnection, string_, string_2, string_3));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994159520));
			return gClass;
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994159428));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_4(MySqlConnection mySqlConnection_0, string string_0, string string_1, string string_2)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		string commandText = Class84.smethod_0(-994159409) + string_0 + Class84.smethod_0(-994157499);
		mySqlCommand.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			return new GClass70(0, Class84.smethod_0(-994157662));
		}
		int num = 0;
		commandText = Class84.smethod_0(-994159281) + string_0 + Class84.smethod_0(-994159152);
		mySqlCommand.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		List<List<string>> list = new List<List<string>>();
		commandText = Class84.smethod_0(-994159136) + string_1 + Class84.smethod_0(-994159004);
		mySqlCommand.CommandText = commandText;
		mySqlDataReader = mySqlCommand.ExecuteReader();
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
		foreach (List<string> item8 in list)
		{
			string arg = item8[0];
			string item2 = item8[1];
			string item3 = item8[2];
			string item4 = Class84.smethod_0(-994274584);
			commandText = string.Format(Class84.smethod_0(-994158889), num, arg, string_2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item4 = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			string item5 = Class84.smethod_0(-994274584);
			string item6 = string.Empty;
			commandText = string.Format(Class84.smethod_0(-994158685), num, arg, string_2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item6 = mySqlDataReader[0].ToString();
				item5 = mySqlDataReader[1].ToString();
			}
			mySqlDataReader.Close();
			List<string> item7 = new List<string> { item2, item3, item4, item5, item6 };
			list2.Add(item7);
		}
		return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
	}

	private static GClass70 smethod_5(MySqlConnection mySqlConnection_0, string string_0, string string_1, string string_2)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		string commandText = Class84.smethod_0(-994159409) + string_0 + Class84.smethod_0(-994157499);
		mySqlCommand.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			return new GClass70(0, Class84.smethod_0(-994157662));
		}
		int num = 0;
		commandText = Class84.smethod_0(-994159281) + string_0 + Class84.smethod_0(-994159152);
		mySqlCommand.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		List<List<string>> list = new List<List<string>>();
		commandText = Class84.smethod_0(-994159136) + string_1 + Class84.smethod_0(-994159004);
		mySqlCommand.CommandText = commandText;
		mySqlDataReader = mySqlCommand.ExecuteReader();
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
		foreach (List<string> item8 in list)
		{
			string arg = item8[0];
			string item2 = item8[1];
			string item3 = item8[2];
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			commandText = string.Format(Class84.smethod_0(-994162493), string_2, arg, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num2 = Convert.ToInt64(mySqlDataReader[1]);
				num3 = Convert.ToInt64(mySqlDataReader[2]) + Convert.ToInt64(mySqlDataReader[4]);
				num4 = Convert.ToInt64(mySqlDataReader[3]);
				num5 = Convert.ToInt64(mySqlDataReader[4]);
				num6 = num2 - num3;
				mySqlDataReader.Close();
			}
			else
			{
				mySqlDataReader.Close();
				commandText = string.Format(Class84.smethod_0(-994162236), string_2, arg, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = Convert.ToInt64(mySqlDataReader[0]);
					num3 = 0L;
					num4 = Convert.ToInt64(mySqlDataReader[1]);
					num5 = 0L;
					num6 = num2;
				}
				mySqlDataReader.Close();
			}
			string item4 = string.Empty;
			string item5 = string.Empty;
			string item6 = string.Empty;
			commandText = string.Format(Class84.smethod_0(-994161991), string_2, arg, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item4 = mySqlDataReader[0].ToString();
				item5 = mySqlDataReader[1].ToString();
				item6 = mySqlDataReader[2].ToString();
				mySqlDataReader[3].ToString();
			}
			mySqlDataReader.Close();
			List<string> item7 = new List<string>
			{
				item2,
				item3,
				num4.ToString(),
				num2.ToString(),
				num3.ToString(),
				num5.ToString(),
				num6.ToString(),
				item4,
				item5,
				item6
			};
			list2.Add(item7);
		}
		return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
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
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994157662));
			}
			int num = 0;
			string item = string.Empty;
			commandText = Class84.smethod_0(-994157630) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
				item = mySqlDataReader[1].ToString();
			}
			mySqlDataReader.Close();
			List<Tuple<string, string>> list2 = new List<Tuple<string, string>>();
			commandText = string.Format(Class84.smethod_0(-994161728), num, text2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<string, string> item8 in list2)
			{
				string item2 = item8.Item1;
				string item3 = item8.Item2;
				string item4 = string.Empty;
				commandText = Class84.smethod_0(-994161460) + item2 + Class84.smethod_0(-994140566) + text2 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item4 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				string item5 = string.Empty;
				string item6 = string.Empty;
				commandText = Class84.smethod_0(-994161286) + item2 + Class84.smethod_0(-994161123) + text2 + Class84.smethod_0(-994161111);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item5 = mySqlDataReader[0].ToString();
					item6 = mySqlDataReader[1].ToString();
				}
				mySqlDataReader.Close();
				List<string> item7 = new List<string>
				{
					num.ToString(),
					item,
					item2,
					item3,
					item4,
					item5,
					item6
				};
				list3.Add(item7);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994160998));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994160978));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			List<Tuple<string, string, string, string, string, string, string>> list = new List<Tuple<string, string, string, string, string, string, string>>();
			string commandText = Class84.smethod_0(-994160919) + text + Class84.smethod_0(-994160350);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string, string, string, string, string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString(), mySqlDataReader[2].ToString(), mySqlDataReader[3].ToString(), mySqlDataReader[4].ToString(), mySqlDataReader[5].ToString(), mySqlDataReader[6].ToString()));
			}
			mySqlDataReader.Close();
			if (list.Count == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994160667));
			}
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<string, string, string, string, string, string, string> item12 in list)
			{
				string item = item12.Item1;
				long num = Convert.ToInt64(item12.Item2);
				string item2 = item12.Item3;
				string item3 = item12.Item4;
				string item4 = item12.Item5;
				string item5 = item12.Item6;
				string item6 = item12.Item7;
				long num2 = 0L;
				long num3 = 0L;
				long num4 = 0L;
				commandText = Class84.smethod_0(-994164655) + item + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = Convert.ToInt64(mySqlDataReader[0]) + Convert.ToInt64(mySqlDataReader[1]);
					num3 = Convert.ToInt64(mySqlDataReader[1]);
					num4 = num - num2;
				}
				mySqlDataReader.Close();
				string item7 = string.Empty;
				string item8 = string.Empty;
				string item9 = string.Empty;
				string item10 = string.Empty;
				commandText = Class84.smethod_0(-994164500) + item + Class84.smethod_0(-994159686);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					item7 = mySqlDataReader[0].ToString();
					item9 = mySqlDataReader[1].ToString();
					item8 = mySqlDataReader[2].ToString();
					item10 = mySqlDataReader[3].ToString();
				}
				mySqlDataReader.Close();
				List<string> item11 = new List<string>
				{
					item3,
					item4,
					item5,
					item6,
					num.ToString(),
					num2.ToString(),
					num3.ToString(),
					num4.ToString(),
					item2,
					item7,
					item9,
					item8,
					item10
				};
				list2.Add(item11);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994164247));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994164166));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			string string_ = list[0];
			string string_2 = list[1];
			string text = list[2];
			string string_3 = list[3];
			GClass70 gClass = null;
			gClass = ((!text.Equals(Class84.smethod_0(-994193155))) ? smethod_10(mySqlConnection, string_, string_2, string_3) : smethod_9(mySqlConnection, string_, string_2, string_3));
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994164158));
			return gClass;
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994164121));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_9(MySqlConnection mySqlConnection_0, string string_0, string string_1, string string_2)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		string commandText = Class84.smethod_0(-994159409) + string_0 + Class84.smethod_0(-994157499);
		mySqlCommand.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			return new GClass70(0, Class84.smethod_0(-994164045));
		}
		int num = 0;
		commandText = Class84.smethod_0(-994159281) + string_0 + Class84.smethod_0(-994159152);
		mySqlCommand.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		List<List<string>> list = new List<List<string>>();
		commandText = Class84.smethod_0(-994163989) + string_1 + Class84.smethod_0(-994159004);
		mySqlCommand.CommandText = commandText;
		mySqlDataReader = mySqlCommand.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			List<string> item = new List<string>
			{
				mySqlDataReader[0].ToString(),
				mySqlDataReader[1].ToString()
			};
			list.Add(item);
		}
		mySqlDataReader.Close();
		List<List<string>> list2 = new List<List<string>>();
		foreach (List<string> item8 in list)
		{
			string text = item8[0];
			string item2 = item8[1];
			long num2 = 0L;
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			long num6 = 0L;
			commandText = string.Format(Class84.smethod_0(-994163899), string_2, text, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num2 = Convert.ToInt64(mySqlDataReader[1]);
				num3 = Convert.ToInt64(mySqlDataReader[2]) + Convert.ToInt64(mySqlDataReader[4]);
				num4 = Convert.ToInt64(mySqlDataReader[3]);
				num5 = Convert.ToInt64(mySqlDataReader[4]);
				num6 = num2 - num3;
				mySqlDataReader.Close();
			}
			else
			{
				mySqlDataReader.Close();
				commandText = string.Format(Class84.smethod_0(-994163638), string_2, text, num);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num2 = Convert.ToInt64(mySqlDataReader[0]);
					num3 = 0L;
					num4 = Convert.ToInt64(mySqlDataReader[1]);
					num5 = 0L;
					num6 = num2;
				}
				mySqlDataReader.Close();
			}
			string item3 = string.Empty;
			string item4 = string.Empty;
			string item5 = string.Empty;
			string item6 = string.Empty;
			commandText = string.Format(Class84.smethod_0(-994163447), string_2, text, num);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item3 = mySqlDataReader[0].ToString();
				item4 = mySqlDataReader[1].ToString();
				item5 = mySqlDataReader[2].ToString();
				item6 = mySqlDataReader[3].ToString();
			}
			mySqlDataReader.Close();
			List<string> item7 = new List<string>
			{
				text,
				item2,
				num4.ToString(),
				num2.ToString(),
				num3.ToString(),
				num5.ToString(),
				num6.ToString(),
				item3,
				item4,
				item5,
				item6
			};
			list2.Add(item7);
		}
		return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
	}

	private static GClass70 smethod_10(MySqlConnection mySqlConnection_0, string string_0, string string_1, string string_2)
	{
		MySqlCommand mySqlCommand = new MySqlCommand
		{
			Connection = mySqlConnection_0
		};
		string commandText = Class84.smethod_0(-994159409) + string_0 + Class84.smethod_0(-994157499);
		mySqlCommand.CommandText = commandText;
		if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
		{
			return new GClass70(0, Class84.smethod_0(-994163111));
		}
		int num = 0;
		commandText = Class84.smethod_0(-994159281) + string_0 + Class84.smethod_0(-994159152);
		mySqlCommand.CommandText = commandText;
		MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
		if (mySqlDataReader.Read())
		{
			num = Convert.ToInt32(mySqlDataReader[0]);
		}
		mySqlDataReader.Close();
		List<List<string>> list = new List<List<string>>();
		commandText = Class84.smethod_0(-994163989) + string_1 + Class84.smethod_0(-994159004);
		mySqlCommand.CommandText = commandText;
		mySqlDataReader = mySqlCommand.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			List<string> item = new List<string>
			{
				mySqlDataReader[0].ToString(),
				mySqlDataReader[1].ToString()
			};
			list.Add(item);
		}
		mySqlDataReader.Close();
		List<List<string>> list2 = new List<List<string>>();
		foreach (List<string> item7 in list)
		{
			string text = item7[0];
			string item2 = item7[1];
			string item3 = Class84.smethod_0(-994274584);
			commandText = string.Format(Class84.smethod_0(-994163052), num, text, string_2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item3 = mySqlDataReader[0].ToString();
			}
			mySqlDataReader.Close();
			string item4 = Class84.smethod_0(-994274584);
			string item5 = string.Empty;
			commandText = string.Format(Class84.smethod_0(-994162836), num, text, string_2);
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				item5 = mySqlDataReader[0].ToString();
				item4 = mySqlDataReader[1].ToString();
			}
			mySqlDataReader.Close();
			List<string> item6 = new List<string> { text, item2, item3, item4, item5 };
			list2.Add(item6);
		}
		return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
	}

	private static GClass70 smethod_11(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994150269) + text2 + Class84.smethod_0(-994150089) + text + Class84.smethod_0(-994150028), mySqlConnection).ExecuteReader();
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994149967));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994157662));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994190974) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			commandText = (mySqlCommand.CommandText = Class84.smethod_0(-994149932) + text + Class84.smethod_0(-994149816) + text2 + Class84.smethod_0(-994271698));
			mySqlDataReader = mySqlCommand.ExecuteReader();
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
			if (text2.Equals(Class84.smethod_0(-994193155)))
			{
				commandText = string.Format(Class84.smethod_0(-994149715), num, text, text3, text4);
			}
			else if (text2.Equals(Class84.smethod_0(-994193161)))
			{
				commandText = string.Format(Class84.smethod_0(-994149349), num, text, text3, text4);
			}
			else if (text2.Equals(Class84.smethod_0(-994159500)))
			{
				commandText = string.Format(Class84.smethod_0(-994149078), num, text, text3, text4);
			}
			else if (text2.Equals(Class84.smethod_0(-994148716)))
			{
				commandText = string.Format(Class84.smethod_0(-994148736), num, text, text3, text4);
			}
			else if (text2.Equals(Class84.smethod_0(-994148408)))
			{
				commandText = string.Format(Class84.smethod_0(-994148414), num, text, text3, text4);
			}
			List<string> list3 = new List<string>();
			mySqlCommand.CommandText = commandText;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list3.Add(mySqlDataReader[0].ToString());
			}
			mySqlDataReader.Close();
			List<List<string>> list4 = new List<List<string>>();
			foreach (string item5 in list3)
			{
				List<string> list5 = new List<string>();
				foreach (List<string> item6 in list2)
				{
					string text6 = item6[0];
					_ = item6[1];
					if (text2.Equals(Class84.smethod_0(-994193155)))
					{
						commandText = string.Format(Class84.smethod_0(-994152174), num, text6, text, item5);
					}
					else if (text2.Equals(Class84.smethod_0(-994193161)))
					{
						commandText = string.Format(Class84.smethod_0(-994151851), num, text6, text, item5);
					}
					else if (text2.Equals(Class84.smethod_0(-994159500)))
					{
						commandText = string.Format(Class84.smethod_0(-994151584), num, text6, text, item5);
					}
					else if (text2.Equals(Class84.smethod_0(-994148716)))
					{
						commandText = string.Format(Class84.smethod_0(-994151260), num, text6, text, item5);
					}
					else if (text2.Equals(Class84.smethod_0(-994148408)))
					{
						commandText = string.Format(Class84.smethod_0(-994150925), num, text6, text, item5);
					}
					mySqlCommand.CommandText = commandText;
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						string text7 = Class84.smethod_0(-994274584);
						if (!Convert.IsDBNull(mySqlDataReader[0]))
						{
							text7 = mySqlDataReader[0].ToString();
						}
						string text8 = Class84.smethod_0(-994274584);
						if (!Convert.IsDBNull(mySqlDataReader[1]))
						{
							text8 = mySqlDataReader[1].ToString();
						}
						list5.Add(text7 + Class84.smethod_0(-994282651) + text8);
					}
					mySqlDataReader.Close();
				}
				list4.Add(list5);
			}
			string item2 = JsonConvert.SerializeObject(list2);
			string item3 = JsonConvert.SerializeObject(list3);
			string item4 = JsonConvert.SerializeObject(list4);
			List<string> value = new List<string>
			{
				num.ToString(),
				item2,
				item3,
				item4
			};
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994150682));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994150652));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			_ = list[4];
			string text5 = list[5];
			string text6 = list[6];
			string cmdText = string.Empty;
			if (text3.Equals(Class84.smethod_0(-994193155)))
			{
				cmdText = Class84.smethod_0(-994150567) + text2 + Class84.smethod_0(-994154250) + text4 + Class84.smethod_0(-994154191) + text + Class84.smethod_0(-994154128) + text5 + Class84.smethod_0(-994224932) + text6 + Class84.smethod_0(-994154063);
			}
			else if (text3.Equals(Class84.smethod_0(-994193161)))
			{
				cmdText = Class84.smethod_0(-994153986) + text2 + Class84.smethod_0(-994154250) + text4 + Class84.smethod_0(-994154191) + text + Class84.smethod_0(-994154128) + text5 + Class84.smethod_0(-994224932) + text6 + Class84.smethod_0(-994154063);
			}
			else if (text3.Equals(Class84.smethod_0(-994159500)))
			{
				cmdText = Class84.smethod_0(-994153624) + text2 + Class84.smethod_0(-994154250) + text4 + Class84.smethod_0(-994154191) + text + Class84.smethod_0(-994154128) + text5 + Class84.smethod_0(-994224932) + text6 + Class84.smethod_0(-994154063);
			}
			else if (text3.Equals(Class84.smethod_0(-994148716)))
			{
				cmdText = Class84.smethod_0(-994153211) + text2 + Class84.smethod_0(-994154250) + text4 + Class84.smethod_0(-994152778) + text + Class84.smethod_0(-994154128) + text5 + Class84.smethod_0(-994224932) + text6 + Class84.smethod_0(-994154063);
			}
			else if (text3.Equals(Class84.smethod_0(-994148408)))
			{
				cmdText = Class84.smethod_0(-994152714) + text2 + Class84.smethod_0(-994154250) + text4 + Class84.smethod_0(-994152778) + text + Class84.smethod_0(-994154128) + text5 + Class84.smethod_0(-994224932) + text6 + Class84.smethod_0(-994154063);
			}
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				long num = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994297386)]);
				long num2 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994234097)]);
				num += num2;
				if (num != 0L)
				{
					List<string> item = new List<string>
					{
						mySqlDataReader[Class84.smethod_0(-994263532)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994156447)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
						num.ToString(),
						num2.ToString(),
						mySqlDataReader[Class84.smethod_0(-994156399)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994188553)].ToString()
					};
					list2.Add(item);
				}
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994156415));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994156384));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string commandText = Class84.smethod_0(-994157854) + text + Class84.smethod_0(-994157670);
			mySqlCommand.CommandText = commandText;
			if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0)
			{
				return new GClass70(0, Class84.smethod_0(-994157662));
			}
			int num = 0;
			commandText = Class84.smethod_0(-994190974) + text + Class84.smethod_0(-994157499);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
			}
			mySqlDataReader.Close();
			List<Tuple<int, string>> list2 = new List<Tuple<int, string>>();
			commandText = (mySqlCommand.CommandText = Class84.smethod_0(-994149932) + text + Class84.smethod_0(-994149816) + text2 + Class84.smethod_0(-994271698));
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				Tuple<int, string> item = new Tuple<int, string>(Convert.ToInt32(mySqlDataReader[0]), mySqlDataReader[1].ToString());
				list2.Add(item);
			}
			mySqlDataReader.Close();
			List<List<string>> list3 = new List<List<string>>();
			foreach (Tuple<int, string> item7 in list2)
			{
				int item2 = item7.Item1;
				string item3 = item7.Item2;
				if (text2.Equals(Class84.smethod_0(-994193155)))
				{
					commandText = string.Format(Class84.smethod_0(-994156346), num, item2, text, text3, text4);
				}
				else if (text2.Equals(Class84.smethod_0(-994193161)))
				{
					commandText = string.Format(Class84.smethod_0(-994155979), num, item2, text, text3, text4);
				}
				else if (text2.Equals(Class84.smethod_0(-994159500)))
				{
					commandText = string.Format(Class84.smethod_0(-994155653), num, item2, text, text3, text4);
				}
				else if (text2.Equals(Class84.smethod_0(-994148716)))
				{
					commandText = string.Format(Class84.smethod_0(-994155349), num, item2, text, text3, text4);
				}
				else if (text2.Equals(Class84.smethod_0(-994148408)))
				{
					commandText = string.Format(Class84.smethod_0(-994155018), num, item2, text, text3, text4);
				}
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					string item4 = Class84.smethod_0(-994274584);
					if (!Convert.IsDBNull(mySqlDataReader[0]))
					{
						item4 = mySqlDataReader[0].ToString();
					}
					string item5 = Class84.smethod_0(-994274584);
					if (!Convert.IsDBNull(mySqlDataReader[1]))
					{
						item5 = mySqlDataReader[1].ToString();
					}
					List<string> item6 = new List<string>
					{
						item3,
						item4,
						item5,
						item2.ToString(),
						num.ToString()
					};
					list3.Add(item6);
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994154733));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list3));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994154704));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
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
			List<Tuple<string, string>> list = new List<Tuple<string, string>>();
			string format = Class84.smethod_0(-994154668);
			mySqlCommand.CommandText = string.Format(format, string_);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(new Tuple<string, string>(mySqlDataReader[0].ToString(), mySqlDataReader[1].ToString()));
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<string, string> item5 in list)
			{
				string item = item5.Item1;
				string item2 = item5.Item2;
				format = Class84.smethod_0(-994076643);
				mySqlCommand.CommandText = string.Format(format, item, string_);
				long num = Convert.ToInt64(mySqlCommand.ExecuteScalar());
				format = Class84.smethod_0(-994076487);
				mySqlCommand.CommandText = string.Format(format, item, string_);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				long num2 = num;
				bool flag = true;
				int num3 = 0;
				while (mySqlDataReader.Read())
				{
					num3++;
					if (flag)
					{
						flag = false;
						List<string> item3 = new List<string>
						{
							Class84.smethod_0(-994230871),
							item,
							item2,
							mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230874)].ToString()),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230830)].ToString()),
							Class176.smethod_0(num2.ToString()),
							Class176.smethod_0(num.ToString())
						};
						list2.Add(item3);
					}
					else
					{
						List<string> item4 = new List<string>
						{
							Class84.smethod_0(-994230833),
							item,
							Class84.smethod_0(-994278690),
							mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230874)].ToString()),
							Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994230830)].ToString()),
							Class176.smethod_0(num2.ToString()),
							Class84.smethod_0(-994278690)
						};
						list2.Add(item4);
					}
					long num4 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230874)]);
					long num5 = Convert.ToInt64(mySqlDataReader[Class84.smethod_0(-994230830)]);
					num2 = ((num4 > 0L) ? (num2 + num4) : (num2 - num5));
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994076274));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994076250));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
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
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			string arg = Class320.smethod_4(requestData, int_);
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994076171), string_, arg);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				string item = mySqlDataReader[Class84.smethod_0(-994245302)]?.ToString() + Class84.smethod_0(-994243044) + mySqlDataReader[Class84.smethod_0(-994245305)];
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994245259)]);
				string empty = string.Empty;
				empty = ((num != 0) ? (Class84.smethod_0(-994245243) + mySqlDataReader[Class84.smethod_0(-994245197)]) : Class84.smethod_0(-994245274));
				string text = mySqlDataReader[Class84.smethod_0(-994188553)].ToString().Trim();
				if (text.Length != 0)
				{
					empty = empty + Class84.smethod_0(-994245212) + text;
				}
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994263532)].ToString(),
					Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994297386)].ToString()),
					item,
					empty
				};
				list.Add(item2);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994075805));
			string object_ = JsonConvert.SerializeObject(list);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994075722));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
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
			List<Tuple<int, int>> list = new List<Tuple<int, int>>();
			string format = Class84.smethod_0(-994075664);
			mySqlCommand.CommandText = string.Format(format, string_);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string[] array = mySqlDataReader[0].ToString().Split('-');
				if (array.Length == 2)
				{
					int item = Convert.ToInt32(array[0]);
					int item2 = Convert.ToInt32(array[1]);
					list.Add(new Tuple<int, int>(item, item2));
				}
			}
			mySqlDataReader.Close();
			format = Class84.smethod_0(-994075470);
			List<List<string>> list2 = new List<List<string>>();
			foreach (Tuple<int, int> item6 in list)
			{
				int item3 = item6.Item1;
				int item4 = item6.Item2;
				int num = 0;
				long num2 = 0L;
				mySqlCommand.CommandText = string.Format(format, string_, item3, item4);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					num = Convert.ToInt32(mySqlDataReader[0]);
					num2 = Convert.ToInt64(mySqlDataReader[1]);
				}
				mySqlDataReader.Close();
				List<string> item5 = new List<string>
				{
					Class120.smethod_18(item4) + Class84.smethod_0(-994263061) + item3,
					num.ToString(),
					Class176.smethod_0(num2.ToString()),
					item3.ToString(),
					item4.ToString()
				};
				list2.Add(item5);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994075263));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994075199));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
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
			string requestData = jsRequest_0.UserRequest.RequestData;
			int int_ = Convert.ToInt32(jsRequest_0.UserRequest.RequestDataKey);
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_4(requestData, int_));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			mySqlCommand.CommandText = string.Format(Class84.smethod_0(-994075080), string_, text, text2, text3);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			List<List<string>> list2 = new List<List<string>>();
			while (mySqlDataReader.Read())
			{
				string item = mySqlDataReader[Class84.smethod_0(-994245302)]?.ToString() + Class84.smethod_0(-994243044) + mySqlDataReader[Class84.smethod_0(-994245305)];
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994245259)]);
				string empty = string.Empty;
				empty = ((num != 0) ? (Class84.smethod_0(-994245243) + mySqlDataReader[Class84.smethod_0(-994245197)]) : Class84.smethod_0(-994245274));
				string text4 = mySqlDataReader[Class84.smethod_0(-994188553)].ToString().Trim();
				if (text4.Length != 0)
				{
					empty = empty + Class84.smethod_0(-994245212) + text4;
				}
				List<string> item2 = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994263532)].ToString(),
					Class176.smethod_0(mySqlDataReader[Class84.smethod_0(-994297386)].ToString()),
					item,
					empty
				};
				list2.Add(item2);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994074678));
			string object_ = JsonConvert.SerializeObject(list2);
			return new GClass70(1, Class84.smethod_0(-994247224), object_);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994078699));
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
