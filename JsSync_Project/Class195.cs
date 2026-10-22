using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Net;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Yim.Jibas.JendelaSekolah.Common.Data;
using Yim.Jibas.JendelaSekolah.Common.Utility;

internal sealed class Class195
{
	private static CookieContainer cookieContainer_0;

	public static CookieContainer smethod_0()
	{
		if (cookieContainer_0 == null)
		{
			cookieContainer_0 = new CookieContainer();
		}
		return cookieContainer_0;
	}

	public static void smethod_1(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		try
		{
			GClass70 gClass = null;
			if (jsRequest_0.UserRequest.Protocol == 2231)
			{
				gClass = smethod_33(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2262)
			{
				gClass = smethod_34(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2263)
			{
				gClass = smethod_35(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2232)
			{
				gClass = smethod_36(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2233)
			{
				gClass = smethod_32(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2234)
			{
				gClass = smethod_31(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2235)
			{
				gClass = smethod_30(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2236)
			{
				gClass = smethod_28(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2265)
			{
				gClass = smethod_3(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2264)
			{
				gClass = smethod_29(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2237)
			{
				gClass = smethod_27(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2238)
			{
				gClass = smethod_26(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2239)
			{
				gClass = smethod_25(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2240)
			{
				gClass = smethod_24(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2241)
			{
				gClass = smethod_23(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2242)
			{
				gClass = smethod_22(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2243)
			{
				gClass = smethod_21(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2244)
			{
				gClass = smethod_19(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2245)
			{
				gClass = smethod_17(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2246)
			{
				gClass = smethod_16(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2248)
			{
				gClass = smethod_14(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2247)
			{
				gClass = smethod_13(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2249)
			{
				gClass = smethod_12(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2250)
			{
				gClass = smethod_20(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2251)
			{
				gClass = smethod_15(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2252)
			{
				gClass = smethod_11(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2253)
			{
				gClass = smethod_10(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2254)
			{
				gClass = smethod_9(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2255)
			{
				gClass = smethod_8(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2256)
			{
				gClass = smethod_7(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2257)
			{
				gClass = smethod_6(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2258)
			{
				gClass = smethod_5(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2259)
			{
				gClass = smethod_4(gclass4_0, gclass41_0, jsRequest_0);
			}
			else if (jsRequest_0.UserRequest.Protocol == 2312)
			{
				gClass = smethod_2(gclass4_0, gclass41_0, jsRequest_0);
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994131758));
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

	private static GClass70 smethod_2(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			new MySqlCommand(Class84.smethod_0(-994131713) + text, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (MySqlException ex)
		{
			if (ex.Number == 1451)
			{
				return new GClass70(0, Class84.smethod_0(-994131656), string.Empty);
			}
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994131600));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, Class309.smethod_70() + ex.Message, ex);
		}
		catch (Exception ex2)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994131600));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex2.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			return new GClass70(-1, ex2.Message, ex2);
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
			string text3 = list[2];
			string text4 = Class84.smethod_0(-994131574);
			if (!text3.Equals(Class84.smethod_0(-994278690)))
			{
				text4 = text4 + Class84.smethod_0(-994131413) + text3 + Class84.smethod_0(-994271698);
			}
			text4 = (text.Equals(Class84.smethod_0(-994278690)) ? (text4 + Class84.smethod_0(-994131305)) : (text4 + Class84.smethod_0(-994131369) + text + Class84.smethod_0(-994131299)));
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				text4 = text4 + Class84.smethod_0(-994131266) + text2 + Class84.smethod_0(-994131207);
			}
			List<List<string>> list2 = new List<List<string>>();
			MySqlCommand mySqlCommand = new MySqlCommand(text4, mySqlConnection);
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				});
			}
			mySqlDataReader.Close();
			text4 = Class84.smethod_0(-994131227);
			text4 = (text.Equals(Class84.smethod_0(-994278690)) ? (text4 + Class84.smethod_0(-994131305)) : (text4 + Class84.smethod_0(-994131369) + text + Class84.smethod_0(-994131299)));
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				text4 = text4 + Class84.smethod_0(-994131266) + text2 + Class84.smethod_0(-994131207);
			}
			List<List<string>> list3 = new List<List<string>>();
			mySqlCommand.CommandText = text4;
			mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list3.Add(new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString()
				});
			}
			mySqlDataReader.Close();
			text4 = Class84.smethod_0(-994131070);
			text4 = (text.Equals(Class84.smethod_0(-994278690)) ? (text4 + Class84.smethod_0(-994130792)) : (text4 + Class84.smethod_0(-994130872) + text + Class84.smethod_0(-994131299)));
			if (!text2.Equals(Class84.smethod_0(-994274584)))
			{
				text4 = text4 + Class84.smethod_0(-994130803) + text2 + Class84.smethod_0(-994131207);
			}
			List<List<string>> list4 = new List<List<string>>();
			for (int i = 0; i < list2.Count; i++)
			{
				string arg = list2[i][0];
				_ = list2[i][1];
				for (int j = 0; j < list3.Count; j++)
				{
					string arg2 = list3[j][0];
					_ = list3[j][1];
					int num = 0;
					float num2 = 0f;
					double num3 = 0.0;
					mySqlCommand.CommandText = string.Format(text4, arg, arg2);
					mySqlDataReader = mySqlCommand.ExecuteReader();
					if (mySqlDataReader.Read())
					{
						num = Convert.ToInt32(mySqlDataReader[0]);
						num2 = Convert.ToSingle(mySqlDataReader[1]);
					}
					mySqlDataReader.Close();
					if (num > 0)
					{
						num3 = Math.Round(num2 / (float)num, 2);
					}
					list4.Add(new List<string>
					{
						num.ToString(),
						num3.ToString()
					});
				}
			}
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994130730));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			new MySqlCommand(Class84.smethod_0(-994130707) + text, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994130627));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string value = list[1];
			string value2 = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand(Class84.smethod_0(-994130609), mySqlConnection);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994130444), MySqlDbType.Int32);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994130458), MySqlDbType.Int32);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994130413), MySqlDbType.VarChar);
			mySqlCommand.Parameters.Add(Class84.smethod_0(-994130418), MySqlDbType.VarChar);
			mySqlCommand.Parameters[Class84.smethod_0(-994130444)].Value = value;
			if (text.Equals(Class84.smethod_0(-994274584)))
			{
				mySqlCommand.Parameters[Class84.smethod_0(-994130458)].Value = text;
				mySqlCommand.Parameters[Class84.smethod_0(-994130413)].Value = value2;
				mySqlCommand.Parameters[Class84.smethod_0(-994130418)].Value = null;
			}
			else
			{
				mySqlCommand.Parameters[Class84.smethod_0(-994130458)].Value = text;
				mySqlCommand.Parameters[Class84.smethod_0(-994130413)].Value = null;
				mySqlCommand.Parameters[Class84.smethod_0(-994130418)].Value = value2;
			}
			mySqlCommand.ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994130375));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			MySqlCommand mySqlCommand = new MySqlCommand(Class84.smethod_0(-994130356) + text, mySqlConnection);
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994276368)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994311417)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994311329)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277147)].ToString()
				};
				list.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994130053));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string commandText = Class84.smethod_0(-994130025) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994129957) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994129950));
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
			string text2 = Class282.smethod_7(list[1]);
			string text3 = list[2];
			string text4 = list[3];
			string text5 = Class282.smethod_7(list[4]);
			string text6 = list[5];
			string empty = string.Empty;
			empty = ((!text.Equals(Class84.smethod_0(-994274584))) ? (Class84.smethod_0(-994117445) + text2 + Class84.smethod_0(-994219780) + text5 + Class84.smethod_0(-994189412) + text3 + Class84.smethod_0(-994117531) + text4 + Class84.smethod_0(-994117393) + text) : (Class84.smethod_0(-994117572) + text2 + Class84.smethod_0(-994219780) + text5 + Class84.smethod_0(-994189412) + text3 + Class84.smethod_0(-994117531) + text4 + Class84.smethod_0(-994117481) + text6 + Class84.smethod_0(-994271698)));
			new MySqlCommand(empty, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994117333));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string cmdText = Class84.smethod_0(-994117306) + text + Class84.smethod_0(-994271698);
			List<List<string>> list = new List<List<string>>();
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			foreach (DataRow row in dataTable.Rows)
			{
				string text2 = row[Class84.smethod_0(-994240446)].ToString();
				cmdText = Class84.smethod_0(-994117090) + text2;
				mySqlCommand.CommandText = cmdText;
				int num = Convert.ToInt32(mySqlCommand.ExecuteScalar());
				cmdText = Class84.smethod_0(-994117040) + text2 + Class84.smethod_0(-994116971);
				mySqlCommand.CommandText = cmdText;
				string item = ((Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 0) ? Class84.smethod_0(-994274584) : Class84.smethod_0(-994248276));
				List<string> item2 = new List<string>
				{
					row[Class84.smethod_0(-994240446)].ToString(),
					row[Class84.smethod_0(-994268131)].ToString(),
					row[Class84.smethod_0(-994273283)].ToString(),
					row[Class84.smethod_0(-994268492)].ToString(),
					row[Class84.smethod_0(-994277147)].ToString(),
					num.ToString(),
					item
				};
				list.Add(item2);
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994116988));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994255850) + gClass.Text);
			}
			GClass70 gClass2 = smethod_18();
			if (gClass2.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994255850) + gClass2.Text);
			}
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string commandText = Class84.smethod_0(-994270222) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994270367) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994270296) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994255838) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			string transactionId = gClass2.Data.ToString();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				SchoolId = Class348.Class352.string_0,
				IdBerita = text,
				Op = Class84.smethod_0(-994255819),
				TransactionId = transactionId
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass3.Value == 1)
			{
				mySqlTransaction?.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
			}
			mySqlTransaction?.Rollback();
			return new GClass70(-1, Class84.smethod_0(-994116905) + gClass3.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994116874));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string cmdText = Class84.smethod_0(-994116856) + text + Class84.smethod_0(-994271698);
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994116482), string.Empty);
			}
			DataRow dataRow = dataTable.Rows[0];
			string text2 = dataRow[Class84.smethod_0(-994268429)].ToString();
			string item = Class84.smethod_0(-994274584);
			string item2 = string.Empty;
			string item3 = Class84.smethod_0(-994274584);
			string item4 = string.Empty;
			string item5 = Class84.smethod_0(-994274987);
			string text3 = string.Empty;
			string item6 = Class84.smethod_0(-994274987);
			string text4 = string.Empty;
			string item7 = string.Empty;
			if (text2.Equals(Class84.smethod_0(-994268448)))
			{
				item7 = Class84.smethod_0(-994268148);
			}
			else if (text2.Equals(Class84.smethod_0(-994268389)))
			{
				item7 = Class84.smethod_0(-994268118);
			}
			else if (text2.Equals(Class84.smethod_0(-994268394)))
			{
				item7 = Class84.smethod_0(-994268066);
			}
			else if (text2.Equals(Class84.smethod_0(-994268415)))
			{
				item = dataRow[Class84.smethod_0(-994205248)].ToString();
				item2 = dataRow[Class84.smethod_0(-994273283)].ToString();
				item7 = Class84.smethod_0(-994270613) + dataRow[Class84.smethod_0(-994273283)];
			}
			else if (text2.Equals(Class84.smethod_0(-994268356)))
			{
				item = dataRow[Class84.smethod_0(-994205248)].ToString();
				item2 = dataRow[Class84.smethod_0(-994273283)].ToString();
				item3 = dataRow[Class84.smethod_0(-994268361)].ToString();
				item4 = dataRow[Class84.smethod_0(-994264701)].ToString();
				item7 = Class84.smethod_0(-994116453) + dataRow[Class84.smethod_0(-994264701)];
			}
			else if (text2.Equals(Class84.smethod_0(-994268377)))
			{
				item3 = dataRow[Class84.smethod_0(-994268361)].ToString();
				item4 = dataRow[Class84.smethod_0(-994264701)].ToString();
				List<string> list = new List<string>();
				cmdText = Class84.smethod_0(-994116479) + text + Class84.smethod_0(-994116305);
				mySqlCommand.CommandText = cmdText;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					if (!text3.Equals(string.Empty))
					{
						text3 += Class84.smethod_0(-994271851);
					}
					text3 += mySqlDataReader[1];
					list.Add(mySqlDataReader[0].ToString());
				}
				mySqlDataReader.Close();
				item5 = JsonConvert.SerializeObject(list);
			}
			else if (text2.Equals(Class84.smethod_0(-994268275)))
			{
				item = dataRow[Class84.smethod_0(-994205248)].ToString();
				item2 = dataRow[Class84.smethod_0(-994273283)].ToString();
				List<string> list2 = new List<string>();
				cmdText = Class84.smethod_0(-994116233) + text + Class84.smethod_0(-994116085);
				mySqlCommand.CommandText = cmdText;
				MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
				while (mySqlDataReader2.Read())
				{
					if (!text4.Equals(string.Empty))
					{
						text4 += Class84.smethod_0(-994271851);
					}
					text4 += mySqlDataReader2[1];
					list2.Add(mySqlDataReader2[0].ToString());
				}
				mySqlDataReader2.Close();
				item6 = JsonConvert.SerializeObject(list2);
			}
			DateTime dateTime = Convert.ToDateTime(dataTable.Rows[0][Class84.smethod_0(-994268477)]);
			List<string> value = new List<string>
			{
				text,
				dataRow[Class84.smethod_0(-994116010)].ToString(),
				dataRow[Class84.smethod_0(-994116027)].ToString(),
				dateTime.Year.ToString(),
				dateTime.Month.ToString(),
				dateTime.Day.ToString(),
				dateTime.Hour.ToString(),
				dateTime.Minute.ToString(),
				dataRow[Class84.smethod_0(-994268488)].ToString(),
				dataRow[Class84.smethod_0(-994268492)].ToString(),
				dataRow[Class84.smethod_0(-994268508)].ToString(),
				text2,
				item7,
				item,
				item2,
				item3,
				item4,
				item5,
				text3,
				item6,
				text4
			};
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(value));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994115978));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string cmdText = Class84.smethod_0(-994115960) + text + Class84.smethod_0(-994115836) + text2 + Class84.smethod_0(-994115732);
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
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994115672));
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
		MySqlTransaction mySqlTransaction = null;
		try
		{
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994255850) + gClass.Text);
			}
			GClass70 gClass2 = smethod_18();
			if (gClass2.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994255850) + gClass2.Text);
			}
			MySqlCommand mySqlCommand = new MySqlCommand();
			mySqlCommand.Connection = mySqlConnection;
			mySqlCommand.Transaction = mySqlTransaction;
			string commandText = Class84.smethod_0(-994270367) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994255838) + text + Class84.smethod_0(-994271698);
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			string transactionId = gClass2.Data.ToString();
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				SchoolId = Class348.Class352.string_0,
				IdBerita = text,
				Op = Class84.smethod_0(-994255819),
				TransactionId = transactionId
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			if (gClass3.Value == 1)
			{
				mySqlTransaction?.Commit();
				return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
			}
			mySqlTransaction?.Rollback();
			return new GClass70(-1, Class84.smethod_0(-994116905) + gClass3.Text);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994115645));
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string cmdText = Class84.smethod_0(-994115613) + text + Class84.smethod_0(-994271698);
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994268488)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268508)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268492)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994116027)].ToString());
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994119518));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994119475));
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1] + Class84.smethod_0(-994119441);
			string text3 = list[2] + Class84.smethod_0(-994119393);
			string text4 = list[3];
			string text5 = Class84.smethod_0(-994119409) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994118982);
			if (!text.Equals(Class84.smethod_0(-994239381)))
			{
				text5 = text5 + Class84.smethod_0(-994118989) + text + Class84.smethod_0(-994271698);
			}
			if (!text4.Equals(Class84.smethod_0(-994248828)))
			{
				text5 = text5 + Class84.smethod_0(-994118948) + text4 + Class84.smethod_0(-994118982);
			}
			text5 += Class84.smethod_0(-994118975);
			MySqlCommand mySqlCommand = new MySqlCommand(text5, mySqlConnection);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				string text6 = row[Class84.smethod_0(-994255971)].ToString();
				string text7 = row[Class84.smethod_0(-994268429)].ToString();
				string item = row[Class84.smethod_0(-994266832)].ToString();
				string item2 = row[Class84.smethod_0(-994277142)].ToString();
				string item3 = Class84.smethod_0(-994274584);
				string item4 = string.Empty;
				string item5 = Class84.smethod_0(-994274584);
				string item6 = string.Empty;
				string item7 = Class84.smethod_0(-994274987);
				string text8 = string.Empty;
				string item8 = Class84.smethod_0(-994274987);
				string text9 = string.Empty;
				string item9 = string.Empty;
				if (text7.Equals(Class84.smethod_0(-994268448)))
				{
					item9 = Class84.smethod_0(-994268148);
				}
				else if (text7.Equals(Class84.smethod_0(-994268389)))
				{
					item9 = Class84.smethod_0(-994268118);
				}
				else if (text7.Equals(Class84.smethod_0(-994268394)))
				{
					item9 = Class84.smethod_0(-994268066);
				}
				else if (text7.Equals(Class84.smethod_0(-994268415)))
				{
					item3 = row[Class84.smethod_0(-994205248)].ToString();
					item4 = row[Class84.smethod_0(-994273283)].ToString();
					item9 = Class84.smethod_0(-994270613) + row[Class84.smethod_0(-994273283)];
				}
				else if (text7.Equals(Class84.smethod_0(-994268356)))
				{
					item3 = row[Class84.smethod_0(-994205248)].ToString();
					item4 = row[Class84.smethod_0(-994273283)].ToString();
					item5 = row[Class84.smethod_0(-994268361)].ToString();
					item6 = row[Class84.smethod_0(-994264701)].ToString();
					item9 = Class84.smethod_0(-994116453) + row[Class84.smethod_0(-994264701)];
				}
				else if (text7.Equals(Class84.smethod_0(-994268377)))
				{
					item5 = row[Class84.smethod_0(-994268361)].ToString();
					item6 = row[Class84.smethod_0(-994264701)].ToString();
					List<string> list3 = new List<string>();
					text5 = Class84.smethod_0(-994118929) + text6 + Class84.smethod_0(-994118783);
					mySqlCommand.CommandText = text5;
					MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
					while (mySqlDataReader.Read())
					{
						if (!text8.Equals(string.Empty))
						{
							text8 += Class84.smethod_0(-994271851);
						}
						text8 += mySqlDataReader[1];
						list3.Add(mySqlDataReader[0].ToString());
					}
					mySqlDataReader.Close();
					item7 = JsonConvert.SerializeObject(list3);
					item9 = Class84.smethod_0(-994118707) + text8;
				}
				else if (text7.Equals(Class84.smethod_0(-994268275)))
				{
					item3 = row[Class84.smethod_0(-994205248)].ToString();
					item4 = row[Class84.smethod_0(-994273283)].ToString();
					List<string> list4 = new List<string>();
					text5 = Class84.smethod_0(-994118671) + text6 + Class84.smethod_0(-994118519);
					mySqlCommand.CommandText = text5;
					MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
					while (mySqlDataReader2.Read())
					{
						if (!text9.Equals(string.Empty))
						{
							text9 += Class84.smethod_0(-994271851);
						}
						text9 += mySqlDataReader2[1];
						list4.Add(mySqlDataReader2[0].ToString());
					}
					mySqlDataReader2.Close();
					item8 = JsonConvert.SerializeObject(list4);
					item9 = Class84.smethod_0(-994118456) + text9;
				}
				List<string> item10 = new List<string>
				{
					text6,
					row[Class84.smethod_0(-994116010)].ToString(),
					row[Class84.smethod_0(-994116027)].ToString(),
					row[Class84.smethod_0(-994268488)].ToString(),
					row[Class84.smethod_0(-994268492)].ToString(),
					text7,
					item9,
					item3,
					item4,
					item5,
					item6,
					item7,
					text8,
					item8,
					text9,
					item,
					item2
				};
				list2.Add(item10);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994270650));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994118401));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2] + Class84.smethod_0(-994119441);
			string text4 = list[3] + Class84.smethod_0(-994119393);
			string cmdText = Class84.smethod_0(-994118382) + text + Class84.smethod_0(-994118114) + text2 + Class84.smethod_0(-994118052) + text3 + Class84.smethod_0(-994224932) + text4 + Class84.smethod_0(-994117987);
			MySqlCommand mySqlCommand = new MySqlCommand(cmdText, mySqlConnection);
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			List<List<string>> list2 = new List<List<string>>();
			foreach (DataRow row in dataTable.Rows)
			{
				string text5 = row[Class84.smethod_0(-994255971)].ToString();
				string text6 = string.Empty;
				cmdText = Class84.smethod_0(-994117924) + text5 + Class84.smethod_0(-994116305);
				mySqlCommand.CommandText = cmdText;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					if (!text6.Equals(string.Empty))
					{
						text6 += Class84.smethod_0(-994271851);
					}
					text6 += mySqlDataReader[0];
				}
				mySqlDataReader.Close();
				List<string> item = new List<string>
				{
					text5,
					row[Class84.smethod_0(-994116010)].ToString(),
					row[Class84.smethod_0(-994116027)].ToString(),
					row[Class84.smethod_0(-994264701)].ToString(),
					text6,
					row[Class84.smethod_0(-994268488)].ToString(),
					row[Class84.smethod_0(-994268492)].ToString()
				};
				list2.Add(item);
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994117818));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994117783));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
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
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string format = Class84.smethod_0(-994117750);
			format = string.Format(format, text);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				CommandText = format
			};
			MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
			mySqlDataAdapter.SelectCommand = mySqlCommand;
			DataTable dataTable = new DataTable();
			mySqlDataAdapter.Fill(dataTable);
			if (dataTable.Rows.Count == 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994268571));
			}
			List<string> list = new List<string>();
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994268488)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994268492)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994268508)].ToString());
			list.Add(Class84.smethod_0(-994248276));
			DateTime dateTime = Convert.ToDateTime(dataTable.Rows[0][Class84.smethod_0(-994268477)]);
			list.Add(dateTime.Year.ToString());
			list.Add(dateTime.Month.ToString());
			list.Add(dateTime.Day.ToString());
			list.Add(dateTime.Hour.ToString());
			list.Add(dateTime.Minute.ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994205248)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994273283)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994268361)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994264701)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994255988)].ToString());
			list.Add(dataTable.Rows[0][Class84.smethod_0(-994121394)].ToString());
			format = Class84.smethod_0(-994121360) + text + Class84.smethod_0(-994271698);
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			mySqlCommand.CommandText = format;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list2.Add(mySqlDataReader[Class84.smethod_0(-994277103)].ToString());
				list3.Add(mySqlDataReader[Class84.smethod_0(-994277105)].ToString());
			}
			mySqlDataReader.Close();
			list.Add(JsonConvert.SerializeObject(list2));
			list.Add(JsonConvert.SerializeObject(list3));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994121192));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_18()
	{
		try
		{
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(new Class191
			{
				Op = Class84.smethod_0(-994265364)
			}), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 @class = new Class139(smethod_0());
			GClass70 result;
			try
			{
				byte[] bytes = @class.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				result = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)@class).Dispose();
			}
			return result;
		}
		catch (Exception ex)
		{
			return new GClass70(-99, ex.Message, ex);
		}
	}

	private static GClass70 smethod_19(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994270657) + gClass.Text);
			}
			GClass70 gClass2 = smethod_18();
			if (gClass2.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994270657) + gClass2.Text);
			}
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string deskripsi = list[1];
			string berita = list[2];
			_ = list[3];
			string text2 = list[4];
			string text3 = list[5];
			string text4 = list[6];
			string text5 = list[7];
			string text6 = list[8];
			string text7 = list[9];
			string target = list[10];
			string idDepartemen = list[11];
			string departemen = list[12];
			string idTingkat = list[13];
			string text8 = list[14];
			string namaPenulis = list[15];
			string text9 = list[16];
			string text10 = list[17];
			string text11 = list[18];
			bool flag = !text10.Equals(Class84.smethod_0(-994274584));
			string text12 = text2 + Class84.smethod_0(-994278690) + text3 + Class84.smethod_0(-994278690) + text4 + Class84.smethod_0(-994263061) + text5 + Class84.smethod_0(-994263069) + text6;
			List<string> list2 = JsonConvert.DeserializeObject<List<string>>(text7);
			string empty = string.Empty;
			if (!flag)
			{
				int num = 0;
				do
				{
					text10 = Class211.smethod_1(10) ?? string.Empty;
					empty = Class84.smethod_0(-994270426) + text10 + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = empty;
				}
				while (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0);
			}
			string transactionId = gClass2.Data.ToString();
			Class191 @class = new Class191
			{
				Op = (flag ? Class84.smethod_0(-994270647) : Class84.smethod_0(-994270626)),
				TransactionId = transactionId
			};
			@class.SchoolId = Class348.Class352.string_0;
			@class.IdBerita = text10;
			@class.Judul = text;
			@class.Deskripsi = deskripsi;
			@class.Berita = berita;
			@class.TglTayang = text12;
			@class.Target = target;
			@class.IdDepartemen = idDepartemen;
			@class.Departemen = departemen;
			@class.IdTingkat = idTingkat;
			@class.IdKelas = text7;
			@class.IdKelompok = Class84.smethod_0(-994274987);
			@class.IdAnggota = Class84.smethod_0(-994274987);
			@class.Penulis = text8;
			@class.NamaPenulis = namaPenulis;
			@class.NamaTarget = ((text9.Length <= 255) ? text9 : text9.Substring(0, 255));
			if (flag)
			{
				empty = Class84.smethod_0(-994270367) + text10 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994270149);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Clear();
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
				mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
				mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
				if (!@class.Departemen.Equals(string.Empty))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
				}
				if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
				}
				mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = text8;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994269767);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Clear();
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
				mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
				mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
				if (!@class.Departemen.Equals(string.Empty))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
				}
				if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
				}
				mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = text8;
				mySqlCommand.ExecuteNonQuery();
			}
			if (list2.Count > 0)
			{
				empty = Class84.smethod_0(-994269579);
				foreach (string item in list2)
				{
					mySqlCommand.CommandText = string.Format(empty, text10, item);
					mySqlCommand.ExecuteNonQuery();
				}
			}
			if (text11.Equals(Class84.smethod_0(-994248276)))
			{
				Class156 class2 = new Class156(mySqlCommand);
				foreach (string item2 in list2)
				{
					string string_ = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item2;
					class2.method_0(string_, Class84.smethod_0(-994270650), text, Class84.smethod_0(-994269328), text12);
					string_ = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item2;
					class2.method_4(string.Empty, string.Empty, string.Empty, string_, Class84.smethod_0(-994270650), text, Class84.smethod_0(-994269328), text12);
				}
			}
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(@class), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 class3 = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = class3.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)class3).Dispose();
			}
			if (gClass3.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994256874), string.Empty);
			}
			mySqlTransaction?.Rollback();
			return new GClass70(1, Class84.smethod_0(-994256846) + gClass3.Text, string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994121160));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_20(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		MySqlTransaction mySqlTransaction = null;
		try
		{
			GClass70 gClass = Class194.smethod_0();
			if (gClass.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994270657) + gClass.Text);
			}
			GClass70 gClass2 = smethod_18();
			if (gClass2.Value < 0)
			{
				return new GClass70(-1, Class84.smethod_0(-994270657) + gClass2.Text);
			}
			mySqlConnection.Open();
			mySqlTransaction = mySqlConnection.BeginTransaction(IsolationLevel.ReadCommitted, string.Empty);
			string empty = string.Empty;
			MySqlCommand mySqlCommand = new MySqlCommand
			{
				Connection = mySqlConnection,
				Transaction = mySqlTransaction
			};
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string deskripsi = list[2];
			string berita = list[3];
			_ = list[4];
			string text3 = list[5];
			string text4 = list[6];
			string text5 = list[7];
			string text6 = list[8];
			string text7 = list[9];
			string text8 = list[10];
			string idDepartemen = list[11];
			string departemen = list[12];
			string idTingkat = list[13];
			string text9 = list[14];
			string text10 = list[15];
			string text11 = list[16];
			string namaPenulis = list[17];
			string text12 = list[18];
			string text13 = list[19];
			string idAnggota = Class84.smethod_0(-994274987);
			bool flag = !text.Equals(Class84.smethod_0(-994274584));
			string text14 = text3 + Class84.smethod_0(-994278690) + text4 + Class84.smethod_0(-994278690) + text5 + Class84.smethod_0(-994263061) + text6 + Class84.smethod_0(-994263069) + text7;
			List<string> list2 = JsonConvert.DeserializeObject<List<string>>(text9);
			List<string> list3 = JsonConvert.DeserializeObject<List<string>>(text10);
			List<string> list4 = new List<string>();
			if (text8.Equals(Class84.smethod_0(-994268275)))
			{
				string text15 = string.Empty;
				foreach (string item in list3)
				{
					if (!text15.Equals(string.Empty))
					{
						text15 += Class84.smethod_0(-994279022);
					}
					text15 += item;
				}
				empty = Class84.smethod_0(-994270502) + text15 + Class84.smethod_0(-994271866);
				mySqlCommand.CommandText = empty;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994276368)]);
					string arg = string.Empty;
					string arg2 = string.Empty;
					switch (num)
					{
					case 0:
						arg = mySqlDataReader[Class84.smethod_0(-994277136)].ToString();
						arg2 = Class84.smethod_0(-994277136);
						break;
					case 1:
						arg = mySqlDataReader[Class84.smethod_0(-994266832)].ToString();
						arg2 = Class84.smethod_0(-994266832);
						break;
					case 3:
						arg = mySqlDataReader[Class84.smethod_0(-994270443)].ToString();
						arg2 = Class84.smethod_0(-994270443);
						break;
					}
					list4.Add(string.Format(Class84.smethod_0(-994270449), num, arg2, arg));
				}
				mySqlDataReader.Close();
				idAnggota = JsonConvert.SerializeObject(list4);
			}
			if (!flag)
			{
				int num2 = 0;
				do
				{
					text = Class211.smethod_1(10) ?? string.Empty;
					empty = Class84.smethod_0(-994270426) + text + Class84.smethod_0(-994271698);
					mySqlCommand.CommandText = empty;
				}
				while (Convert.ToInt32(mySqlCommand.ExecuteScalar()) != 0);
			}
			string transactionId = gClass2.Data.ToString();
			Class191 @class = new Class191
			{
				Op = (flag ? Class84.smethod_0(-994270647) : Class84.smethod_0(-994270626)),
				TransactionId = transactionId
			};
			@class.SchoolId = Class348.Class352.string_0;
			@class.IdBerita = text;
			@class.Judul = text2;
			@class.Deskripsi = deskripsi;
			@class.Berita = berita;
			@class.TglTayang = text14;
			@class.Target = text8;
			@class.IdDepartemen = idDepartemen;
			@class.Departemen = departemen;
			@class.IdTingkat = idTingkat;
			@class.IdKelas = text9;
			@class.IdKelompok = text10;
			@class.IdAnggota = idAnggota;
			@class.Penulis = text11;
			@class.NamaPenulis = namaPenulis;
			@class.NamaTarget = ((text12.Length <= 255) ? text12 : text12.Substring(0, 255));
			if (flag)
			{
				empty = Class84.smethod_0(-994270367) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994270296) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994270222) + text + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994270149);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Clear();
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
				mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
				mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
				if (!@class.Departemen.Equals(string.Empty))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
				}
				if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
				}
				mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = text11;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = Class84.smethod_0(-994269767);
				mySqlCommand.CommandText = empty;
				mySqlCommand.Parameters.Clear();
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269940), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269892), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269911), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269862), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269880), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269831), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269833), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269799), MySqlDbType.VarChar);
				mySqlCommand.Parameters.Add(Class84.smethod_0(-994269814), MySqlDbType.VarChar);
				mySqlCommand.Parameters[Class84.smethod_0(-994269940)].Value = @class.IdBerita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269892)].Value = @class.Judul;
				mySqlCommand.Parameters[Class84.smethod_0(-994269911)].Value = @class.Deskripsi;
				mySqlCommand.Parameters[Class84.smethod_0(-994269862)].Value = @class.Berita;
				mySqlCommand.Parameters[Class84.smethod_0(-994269880)].Value = @class.TglTayang;
				mySqlCommand.Parameters[Class84.smethod_0(-994269831)].Value = @class.Target;
				if (!@class.Departemen.Equals(string.Empty))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269833)].Value = @class.Departemen;
				}
				if (!@class.IdTingkat.Equals(Class84.smethod_0(-994274584)))
				{
					mySqlCommand.Parameters[Class84.smethod_0(-994269799)].Value = @class.IdTingkat;
				}
				mySqlCommand.Parameters[Class84.smethod_0(-994269814)].Value = text11;
				mySqlCommand.ExecuteNonQuery();
			}
			if (list2.Count > 0)
			{
				empty = Class84.smethod_0(-994269579);
				foreach (string item2 in list2)
				{
					mySqlCommand.CommandText = string.Format(empty, text, item2);
					mySqlCommand.ExecuteNonQuery();
				}
			}
			if (list3.Count > 0)
			{
				empty = Class84.smethod_0(-994269521);
				foreach (string item3 in list3)
				{
					mySqlCommand.CommandText = string.Format(empty, text, item3);
					mySqlCommand.ExecuteNonQuery();
				}
			}
			if (list4.Count > 0)
			{
				empty = Class84.smethod_0(-994269409);
				foreach (string item4 in list4)
				{
					string[] array = item4.Split(':');
					if (array.Length == 3)
					{
						string text16 = array[0];
						string text17 = array[1];
						string text18 = array[2];
						mySqlCommand.CommandText = string.Format(empty, text, text16, text17, text18);
						mySqlCommand.ExecuteNonQuery();
					}
				}
			}
			if (text13.Equals(Class84.smethod_0(-994248276)))
			{
				Class156 class2 = new Class156(mySqlCommand);
				if (text8.Equals(Class84.smethod_0(-994268448)))
				{
					string string_ = Class348.Class352.string_0 + Class84.smethod_0(-994269372);
					class2.method_0(string_, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					string_ = Class348.Class352.string_0 + Class84.smethod_0(-994269372);
					class2.method_4(string.Empty, string.Empty, string.Empty, string_, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
				else if (text8.Equals(Class84.smethod_0(-994268389)))
				{
					string string_2 = Class348.Class352.string_0 + Class84.smethod_0(-994269343);
					class2.method_0(string_2, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					string_2 = Class348.Class352.string_0 + Class84.smethod_0(-994269343);
					class2.method_4(string.Empty, string.Empty, string.Empty, string_2, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
				else if (text8.Equals(Class84.smethod_0(-994268394)))
				{
					string string_3 = Class348.Class352.string_0 + Class84.smethod_0(-994269283);
					class2.method_0(string_3, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					string_3 = Class348.Class352.string_0 + Class84.smethod_0(-994269283);
					class2.method_4(string.Empty, string.Empty, string.Empty, string_3, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
				else if (text8.Equals(Class84.smethod_0(-994268415)))
				{
					string string_4 = Class348.Class352.string_0 + Class84.smethod_0(-994269303) + @class.IdDepartemen;
					class2.method_0(string_4, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					string_4 = Class348.Class352.string_0 + Class84.smethod_0(-994269303) + @class.IdDepartemen;
					class2.method_4(string.Empty, string.Empty, string.Empty, string_4, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
				else if (text8.Equals(Class84.smethod_0(-994268356)))
				{
					string string_5 = Class348.Class352.string_0 + Class84.smethod_0(-994269306) + @class.IdTingkat;
					class2.method_0(string_5, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					string_5 = Class348.Class352.string_0 + Class84.smethod_0(-994269306) + @class.IdTingkat;
					class2.method_4(string.Empty, string.Empty, string.Empty, string_5, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
				else if (text8.Equals(Class84.smethod_0(-994268377)))
				{
					foreach (string item5 in list2)
					{
						string string_6 = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item5;
						class2.method_0(string_6, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
						string_6 = Class348.Class352.string_0 + Class84.smethod_0(-994269261) + item5;
						class2.method_4(string.Empty, string.Empty, string.Empty, string_6, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
					}
				}
				else if (text8.Equals(Class84.smethod_0(-994268275)))
				{
					List<string> list5 = new List<string>();
					empty = Class84.smethod_0(-994269280);
					foreach (string item6 in list4)
					{
						string[] array2 = item6.Split(':');
						if (array2.Length == 3)
						{
							string text19 = array2[1];
							string text20 = array2[2];
							mySqlCommand.CommandText = string.Format(empty, text19, text20);
							MySqlDataReader mySqlDataReader2 = mySqlCommand.ExecuteReader();
							while (mySqlDataReader2.Read())
							{
								list5.Add(mySqlDataReader2[Class84.smethod_0(-994267115)].ToString());
							}
							mySqlDataReader2.Close();
							if (text19.Equals(Class84.smethod_0(-994277136)))
							{
								class2.method_4(text20, string.Empty, string.Empty, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
							}
							else if (text19.Equals(Class84.smethod_0(-994266832)))
							{
								class2.method_4(string.Empty, text20, string.Empty, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
							}
							else if (text19.Equals(Class84.smethod_0(-994270443)))
							{
								class2.method_4(string.Empty, string.Empty, text20, string.Empty, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
							}
						}
					}
					string string_7 = JsonConvert.SerializeObject(list5);
					class2.method_2(string_7, Class84.smethod_0(-994270650), text2, Class84.smethod_0(-994269328), text14);
				}
			}
			var (name, value) = Class320.smethod_5(JsonConvert.SerializeObject(@class), Class320.int_5, 10000);
			NameValueCollection data = new NameValueCollection { { name, value } };
			Class139 class3 = new Class139(smethod_0());
			GClass70 gClass3;
			try
			{
				byte[] bytes = class3.UploadValues(Class272.smethod_11(), Class84.smethod_0(-994265316), data);
				gClass3 = GClass70.smethod_1(Class305.smethod_0(Encoding.UTF8.GetString(bytes), Class320.int_6).Data.ToString());
			}
			finally
			{
				((IDisposable)class3).Dispose();
			}
			if (gClass3.Value == 1)
			{
				mySqlTransaction.Commit();
				return new GClass70(1, Class84.smethod_0(-994256874), string.Empty);
			}
			mySqlTransaction?.Rollback();
			return new GClass70(1, Class84.smethod_0(-994256846) + gClass3.Text, string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994121127));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_21(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			MySqlCommand mySqlCommand = new MySqlCommand(Class84.smethod_0(-994121092) + text + Class84.smethod_0(-994120773) + text2 + Class84.smethod_0(-994120706) + text3 + Class84.smethod_0(-994138434), mySqlConnection);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				int num = Convert.ToInt32(mySqlDataReader[Class84.smethod_0(-994120641)]);
				string empty = string.Empty;
				if (num == 0)
				{
					empty = Class309.smethod_43();
				}
				else
				{
					try
					{
						empty = Convert.ToBase64String((byte[])mySqlDataReader[Class84.smethod_0(-994205227)]);
					}
					catch (Exception)
					{
						empty = Class309.smethod_43();
					}
				}
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					empty,
					mySqlDataReader[Class84.smethod_0(-994120659)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994264701)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994273283)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994120616));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex2)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994120639));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex2.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex2.Message, ex2);
			return new GClass70(-1, ex2.Message, ex2);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_22(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			new MySqlCommand(Class84.smethod_0(-994120607) + text, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994120496));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_23(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string text4 = Class282.smethod_7(list[3]);
			string text5 = Class282.smethod_7(list[4]);
			string empty = string.Empty;
			empty = ((!text.Equals(Class84.smethod_0(-994274584))) ? (Class84.smethod_0(-994120339) + text4 + Class84.smethod_0(-994120365) + text5 + Class84.smethod_0(-994136985) + text + Class84.smethod_0(-994271698)) : (Class84.smethod_0(-994120449) + text3 + Class84.smethod_0(-994120416) + text4 + Class84.smethod_0(-994120365) + text5 + Class84.smethod_0(-994120327) + text2 + Class84.smethod_0(-994271698)));
			new MySqlCommand(empty, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994120281));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_24(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			string cmdText = Class84.smethod_0(-994120249) + text;
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			if (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[0].ToString());
				list.Add(mySqlDataReader[1].ToString());
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994120122));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_25(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string cmdText = Class84.smethod_0(-994120093) + text + Class84.smethod_0(-994119909) + text2 + Class84.smethod_0(-994119900);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[0].ToString(),
					mySqlDataReader[1].ToString(),
					mySqlDataReader[2].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994119829));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_26(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			int num = 0;
			int num2 = 0;
			string commandText = Class84.smethod_0(-994119797) + text2 + Class84.smethod_0(-994278690) + text3 + Class84.smethod_0(-994119756) + text2 + Class84.smethod_0(-994278690) + text3 + Class84.smethod_0(-994119713);
			mySqlCommand.CommandText = commandText;
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			if (mySqlDataReader.Read())
			{
				num = Convert.ToInt32(mySqlDataReader[0]);
				num2 = Convert.ToInt32(mySqlDataReader[1]);
			}
			mySqlDataReader.Close();
			List<List<string>> list2 = new List<List<string>>();
			int num3 = 0;
			int num4 = 0;
			for (int num5 = num - 1; num5 > 0; num5--)
			{
				commandText = string.Format(Class84.smethod_0(-994119733), text2, text3, num5);
				mySqlCommand.CommandText = commandText;
				string text4 = mySqlCommand.ExecuteScalar().ToString();
				List<string> list3 = new List<string>
				{
					num3.ToString(),
					text4
				};
				commandText = Class84.smethod_0(-994123760) + text + Class84.smethod_0(-994119909) + text4 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string text5 = mySqlDataReader[0].ToString().Trim();
					if (text5.Length > 15)
					{
						text5 = text5.Substring(0, 12) + Class84.smethod_0(-994123673);
					}
					list3.Add(text5);
				}
				mySqlDataReader.Close();
				list2.Add(list3);
				num4++;
			}
			for (int i = 1; i <= num2; i++)
			{
				string text6 = string.Format(Class84.smethod_0(-994123631), text2, text3, i);
				List<string> list4 = new List<string>
				{
					num3.ToString(),
					text6
				};
				commandText = Class84.smethod_0(-994123760) + text + Class84.smethod_0(-994119909) + text6 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string text7 = mySqlDataReader[0].ToString().Trim();
					if (text7.Length > 15)
					{
						text7 = text7.Substring(0, 12) + Class84.smethod_0(-994123673);
					}
					list4.Add(text7);
				}
				mySqlDataReader.Close();
				list2.Add(list4);
				num4++;
				if (num4 == 7)
				{
					num4 = 0;
					num3++;
				}
			}
			int num6 = 0;
			for (int j = num4; j < 7; j++)
			{
				num6++;
				commandText = string.Format(Class84.smethod_0(-994123645), text2, text3, num2, num6);
				mySqlCommand.CommandText = commandText;
				string text8 = mySqlCommand.ExecuteScalar().ToString();
				List<string> list5 = new List<string>
				{
					num3.ToString(),
					text8
				};
				commandText = Class84.smethod_0(-994123760) + text + Class84.smethod_0(-994119909) + text8 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = commandText;
				mySqlDataReader = mySqlCommand.ExecuteReader();
				while (mySqlDataReader.Read())
				{
					string text9 = mySqlDataReader[0].ToString().Trim();
					if (text9.Length > 15)
					{
						text9 = text9.Substring(0, 12) + Class84.smethod_0(-994123673);
					}
					list5.Add(text9);
				}
				mySqlDataReader.Close();
				list2.Add(list5);
			}
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994123574));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_27(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string> list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			List<List<string>> list2 = new List<List<string>>();
			if (text3.Equals(Class84.smethod_0(-994274584)))
			{
				string text4 = list[3];
				string text5 = list[4];
				string text6 = list[5];
				string text7 = Class84.smethod_0(-994123542);
				if (!text.Equals(Class84.smethod_0(-994278690)))
				{
					text7 = text7 + Class84.smethod_0(-994123139) + text + Class84.smethod_0(-994271698);
				}
				if (!text4.Equals(Class84.smethod_0(-994278690)))
				{
					text7 = text7 + Class84.smethod_0(-994123166) + text4;
				}
				if (text5.Equals(Class84.smethod_0(-994278690)))
				{
					text7 = text7 + Class84.smethod_0(-994131369) + text2 + Class84.smethod_0(-994131299);
				}
				else if (text5.Equals(Class84.smethod_0(-994274584)))
				{
					text7 += Class84.smethod_0(-994131305);
				}
				else if (text5.Equals(Class84.smethod_0(-994248276)))
				{
					text7 = text7 + Class84.smethod_0(-994123123) + text2 + Class84.smethod_0(-994123101);
				}
				text7 = text7 + Class84.smethod_0(-994123044) + text6;
				MySqlDataReader mySqlDataReader = new MySqlCommand(text7, mySqlConnection).ExecuteReader();
				while (mySqlDataReader.Read())
				{
					List<string> item = new List<string>
					{
						mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994241168)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994214723)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994123023)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994221697)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994123027)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994122981)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277103)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994277105)].ToString(),
						mySqlDataReader[Class84.smethod_0(-994273283)].ToString()
					};
					list2.Add(item);
				}
				mySqlDataReader.Close();
			}
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994123000));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994122956));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_28(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string text5 = Class84.smethod_0(-994122921);
			if (!text4.Equals(Class84.smethod_0(-994278690)))
			{
				text5 = text5 + Class84.smethod_0(-994122728) + text4 + Class84.smethod_0(-994271698);
			}
			if (!text.Equals(Class84.smethod_0(-994278690)))
			{
				text5 = text5 + Class84.smethod_0(-994122750) + text + Class84.smethod_0(-994271698);
			}
			text5 = (text2.Equals(Class84.smethod_0(-994278690)) ? (text5 + Class84.smethod_0(-994130792)) : (text5 + Class84.smethod_0(-994130872) + text2 + Class84.smethod_0(-994131299)));
			if (!text3.Equals(Class84.smethod_0(-994274584)))
			{
				text5 = text5 + Class84.smethod_0(-994130803) + text3 + Class84.smethod_0(-994131207);
			}
			text5 += Class84.smethod_0(-994122699);
			MySqlCommand mySqlCommand = new MySqlCommand(Class84.smethod_0(-994122672) + text5 + Class84.smethod_0(-994122561), mySqlConnection);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994214723)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994122458)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994122416)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994122419));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994122377));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_29(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string value = Class320.smethod_3(jsRequest_0.UserRequest.RequestInfo, jsRequest_0.UserRequest.RequestInfoKey);
			int num = 10;
			int num2 = Convert.ToInt32(value) * 10;
			string text6 = Class84.smethod_0(-994122360) + text4;
			if (!text5.Equals(Class84.smethod_0(-994278690)))
			{
				text6 = text6 + Class84.smethod_0(-994131413) + text5 + Class84.smethod_0(-994271698);
			}
			if (!text.Equals(Class84.smethod_0(-994278690)))
			{
				text6 = text6 + Class84.smethod_0(-994123139) + text + Class84.smethod_0(-994271698);
			}
			text6 = (text2.Equals(Class84.smethod_0(-994278690)) ? (text6 + Class84.smethod_0(-994131305)) : (text6 + Class84.smethod_0(-994131369) + text2 + Class84.smethod_0(-994131299)));
			if (!text3.Equals(Class84.smethod_0(-994274584)))
			{
				text6 = text6 + Class84.smethod_0(-994131266) + text3 + Class84.smethod_0(-994131207);
			}
			text6 += string.Format(Class84.smethod_0(-994121954), num2, num);
			List<List<string>> list2 = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(text6, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994241168)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214723)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994123023)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994266832)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994221697)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994123027)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994122981)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994121915));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994121881));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_30(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string commandText = Class84.smethod_0(-994121808) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			commandText = Class84.smethod_0(-994121754) + text;
			mySqlCommand.CommandText = commandText;
			mySqlCommand.ExecuteNonQuery();
			mySqlTransaction.Commit();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994174873));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_31(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994174792) + text + Class84.smethod_0(-994174557) + text2 + Class84.smethod_0(-994224932) + text3 + Class84.smethod_0(-994174494), mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				List<string> item = new List<string>
				{
					mySqlDataReader[Class84.smethod_0(-994240446)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277136)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994277142)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994214738)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994188552)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994268488)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994123023)].ToString(),
					mySqlDataReader[Class84.smethod_0(-994241168)].ToString()
				};
				list2.Add(item);
			}
			mySqlDataReader.Close();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994174417));
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list2));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994174399));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_32(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			string text = Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey);
			List<string> list = new List<string>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994174310) + text, mySqlConnection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				list.Add(mySqlDataReader[Class84.smethod_0(-994277136)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994123027)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994173906)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994173862)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994173866)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994188552)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994277103)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994268488)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994224832)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994123023)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994241168)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994214723)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994214738)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994173887)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994205227)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994266832)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994221697)].ToString());
				list.Add(mySqlDataReader[Class84.smethod_0(-994122981)].ToString());
			}
			mySqlDataReader.Close();
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994173826));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_33(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994173795), mySqlConnection).ExecuteReader();
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
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994173675));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_34(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<List<string>> list = new List<List<string>>();
			MySqlDataReader mySqlDataReader = new MySqlCommand(Class84.smethod_0(-994173655), mySqlConnection).ExecuteReader();
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
			return new GClass70(1, Class84.smethod_0(-994247224), JsonConvert.SerializeObject(list));
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994173479));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_35(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(Class224.Class228.smethod_0());
		try
		{
			mySqlConnection.Open();
			List<string>? list = JsonConvert.DeserializeObject<List<string>>(Class320.smethod_3(jsRequest_0.UserRequest.RequestData, jsRequest_0.UserRequest.RequestDataKey));
			string text = list[0];
			string text2 = list[1];
			string text3 = list[2];
			string empty = string.Empty;
			empty = ((!text.Equals(Class84.smethod_0(-994274584))) ? (Class84.smethod_0(-994173345) + text2 + Class84.smethod_0(-994126286) + text3 + Class84.smethod_0(-994142640) + text) : (Class84.smethod_0(-994173452) + text2 + Class84.smethod_0(-994126286) + text3 + Class84.smethod_0(-994271698)));
			new MySqlCommand(empty, mySqlConnection).ExecuteNonQuery();
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994173307));
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), string.Empty, ex.Message);
			Class125.smethod_1(MethodBase.GetCurrentMethod().DeclaringType.Name + Class84.smethod_0(-994272055) + MethodBase.GetCurrentMethod().Name, ex.Message, ex);
			return new GClass70(-1, ex.Message, ex);
		}
		finally
		{
			mySqlConnection.Close();
		}
	}

	private static GClass70 smethod_36(GClass4 gclass4_0, GClass41 gclass41_0, JsRequest jsRequest_0)
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
			string text2 = list[1];
			string text3 = list[2];
			string text4 = list[3];
			string text5 = list[4];
			string text6 = Class282.smethod_7(list[5]);
			string text7 = Class282.smethod_7(list[6]);
			string text8 = list[7];
			string text9 = list[8];
			string text10 = list[9];
			int num = Convert.ToInt32(list[10]);
			string text11 = list[11];
			string text12 = list[12];
			string text13 = text6 + Class84.smethod_0(-994273716) + text3;
			string text14 = (text8.Equals(Class84.smethod_0(-994274584)) ? Class84.smethod_0(-994248276) : Class84.smethod_0(-994274584));
			string empty = string.Empty;
			if (text10.Equals(Class84.smethod_0(-994274584)))
			{
				empty = string.Format(Class84.smethod_0(-994173232), text2, text3, text4, text5, text6, text7, text, text8, text9, num, text11, text12);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				string text15 = Class84.smethod_0(-994274584);
				empty = Class84.smethod_0(-994260596);
				mySqlCommand.CommandText = empty;
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				if (mySqlDataReader.Read())
				{
					text15 = mySqlDataReader[0].ToString();
				}
				mySqlDataReader.Close();
				empty = Class84.smethod_0(-994215956) + text12 + Class84.smethod_0(-994173016) + text + Class84.smethod_0(-994219854) + text15 + Class84.smethod_0(-994172959) + text14 + Class84.smethod_0(-994219780) + text13 + Class84.smethod_0(-994271698);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			else
			{
				empty = string.Format(Class84.smethod_0(-994177014), text2, text3, text4, text5, text6, text7, text, text8, text9, num, text11, text12, text10);
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
				empty = Class84.smethod_0(-994176705) + text14 + Class84.smethod_0(-994219780) + text13 + Class84.smethod_0(-994176668) + text + Class84.smethod_0(-994176526) + text10;
				mySqlCommand.CommandText = empty;
				mySqlCommand.ExecuteNonQuery();
			}
			mySqlTransaction.Commit();
			gclass4_0.method_5(GEnum0.Info, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994176455));
			return new GClass70(1, Class84.smethod_0(-994247224), string.Empty);
		}
		catch (Exception ex)
		{
			mySqlTransaction?.Rollback();
			gclass4_0.method_5(GEnum0.Error, gclass41_0.method_46(), jsRequest_0.UserRequest.UserName, Class84.smethod_0(-994176476));
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
