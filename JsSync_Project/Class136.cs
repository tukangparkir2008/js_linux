using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class136
{
	public static void smethod_0(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2228)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2229)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2230)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2295)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2296)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2297)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2298)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2299)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2300)
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = Class282.smethod_6(list[2]);
			string commandText = Class84.smethod_0(-994137088) + text2 + Class84.smethod_0(-994136974) + text3 + Class84.smethod_0(-994136985) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994136913));
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
			List<List<string>> list2 = new List<List<string>>();
			string text4 = Class84.smethod_0(-994136838) + text + Class84.smethod_0(-994271698);
			if (!text2.Equals(Class84.smethod_0(-994136500)))
			{
				text4 = text4 + Class84.smethod_0(-994136507) + text2 + Class84.smethod_0(-994271698);
			}
			text4 = text4 + Class84.smethod_0(-994136477) + text3;
			mySqlCommand.CommandText = text4;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994136355)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994136376)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224863)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994221697)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188054)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224892)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224886)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224813)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994136381));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994136294));
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
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			List<List<string>> list2 = new List<List<string>>();
			string commandText = Class84.smethod_0(-994136280) + text + Class84.smethod_0(-994136087) + text2 + Class84.smethod_0(-994140122);
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
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994224770));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994224749));
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
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994139938) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994139890) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994218596) + text + Class84.smethod_0(-994139786);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994139713));
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
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994139691) + text + Class84.smethod_0(-994271698), mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994249543)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994273283)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268361)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994264701)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994277103)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994277105)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994188054)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994224892)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994266832)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994221697)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994188552)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994139247)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994139264)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994139201)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994224886)].ToString());
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994139218));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994139188));
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
			string text4 = list[3];
			string text5 = list[4];
			string empty = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand(empty, mySqlConnection);
			string text6 = Class84.smethod_0(-994274584);
			string item = Class84.smethod_0(-994274584);
			string item2 = string.Empty;
			string item3 = string.Empty;
			string item4 = string.Empty;
			string item5 = string.Empty;
			string item6 = Class84.smethod_0(-994274584);
			string item7 = string.Empty;
			empty = Class84.smethod_0(-994139167) + text + Class84.smethod_0(-994138906) + text2 + Class84.smethod_0(-994138834) + text3 + Class84.smethod_0(-994138774) + text4 + Class84.smethod_0(-994138702) + text5 + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = empty;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				text6 = mySqlDataReader[Class84.smethod_0(-994240446)].ToString();
				item = mySqlDataReader[Class84.smethod_0(-994138682)].ToString();
				item2 = mySqlDataReader[Class84.smethod_0(-994224813)].ToString();
				item3 = mySqlDataReader[Class84.smethod_0(-994138634)].ToString();
				item4 = mySqlDataReader[Class84.smethod_0(-994138598)].ToString();
				item5 = mySqlDataReader[Class84.smethod_0(-994188553)].ToString();
				item6 = mySqlDataReader[Class84.smethod_0(-994216676)].ToString();
				item7 = mySqlDataReader[Class84.smethod_0(-994138614)].ToString();
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			List<string> value = new List<string> { text6, item6, item, item4, item3, item2, item5, item7 };
			if (text6.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994138565) + text2 + Class84.smethod_0(-994138434);
				mySqlCommand.CommandText = empty;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> item8 = new List<string>
					{
						mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
						Class84.smethod_0(-994274584),
						Class84.smethod_0(-994274584),
						string.Empty
					};
					list2.Add(item8);
				}
				mySqlDataReader.Close();
			}
			else
			{
				empty = Class84.smethod_0(-994138394) + text2 + Class84.smethod_0(-994138120) + text6 + Class84.smethod_0(-994125790);
				mySqlCommand.CommandText = empty;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> item9 = new List<string>
					{
						mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994125719)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994224863)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994224832)].ToString()
					};
					list2.Add(item9);
				}
				mySqlDataReader.Close();
			}
			List<string> value2 = new List<string>
			{
				JsonConvert.SerializeObject(list2),
				JsonConvert.SerializeObject(value)
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994125672));
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
			string cmdText = Class84.smethod_0(-994125648) + text + Class84.smethod_0(-994224998) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994125343);
			List<List<string>> list2 = new List<List<string>>();
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224886)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224892)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276441)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994138634)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994138598)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994224813)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188553)].ToString(),
					Class84.smethod_0(-994274584),
					Class84.smethod_0(-994274584),
					Class84.smethod_0(-994274584),
					Class84.smethod_0(-994274584),
					Class84.smethod_0(-994274584),
					Class84.smethod_0(-994274584)
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			cmdText = Class84.smethod_0(-994125204);
			for (int i = 0; i < list2.Count; i++)
			{
				string arg = list2[i][0];
				mySqlCommand.CommandText = string.Format(cmdText, arg);
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					int num = Convert.ToInt32(mySqlDataReader[0]);
					string value = mySqlDataReader[1].ToString();
					int index = num + 10;
					list2[i][index] = value;
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994125038));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994125002));
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
			string cmdText = Class84.smethod_0(-994124991) + text + Class84.smethod_0(-994124820) + text2 + Class84.smethod_0(-994124756);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994124622));
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
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string text5 = list[4];
			string text6 = list[5];
			string text7 = list[6];
			string text8 = list[7];
			string text9 = list[8];
			string text10 = Class282.smethod_7(list[9]);
			string text11 = Class282.smethod_7(list[10]);
			string text12 = list[11];
			string text13 = list[12];
			List<List<string>> list2 = JsonConvert.DeserializeObject<List<List<string>>>(list[13]);
			string text14 = Class282.smethod_7(list[14]);
			string empty = string.Empty;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				empty = Class84.smethod_0(-994124590) + text2 + Class84.smethod_0(-994124450);
				mySqlCommand.CommandText = empty;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					text3 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				empty = Class84.smethod_0(-994124444) + text4 + Class84.smethod_0(-994124330) + text3 + Class84.smethod_0(-994124292) + text6 + Class84.smethod_0(-994124317) + text7 + Class84.smethod_0(-994124266) + text8 + Class84.smethod_0(-994124255) + text5 + Class84.smethod_0(-994124214) + text9 + Class84.smethod_0(-994124161) + text11 + Class84.smethod_0(-994124187) + text10 + Class84.smethod_0(-994124137) + text12 + Class84.smethod_0(-994124090) + text13 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994260596);
				mySqlCommand.CommandText = empty;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					text = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				foreach (List<string> item in list2)
				{
					string text15 = item[0];
					string text16 = item[1];
					string text17 = Class282.smethod_7(item[2]);
					empty = Class84.smethod_0(-994124053) + text + Class84.smethod_0(-994123939) + text15 + Class84.smethod_0(-994123957) + text16 + Class84.smethod_0(-994123918) + text17 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = empty;
					mySqlCommand.ExecuteNonQuery();
				}
				empty = Class84.smethod_0(-994215956) + text2 + Class84.smethod_0(-994123931) + text5 + Class84.smethod_0(-994219854) + text + Class84.smethod_0(-994219780) + text14 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994123839) + text7 + Class84.smethod_0(-994127810) + text8 + Class84.smethod_0(-994124214) + text9 + Class84.smethod_0(-994124161) + text11 + Class84.smethod_0(-994124187) + text10 + Class84.smethod_0(-994124137) + text12 + Class84.smethod_0(-994124090) + text13 + Class84.smethod_0(-994127827) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994127757) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				foreach (List<string> item2 in list2)
				{
					string text18 = item2[0];
					string text19 = item2[1];
					string text20 = Class282.smethod_7(item2[2]);
					empty = Class84.smethod_0(-994124053) + text + Class84.smethod_0(-994123939) + text18 + Class84.smethod_0(-994123957) + text19 + Class84.smethod_0(-994123918) + text20 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = empty;
					mySqlCommand.ExecuteNonQuery();
				}
			}
			mySqlTransaction.Commit();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994127711));
			return new GClass70(1, Class84.smethod_0(-994247224), Class84.smethod_0(-994127679));
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994127588));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static int smethod_10(string string_0)
	{
		if (!(string_0 == Class84.smethod_0(-994127565)))
		{
			if (!(string_0 == Class84.smethod_0(-994127569)))
			{
				if (!(string_0 == Class84.smethod_0(-994127525)))
				{
					if (!(string_0 == Class84.smethod_0(-994127530)))
					{
						if (!(string_0 == Class84.smethod_0(-994127550)))
						{
							return 5;
						}
						return 4;
					}
					return 3;
				}
				return 2;
			}
			return 1;
		}
		return 0;
	}
}
